using SaveConverter.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader.LoadAll();
            MainInfo.tableCollection.saveTables();
        }
    }
}
