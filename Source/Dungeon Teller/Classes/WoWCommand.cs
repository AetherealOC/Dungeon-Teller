using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dungeon_Teller.Classes
{
	class WoWCommand
	{

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr thWnd, int msg, int wParam, IntPtr lParam);

		private const int VK_CONTROL = 0xA2;
		private const int WM_KEYDOWN = 0x100;
		private const int WM_KEYUP = 0x101;
		private const int VK_RETURN = 0x0D;
		const int VK_LEFT = 0x25;
		const int VK_RIGHT = 0x27;

		public static void sendAntiAFK(IntPtr hWnd)
		{
			SendMessage(hWnd, WM_KEYDOWN, VK_LEFT, IntPtr.Zero);
			SendMessage(hWnd, WM_KEYUP, VK_LEFT, IntPtr.Zero);
			SendMessage(hWnd, WM_KEYDOWN, VK_RIGHT, IntPtr.Zero);
			SendMessage(hWnd, WM_KEYUP, VK_RIGHT, IntPtr.Zero);
		}

		public static void sendSlashCommand(IntPtr hWnd, string slashCommand)
		{
			Object savedClipboard = Clipboard.GetDataObject();
			Clipboard.SetText(slashCommand);

			SendMessage(hWnd, WM_KEYDOWN, VK_RETURN, IntPtr.Zero);
			SendMessage(hWnd, WM_KEYUP, VK_RETURN, IntPtr.Zero);

			SendMessage(hWnd, WM_KEYDOWN, VK_CONTROL, IntPtr.Zero);
			SendMessage(hWnd, WM_KEYDOWN, 0x56, IntPtr.Zero);
			SendMessage(hWnd, WM_KEYUP, 0x56, IntPtr.Zero);
			SendMessage(hWnd, WM_KEYUP, VK_CONTROL, IntPtr.Zero);

			SendMessage(hWnd, WM_KEYDOWN, VK_RETURN, IntPtr.Zero);
			SendMessage(hWnd, WM_KEYUP, VK_RETURN, IntPtr.Zero);

			Clipboard.SetDataObject(savedClipboard);
		}
	}
}