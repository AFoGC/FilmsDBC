using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTypes
{
	public class Category : Cell
	{
		public String name = "";
		public sbyte mark = -1;
		public int priority = 0;

		public List<Film> films = new List<Film>();

		public Category() : base()
		{

		}

		public Category(int id) : base(id)
		{
			
		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			streamWriter.Write(formatParam(nameof(id), id, 2));
			streamWriter.Write(formatParam(nameof(name), name, 2));
			streamWriter.Write(formatParam(nameof(mark), mark, 2));
			streamWriter.Write(formatParam(nameof(priority), priority, 2));
		}

        protected override void loadBody(Comand comand)
        {
			switch (comand.Paramert)
			{
				case "id":
					this.id = Convert.ToInt32(comand.Argument);
					break;
				case "name":
					this.name = comand.Argument;
					break;
				case "mark":
					this.mark = Convert.ToSByte(comand.Argument);
					break;
				case "priority":
					this.priority = Convert.ToInt32(comand.Argument);
					break;

				default:
					break;
			}
		}
    }
}
