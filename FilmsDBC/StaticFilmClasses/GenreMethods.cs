using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.StaticFilmClasses
{
	public static class GenreMethods
	{

		
		/*
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
		*/

		/*
		public static List<String> GetAllGenresNames()
		{
			List<String> export = new List<String>();
			foreach (Genre genre in MainInformation.tableCollection.GetTable(typeof(Genre)).Cells)
			{
				export.Add(genre.Name);
			}
			return export;
		}
		*/

		/*
		public static Table GetDefaultGenresTable()
        {
			Table export = new Table(typeof(Genre));
			export.name = "Genres";

			Genre film = new Genre();
			film.IsSerialGenre = false;
			film.Name = "film";

			Genre series = new Genre();
			series.IsSerialGenre = true;
			series.Name = "series";

			Genre cartoon = new Genre();
			cartoon.IsSerialGenre = false;
			cartoon.Name = "cartoon";

			Genre animated_series = new Genre();
			animated_series.IsSerialGenre = true;
			animated_series.Name = "animated_series";

			export.addElement(film);
			export.addElement(series);
			export.addElement(cartoon);
			export.addElement(animated_series);

			return export;
        }
		*/
	}
}
