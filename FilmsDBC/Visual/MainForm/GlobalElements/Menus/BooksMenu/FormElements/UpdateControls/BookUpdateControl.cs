using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.BooksControls;
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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateControls
{
    public partial class BookUpdateControl : UserControl, IUpdateControl
    {
        private BookControl bookControl = null;
        private Book book = null;
        public BookUpdateControl(BookControl bookControl)
        {
            InitializeComponent();
            this.bookControl = bookControl;
            this.book = bookControl.BookInfo;

            comboBox_genre.Items.AddRange(MainInfo.Tables.BookGenresTable.ToArray());
            comboBox_mark.Items.AddRange(FilmMethods.GetAllMarks().ToArray());

            label_comment.SetDefaultButtonBlink();
            label_sources.SetDefaultButtonBlink();

            refresh();
        }

        private void refresh()
        {
            Book defBook = MainInfo.Tables.BooksTable.DefaultCell;

            textBox_id.Text = book.ID.ToString();
            textBox_name.Text = book.Name;
            comboBox_genre.SelectedItem = book.BookGenre;
            textBox_realiseYear.Text = Book.FormatToString(book.PublicationYear, defBook.PublicationYear);
            checkBox_readed.Checked = book.Readed;
            textBox_author.Text = book.Author;
            dateUpdateControl_fullReadDate.Date = book.FullReadDate;
            comboBox_mark.Text = VisualHelper.markToText(Book.FormatToString(book.Mark, defBook.Mark));
            textBox_countOfReadings.Text = Book.FormatToString(book.CountOfReadings, defBook.CountOfReadings);
            textBox_bookmark.Text = book.Bookmark;
        }

        public void UpdateElement()
        {
            book.Name = textBox_name.Text;
            book.BookGenre = (BookGenre)comboBox_genre.SelectedItem;
            book.PublicationYear = VisualHelper.TextToInt32(textBox_realiseYear.Text);
            book.Readed = this.checkBox_readed.Checked;
            book.Author = textBox_author.Text;
            book.FullReadDate = dateUpdateControl_fullReadDate.Date;
            book.Mark = VisualHelper.TextToMark(this.comboBox_mark.Text);
            book.CountOfReadings = VisualHelper.TextToInt32(textBox_countOfReadings.Text);
            book.Bookmark = textBox_bookmark.Text;

            bookControl.RefreshData();
        }

        private void label_sources_Click(object sender, EventArgs e)
        {
            MainInfo.MainForm.BooksControl.UpdateVisualizer.SourcesVisualizer.OpenSourceControl(this.book.Sources);
        }
    }
}
