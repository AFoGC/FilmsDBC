using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTables
{
	public class BookCategoriesTable : Table<BookCategory>
	{
		public BookCategoriesTable() : base() { }
		public BookCategoriesTable(int id) : base(id) { }
		public BookCategoriesTable(int id, String name) : base(id, name) { }

        public void CategorySubload(BooksTable booksTable)
        {
            throw new NotImplementedException();
        }
    }
}
