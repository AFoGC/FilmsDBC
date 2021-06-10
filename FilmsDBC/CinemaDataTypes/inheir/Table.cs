using FilmsDBC.Interpreter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.CinemaDataTypes
{
	public class Table<Te> where Te : Cell, new()
	{
		protected int id = -1;
		public String name = "";
		protected List<Te> items = new List<Te>();

		private static int count = 0;
		private int lastId = 0;

		public int ID
		{
			set { id = value; }
			get { return id; }
		}

		public List<Te> Items
		{
			get { return items; }
		}
		public int LastID
		{
			set { lastId = value; }
			get { return lastId; }
		}

		public Table()
		{
			this.id = ++count;
		}

		public Table(String name)
		{
			this.id = ++count;
			this.name = name;
		}

		public Table(int id, String name)
		{
			this.id = id;
			this.name = name;
		}

		public void addElement()
		{
			Te item = new Te();
			item.ID = ++lastId;
			items.Add(item);
		}

		public void addElement(Te item)
		{
			items.Add(item);
		}

		public Type getElementType()
        {
			return typeof(Te);
        }

		public void saveTable(StreamWriter streamWriter)
		{
			streamWriter.Write(Writer.tableDeclaration(typeof(Te), 0));
			streamWriter.Write(Writer.formatParam(nameof(id), id, 1));
			streamWriter.Write(Writer.formatParam(nameof(name), name, 1));

			foreach (Te cell in this.items)
			{
				cell.saveCell(streamWriter);
			}

			streamWriter.WriteLine("<Table>");
			streamWriter.WriteLine();
		}

		public Te getElemnt(int index)
        {
            foreach (Te item in items)
            {
                if (item.ID == index)
                {
					return item;
                }
            }
			return null;
        }
	}
}
