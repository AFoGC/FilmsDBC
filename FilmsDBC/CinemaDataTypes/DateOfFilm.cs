using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.CinemaDataTypes
{
    public class DateOfFilm
    {
        private int day = 0;
        private int month = 0;
        private int year = 0;

        public static bool firstBigger(DateOfFilm first, DateOfFilm second)
        {
            return false;
        }

        public static void sortToBig(List<DateOfFilm> dateList)
        {

        }

        public static void sortToSmall(List<DateOfFilm> dateList)
        {

        }

        DateOfFilm()
        {

        }

        DateOfFilm(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }
}
