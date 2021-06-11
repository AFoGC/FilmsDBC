using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.CinemaDataTypes
{
	public class FranshiseTable : Table<Franshise>
	{
		public FranshiseTable() : base()
		{

		}

		public FranshiseTable(String name) : base(name)
		{

		}

		new public List<Franshise> Items
        {
            get
            {
				List<Franshise> export = new List<Franshise>();
				List<Franshise> list = new List<Franshise>(); 

                foreach (Franshise franshise in items)
                {
                    if (franshise.priority != -1)
                    {
						export.Add(franshise);
                    }
                    else
                    {
						list.Add(franshise);
                    }
                }

				foreach (Franshise franshise in list)
				{
					export.Add(franshise);
				}

				return export;
			}
        }

		public void setFirstPriority(int id)
		{
			foreach (Franshise franshise in items)
			{
                if (franshise.ID == id)
                {
					franshise.priority = 0;
                }
                else
                {
                    if (franshise.priority != -1)
                    {
						++franshise.priority;
                    }
                }
			}
		}
	}
}
