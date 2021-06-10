using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.CinemaDataTypes
{
    public class FilmTable : Table<Film>
    {
        public FilmTable() : base()
        {

        }

        public FilmTable(String name) : base(name)
        {
             
        }

        public Film getElemnt(String name)
        {
            foreach (Film item in items)
            {
                if (item.name == name)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
