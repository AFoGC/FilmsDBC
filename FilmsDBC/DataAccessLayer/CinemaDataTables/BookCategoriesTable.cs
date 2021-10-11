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
			Table<Book> booksTable = tablesCollection.GetTable<Book>();

			foreach (BookCategory category in this)
			{
				while (category.Books.Count != 0)
				{
					category.Books.Remove(category.Books[0]);
				}
			}

			foreach (Book book in booksTable)
			{
				if (book.FranshiseId != 0)
				{
					foreach (BookCategory category in this)
					{
						if (book.FranshiseId == category.ID)
						{
							category.Books.Add(book);
						}
					}
				}
			}
		}
	}
}
