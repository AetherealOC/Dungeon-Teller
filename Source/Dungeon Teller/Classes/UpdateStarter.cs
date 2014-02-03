using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dungeon_Teller.Classes
{
	class UpdateStarter
	{
		public static void start(string args)
		{
			ProcessStartInfo Info = new ProcessStartInfo();
			string arguments = "/C ping 127.0.0.1 -n 2 && start \"\" \"" + Path.GetFullPath("Updater.exe") + "\" " + args;
			Info.Arguments = arguments;
			Info.WindowStyle = ProcessWindowStyle.Hidden;
			Info.CreateNoWindow = true;
			Info.FileName = "cmd.exe";
			Process.Start(Info);
			Application.Exit();
		}
	}
}
