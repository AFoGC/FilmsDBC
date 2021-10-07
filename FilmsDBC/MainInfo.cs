using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.Visual.MainForm;
using FilmsDBC.Settings;
using FilmsDBC.DataAccessLayer.CinemaDataTables;
using FilmsDBC.DataAccessLayer.CinemaDataTypes;

namespace FilmsDBC
{
    public static class MainInfo
	{
		public static TableCollection tableCollection = null;
		public static TableCollection TableCollection
        {
            get { return tableCollection; }
        }

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

		static MainInfo()
		{
			Tables.SetDefaultMainTableCollection();

			settings = loadSettings();
			TableCollection.TableFilePath = settings.UsedProfile.MainFilePath;

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
			export.AddTable(typeof(BookGenre));
			export.AddTable(typeof(Book));

			return export;
		}

		public static void LoadTables()
		{
			TableCollection.LoadTables();
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
			private static BookGenresTable bookGenresTable;
			private static BooksTable booksTable;

			public static void SetDefaultMainTableCollection()
            {
				tableCollection = new TableCollection();

				categoriesTable = new CategoriesTable();
				genresTable = GenresTable.GetDefaultGenresTable();
				filmsTable = new FilmsTable();
				seriesTable = new SeriesTable();
				priorityFilmsTable = new PriorityFilmsTable();
				bookGenresTable = new BookGenresTable();
				booksTable = new BooksTable();

				TableCollection.RemoveAllTables(true);

				TableCollection.AddTable(categoriesTable);
				TableCollection.AddTable(genresTable);
				TableCollection.AddTable(filmsTable);
				TableCollection.AddTable(seriesTable);
				TableCollection.AddTable(priorityFilmsTable);
				TableCollection.AddTable(bookGenresTable);
				TableCollection.AddTable(booksTable);
			}

			public static CategoriesTable CategoriesTable { get { return categoriesTable; } }
			public static GenresTable GenresTable { get { return genresTable; } }
			public static FilmsTable FilmsTable { get { return filmsTable; } }
			public static SeriesTable SeriesTable { get { return seriesTable; } }
			public static PriorityFilmsTable PriorityFilmsTable { get { return priorityFilmsTable; } }
			public static BookGenresTable BookGenresTable { get { return bookGenresTable; } }
			public static BooksTable BooksTable { get { return booksTable; } }
		}
	}
}
