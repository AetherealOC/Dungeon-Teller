using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Dungeon_Teller.Updater.Classes;
using Dungeon_Teller.XML;

namespace Dungeon_Teller.Updater.Forms
{
	public partial class CheckForUpdate : Form
	{
		UpdateXML update;
		Uri uri;

		public CheckForUpdate()
		{
			InitializeComponent();
		}

		private void CheckForUpdate_Load(object sender, EventArgs e)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += new ResolveEventHandler(MyResolveEventHandler);
		}

		private Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
		{
			string folderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string assemblyPath = Path.Combine(folderPath, "libs", new AssemblyName(args.Name).Name + ".dll");
			if (File.Exists(assemblyPath) == false) return null;
			Assembly assembly = Assembly.LoadFrom(assemblyPath);
			return assembly;
		}

		private void bw_loadXML_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			this.update = UpdateXML.getRemote<UpdateXML>();
			string url = (ConfigXML.base_url + "file=dungeon_teller_" + update.tool_version + ".zip");
			this.uri = new Uri(url);
		}

		private void bw_loadXML_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			string dt_name = "Dungeon Teller.exe";

			if (File.Exists(dt_name))
			{
				string dt_version = ConfigXML.getDtVersion();

				if (this.update.tool_version != dt_version)
				{
					invokeUpdate();
				}
				else
				{
					MessageBox.Show("Dungeon Teller is already up to date.", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Application.Exit();
				}
			}
			else
			{
				DialogResult result = MessageBox.Show(String.Format("{0} not found! Do you want to download it?", dt_name), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
					invokeUpdate();
				else
					Application.Exit();
			}
		}

		private void invokeUpdate()
		{
			Directory.CreateDirectory("temp");
			ConfigXML.writeLocal<UpdateXML>(update, "temp\\update.xml");
			foreach (string newPath in Directory.GetFiles("libs", "*.*"))
				File.Copy(newPath, newPath.Replace("libs", "temp"), true);

			Restarter.restart("update");
		}

		private void CheckForUpdate_Shown(object sender, EventArgs e)
		{
			bw_loadXML.RunWorkerAsync();
		}
	}
}
