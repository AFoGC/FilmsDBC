using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Interpreter.ReaderClasses
{
    class CategoryReader
    {
        public static CategoryTable loadCategoryTable(StreamReader streamReader)
        {
            CategoryTable categoryTable = new CategoryTable();
            bool endReading = false;
            Comand comand;

			while(endReading == false)
			{
				comand = ParamReader.getComand(streamReader.ReadLine());
				if (comand.IsComand)
				{
					switch (comand.Paramert)
					{
						case "Category":
							categoryTable.addElement(loadCategory(streamReader));
							break;
						case "id":
							categoryTable.ID = Convert.ToInt32(comand.Argument);
							break;
						case "name":
							categoryTable.name = comand.Argument;
							break;
						case "Table":
							endReading = true;
							break;
						default:
							break;
					}
				}
			}

			return categoryTable;
        }

        private static Category loadCategory(StreamReader streamReader)
        {
			Category category = new Category();
			bool endReading = false;
			Comand comand;

			while (endReading == false)
			{
				comand = ParamReader.getComand(streamReader.ReadLine());
				if (comand.IsComand)
				{
					switch (comand.Paramert)
					{
						case "id":
							category.ID = Convert.ToInt32(comand.Argument);
							break;
						case "name":
							category.name = comand.Argument;
							break;
						case "mark":
							category.mark = Convert.ToSByte(comand.Argument);
							break;
						case "priority":
							category.priority = Convert.ToInt32(comand.Argument);
							break;
						
						default:
							break;
					}
				}
			}

			return category;
        }
    }
}
