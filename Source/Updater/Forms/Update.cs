using Ionic.Zip;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Dungeon_Teller.Updater.Classes;
using Dungeon_Teller.XML;

namespace Dungeon_Teller.Updater.Forms
{

	public partial class Update : Form
	{
		MemoryStream download;
		UpdateXML update;
		Uri uri;

		public Update()
		{
			InitializeComponent();
		}

		private void updateProgressBarText(int percent)
		{
			this.progress_status.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(this.progress_status.Width / 2 - 10, this.progress_status.Height / 2 - 7));
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			this.update = UpdateXML.getLocal<UpdateXML>("temp\\update.xml");
			this.lbl_status.Text = "Downloading files ...";
			uri = new Uri( String.Format("{0}file=dungeon_teller_{1}.zip", ConfigXML.base_url, update.tool_version) );
			downloadUpdate(this.uri);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += new ResolveEventHandler(MyResolveEventHandler);
		}

		private Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
		{
			string folderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string assemblyPath = Path.Combine(folderPath, "temp", new AssemblyName(args.Name).Name + ".dll");
			if (File.Exists(assemblyPath) == false) return null;
			Assembly assembly = Assembly.LoadFrom(assemblyPath);
			return assembly;
		}

		public void downloadUpdate(Uri url)
		{
			WebClient client = new WebClient();
			client.Headers.Add(HttpRequestHeader.Cookie, "visitorID=" + ConfigXML.visitorID);

			client.DownloadDataCompleted += new DownloadDataCompletedEventHandler(DownloadDataCompleted);
			client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
			client.Proxy = null;	

			try
			{
				client.DownloadDataAsync(url);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			try
			{
				if (this.progress_status.Value != e.ProgressPercentage)
					this.progress_status.Value = e.ProgressPercentage;

				updateProgressBarText(e.ProgressPercentage);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
 
		// The event that will trigger when the WebClient is completed
		private void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
		{
			download = new MemoryStream( e.Result );
			lbl_status.Text = "Extracting files ...";
			bw_extractUpdate.RunWorkerAsync();
		}

		private void bw_extractUpdate_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			var zip = ZipFile.Read(download);

			foreach (ZipEntry file in zip)
			{
				if (file.FileName != "Updater.exe")
				{
					file.Extract(".", ExtractExistingFileAction.OverwriteSilently);
				}
			}
		}

		private void bw_extractUpdate_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			Restarter.restart("cleanup");
		}
	}
}
