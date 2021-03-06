using SaveConverter.CinemaDataTypes.CellDataClasses;
using SaveConverter.Converter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace SaveConverter.CinemaDataTypes
{
	public class Film : Cell
	{
		private String name = "";
		private Genre genre = null;
		private int realiseYear = 0;
		private bool watched = false;
		private sbyte mark = -1;
		private DateTime dateOfWatch = new DateTime();

		private String comment = "";
		private List<Source> sources = new List<Source>();

		private int countOfviews = 0;
		private int franshiseId = 0;
		private sbyte franshiseListIndex = -1;


		public Film() : base() { }
		public Film(int id) : base(id) { }

		protected override void updateThisBody(Cell cell)
		{
			Film film = (Film)cell;

			this.name = film.name;
			this.genre = film.genre;
			this.realiseYear = film.realiseYear;
			this.watched = film.watched;
			this.mark = film.mark;
			this.dateOfWatch = film.dateOfWatch;
			this.comment = film.comment;
			this.sources = film.sources;
			this.countOfviews = film.countOfviews;
			this.franshiseId = film.franshiseId;
			this.franshiseListIndex = film.franshiseListIndex;
		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			streamWriter.Write(formatParam(nameof(id), id, 2));
			streamWriter.Write(formatParam(nameof(name), name, 2));
			streamWriter.Write(formatParam(nameof(genre), genre.ID, 2));
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
			streamWriter.Write(formatParam(nameof(franshiseListIndex), franshiseListIndex, 2));
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
					this.genre = (Genre)MainInfo.tableCollection.GetTable(typeof(Genre)).GetElement(Convert.ToInt32(comand.Argument));
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
				case "franshiseListIndex":
					this.franshiseListIndex = Convert.ToSByte(comand.Argument);
					break;

				default:
					break;
			}
		}

		public void ConverterLoad(StreamReader sr)
        {
			this.id = Convert.ToInt32(sr.ReadLine());
			this.name = sr.ReadLine();
			this.genre = StaticHelper.GetGenreByName(sr.ReadLine());
			this.realiseYear = Convert.ToInt32(sr.ReadLine());
			this.watched = Convert.ToBoolean(sr.ReadLine());
			this.mark = Convert.ToSByte(sr.ReadLine());
			this.dateOfWatch = readDate(sr.ReadLine());
			this.comment = sr.ReadLine();
			this.sources.Add(Source.ToSource(sr.ReadLine()));
			this.countOfviews = Convert.ToInt32(sr.ReadLine());
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

		public String Name
		{
			get { return name; }
			set { name = value; }
		}

		public Genre Genre
		{
			get
            {
                if (genre != null)
                {
					return genre;
                }
                else
                {
					return new Genre(0);
                }
            }
			set { genre = value; }
		}

		public int RealiseYear
		{
			get { return realiseYear; }
			set { realiseYear = value; }
		}

		public bool Watched
		{
			get { return watched; }
			set { watched = value; }
		}

		public sbyte Mark
		{
			get { return mark; }
			set { mark = value; }
		}

		public DateTime DateOfWatch
		{
			get { return dateOfWatch; }
			set { dateOfWatch = value; }
		}

		public String Comment
		{
			get { return comment; }
			set { comment = value; }
		}

		public List<Source> Sources
		{
			get { return sources; }
			set { sources = value; }
		}

		public int CountOfViews
		{
			get { return countOfviews; }
			set { countOfviews = value; }
		}

		public int FranshiseId
		{
			get { return franshiseId; }
			set { franshiseId = value; }
		}

		public sbyte FranshiseListIndex
        {
            get { return franshiseListIndex; }
			set { franshiseListIndex = value; }
        }
	}
}
