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
		private String directoyPath;
		public String DirectoryPath
		{
			get { return directoyPath; }
            set { directoyPath = value; }
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
			streamWriter.Write(formatParam("directoyPath", directoyPath, 2));
		}

		protected override void loadBody(Comand comand)
		{
			switch (comand.Paramert)
			{
				case "directoyPath":
					this.directoyPath = comand.Argument;
					break;

				default:
					break;
			}
		}
	}
}
