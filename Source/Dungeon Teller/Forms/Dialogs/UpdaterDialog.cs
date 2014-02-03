using Dungeon_Teller.Classes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Dungeon_Teller.Forms.Dialogs
{
	public partial class UpdaterDialog : Form
	{

		Properties.Settings settings;

		public UpdaterDialog()
		{
			InitializeComponent();
			this.settings = Properties.Settings.Default;
		}

		public DialogResult ShowDialog(UpdateState state, string version="")
		{

			btn_yes.Text = "Yes";
			btn_no.Text = "No";
			string title="";
			string desc="";

			switch(state)
			{
				case UpdateState.OffsetsMissing:
					pic_image.Image = Properties.Resources.file_missing;
					btn_no.Text = "Exit program";
					title="Offsets missing!";
					desc= String.Format("{0} could not be found. Do you want to download the latest offsets?", settings.OffSetXML);
					break;
				case UpdateState.UpgradeTool:
					title="Program update available!";
					desc = String.Format("Dungeon Teller v{0} is available. Do you want to start the updater?", version);
					break;
				case UpdateState.UpdateOffsets:
					title="Offset update available!";
					desc = String.Format("Your offsets version: {0}\nLatest offsets version: {1}\nDo you want to update them now?", settings.WowVersion, version);
					break;
			}

			lbl_title.Text = title;
			lbl_desc.Text = desc;

			return this.ShowDialog();
		}
	}
}
