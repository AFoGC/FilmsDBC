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
	public class Category : Cell
	{
		public String name = "";
		public sbyte mark = -1;
		public int priority = 0;

		public List<Film> films;

		public Category() : base()
		{

		}

		public Category(int id) : base(id)
		{
			
		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			base.saveBody(streamWriter);

			streamWriter.Write(Helper.formatParam(nameof(name), name, 2));
			streamWriter.Write(Helper.formatParam(nameof(mark), mark, 2));
			streamWriter.Write(Helper.formatParam(nameof(priority), priority, 2));
		}
	}
}
