using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dungeon_Teller.Updater.Classes
{
	class Restarter
	{

		public static void restart(string args)
		{
			ProcessStartInfo Info = new ProcessStartInfo();
			string arguments = "/C ping 127.0.0.1 -n 2 && start \"\" \"" + Application.ExecutablePath + "\" " + args;
			Info.Arguments = arguments;
			Info.WindowStyle = ProcessWindowStyle.Hidden;
			Info.CreateNoWindow = true;
			Info.FileName = "cmd.exe";
			Process.Start(Info);
			Application.Exit(); 
		}

	}
}
