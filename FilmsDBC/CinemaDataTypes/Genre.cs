using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTypes
{
	public class Genre : Cell
	{
		private String name = "";
		private bool isSerialGenre = false;

		public Genre() : base() { }
		public Genre(int id) : base(id) { }

		protected override void updateThisBody(Cell cell)
		{
			Genre genre = (Genre)cell;

			this.name = genre.name;
			this.isSerialGenre = genre.isSerialGenre;
		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			streamWriter.Write(formatParam(nameof(id), id, 2));
			streamWriter.Write(formatParam(nameof(name), name, 2));
			streamWriter.Write(formatParam(nameof(isSerialGenre), isSerialGenre, 2));
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
				case "isSerialGenre":
					this.isSerialGenre = Convert.ToBoolean(comand.Argument);
					break;

				default:
					break;
            }
		}

		public String Name
        {
            get { return name; }
			set { name = value; }
        }

		public bool IsSerialGenre
        {
            get { return isSerialGenre; }
            set { isSerialGenre = value; }
        }
	}
}
