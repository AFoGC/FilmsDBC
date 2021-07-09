using SaveConverter.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace SaveConverter
{
    public static class MainInfo
    {
		public static TableCollection tableCollection = null;


		static MainInfo()
		{
			tableCollection = new TableCollection();

			tableCollection.tableFilePath = @"F:\filmsDirectory\Films.fdbc";

			tableCollection.AddTable(typeof(Category));
			tableCollection.AddTable(typeof(Genre));
			tableCollection.AddTable(typeof(Film));
			tableCollection.AddTable(typeof(Serie));
		}
	}
}
