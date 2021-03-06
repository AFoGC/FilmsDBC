using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace SaveConverter.CinemaDataTypes
{
	public class Category : Cell
	{
		private String name = "";
		private sbyte mark = -1;
		private int priority = 0;

		private List<Film> films = new List<Film>();

		public Category() : base() { }
		public Category(int id) : base(id) { }

		protected override void updateThisBody(Cell cell)
		{
			Category category = (Category)cell;

			this.name = category.name;
			this.mark = category.mark;
			this.priority = category.priority;
			this.films = category.films;
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

		public void FilmsSubload(Table table)
		{
			if (table.DataType == typeof(Film))
			{
				foreach (Film film in table.Cells)
				{
					if (film.FranshiseId == this.ID)
					{
						this.films.Add(film);
					}
				}
			}
			else
			{
				throw new Exception("Wrong table DataType");
			}
		}

		public String Name
		{
			get { return name; }
			set { name = value; }
		}

		public sbyte Mark
		{
			get { return mark; }
			set { mark = value; }
		}

		public int Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		public List<Film> Films
		{
			get { return films; }
			set { films = value; }
		}
	}
}
