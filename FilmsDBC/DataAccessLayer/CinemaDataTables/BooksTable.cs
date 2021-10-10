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

		public override void ConnectionsSubload(TableCollection tablesCollection)
		{
			Table<BookGenre> genresTable = tablesCollection.GetTable<BookGenre>();

            foreach (Book book in this)
            {
                if (book.BookGenreId != 0)
                {
                    foreach (BookGenre genre in genresTable)
                    {
						if (book.BookGenreId == genre.ID)
						{
							book.BookGenre = genre;
							break;
						}
					}
                }
                else
                {
					book.BookGenre = genresTable.DefaultCell;
                }
            }
		}
	}
}
