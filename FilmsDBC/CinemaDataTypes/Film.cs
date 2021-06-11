using FilmsDBC.Interpreter;
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
		/*
		public Film(int id, String name, String genre, int realiseYear, bool watched, sbyte mark, String dateOfWatch, String comment, String sourceUrl, int countOfviews, int franshiseId) : base(id)
		{
			this.name = name;
			this.genre = genre;
			this.realiseYear = realiseYear;
			this.watched = watched;
			this.mark = mark;
			this.dateOfWatch = dateOfWatch;
			this.comment = comment;
			this.sourceUrl = sourceUrl;
			this.countOfviews = countOfviews;
			this.franshiseId = franshiseId;
		}
		*/
        protected override void saveBody(StreamWriter streamWriter)
        {
            base.saveBody(streamWriter);

			streamWriter.Write(Writer.formatParam(nameof(name), name, 2));
			streamWriter.Write(Writer.formatParam(nameof(genre), genre, 2));
			streamWriter.Write(Writer.formatParam(nameof(realiseYear), realiseYear, 2));
			streamWriter.Write(Writer.formatParam(nameof(watched), watched, 2));
			streamWriter.Write(Writer.formatParam(nameof(mark), mark, 2));
			streamWriter.Write(Writer.formatParam(nameof(dateOfWatch), dateOfWatch, 2));
			streamWriter.Write(Writer.formatParam(nameof(comment), comment, 2));
			streamWriter.Write(Writer.formatParam(nameof(sourceUrl), sourceUrl, 2));
			streamWriter.Write(Writer.formatParam(nameof(countOfviews), countOfviews, 2));
			streamWriter.Write(Writer.formatParam(nameof(franshiseId), franshiseId, 2));
		}
    }
}
