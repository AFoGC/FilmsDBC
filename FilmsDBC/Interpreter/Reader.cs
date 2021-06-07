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
		
		public static bool loadAll(FilmTable filmTable, SerieTable serieTable)
		{
			using (StreamReader sr = new StreamReader(MainInformation.TablePath, System.Text.Encoding.Default))
			{
				if (sr.ReadLine() == "<DocStart>")
				{
					Comand comand;
					bool endReading = false;
					while (endReading == false)
					{
						comand = getComand(sr.ReadLine());
						if (comand.IsComand)
						{
							switch (comand.Paramert)
							{
								case "Table":
									switch (comand.Argument)
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
			Comand comand;

			while (endReading == false)
			{
				comand = getComand(streamReader.ReadLine());
				if (comand.IsComand)
				{
                    switch (comand.Paramert)
                    {
						case "Film":
							filmTable.addElement(loadFilm(streamReader));
							break;
						case "id":
							filmTable.ID = Convert.ToInt32(comand.Argument);
							break;
						case "name":
							filmTable.name = comand.Argument;
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
			Comand comand;

			while (endReading == false)
			{
				comand = getComand(streamReader.ReadLine());
				if (comand.IsComand)
				{
					switch (comand.Paramert)
					{
						case "id":
							film.ID = Convert.ToInt32(comand.Argument);
							break;
						case "name":
							film.name = comand.Argument;
							break;
						case "genre":
							film.genre = comand.Argument;
							break;
						case "realiseYear":
							film.realiseYear = Convert.ToInt32(comand.Argument);
							break;
						case "watched":
							film.watched = Convert.ToBoolean(comand.Argument);
							break;
						case "mark":
							film.mark = Convert.ToInt32(comand.Argument);
							break;
						case "dateOfWatch":
							film.dateOfWatch = comand.Argument;
							break;
						case "comment":
							film.comment = comand.Argument;
							break;
						case "sourceUrl":
							film.sourceUrl = comand.Argument;
							break;
						case "countOfviews":
							film.countOfviews = Convert.ToInt32(comand.Argument);
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
			Comand comand;

			while (endReading == false)
			{
				comand = getComand(streamReader.ReadLine());
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
				comand = getComand(streamReader.ReadLine());
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

		private static Comand getComand(String import)
		{
			bool isComand = false;
			//parametr = "";
			//argument = "";
			String param = "";
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
				return new Comand("", "", isComand);
			}

			for (; i < n; i++)
			{
				switch (import[i])
				{
					case ':':
						i += 2;
						return getArgument(import, param, i);
					case '>':
						return new Comand(param, "", true);
					default:
						param = param + import[i];
						break;
				}
			}
			return new Comand("", "", false);
		}

		private static Comand getArgument(String import, String param, int i)
		{
			//int n = import.Length;

			String arg = "";
			for (; i < import.Length; i++)
			{
				if (import[i] == '>')
				{
					return new Comand(param, arg, true);
				}
				else
				{
					arg = arg + import[i];
				}
			}

			return new Comand("", "", false);
		}
	}
}
