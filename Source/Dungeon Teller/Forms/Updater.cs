using Dungeon_Teller.Classes;
using Dungeon_Teller.Forms.Dialogs;
using Dungeon_Teller.XML;
using Ionic.Zip;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Dungeon_Teller.Forms
{
	public partial class Updater : Form
	{
		Properties.Settings settings = Properties.Settings.Default;
		UpdaterDialog updater = new UpdaterDialog();
		UpdateXML update;
		OffsetXML remote;

		public Updater()
		{
			InitializeComponent();
		}

		private void Updater_Shown(object sender, EventArgs e)
		{
			workerLoadUpdateXml.RunWorkerAsync();
		}

		private void workerLoadUpdateXml_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (update != null)
			{
				if (update.msg != "")
				{
					MessageBox.Show(update.msg, "Dungeon Teller - Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				if (update.tool_version != Application.ProductVersion)
				{
					this.Hide();
					DialogResult UpgradeToolDialog = updater.ShowDialog(UpdateState.UpgradeTool, update.tool_version);

					if (UpgradeToolDialog == DialogResult.Yes)
					{
						Directory.CreateDirectory("temp");
						ConfigXML.writeLocal<UpdateXML>(update, "temp\\update.xml");
						foreach (string newPath in Directory.GetFiles("libs", "*.*"))
							File.Copy(newPath, newPath.Replace("libs", "temp"), true);

						if (!File.Exists("Updater.exe") || FileVersionInfo.GetVersionInfo("Updater.exe").ProductVersion != update.updater_version)
						{
							this.lbl_status.Text = "Updating the updater ...";
							this.Show();
							workerLoadUpdater.RunWorkerAsync();
						}
						else
						{
							UpdateStarter.start("update");
							Application.Exit();
						}
					}
					else
					{
						checkOffsets();
					}
				}
				else
				{
					checkOffsets();
				}
			}
		}

		private void checkOffsets()
		{
			if (!File.Exists(settings.OffSetXML) || update.wow_version != settings.WowVersion || settings.OffsetsLastUpdated < update.force_offsets)
			{
				UpdateState state;

				if (!File.Exists(settings.OffSetXML))
				{
					state = UpdateState.OffsetsMissing;
				}
				else
				{
					state = UpdateState.UpdateOffsets;
				}

				this.Hide();
				DialogResult GetOffsetsDialog = updater.ShowDialog(state, update.wow_version);

				if (GetOffsetsDialog == DialogResult.Yes)
				{
					this.lbl_status.Text = "Updating offsets ... ";
					this.Show();
					workerLoadOffsets.RunWorkerAsync();
				}
				else if (state == UpdateState.OffsetsMissing)
				{
					Application.Exit();
				}
				else
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void workerLoadUpdateXml_DoWork(object sender, DoWorkEventArgs e)
		{
			update = UpdateXML.getRemote<UpdateXML>();
		}

		private void workerLoadOffsets_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			int timestamp = (int)((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds);
			Offsets.writeLocal(remote, settings.OffSetXML);
			Offsets.reinitialize();
			settings.WowVersion = update.wow_version;
			settings.OffsetsLastUpdated = timestamp;
			settings.Save();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void workerLoadOffsets_DoWork(object sender, DoWorkEventArgs e)
		{
			remote = Offsets.getRemote<OffsetXML>(String.Format("offset={0}", update.wow_version));
		}

		private void workerLoadUpdater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			UpdateStarter.start("update");
			Application.Exit();
		}

		private void workerLoadUpdater_DoWork(object sender, DoWorkEventArgs e)
		{
			WebClient client = new WebClient();
			client.Headers.Add(HttpRequestHeader.Cookie, "visitorID=" + ConfigXML.visitorID);
			client.Proxy = null;

			Uri uri = new Uri(String.Format("{0}file=updater_{1}.zip", ConfigXML.base_url, update.updater_version));

			try
			{
				var data = client.DownloadData(uri);
				var download = new MemoryStream(data);
				var zip = ZipFile.Read(download);
				foreach (ZipEntry file in zip)
				{
					file.Extract(".", ExtractExistingFileAction.OverwriteSilently);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void Updater_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Updater temporarily disabled - sorry!");
            this.Close();
        }
	}
}
