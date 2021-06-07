using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Interpreter.ReaderClasses
{
    public static class ParamReader
    {
		public static Comand getComand(String import)
		{
			bool isComand = false;
			String param = "";
			int i = 0;
			int n = import.Length;
			for (; i < n; i++)
			{
				if (import[i] == '<')
				{
					isComand = true;
					++i;
					break;
				}
			}

			if (isComand == false)
			{
				return new Comand("", "", isComand);
			}

			for (; i < n; i++)
			{
				switch (import[i])
				{
					case ':':
						i += 2;
						return getArgument(import, param, i);
					case '>':
						return new Comand(param, "", true);
					default:
						param = param + import[i];
						break;
				}
			}
			return new Comand("", "", false);
		}

		private static Comand getArgument(String import, String param, int i)
		{
			String arg = "";
			for (; i < import.Length; i++)
			{
				if (import[i] == '>')
				{
					return new Comand(param, arg, true);
				}
				else
				{
					arg = arg + import[i];
				}
			}

			return new Comand("", "", false);
		}
	}
}
