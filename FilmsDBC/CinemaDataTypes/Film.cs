using FilmsDBC.CinemaDataTypes.CellDataClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.CinemaDataTypes
{
	public class Film : Cell
	{
		public String name = "";
		public String genre = "";
		public int realiseYear = 0;
		public bool watched = false;
		public sbyte mark = -1;
        public DateTime dateOfWatch = new DateTime();

		public String comment = "";
		public List<Source> sources = new List<Source>();

		public int countOfviews = 0;
		public int franshiseId = 0;


		public Film() : base()
		{

		}

		public Film(int id) : base(id)
		{

		}
        protected override void saveBody(StreamWriter streamWriter)
        {
            base.saveBody(streamWriter);

			streamWriter.Write(formatParam(nameof(name), name, 2));
			streamWriter.Write(formatParam(nameof(genre), genre, 2));
			streamWriter.Write(formatParam(nameof(realiseYear), realiseYear, 2));
			streamWriter.Write(formatParam(nameof(watched), watched, 2));
			streamWriter.Write(formatParam(nameof(mark), mark, 2));
			streamWriter.Write(formatParam(nameof(dateOfWatch), dateOfWatch, 2));
			streamWriter.Write(formatParam(nameof(comment), comment, 2));

            foreach (Source source in sources)
            {
				streamWriter.Write(formatParam(nameof(source.sourceUrl), source, 2));
			}
			
			streamWriter.Write(formatParam(nameof(countOfviews), countOfviews, 2));
			streamWriter.Write(formatParam(nameof(franshiseId), franshiseId, 2));
		}

		private String formatParam(String variableName, Source item, int countOfTabulations)
        {
			if (item.sourceUrl != "")
			{
				String export = "";
				for (int i = 0; i < countOfTabulations; i++)
				{
					export = export + "\t";
				}
				return export + "<" + variableName + ": " + item.ToString() + ">\n";
			}
			return "";
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
				case "genre":
					this.genre = comand.Argument;
					break;
				case "realiseYear":
					this.realiseYear = Convert.ToInt32(comand.Argument);
					break;
				case "watched":
					this.watched = Convert.ToBoolean(comand.Argument);
					break;
				case "mark":
					this.mark = Convert.ToSByte(comand.Argument);
					break;
				case "dateOfWatch":
					this.dateOfWatch = readDate(comand.Argument);
					break;
				case "comment":
					this.comment = comand.Argument;
					break;
				case "sourceUrl":
					this.sources.Add(Source.ToSource(comand.Argument));
					break;
				case "countOfviews":
					this.countOfviews = Convert.ToInt32(comand.Argument);
					break;
				case "franshiseId":
					this.franshiseId = Convert.ToInt32(comand.Argument);
					break;

				default:
					break;
            }
        }
    }
}
