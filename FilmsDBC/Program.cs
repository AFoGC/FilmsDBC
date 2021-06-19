using FilmsDBC.Visual;
using FilmsDBC.Visual.Forms;
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
            MainInformation.TablesInitialize();
            MainInformation.tableCollection.loadTables();
            MainInformation.tableCollection.saveTables();
            Application.Run(new MainForm());
        }
    }
}
