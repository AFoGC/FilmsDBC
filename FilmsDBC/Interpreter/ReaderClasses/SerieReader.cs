using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Interpreter.ReaderClasses
{
    public static class SerieReader
    {
		public static SerieTable loadSerieTable(StreamReader streamReader)
		{
			SerieTable serieTable = new SerieTable();
			bool endReading = false;
			Comand comand;

			while (endReading == false)
			{
				comand = ParamReader.getComand(streamReader.ReadLine());
				if (comand.IsComand)
				{
					switch (comand.Paramert)
					{
						case "Serie":
							serieTable.addElement(loadSerie(streamReader));
							break;
						case "id":
							serieTable.ID = Convert.ToInt32(comand.Argument);
							break;
						case "name":
							serieTable.name = comand.Argument;
							break;
						case "Table":
							endReading = true;
							break;
						default:
							break;
					}
				}
			}

			return serieTable;
		}

		private static Serie loadSerie(StreamReader streamReader)
		{
			Serie serie = new Serie();
			bool endReading = false;
			Comand comand;

			while (endReading == false)
			{
				comand = ParamReader.getComand(streamReader.ReadLine());
				if (comand.IsComand)
				{
					switch (comand.Paramert)
					{
						case "id":
							serie.ID = Convert.ToInt32(comand.Argument);
							break;
						case "filmId":
							serie.filmId = Convert.ToInt32(comand.Argument);
							break;
						case "startWatchDate":
							serie.startWatchDate = comand.Argument;
							break;
						case "countOfWatchedSeries":
							serie.countOfWatchedSeries = Convert.ToInt32(comand.Argument);
							break;
						case "Serie":
							endReading = true;
							break;
						default:
							break;
					}
				}
			}
			return serie;
		}
	}
}
