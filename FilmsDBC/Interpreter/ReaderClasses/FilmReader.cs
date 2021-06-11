using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Interpreter.ReaderClasses
{
    public static class FilmReader
    {
		public static FilmTable loadFilmTable(StreamReader streamReader)
		{
			FilmTable filmTable = new FilmTable();
			bool endReading = false;
			Comand comand;

			while (endReading == false)
			{
				comand = ParamReader.getComand(streamReader.ReadLine());
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
				comand = ParamReader.getComand(streamReader.ReadLine());
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
							film.mark = Convert.ToSByte(comand.Argument);
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
						case "franshiseId":
							film.franshiseId = Convert.ToInt32(comand.Argument);
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
	}
}
