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
		public String dateOfWatch = "";

		public String comment = "";
		public List<String> sources = new List<String>();

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

            foreach (String sourceUrl in sources)
            {
				streamWriter.Write(formatParam(nameof(sourceUrl), sourceUrl, 2));
			}
			
			streamWriter.Write(formatParam(nameof(countOfviews), countOfviews, 2));
			streamWriter.Write(formatParam(nameof(franshiseId), franshiseId, 2));
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
					this.dateOfWatch = comand.Argument;
					break;
				case "comment":
					this.comment = comand.Argument;
					break;
				case "sourceUrl":
					this.sources.Add(comand.Argument);
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
