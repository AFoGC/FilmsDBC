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
	public class Cell
	{
		//
		//
		private int id = 0;
		
		public int ID
		{
			set { id = value; }
			get { return id; }
		}

		public Cell()
        {
			
        }

		public Cell(int id)
        {
			this.id = id;
        }

		protected virtual void saveBody(StreamWriter streamWriter)
        {
			streamWriter.Write(Helper.formatParam(nameof(id), id, 2));
		}

		public void saveCell(StreamWriter streamWriter)
        {
			streamWriter.Write(Helper.formatMark(this.GetType(), 1));
			this.saveBody(streamWriter);
			streamWriter.Write(Helper.formatMark(this.GetType(), 1));
        }
	}
}
