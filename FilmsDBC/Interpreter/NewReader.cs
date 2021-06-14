using FilmsDBC.Interpreter.ReaderClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Interpreter
{
    class NewReader
    {
		public static bool loadAll()
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

										case "Category":
											MainInformation.categoryTable = CategoryReader.loadCategoryTable(sr);
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
