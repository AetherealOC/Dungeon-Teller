using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dungeon_Teller.Updater.Forms;

namespace Dungeon_Teller.Updater
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>

		public static Mutex mutex;

		[STAThread]
		static void Main(string[] args=null)
		{

			bool dtRunning = false;
			try
			{
				mutex = Mutex.OpenExisting("DungeonTeller-{25dsfgdsdfsd54325sdf}");
				if (mutex != null)
				{
					dtRunning = true;
				}
			}
			catch
			{
			}

			if (dtRunning)
			{
				MessageBox.Show("You can't run the updater while Dungeon Teller is active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				if (args.Length == 0)
				{
					Application.Run(new CheckForUpdate());
				}
				else if (args[0] == "update")
				{
					Application.Run(new Update());
				}
				else if (args[0] == "cleanup")
				{
					foreach ( FileInfo file in new DirectoryInfo("temp").GetFiles() )
					{
						file.Delete();
					}
					Directory.Delete("temp");
					UpdateCompleted completed = new UpdateCompleted();
					completed.ShowDialog();
				}
			}

		}
	}
}
