using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
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
    public partial class BookSimpleControl : ABookElementControl, ISimpleControl
    {
        public BookSimpleControl(Book book)
        {
            InitializeComponent();
            this.bookInfo = book;

            clickButton_info.SetDefaultButtonBlink();

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

        public Control ToMoreInfo()
        {
            return new BookControl(this);
        }

        public override Control ToUpdateControl()
        {
            //return new BookUpdateControl(new BookControl(this));
            throw new NotImplementedException();
        }

        private void clickButton_info_Click(object sender, EventArgs e)
        {
            MainInfo.MainForm.BooksControl.MoreInfoVisualizer.OpenMoreInfoForm(this, MainInfo.MainForm.BooksControl.UpdateVisualizer);
        }

        private void checkBox_readed_Click(object sender, EventArgs e)
        {
            checkBox_readed.Checked = !checkBox_readed.Checked;
        }
    }
}
