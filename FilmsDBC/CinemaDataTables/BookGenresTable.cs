using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTables
{
    public class BookGenresTable : Table<BookGenre>
    {
        public BookGenresTable() : base() { }
        public BookGenresTable(int id) : base(id) { }
        public BookGenresTable(int id, String name) : base(id, name) { }
    }
}
