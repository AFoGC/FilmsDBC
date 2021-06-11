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
			Film film = new Film();

			film.ID = Convert.ToInt32(sr.ReadLine());
			film.name = sr.ReadLine();
			film.genre = sr.ReadLine();
			film.realiseYear = Convert.ToInt32(sr.ReadLine());
			film.watched = Convert.ToBoolean(sr.ReadLine());
			film.mark = Convert.ToSByte(sr.ReadLine());
			film.dateOfWatch = sr.ReadLine();
			film.comment = sr.ReadLine();
			film.sourceUrl = sr.ReadLine();
			film.countOfviews = Convert.ToInt32(sr.ReadLine());
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
			Serie serie = new Serie();
			serie.filmId = Convert.ToInt32(sr.ReadLine());
			serie.startWatchDate = sr.ReadLine();
			serie.countOfWatchedSeries = Convert.ToInt32(sr.ReadLine());

			return serie;
		}
	}
}
