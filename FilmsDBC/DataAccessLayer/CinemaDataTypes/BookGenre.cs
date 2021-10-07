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
    [TableCell("BookGenre")]
    public class BookGenre : Cell
    {
        private string name = "";

        public BookGenre() : base() { }
        public BookGenre(int id) : base(id) { }

        protected override void updateThisBody(Cell cell)
        {
            BookGenre bookGenre = (BookGenre)cell;

            name = bookGenre.name;
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
                    name = comand.Value;
                    break;

                default:
                    break;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
