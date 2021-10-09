using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.DataAccessLayer.CinemaDataTables
{
	public class BookCategoriesTable : Table<BookCategory>
	{
		public BookCategoriesTable() : base() { }
		public BookCategoriesTable(int id) : base(id) { }
		public BookCategoriesTable(int id, string name) : base(id, name) { }


		public override void ConnectionsSubload(TableCollection tablesCollection)
		{
			
		}
	}
}
