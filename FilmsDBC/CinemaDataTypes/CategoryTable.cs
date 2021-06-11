using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.CinemaDataTypes
{
	public class CategoryTable : Table<Category>
	{
		public CategoryTable() : base()
		{

		}

		public CategoryTable(String name) : base(name)
		{

		}

		new public List<Category> Items
        {
            get
            {
				List<Category> export = new List<Category>();
				List<Category> list = new List<Category>(); 

                foreach (Category franshise in items)
                {
                    if (franshise.priority != 0)
                    {
						export.Add(franshise);
                    }
                    else
                    {
						list.Add(franshise);
                    }
                }

				foreach (Category franshise in list)
				{
					export.Add(franshise);
				}

				return export;
			}
        }

		public void setFirstPriority(int id)
		{
			foreach (Category franshise in items)
			{
                if (franshise.ID == id)
                {
					franshise.priority = 1;
                }
                else
                {
                    if (franshise.priority != 0)
                    {
						++franshise.priority;
                    }
                }
			}
		}
	}
}
