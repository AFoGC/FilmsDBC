﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTypes
{
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
				case "id":
					this.id = Convert.ToInt32(comand.Argument);
					break;
				case "film":
					int i = Convert.ToInt32(comand.Argument);
					this.film = (Film)MainInformation.tableCollection.GetTable(typeof(Film)).GetElement(i);
					break;


				default:
					break;
			}
		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			streamWriter.Write(formatParam(nameof(id), id, 2));
			streamWriter.Write(formatParam(nameof(film), film.ID, 2));
		}

		protected override void updateThisBody(Cell cell)
		{
			PriorityFilm priorityFilm = (PriorityFilm)cell;

			this.film = priorityFilm.film;
		}
	}
}
