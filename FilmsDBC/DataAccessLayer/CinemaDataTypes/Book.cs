using FilmsDBC.DataAccessLayer.CinemaDataTypes.CellDataClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;
using TablesLibrary.Interpreter.Attributes;

namespace FilmsDBC.DataAccessLayer.CinemaDataTypes
{
	[TableCell("Book")]
	public class Book : Cell
	{
		private String name = "";
		private String author = "";
		private BookGenre bookGenre;
		private int bookGenreId = 0;
		private int publicationYear = 0;
		private bool readed = false;
		private DateTime fullReadDate = new DateTime();
		private sbyte mark = -1;
		private List<Source> sources = new List<Source>();

		public Book() : base() { }
		public Book(int id) : base(id) { }

		protected override void loadBody(Comand comand)
		{
            switch (comand.Paramert)
            {
				case "name":
					this.name = comand.Value;
					break;
				case "author":
					this.author = comand.Value;
					break;
				case "bookGenreId":
					this.bookGenreId = Convert.ToInt32(comand.Value);
					break;
				case "publicationYear":
					this.publicationYear = Convert.ToInt32(comand.Value);
					break;
				case "readed":
					this.readed = Convert.ToBoolean(comand.Value);
					break;
				case "fullReadDate":
					this.fullReadDate = readDate(comand.Value);
					break;
				case "mark":
					this.mark = Convert.ToSByte(comand.Value);
					break;
				case "sourceUrl":
					this.sources.Add(Source.ToSource(comand.Value));
					break;
			}
		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			streamWriter.Write(FormatParam(nameof(name), name, "", 2));
			streamWriter.Write(FormatParam(nameof(author), author, "", 2));
			streamWriter.Write(FormatParam("bookGenreId", bookGenreId, 0, 2));
			streamWriter.Write(FormatParam(nameof(publicationYear), publicationYear, 0, 2));
			streamWriter.Write(FormatParam(nameof(readed), readed, false, 2));
			streamWriter.Write(FormatParam(nameof(fullReadDate), fullReadDate, new DateTime(), 2));
			streamWriter.Write(FormatParam(nameof(mark), mark, -1, 2));

			foreach (Source source in sources)
			{
				streamWriter.Write(formatParam(nameof(source.sourceUrl), source, 2));
			}
		}

		protected override void updateThisBody(Cell cell)
		{
			Book book = (Book)cell;

			this.name = book.name;
			this.author = book.author;
			this.publicationYear = book.publicationYear;
			this.readed = book.readed;
			this.fullReadDate = book.fullReadDate;
			this.mark = book.mark;
			this.sources = book.sources;
		}


		public String Name
        {
            get { return name; }
            set { name = value; }
        }
		public String Author
        {
            get { return author; }
            set { author = value; }
        }
		public BookGenre BookGenre
        {
            get { return bookGenre; }
            set
            {
				bookGenre = value;
				bookGenreId = bookGenre.ID;
            }
        }
		public int BookGenreId
        {
            get { return bookGenreId; }
        }
		public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }
		public bool Readed
        {
            get { return readed; }
            set { readed = value; }
        }
		public DateTime FullReadDate
        {
            get { return fullReadDate; }
            set { fullReadDate = value; }
        }
		public sbyte Mark
        {
            get { return mark; }
            set { mark = value; }
        }
		public List<Source> Sources
        {
            get { return sources; }
			set { sources = value; }
		}


		private String formatParam(String variableName, Source item, int countOfTabulations)
		{
			if (item.sourceUrl != "")
			{
				String export = "";
				for (int i = 0; i < countOfTabulations; i++)
				{
					export = export + "\t";
				}
				return export + "<" + variableName + ": " + item.ToString() + ">\n";
			}
			return "";
		}
	}
}
