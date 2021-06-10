using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.CinemaDataTypes
{
    public class SerieTable : Table<Serie>
    {
        public SerieTable() : base()
        {

        }

        public SerieTable(String name) : base(name)
        {

        }
    }
}
