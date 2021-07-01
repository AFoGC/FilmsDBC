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
	}
}
