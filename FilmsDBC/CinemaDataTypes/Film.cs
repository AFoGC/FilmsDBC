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
	public class Film : Cell
	{
		public String name = "";
		public String genre = "";
		public int realiseYear = 0;
		public bool watched = false;
		public sbyte mark = -1;
		public String dateOfWatch = "";

		public String comment = "";
		public String sourceUrl = "";

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

			streamWriter.Write(Helper.formatParam(nameof(name), name, 2));
			streamWriter.Write(Helper.formatParam(nameof(genre), genre, 2));
			streamWriter.Write(Helper.formatParam(nameof(realiseYear), realiseYear, 2));
			streamWriter.Write(Helper.formatParam(nameof(watched), watched, 2));
			streamWriter.Write(Helper.formatParam(nameof(mark), mark, 2));
			streamWriter.Write(Helper.formatParam(nameof(dateOfWatch), dateOfWatch, 2));
			streamWriter.Write(Helper.formatParam(nameof(comment), comment, 2));
			streamWriter.Write(Helper.formatParam(nameof(sourceUrl), sourceUrl, 2));
			streamWriter.Write(Helper.formatParam(nameof(countOfviews), countOfviews, 2));
			streamWriter.Write(Helper.formatParam(nameof(franshiseId), franshiseId, 2));
		}
    }
}
