using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.DataAccessLayer.CinemaDataTables
{
    public class FilmsTable : Table<Film>
    {
        public FilmsTable() : base() { }
        public FilmsTable(int id) : base(id) { }
        public FilmsTable(int id, string name) : base(id, name) { }
    }
}
