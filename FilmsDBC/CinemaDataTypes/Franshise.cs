using FilmsDBC.Interpreter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.CinemaDataTypes
{
    public class Franshise : Cell
    {
        public String name = "";
        public int mark = -1;
        public int priority = -1;

        public List<Film> films;

        public Franshise() : base()
        {

        }

        public Franshise(int id, String name, int mark, int priority) : base(id)
        {
            this.name = name;
            this.mark = mark;
            this.priority = priority;
        }

        protected override void saveBody(StreamWriter streamWriter)
        {
            base.saveBody(streamWriter);

            streamWriter.Write(Writer.formatParam(nameof(name), name, 2));
            streamWriter.Write(Writer.formatParam(nameof(mark), mark, 2));
            streamWriter.Write(Writer.formatParam(nameof(priority), priority, 2));
        }
    }
}
