using FilmsDBC.Visual;
using FilmsDBC.Visual.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC
{
	static class Program
	{

		[DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            if (!IsAssociated())
            {

            }
            else
            {
				Associate();
            }

            if (args.Length != 0)
            {
				MainInformation.tableCollection.tableFilePath = args[0];
            }

			MainInformation.LoadTables();
			MainInformation.MainForm.loadCategories();
			MainInformation.MainForm.loadGenres();
			Application.Run(MainInformation.MainForm);
		}

		public static bool IsAssociated()
		{
			return (Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.fdbc", false) == null);
		}

		public static void Associate()
		{
			RegistryKey FileReg = Registry.CurrentUser.OpenSubKey("Software\\Classes\\.fdbc");
			RegistryKey AppReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\Applications\\FilmsDBC.exe");
			RegistryKey AppAssoc = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.fdbc");

			FileReg.CreateSubKey("DefaultIcon").SetValue("", "D:\\favicon.ico");
			FileReg.CreateSubKey("PerceivedType").SetValue("", "Text");

			AppReg.CreateSubKey("shell\\open\\command").SetValue("", "\"" + Application.ExecutablePath +"\" %1");
			AppReg.CreateSubKey("shell\\edit\\command").SetValue("", "\"" + Application.ExecutablePath + "\" %1");
			AppReg.CreateSubKey("DefaultIcon").SetValue("", "D:\\favicon.ico");

			AppAssoc.CreateSubKey("UserChoise").SetValue("Progid", "Applications\\FilmsDBC.exe");
			SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
		}
	}
}
