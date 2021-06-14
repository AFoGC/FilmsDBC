using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Interpreter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC
{
	public class AllCinemaTypes
    {
		private List<Type> types;

        AllCinemaTypes()
        {
			types.Add(typeof(Film));
        }
    }

	public class MainInformation
	{
		private static string tablePath = @"F:\filmsDirectory\Films.fdbc";
		public static CategoryTable categoryTable = new CategoryTable();
		public static FilmTable filmTable = new FilmTable();
		public static SerieTable serieTable = new SerieTable();

		//private static List<> tables = new List<>();

		public static string TablePath
		{
			get { return tablePath; }
		}

		public static void saveTables()
		{
			using (StreamWriter sw = new StreamWriter(tablePath, false, System.Text.Encoding.Default))
			{
				sw.WriteLine("<DocStart>");
				categoryTable.saveTable(sw);
				filmTable.saveTable(sw);
				serieTable.saveTable(sw);
				sw.WriteLine("<DocEnd>");
			}
		}
		
		public static void loadTables()
		{
			//filmTable = TestReader.loadTable();
			//serieTable = TestReader.loadSeriesTable();

			Reader.loadAll();
		}
	}
}
