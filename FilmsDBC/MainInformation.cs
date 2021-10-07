using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.Visual.MainForm;
using FilmsDBC.Settings;
using FilmsDBC.CinemaDataTables;

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
			Tables.SetDefaultMainTableCollection();

			settings = loadSettings();
			tableCollection.TableFilePath = settings.UsedProfile.MainFilePath;

			mainForm = new MainForm();
		}

		public static TableCollection GetDefaultTableCollectionData()
		{
			TableCollection export = new TableCollection();

			export.AddTable(typeof(Category));
			export.AddTable(GenresTable.GetDefaultGenresTable());
			export.AddTable(typeof(Film));
			export.AddTable(typeof(Serie));
			export.AddTable(typeof(PriorityFilm));

			return export;
		}

		public static void LoadTables()
		{
			tableCollection.LoadTables();
			Tables.CategoriesTable.CategorySubload(Tables.FilmsTable);
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

		public static class Tables
		{
			private static CategoriesTable categoriesTable;
			private static GenresTable genresTable;
			private static FilmsTable filmsTable;
			private static SeriesTable seriesTable;
			private static PriorityFilmsTable priorityFilmsTable;

			public static void SetDefaultMainTableCollection()
            {
				tableCollection = new TableCollection();

				categoriesTable = new CategoriesTable();
				genresTable = GenresTable.GetDefaultGenresTable();
				filmsTable = new FilmsTable();
				seriesTable = new SeriesTable();
				priorityFilmsTable = new PriorityFilmsTable();

				tableCollection.RemoveAllTables(true);

				tableCollection.AddTable(categoriesTable);
				tableCollection.AddTable(genresTable);
				tableCollection.AddTable(filmsTable);
				tableCollection.AddTable(seriesTable);
				tableCollection.AddTable(priorityFilmsTable);


			}

			public static CategoriesTable CategoriesTable { get { return categoriesTable; } }
			public static GenresTable GenresTable { get { return genresTable; } }
			public static FilmsTable FilmsTable { get { return filmsTable; } }
			public static SeriesTable SeriesTable { get { return seriesTable; } }
			public static PriorityFilmsTable PriorityFilmsTable { get { return priorityFilmsTable; } }

		}
	}
}
