using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.IO;
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

		static MainInformation()
		{
			tableCollection = new TableCollection();

			tableCollection.tableFilePath = @"F:\filmsDirectory\Films.fdbc";

			tableCollection.AddTable(typeof(Category));
			tableCollection.AddTable(typeof(Genre));
			tableCollection.AddTable(typeof(Film));
			tableCollection.AddTable(typeof(Serie));

			mainForm = new MainForm();
		}

		public static void LoadTables()
		{
			tableCollection.loadTables();
			tableCollection.CategorySubload();
		}
	}
}
