using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Visual.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.StaticVisualClasses
{
    public static class ControlsConverter
    {
        public static FilmControl ToFilmControl(Film film)
        {
            return new FilmControl(film);
        }

        public static SerieControl ToSerieControl(Film film)
        {
            foreach(Serie serie in MainInformation.tableCollection.GetTable(typeof(Serie)).Cells)
            {
                if (serie.FilmId == film.ID)
                {
                    return new SerieControl(film, serie);
                }
            }

            Serie ser = new Serie();
            ser.FilmId = film.ID;

            MainInformation.tableCollection.GetTable(typeof(Serie)).addElement(ser);

            return new SerieControl(film, (Serie)MainInformation.tableCollection.GetTable(typeof(Serie)).GetLastElement);
        }
    }
}
