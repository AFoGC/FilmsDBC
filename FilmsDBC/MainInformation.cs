using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.Visual.Forms;

namespace FilmsDBC
{
	public static class MainInformation
	{
		public static TableCollection tableCollection = null;

		private static MainForm mainForm = null;
		public static MainForm MainForm
        {
            get { return mainForm; }
        }

		private static ProgramSettings settings = null;
		public static ProgramSettings Settings
        {
			get { return settings; }
        }

		static MainInformation()
		{
			tableCollection = new TableCollection();
			settings = loadSettings();

			tableCollection.tableFilePath = settings.UsedProfile.MainFilePath;

			tableCollection.AddTable(typeof(Category));
			tableCollection.AddTable(GenreMethods.GetDefaultGenresTable());
			tableCollection.AddTable(typeof(Film));
			tableCollection.AddTable(typeof(Serie));
			tableCollection.AddTable(typeof(PriorityFilm));

			mainForm = new MainForm();
		}

		public static void LoadTables()
		{
			tableCollection.loadTables();
			tableCollection.CategorySubload();
		}

		private static ProgramSettings loadSettings()
        {
			ProgramSettings settings = new ProgramSettings();
			String settingPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Program.properties";

			Comand comand = new Comand();
			using (System.IO.StreamReader sr = new System.IO.StreamReader(settingPath, System.Text.Encoding.Default))
			{
				comand.getComand(sr.ReadLine());
				if (comand.Paramert == "ProgramSettings")
                {
					settings.loadCell(sr, comand);
                }
			}

			return settings;
        }
	}
}
