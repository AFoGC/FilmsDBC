using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTables
{
	public class BooksTable : Table<Book>
	{
		public BooksTable() : base() { }
		public BooksTable(int id) : base(id) { }
		public BooksTable(int id, String name) : base(id, name) { }
	}
}
