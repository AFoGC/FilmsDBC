using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablesLibrary.Interpreter;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using FilmsDBC.DataAccessLayer.CinemaDataTypes;

namespace Benchmark.Interpreter
{
    [MemoryDiagnoser]
    [RankColumn]
    public class TableCollectionBenchmark
    {

        [Benchmark]
        public void loadTableCollection()
        {
            
        }
    }
}
