using FilmsDBC.Interpreter;
using FilmsDBC.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainInformation.loadTables();
            MainInformation.saveTables();
            Application.Run(new MainForm());
        }
    }
}
