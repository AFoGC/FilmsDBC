using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTables
{
    public class PriorityFilmsTable : Table<PriorityFilm>
    {
        public PriorityFilmsTable() : base() { }
        public PriorityFilmsTable(int id) : base(id) { }
        public PriorityFilmsTable(int id, String name) : base(id, name) { }
    }
}
