using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTables
{
	public class CategoriesTable : Table<Category>
	{
		public CategoriesTable() : base() { }
		public CategoriesTable(int id) : base(id) { }
		public CategoriesTable(int id, String name) : base(id, name) { }

		public void CategorySubload(FilmsTable filmsTable)
		{
			foreach (Category category in this)
			{
				category.FilmsSubload(filmsTable);
			}
		}
	}
}
