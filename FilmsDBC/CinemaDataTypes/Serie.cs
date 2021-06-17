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

		public Serie(int id) : base(id)
		{

		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			base.saveBody(streamWriter);
			streamWriter.Write(formatParam(nameof(filmId), filmId, 2));
			streamWriter.Write(formatParam(nameof(startWatchDate), startWatchDate, 2));
			streamWriter.Write(formatParam(nameof(countOfWatchedSeries), countOfWatchedSeries, 2));
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
					this.startWatchDate = comand.Argument;
					break;
				case "countOfWatchedSeries":
					this.countOfWatchedSeries = Convert.ToInt32(comand.Argument);
					break;

				default:
					break;
			}
		}
	}
}
