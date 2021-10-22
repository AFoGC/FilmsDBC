using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateControls;
using FilmsDBC.Visual.StaticVisualClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.BooksControls
{
    public partial class BookCategoryControl : UserControl, IBooksControls
    {

        public BookCategory CategoryInfo { get; private set; }
        public BookCategoryControl(BookCategory category)
        {
            InitializeComponent();
            this.CategoryInfo = category;

            this.label_update.SetDefaultButtonBlink();
            RefreshData();
        }

        public void RefreshData()
        {
            this.textBox_id.Text = CategoryInfo.ID.ToString();
            this.textBox_name.Text = CategoryInfo.Name;
            this.textBox_mark.Text = VisualHelper.markToText(Category.FormatToString(CategoryInfo.Mark, -1));

            categoryBooks();
        }

        private Point controlPoint = new Point(830, 18);
        private Point panelPoint = new Point(800, 5);
        private void categoryBooks()
        {
            this.flowLayoutPanel_SimpleControls.Controls.Clear();

            Size panelSize = new Size(panelPoint);
            Size controlSize = new Size(controlPoint);

            this.Size = new Size(controlPoint);
            flowLayoutPanel_SimpleControls.Size = new Size(panelPoint);

            foreach (Book book in CategoryInfo.Books)
            {
                panelSize.Height += 15;
                controlSize.Height += 15;
                this.Size = controlSize;
                flowLayoutPanel_SimpleControls.Size = panelSize;
                flowLayoutPanel_SimpleControls.Controls.Add(new BookSimpleControl(book));
            }

            foreach (BookSimpleControl simpleControl in flowLayoutPanel_SimpleControls.Controls)
            {
                flowLayoutPanel_SimpleControls.Controls.SetChildIndex(simpleControl, simpleControl.BookInfo.FranshiseListIndex);
            }
        }

        public void AddSimpleCotrol(Book book)
        {
            Size controlSize = this.Size;
            Size panelSize = this.flowLayoutPanel_SimpleControls.Size;
            panelSize.Height += 15;
            controlSize.Height += 15;
            this.Size = controlSize;
            flowLayoutPanel_SimpleControls.Size = panelSize;

            this.flowLayoutPanel_SimpleControls.Controls.Add(new BookSimpleControl(book));

            book.FranshiseListIndex = Convert.ToSByte(flowLayoutPanel_SimpleControls.Controls.Count - 1);
        }

        public bool RemoveBookFromCategory(BookSimpleControl simpleControl)
        {
            if (simpleControl.BookInfo.FranshiseId == this.CategoryInfo.ID)
            {
                flowLayoutPanel_SimpleControls.Controls.Remove(simpleControl);

                Size controlSize = this.Size;
                Size panelSize = this.flowLayoutPanel_SimpleControls.Size;
                panelSize.Height -= 15;
                controlSize.Height -= 15;
                this.Size = controlSize;
                flowLayoutPanel_SimpleControls.Size = panelSize;

                simpleControl.BookInfo.FranshiseId = 0;
                simpleControl.BookInfo.FranshiseListIndex = 0;

                foreach (Book book in CategoryInfo.Books)
                {
                    if (simpleControl.BookInfo.FranshiseListIndex < book.FranshiseListIndex)
                    {
                        --book.FranshiseListIndex;
                    }
                }

                return CategoryInfo.Books.Remove(simpleControl.BookInfo);
            }
            else
            {
                return false;
            }
        }

        public bool SetFindedElement(string search)
        {
            throw new NotImplementedException();
        }

        public void SetVisualDefault()
        {
            throw new NotImplementedException();
        }

        public Control ToUpdateControl()
        {
            return new BookCategoryUpdateContol(this);
        }

        private void label_update_Click(object sender, EventArgs e)
        {
            MainInfo.MainForm.BooksControl.UpdateVisualizer.OpenUpdateControl(this, MainInfo.MainForm.BooksControl.MoreInfoVisualizer);
        }
    }
}
