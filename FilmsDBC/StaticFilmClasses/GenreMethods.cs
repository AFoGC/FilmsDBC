using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.StaticFilmClasses
{
	public static class GenreMethods
	{
		public static bool IsSerialGenre(String genreName)
		{
			foreach (Genre genre in MainInformation.tableCollection.GetTable(typeof(Genre)).Cells)
			{
				if (genreName == genre.Name)
				{
					return genre.IsSerialGenre;
				}
			}

			return false;
		}

		public static Genre GetByName(String name)
		{
			foreach (Genre genre in MainInformation.tableCollection.GetTable(typeof(Genre)).Cells)
			{
				if (name == genre.Name)
				{
					return genre;
				}
			}
			return null;
		}

		public static List<String> GetAllGenresNames()
		{
			List<String> export = new List<String>();
			foreach (Genre genre in MainInformation.tableCollection.GetTable(typeof(Genre)).Cells)
			{
				export.Add(genre.Name);
			}
			return export;
		}

		public static String GetDefaultGenres()
        {
			return "<Table: Genre>\n\t<id: 2>\n\t<name: Genres>\n\t<Genre>\n\t\t<id: 1>\n\t\t<name: film>\n\t\t<isSerialGenre: False>\n\t<Genre>\n\t<Genre>\n\t\t<id: 2>\n\t\t<name: series>\n\t\t<isSerialGenre: True>\n\t<Genre>\n\t<Genre>\n\t\t<id: 3>\n\t\t<name: cartoon>\n\t\t<isSerialGenre: False>\n\t<Genre>\n\t<Genre>\n\t\t<id: 4>\n\t\t<name: animated series>\n\t\t<isSerialGenre: True>\n\t<Genre>\n<Table>\n";
        }
	}
}
