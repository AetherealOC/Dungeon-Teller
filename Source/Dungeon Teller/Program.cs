using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Dungeon_Teller.Classes;
using Dungeon_Teller.Forms;
using System.Threading;

namespace Dungeon_Teller
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 

		private static Mutex mutex;

		[STAThread]
		static void Main()
		{
			bool dtRunning;
			mutex = new Mutex(false, "DungeonTeller-{25dsfgdsdfsd54325sdf}", out dtRunning);
			if (!dtRunning)
			{
				MessageBox.Show("Another instance of Dungeon Teller is already running!", "Dungeon Teller", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
		}
	}
}
