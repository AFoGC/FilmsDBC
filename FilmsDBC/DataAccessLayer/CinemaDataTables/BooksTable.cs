using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.DataAccessLayer.CinemaDataTables
{
    public class BooksTable : Table<Book>
    {
        public BooksTable() : base() { }
        public BooksTable(int id) : base(id) { }
        public BooksTable(int id, string name) : base(id, name) { }
    }
}
