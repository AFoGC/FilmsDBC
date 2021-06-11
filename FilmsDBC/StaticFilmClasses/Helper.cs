using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.StaticFilmClasses
{
    public static class Helper
    {
		public static String formatParam(String variableName, int item, int countOftabulations)
		{
			if (item == 0)
			{
				return "";
			}
			else
			{
				String export = "";
				for (int i = 0; i < countOftabulations; i++)
				{
					export = export + "\t";
				}

				return export + "<" + variableName + ": " + item.ToString() + ">\n";
			}
		}

		public static String formatParam(String variableName, sbyte item, int countOftabulations)
		{
			if (item == -1)
			{
				return "";
			}
			else
			{
				String export = "";
				for (int i = 0; i < countOftabulations; i++)
				{
					export = export + "\t";
				}

				return export + "<" + variableName + ": " + item.ToString() + ">\n";
			}
		}

		public static String formatParam(String variableName, String item, int countOfTabulations)
		{
			if (item != "")
			{
				String export = "";
				for (int i = 0; i < countOfTabulations; i++)
				{
					export = export + "\t";
				}
				return export + "<" + variableName + ": " + item + ">\n";
			}
			return "";
		}

		public static String formatParam(String variableName, bool item, int countOfTabulations)
		{
			String export = "";
			for (int i = 0; i < countOfTabulations; i++)
			{
				export = export + "\t";
			}

			return export + "<" + variableName + ": " + item.ToString() + ">\n";
		}

		public static String formatParam(String variableName, DateOfFilm date, int countOfTabulations)
		{
			String export = "";
			for (int i = 0; i < countOfTabulations; i++)
			{
				export = export + "\t";
			}

			return export + "<" + variableName + ": " + date.ToString() + ">\n";
		}

		public static String formatMark(Type type, int countOfTabulations)
		{
			String export = "";
			for (int i = 0; i < countOfTabulations; i++)
			{
				export = export + "\t";
			}
			return export + "<" + type.Name + ">\n";
		}

		public static String tableDeclaration(Type type, int countOfTabulations)
		{
			String export = "";
			for (int i = 0; i < countOfTabulations; i++)
			{
				export = export + "\t";
			}
			return export + "<Table: " + type.Name + ">\n";
		}
	}
}
