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
    [TableCell("PriorityFilm")]
    public class PriorityFilm : Cell
    {
        private Film film;

        public Film Film
        {
            get { return film; }
            set { film = value; }
        }

        public PriorityFilm() : base() { }
        public PriorityFilm(int id) : base(id) { }

        protected override void loadBody(Comand comand)
        {
            switch (comand.Paramert)
            {
                case "film":
                    int i = Convert.ToInt32(comand.Value);
                    //this.film = (Film)MainInformation.tableCollection.GetTable(typeof(Film)).GetElement(i);
                    film = MainInfo.Tables.FilmsTable.GetElementByIndex(i);
                    break;


                default:
                    break;
            }
        }

        protected override void saveBody(StreamWriter streamWriter)
        {
            streamWriter.Write(FormatParam(nameof(film), film.ID, 0, 2));
        }

        protected override void updateThisBody(Cell cell)
        {
            PriorityFilm priorityFilm = (PriorityFilm)cell;

            film = priorityFilm.film;
        }
    }
}
