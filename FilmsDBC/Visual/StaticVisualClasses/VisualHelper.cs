using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.StaticVisualClasses
{
    class VisualHelper
    {
        public static String markToText(String mark)
        {
            switch (mark)
            {
                case "":
                    return mark;

                case "6":
                    return mark + "/6";

                default:
                    return mark + "/5";
            }
        }
    }
}
