using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateControls;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateInfo;
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
    public partial class BookControl : ABookElementControl
    {
        BookSimpleControl simpleControl = null;
        public BookControl(Book book)
        {
            InitializeComponent();
            this.bookInfo = book;

            clickButton_copyUrl.SetDefaultButtonBlink();
            clickButton_update.SetDefaultButtonBlink();

            RefreshData();
        }

        public BookControl(BookSimpleControl simpleControl)
        {
            InitializeComponent();
            this.bookInfo = simpleControl.bookInfo;
            this.simpleControl = simpleControl;

            RefreshData();
        }

        public override void RefreshData()
        {
            Book defBook = MainInfo.Tables.BooksTable.DefaultCell;

            this.textBox_id.Text = bookInfo.ID.ToString();
            this.textBox_name.Text = bookInfo.Name;
            this.textBox_genre.Text = Book.FormatToString(bookInfo.BookGenre, defBook.BookGenre);
            this.textBox_realiseYear.Text = Book.FormatToString(bookInfo.PublicationYear, defBook.PublicationYear);
            this.checkBox_readed.Checked = bookInfo.Readed;
            this.textBox_fullReadDate.Text = Book.FormatToString(bookInfo.FullReadDate, defBook.FullReadDate);
            this.textBox_mark.Text = Book.FormatToString(bookInfo.Mark, defBook.Mark);
            this.textBox_countOfReadings.Text = Book.FormatToString(bookInfo.CountOfReadings, defBook.CountOfReadings);
            this.RefreshSourceLabel();

            if (simpleControl != null)
            {
                simpleControl.RefreshData();
            }
        }

        public void RefreshSourceLabel()
        {
            if (bookInfo.Sources.Count == 0)
            {
                clickButton_copyUrl.Text = "no url";
            }
            else
            {
                if (bookInfo.Sources[0].name != "")
                {
                    clickButton_copyUrl.Text = "url: " + bookInfo.Sources[0].name;
                }
                else
                {
                    clickButton_copyUrl.Text = "copy url";
                }
            }
        }

        public override void SetVisualDefault()
        {
            throw new System.NotImplementedException();
        }

        internal override void setVisualFinded()
        {
            throw new System.NotImplementedException();
        }

        internal override void setVisualSelected()
        {
            throw new System.NotImplementedException();
        }

        public override Control ToUpdateControl()
        {
            return new BookUpdateControl(this);
        }

        private void clickButton_update_Click(object sender, EventArgs e)
        {
            BookUpdateFormVisualizer.OpenUpdateControl(this);
        }
    }
}
