using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using FilmsDBC.CinemaDataTypes;

namespace Benchmark.Interpreter
{
    [MemoryDiagnoser]
    [RankColumn]
    public class TableCollectionBenchmark
    {

        [Benchmark]
        public void loadTableCollection()
        {
            TableCollection tableCollection = new TableCollection(@"F:\filmsDirectory\Films.fdbc");

            tableCollection.AddTable(typeof(Category));
            tableCollection.AddTable(typeof(Film));
            tableCollection.AddTable(typeof(Serie));


            tableCollection.loadTables();
        }
    }
}
