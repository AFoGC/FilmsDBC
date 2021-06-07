using FilmsDBC.CinemaDataTypes;
using FilmsDBC.Interpreter.ReaderClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Interpreter
{
	public static class Reader
	{
		
		public static bool loadAll(FilmTable filmTable, SerieTable serieTable)
		{
			using (StreamReader sr = new StreamReader(MainInformation.TablePath, System.Text.Encoding.Default))
			{
				if (sr.ReadLine() == "<DocStart>")
				{
					Comand comand;
					bool endReading = false;
					while (endReading == false)
					{
						comand = ParamReader.getComand(sr.ReadLine());
						if (comand.IsComand)
						{
							switch (comand.Paramert)
							{
								case "Table":
									switch (comand.Argument)
									{
										case "Film":
											MainInformation.filmTable = FilmReader.loadFilmTable(sr);
											break;

										case "Serie":
											MainInformation.serieTable = SerieReader.loadSerieTable(sr);
											break;

										default:
											break;
									}
									break;
								case "DocEnd":
									endReading = true;
									break;

								default:
									break;

							}
						}
					}
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}
}
