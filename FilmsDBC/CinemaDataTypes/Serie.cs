using FilmsDBC.Interpreter;
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

        public Serie(int filmId, String startWatchDate, int countOfWatchedSeries) : base()
		{
			this.filmId = filmId;
			this.startWatchDate = startWatchDate;
			this.countOfWatchedSeries = countOfWatchedSeries;
		}

        protected override void saveBody(StreamWriter streamWriter)
        {
            base.saveBody(streamWriter);
            streamWriter.Write(Writer.formatParam(nameof(filmId), filmId, 2));
            streamWriter.Write(Writer.formatParam(nameof(startWatchDate), startWatchDate, 2));
            streamWriter.Write(Writer.formatParam(nameof(countOfWatchedSeries), countOfWatchedSeries, 2));
        }
    }
}
