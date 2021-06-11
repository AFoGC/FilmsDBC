using FilmsDBC.Interpreter;
using FilmsDBC.StaticFilmClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.CinemaDataTypes
{
    public class Serie : Cell
    {
        public int filmId = 0;
        public String startWatchDate = "";
        public int countOfWatchedSeries = 0;

        public Serie() : base()
        {

        }

        public Serie(int id) : base(id)
		{

		}

        protected override void saveBody(StreamWriter streamWriter)
        {
            base.saveBody(streamWriter);
            streamWriter.Write(Helper.formatParam(nameof(filmId), filmId, 2));
            streamWriter.Write(Helper.formatParam(nameof(startWatchDate), startWatchDate, 2));
            streamWriter.Write(Helper.formatParam(nameof(countOfWatchedSeries), countOfWatchedSeries, 2));
        }
    }
}
