using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dungeon_Teller
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://dungeonteller.uni.me/");
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            Process.Start("http://www.ownedcore.com/forums/private.php?do=newpm&u=967536");
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            Process.Start("http://www.ownedcore.com/forums/reputation.php?do=addreputation&p=2966613");
			Properties.Settings.Default.HasContributed = true;
		}

		private void About_Shown(object sender, EventArgs e)
		{
			lbl_version.Text = String.Format("Version: {0}", Application.ProductVersion);
			lbl_wow.Text = String.Format("Compatible with: {0}", Properties.Settings.Default.WowVersion);
		}

	}
}
