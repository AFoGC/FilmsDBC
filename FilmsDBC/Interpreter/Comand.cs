using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Interpreter
{
	public class Comand
	{
		private String parametr;
		private String argument;
		private bool isComand;

		public String Paramert
		{
			get { return parametr; }
		}

		public String Argument
		{
			get { return argument; }
		}

		public bool IsComand
		{
			get { return isComand; }
		}

		public Comand(String parametr, String argument, bool isComand)
		{
			this.parametr = parametr;
			this.argument = argument;
			this.isComand = isComand;
		}
	}
}
