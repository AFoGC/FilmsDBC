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
    }
}
