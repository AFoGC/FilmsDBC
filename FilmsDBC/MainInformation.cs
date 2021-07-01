using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;
using FilmsDBC.StaticFilmClasses;

namespace FilmsDBC
{
	public static class MainInformation
	{
		public static TableCollection tableCollection = null;

		static MainInformation()
		{
			tableCollection = new TableCollection();

			tableCollection.tableFilePath = @"F:\filmsDirectory\Films.fdbc";

			tableCollection.AddTable(typeof(Category));
			tableCollection.AddTable(typeof(Genre));
			tableCollection.AddTable(typeof(Film));
			tableCollection.AddTable(typeof(Serie));
		}

		public static void LoadTables()
		{
			tableCollection.loadTables();
			tableCollection.CategorySubload();
		}
	}
}
