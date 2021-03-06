using FilmsDBC.DataAccessLayer.CinemaDataTables;
using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.MoreInfo;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.UpdateInfo;
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
            moreInfoVisualizer = new MoreInfoFormVisualizer(panel_Info);
            updateVisualizer = new UpdateFormVisualizer(panel_Info);
            MainInfo.TableCollection.TableLoad += new EventHandler(this.TableCollection_TablesLoad);
        }

        private void TableCollection_TablesLoad(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private MoreInfoFormVisualizer moreInfoVisualizer;
        public MoreInfoFormVisualizer MoreInfoVisualizer
        {
            get { return moreInfoVisualizer; }
        }
        private UpdateFormVisualizer updateVisualizer;
        public UpdateFormVisualizer UpdateVisualizer
        {
            get { return updateVisualizer; }
        }

        private ABookElementControl controlInBuffer = null;
        public ABookElementControl ControlInBuffer
        {
            get { return controlInBuffer; }
            set { controlInBuffer = value; }
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
            controlInBuffer = null;

            foreach (BookCategory category in MainInfo.Tables.BookCategoriesTable)
            {
                tableControls.Add(new BookCategoryControl(category));
            }

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

        private void button_addCategory_Click(object sender, EventArgs e)
        {
            //if (controlsCondition == MenuCondition.Category)
            {
                BookCategoriesTable categoryTable = MainInfo.Tables.BookCategoriesTable;
                categoryTable.AddElement();
                BookCategoryControl categoryControl = new BookCategoryControl(categoryTable.GetLastElement);
                flowLayoutPanel_main.Controls.Add(categoryControl);
                flowLayoutPanel_main.Controls.SetChildIndex(categoryControl, categoryTable.Count - 1);
            }
        }
    }
}
