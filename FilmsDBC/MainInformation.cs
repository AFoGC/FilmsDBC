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
	public class MainInformation
	{
		private static string tablePath = @"F:\filmsDirectory\Films.fdbc";
		public static FranshiseTable franshiseTable = new FranshiseTable();
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
