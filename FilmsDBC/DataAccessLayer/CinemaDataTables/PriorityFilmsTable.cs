using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.DataAccessLayer.CinemaDataTables
{
    public class PriorityFilmsTable : Table<PriorityFilm>
    {
        public PriorityFilmsTable() : base() { }
        public PriorityFilmsTable(int id) : base(id) { }
        public PriorityFilmsTable(int id, string name) : base(id, name) { }

        public override void ConnectionsSubload(TableCollection tablesCollection)
        {
            Table<Film> filmsTable = tablesCollection.GetTable<Film>();

            foreach (Film film in filmsTable)
            {
                foreach (PriorityFilm priorityFilm in this)
                {
                    if (priorityFilm.FilmId == film.ID)
                    {
                        priorityFilm.Film = film;
                    }
                }
            }
        }
    }
}
