using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC
{
	public class ProgramSettings : Cell
	{
		private String tablePath;
		public String TablePath
		{
			get { return tablePath; }
            set { tablePath = value; }
		}
		private int markSystem = 0;
		public int MarkSystem
        {
            get { return markSystem; }
            set { markSystem = value; }
        }

		protected override void updateThisBody(Cell cell)
		{
			throw new NotImplementedException();
		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			streamWriter.WriteLine(formatParam("tablePath", tablePath, 1));
		}

		protected override void loadBody(Comand comand)
		{
			switch (comand.Paramert)
			{
				case "tablePath":
					this.tablePath = comand.Argument;
					break;

				default:
					break;
			}
		}
	}
}
