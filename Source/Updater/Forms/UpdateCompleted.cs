using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dungeon_Teller.Updater.Forms
{
	public partial class UpdateCompleted : Form
	{

		public int countDown=15;

		public UpdateCompleted()
		{
			InitializeComponent();
		}

		private void btn_start_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.ownedcore.com/forums/reputation.php?do=addreputation&p=2657518");
			startDungeonTeller();
		}

		private void startDungeonTeller()
		{
			Process.Start("Dungeon Teller.exe");
			Application.Exit();
		}

		private void startDungeonTeller_Tick(object sender, EventArgs e)
		{
			this.btn_start.Text = String.Format("Start Dungeon Teller [{0}]", countDown);
			if (countDown-- == 0)
			{
				this.timer_startDungeonTeller.Stop();
				Process.Start("http://www.ownedcore.com/forums/reputation.php?do=addreputation&p=2657518");
				startDungeonTeller();
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void UpdateCompleted_Shown(object sender, EventArgs e)
		{
			this.timer_startDungeonTeller.Start();
		}
	}
}
