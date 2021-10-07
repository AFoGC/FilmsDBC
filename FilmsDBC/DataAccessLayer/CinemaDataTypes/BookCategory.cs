using FilmsDBC.DataAccessLayer.CinemaDataTables;
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
    [TableCell("BookCategory")]
    public class BookCategory : Cell
    {
        private string name = "";
        private sbyte mark = -1;
        private int priority = 0;

        private List<Book> books = new List<Book>();

        public BookCategory() : base() { }
        public BookCategory(int id) : base(id) { }

        protected override void updateThisBody(Cell cell)
        {
            BookCategory category = (BookCategory)cell;

            name = category.name;
            mark = category.mark;
            priority = category.priority;
            books = category.books;
        }

        protected override void saveBody(StreamWriter streamWriter)
        {
            streamWriter.Write(FormatParam(nameof(name), name, "", 2));
            streamWriter.Write(FormatParam(nameof(mark), mark, -1, 2));
            streamWriter.Write(FormatParam(nameof(priority), priority, 0, 2));
        }

        protected override void loadBody(Comand comand)
        {
            switch (comand.Paramert)
            {
                case "name":
                    name = comand.Value;
                    break;
                case "mark":
                    mark = Convert.ToSByte(comand.Value);
                    break;
                case "priority":
                    priority = Convert.ToInt32(comand.Value);
                    break;

                default:
                    break;
            }
        }

        public void BooksSubload(BooksTable table)
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public sbyte Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
    }
}
