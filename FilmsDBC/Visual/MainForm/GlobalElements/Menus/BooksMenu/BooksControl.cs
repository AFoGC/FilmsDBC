using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.BooksControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu
{
    public partial class BooksControl : UserControl
    {
        public BooksControl()
        {
            InitializeComponent();
        }
        public Panel InfoPanel
        {
            get { return panel_Info; }
        }

        private List<UserControl> tableControls = new List<UserControl>();

        private void clearControls()
        {
            flowLayoutPanel_main.Controls.Clear();
            tableControls.Clear();
        }

        public void LoadCategories()
        {
            clearControls();
            foreach (Book book in MainInfo.Tables.BooksTable)
            {
                tableControls.Add(new BookSimpleControl(book));
            }

            flowLayoutPanel_main.Controls.AddRange(tableControls.ToArray());
        }

        private void button_addBook_Click(object sender, EventArgs e)
        {
            MainInfo.Tables.BooksTable.AddElement();
            Book film = MainInfo.Tables.BooksTable.GetLastElement;
            IControls control = new BookSimpleControl(film);

            tableControls.Add((UserControl)control);
            flowLayoutPanel_main.Controls.Add((UserControl)control);
        }
    }
}
