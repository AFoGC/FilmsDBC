using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTypes
{
	public class Serie : Cell
	{
		public int filmId = 0;
		public DateTime startWatchDate = new DateTime();
		public int countOfWatchedSeries = 0;
		public int totalSeries = 0;

		public Serie() : base()
		{

		}

		public Serie(int id) : base(id)
		{

		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			streamWriter.Write(formatParam(nameof(id), id, 2));
			streamWriter.Write(formatParam(nameof(filmId), filmId, 2));
			streamWriter.Write(formatParam(nameof(startWatchDate), startWatchDate, 2));
			streamWriter.Write(formatParam(nameof(countOfWatchedSeries), countOfWatchedSeries, 2));
			streamWriter.Write(formatParam(nameof(totalSeries), totalSeries, 2));
		}

		protected override void loadBody(Comand comand)
		{
			switch (comand.Paramert)
			{
				case "id":
					this.id = Convert.ToInt32(comand.Argument);
					break;
				case "filmId":
					this.filmId = Convert.ToInt32(comand.Argument);
					break;
				case "startWatchDate":
					this.startWatchDate = readDate(comand.Argument);
					break;
				case "countOfWatchedSeries":
					this.countOfWatchedSeries = Convert.ToInt32(comand.Argument);
					break;
				case "totalSeries":
					this.totalSeries = Convert.ToInt32(comand.Argument);
					break;

				default:
					break;
			}
		}
	}
}
