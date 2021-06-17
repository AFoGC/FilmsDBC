using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.CinemaDataTypes.inheir
{
    public class TableCollection
    {
        private List<Table> tables = new List<Table>();
        private int counter = 0;

        public List<Table> Tables
        {
            get { return tables; }
        }

        public void AddTable(Table table)
        {
            tables.Add(table);
        }

        public void AddTable(Type type)
        {
            tables.Add(new Table(++counter, type));
        }

        public Table getTable(int id)
        {
            foreach (Table table in tables)
            {
                if (table.ID == id)
                {
                    return table;
                }
            }
            return null;
        }

        public Table getTable(String name)
        {
            foreach (Table table in tables)
            {
                if (table.name == name)
                {
                    return table;
                }
            }
            return null;
        }

        public bool setTable(Table import)
        {
            for (int i = 0; i < tables.Count; i++)
            {
                if (tables[i].ID == import.ID)
                {
                    tables[i] = import;
                    return true;
                }
            }
            return false;
        }
    }
}
