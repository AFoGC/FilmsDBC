using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC
{
	public static class MainInformation
	{
		public static TableCollection tableCollection = null;
		
		public static void TablesInitialize()
        {
            if (tableCollection == null)
            {
				tableCollection = new TableCollection();

				tableCollection.tableFilePath = @"F:\filmsDirectory\Films.fdbc";

				tableCollection.AddTable(new Category());
				tableCollection.AddTable(new Film());
				tableCollection.AddTable(new Serie());
            }
        }
	}
}
