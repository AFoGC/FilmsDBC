using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TablesLibrary.Interpreter;

namespace FilmsDBC.Visual.StaticVisualClasses
{
	class VisualHelper
	{
		public static String markToText(String mark)
		{
			switch (mark)
			{
				case "":
					return mark;

				case "6":
					return mark + "/6";

				default:
					return mark + "/5";
			}
		}

		public static int TextToInt32(String str)
		{
			if (str == "")
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(str);
			}
		}

		public static sbyte TextToMark(String str)
		{
			if (str == "")
			{
				return -1;
			}
			else
			{
				return Convert.ToSByte(str.Substring(0, str.IndexOf('/')));
			}
		}

		public static sbyte TextToSbyte(String str)
		{
			if (str == "")
			{
				return -1;
			}
			else
			{
				return Convert.ToSByte(str);
			}
		}
	}
}
