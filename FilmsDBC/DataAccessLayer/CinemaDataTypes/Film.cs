using FilmsDBC.DataAccessLayer.CinemaDataTypes.CellDataClasses;
using FilmsDBC.StaticFilmClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;
using TablesLibrary.Interpreter.Attributes;

namespace FilmsDBC.DataAccessLayer.CinemaDataTypes
{
	[TableCell("Film")]
	public class Film : Cell
	{
		private string name = "";
		private Genre genre = null;
		private int genreId = 0;
		private int realiseYear = 0;
		private bool watched = false;
		private sbyte mark = -1;
		private DateTime dateOfWatch = new DateTime();

		private string comment = "";
		private List<Source> sources = new List<Source>();

		private int countOfviews = 0;
		private int franshiseId = 0;
		private sbyte franshiseListIndex = -1;


		public Film() : base() { }
		public Film(int id) : base(id) { }

		protected override void updateThisBody(Cell cell)
		{
			Film film = (Film)cell;

			name = film.name;
			Genre = film.genre;
			realiseYear = film.realiseYear;
			watched = film.watched;
			mark = film.mark;
			dateOfWatch = film.dateOfWatch;
			comment = film.comment;
			sources = film.sources;
			countOfviews = film.countOfviews;
			franshiseId = film.franshiseId;
			franshiseListIndex = film.franshiseListIndex;
		}

		protected override void saveBody(StreamWriter streamWriter)
		{
			streamWriter.Write(FormatParam("name", name, "", 2));
			streamWriter.Write(FormatParam("genre", genre.ID, 0, 2));
			streamWriter.Write(FormatParam("realiseYear", realiseYear, 0, 2));
			streamWriter.Write(FormatParam("watched", watched, false, 2));
			streamWriter.Write(FormatParam("mark", mark, -1, 2));
			streamWriter.Write(FormatParam("dateOfWatch", dateOfWatch, new DateTime(), 2));
			streamWriter.Write(FormatParam("comment", comment, "", 2));

			foreach (Source source in sources)
			{
				streamWriter.Write(formatParam("sourceUrl", source, 2));
			}

			streamWriter.Write(FormatParam("countOfviews", countOfviews, 0, 2));
			streamWriter.Write(FormatParam("franshiseId", franshiseId, 0, 2));
			streamWriter.Write(FormatParam("franshiseListIndex", franshiseListIndex, -1, 2));
		}

		protected override void loadBody(Comand comand)
		{
			switch (comand.Paramert)
			{
				case "name":
					name = comand.Value;
					break;
				case "genre":
					genreId = Convert.ToInt32(comand.Value);
					break;
				case "realiseYear":
					realiseYear = Convert.ToInt32(comand.Value);
					break;
				case "watched":
					watched = Convert.ToBoolean(comand.Value);
					break;
				case "mark":
					mark = Convert.ToSByte(comand.Value);
					break;
				case "dateOfWatch":
					dateOfWatch = readDate(comand.Value);
					break;
				case "comment":
					comment = comand.Value;
					break;
				case "sourceUrl":
					sources.Add(Source.ToSource(comand.Value));
					break;
				case "countOfviews":
					countOfviews = Convert.ToInt32(comand.Value);
					break;
				case "franshiseId":
					franshiseId = Convert.ToInt32(comand.Value);
					break;
				case "franshiseListIndex":
					franshiseListIndex = Convert.ToSByte(comand.Value);
					break;

				default:
					break;
			}
		}

		private string formatParam(string variableName, Source item, int countOfTabulations)
		{
			if (item.sourceUrl != "")
			{
				string export = "";
				for (int i = 0; i < countOfTabulations; i++)
				{
					export = export + "\t";
				}
				return export + "<" + variableName + ": " + item.ToString() + ">\n";
			}
			return "";
		}

		public string Name
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
			set
			{
				genre = value;
				genreId = genre.ID;
			}
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

		public string Comment
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

		public int GenreId
		{
			get { return genreId; }
		}
	}
}
