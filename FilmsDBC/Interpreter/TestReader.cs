using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Interpreter
{
    public static class TestReader
    {
		static string filmTablePath = @"F:\filmsDirectory\Films.newdb";
		static string seriesPath = @"F:\filmsDirectory\Series.newdb";

		public static FilmTable loadTable()
		{
			//Method that load table from file into FilmTable(RAM)
			String str;
			bool endRearing = false;
			FilmTable filmTable = new FilmTable("Films");
			using (StreamReader sr = new StreamReader(filmTablePath, System.Text.Encoding.Default))
			{
				while (endRearing == false)
				{
					str = sr.ReadLine();
					switch (str)
					{
						case "->Film":
							Film film = loadFilm(sr);
							filmTable.addElement(film);
							filmTable.LastID = film.ID;
							break;

						case "!Table":
							filmTable.name = sr.ReadLine();
							break;

						case "~End":
							endRearing = true;
							break;

						default:
							break;
					}
				}
			}
			return filmTable;
		}

		private static Film loadFilm(StreamReader sr)
		{
			int id = Convert.ToInt32(sr.ReadLine());
			String name = sr.ReadLine();
			String genre = sr.ReadLine();
			int realiseYear = Convert.ToInt32(sr.ReadLine());
			bool watched = Convert.ToBoolean(sr.ReadLine());
			int mark = Convert.ToInt32(sr.ReadLine());
			String date = sr.ReadLine();
			String comment = sr.ReadLine();
			String sourceUrl = sr.ReadLine();
			int views = Convert.ToInt32(sr.ReadLine());
			Film film = new Film(id, name, genre, realiseYear, watched, mark, date, comment, sourceUrl, views);
			return film;
		}

		public static SerieTable loadSeriesTable()
		{
			String str;
			bool endRearing = false;
			SerieTable serieTable = new SerieTable("Series");

			using (StreamReader sr = new StreamReader(seriesPath, System.Text.Encoding.Default))
			{
				while (endRearing == false)
				{
					str = sr.ReadLine();
					switch (str)
					{
						case "->Serie":
							Serie serie = loadSerie(sr);
							serieTable.addElement(serie);
							serieTable.LastID = serie.ID;
							//serieTable.series.Add(loadSerie(sr));
							break;

						case "!Table":
							serieTable.name = sr.ReadLine();
							break;

						case "~End":
							endRearing = true;
							break;

						default:
							break;
					}
				}
			}
			return serieTable;
		}

		private static Serie loadSerie(StreamReader sr)
		{
			return new Serie(
				Convert.ToInt32(sr.ReadLine()),
				sr.ReadLine(),
				Convert.ToInt32(sr.ReadLine())
				);
		}
	}
}
