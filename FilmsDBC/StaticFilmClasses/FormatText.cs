using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;

namespace FilmsDBC.StaticFilmClasses
{
	public static class FormatText
	{
		public static String formatToText(int item)
		{
			if (item != 0)
			{
				return item.ToString();
			}
			else
			{
				return "";
			}
		}

		public static String formatToText(sbyte item)
		{
			if (item != -1)
			{
				return item.ToString();
			}
			else
			{
				return "";
			}
		}

		public static String formatToText(String item)
		{
			if (item != "")
			{
				return item;
			}
			else
			{
				return "";
			}
		}

		public static String formatToText(DateTime item)
		{
			if (item.Year != 1)
			{
				return Cell.formatDate(item);
			}
			else
			{
				return "";
			}
		}
	}
}
