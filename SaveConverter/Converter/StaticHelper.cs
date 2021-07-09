using SaveConverter.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveConverter.Converter
{
	public static class StaticHelper
	{
		public static Genre GetGenreByName(String name)
        {
            foreach (Genre genre in MainInfo.tableCollection.GetTable(typeof(Genre)).Cells)
            {
                if (genre.Name == name)
                {
                    return genre;
                }
            }
			return null;
        }
	}
}
