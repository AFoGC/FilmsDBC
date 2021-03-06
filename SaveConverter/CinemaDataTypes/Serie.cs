using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace SaveConverter.CinemaDataTypes
{
	public class Serie : Cell
	{
		private int filmId = 0;
		private DateTime startWatchDate = new DateTime();
		private int countOfWatchedSeries = 0;
		private int totalSeries = 0;

		public Serie() : base() { }
		public Serie(int id) : base(id) { }

		protected override void updateThisBody(Cell cell)
		{
			Serie serie = (Serie)cell;

			this.filmId = serie.filmId;
			this.startWatchDate = serie.startWatchDate;
			this.countOfWatchedSeries = serie.countOfWatchedSeries;
			this.totalSeries = serie.totalSeries;
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

		public void ConverterLoad(StreamReader sr)
        {
			this.filmId = Convert.ToInt32(sr.ReadLine());
			this.startWatchDate = readDate(sr.ReadLine());
			this.countOfWatchedSeries = Convert.ToInt32(sr.ReadLine());
		}

		public int FilmId
		{
			get { return filmId; }
			set { filmId = value; }
		}

		public DateTime StartWatchDate
		{
			get { return startWatchDate; }
			set { startWatchDate = value; }
		}

		public int CountOfWatchedSeries
		{
			get { return countOfWatchedSeries; }
			set { countOfWatchedSeries = value; }
		}

		public int TotalSeries
		{
			get { return totalSeries; }
			set { totalSeries = value; }
		}
	}
}
