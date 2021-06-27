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
		
		//Надо добавить список жанров где будут помечены сериальные жанры
		//не исключено, что нужно будет изменить библиотеку и настроить там запись конфигураций в файле с данными

		static MainInformation()
        {
			tableCollection = new TableCollection();

			tableCollection.tableFilePath = @"F:\filmsDirectory\Films.fdbc";

			tableCollection.AddTable(typeof(Category));
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
