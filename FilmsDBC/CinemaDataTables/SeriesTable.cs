using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTables
{
    public class SeriesTable : Table<Serie>
    {
        public SeriesTable() : base() { }
        public SeriesTable(int id) : base(id) { }
        public SeriesTable(int id, String name) : base(id, name) { }
    }
}
