using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Interpreter.ReaderClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Interpreter
{
	public static class Reader
	{
		private static String parametr = "";
		private static String argument = "";
		
		public static bool loadAll(FilmTable filmTable, SerieTable serieTable)
		{
			using (StreamReader sr = new StreamReader(MainInformation.TablePath, System.Text.Encoding.Default))
			{
				if (sr.ReadLine() == "<DocStart>")
				{
					bool endReading = false;
					while (endReading == false)
					{
						if (getComand(sr.ReadLine()))
						{
							switch (parametr)
							{
								case "Table":
									switch (argument)
									{
										case "Film":
											MainInformation.filmTable = loadFilmTable(sr);
											break;

										case "Serie":
											MainInformation.serieTable = loadSerieTable(sr);
											break;

										default:
											break;
									}
									break;
								case "DocEnd":
									endReading = true;
									break;

								default:
									break;

							}
						}
					}
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		private static FilmTable loadFilmTable(StreamReader streamReader)
		{
			FilmTable filmTable = new FilmTable();
			bool endReading = false;

			while (endReading == false)
			{
				if (getComand(streamReader.ReadLine()))
				{
                    switch (parametr)
                    {
						case "Film":
							filmTable.addElement(loadFilm(streamReader));
							break;
						case "id":
							filmTable.ID = Convert.ToInt32(argument);
							break;
						case "name":
							filmTable.name = argument;
							break;
						case "Table":
							endReading = true;
							break;
						default:
							break;
                    }
				}
			}

			return filmTable;
		}

		private static Film loadFilm(StreamReader streamReader)
        {
			Film film = new Film();
			bool endReading = false;

			while (endReading == false)
			{
				if (getComand(streamReader.ReadLine()))
				{
					switch (parametr)
					{
						case "id":
							film.ID = Convert.ToInt32(argument);
							break;
						case "name":
							film.name = argument;
							break;
						case "genre":
							film.genre = argument;
							break;
						case "realiseYear":
							film.realiseYear = Convert.ToInt32(argument);
							break;
						case "watched":
							film.watched = Convert.ToBoolean(argument);
							break;
						case "mark":
							film.mark = Convert.ToInt32(argument);
							break;
						case "dateOfWatch":
							film.dateOfWatch = argument;
							break;
						case "comment":
							film.comment = argument;
							break;
						case "sourceUrl":
							film.sourceUrl = argument;
							break;
						case "countOfviews":
							film.countOfviews = Convert.ToInt32(argument);
							break;
						case "Film":
							endReading = true;
							break;
						default:
							break;
					}
				}
			}
			return film;
        }

		private static SerieTable loadSerieTable(StreamReader streamReader)
		{
			SerieTable serieTable = new SerieTable();
			bool endReading = false;

			while (endReading == false)
			{
				if (getComand(streamReader.ReadLine()))
				{
					switch (parametr)
					{
						case "Serie":
							serieTable.addElement(loadSerie(streamReader));
							break;
						case "id":
							serieTable.ID = Convert.ToInt32(argument);
							break;
						case "name":
							serieTable.name = argument;
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

			while (endReading == false)
			{
				if (getComand(streamReader.ReadLine()))
				{
					switch (parametr)
					{
						case "id":
							serie.ID = Convert.ToInt32(argument);
							break;
						case "filmId":
							serie.filmId = Convert.ToInt32(argument);
							break;
						case "startWatchDate":
							serie.startWatchDate = argument;
							break;
						case "countOfWatchedSeries":
							serie.countOfWatchedSeries = Convert.ToInt32(argument);
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

		private static bool getComand(String import)
		{
			bool isComand = false;
			parametr = "";
			argument = "";
			int i = 0;
			int n = import.Length;
			for (; i < n; i++)
			{
				if (import[i] == '<')
				{
					isComand = true;
					++i;
					break;
				}
			}

			if (isComand == false)
			{
				return isComand;
			}

			for (; i < n; i++)
			{
				switch (import[i])
				{
					case ':':
						i += 2;
						return getParamValue(import, i);
					case '>':
						return true;
					default:
						parametr = parametr + import[i];
						break;
				}
			}
			return false;
		}

		private static bool getParamValue(String import, int i)
		{
			int n = import.Length;
			for (; i < n; i++)
			{
				if (import[i] == '>')
				{
					return true;
				}
				else
				{
					argument = argument + import[i];
				}
			}

			return false;
		}
	}
}
