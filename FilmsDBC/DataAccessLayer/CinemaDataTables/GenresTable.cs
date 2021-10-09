using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.DataAccessLayer.CinemaDataTables
{
    public class GenresTable : Table<Genre>
    {
        public GenresTable() : base() { }
        public GenresTable(int id) : base(id) { }
        public GenresTable(int id, string name) : base(id, name) { }

        public override void ConnectionsSubload(TableCollection tablesCollection)
        {
            
        }

        public Genre GetByName(string name)
        {
            foreach (Genre genre in this)
            {
                if (name == genre.Name)
                {
                    return genre;
                }
            }
            return null;
        }

        public string[] GetAllGenresNames()
        {
            List<string> export = new List<string>();
            foreach (Genre genre in this)
            {
                export.Add(genre.Name);
            }
            return export.ToArray();
        }

        public static GenresTable GetDefaultGenresTable()
        {
            GenresTable export = new GenresTable();
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

            export.AddElement(film);
            export.AddElement(series);
            export.AddElement(cartoon);
            export.AddElement(animated_series);

            return export;
        }

        public Genre GetFirstSeriealGenre()
        {
            foreach (Genre genre in this)
            {
                if (genre.IsSerialGenre)
                {
                    return genre;
                }
            }

            return null;
        }
    }
}
