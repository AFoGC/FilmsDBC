using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.StaticFilmClasses
{
    public static class Subloads
    {
        public static void CategorySubload(this TableCollection tableCollection)
        {
            foreach (Category category in tableCollection.GetTable(typeof(Category)).Cells)
            {
                category.FilmsSubload(MainInformation.tableCollection.GetTable(typeof(Film)));
            }
        }
    }
}
