using SaveConverter.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace SaveConverter.Converter
{
	public static class Reader
	{
		static string filmTablePath = @"F:\filmsDirectory\Films.newdb";
		static string seriesPath = @"F:\filmsDirectory\Series.newdb";

		public static void LoadAll()
        {
			loadGenreTable();
			loadFilmTable();
			loadSerieTable();
        }

		private static void loadGenreTable()
        {
			Table genretable = MainInfo.tableCollection.GetTable(typeof(Genre));
			genretable.name = "Жанры";

			Genre genre = new Genre();
			genre.Name = "фильм";
			genretable.addElement(genre);

			genre = new Genre();
			genre.Name = "сериал";
			genre.IsSerialGenre = true;
			genretable.addElement(genre);

			genre = new Genre();
			genre.Name = "м/ф";
			genretable.addElement(genre);

			genre = new Genre();
			genre.Name = "м/с";
			genre.IsSerialGenre = true;
			genretable.addElement(genre);

			genre = new Genre();
			genre.Name = "аниме сериал";
			genre.IsSerialGenre = true;
			genretable.addElement(genre);

			genre = new Genre();
			genre.Name = "п-мертаж аниме";
			genretable.addElement(genre);
		}

        private static void loadFilmTable()
        {
			String str;
			bool endRearing = false;
			Table filmTable = MainInfo.tableCollection.GetTable(typeof(Film));
			using (StreamReader sr = new StreamReader(filmTablePath, System.Text.Encoding.Default))
			{
				while (endRearing == false)
				{
					str = sr.ReadLine();
					switch (str)
					{
						case "->Film":
							Film film = new Film();
							film.ConverterLoad(sr);
							filmTable.Cells.Add(film);
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
		}

		private static void loadSerieTable()
        {
			String str;
			bool endRearing = false;
			Table seriesTable = MainInfo.tableCollection.GetTable(typeof(Serie));
			int i = 0;

			using (StreamReader sr = new StreamReader(seriesPath, System.Text.Encoding.Default))
			{
				while (endRearing == false)
				{
					str = sr.ReadLine();
					switch (str)
					{
						case "->Serie":
							++i;
							Serie serie = new Serie(i);
							serie.ConverterLoad(sr);
							seriesTable.Cells.Add(serie);
							break;

						case "!Table":
							seriesTable.name = sr.ReadLine();
							break;

						case "~End":
							endRearing = true;
							break;

						default:
							break;
					}
				}
			}
		}
	}
}
