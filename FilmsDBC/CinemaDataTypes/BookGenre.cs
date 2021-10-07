using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;
using TablesLibrary.Interpreter.Attributes;

namespace FilmsDBC.CinemaDataTypes
{
	[TableCell("BookGenre")]
	class BookGenre : Cell
    {
		private String name = "";

		public BookGenre() : base() { }
		public BookGenre(int id) : base(id) { }

		protected override void updateThisBody(Cell cell)
		{
			BookGenre bookGenre = (BookGenre)cell;

			this.name = bookGenre.name;
		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			streamWriter.Write(FormatParam(nameof(name), name, "", 2));
		}
		protected override void loadBody(Comand comand)
		{

			switch (comand.Paramert)
			{
				case "name":
					this.name = comand.Value;
					break;

				default:
					break;
			}
		}

		public String Name
		{
			get { return name; }
			set { name = value; }
		}

	}
}
