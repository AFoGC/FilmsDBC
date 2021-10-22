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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateControls
{
    public partial class BookCategoryUpdateContol : UserControl, IUpdateControl
    {
        private BookCategoryControl categoryControl = null;
        private BookCategory category = null;
        public BookCategoryUpdateContol(BookCategoryControl categoryControl)
        {
            InitializeComponent();

            this.categoryControl = categoryControl;
            this.category = categoryControl.CategoryInfo;

            refresh();
        }

        private void refresh()
        {
            this.textBox_id.Text = category.ID.ToString();
            this.textBox_name.Text = category.Name;
        }

        public void UpdateElement()
        {
            category.Name = this.textBox_name.Text;
            categoryControl.RefreshData();
        }

		
		private void button_addElement_Click(object sender, EventArgs e)
		{

			if (MainInfo.MainForm.BooksControl.ControlInBuffer != null)
			{
				if (MainInfo.MainForm.BooksControl.ControlInBuffer.GetType() == typeof(BookSimpleControl))
				{
					BookSimpleControl simpleControl = (BookSimpleControl)MainInfo.MainForm.BooksControl.ControlInBuffer;
					Book book = simpleControl.BookInfo;
					if (book.FranshiseId == 0)
					{
						book.FranshiseId = category.ID;
						category.Books.Add(book);
						categoryControl.AddSimpleCotrol(book);
						MainInfo.MainForm.BooksControl.flowLayoutPanel_main.Controls.Remove(simpleControl);
						MainInfo.MainForm.BooksControl.ControlInBuffer = null;
					}
				}
			}
		}

		
		private void button_removeElement_Click(object sender, EventArgs e)
		{
			if (MainInfo.MainForm.BooksControl.ControlInBuffer != null)
			{
				if (MainInfo.MainForm.BooksControl.ControlInBuffer.GetType() == typeof(BookSimpleControl))
				{
					BookSimpleControl simpleControl = (BookSimpleControl)MainInfo.MainForm.BooksControl.ControlInBuffer;
					Book book = simpleControl.BookInfo;

					if (categoryControl.RemoveBookFromCategory(simpleControl))
					{

						//if (MainInfo.MainForm.MainControl.ControlsCondition == BooksControl.MenuCondition.Category)
						{
							int i = 0;
							foreach (UserControl userControl in MainInfo.MainForm.BooksControl.flowLayoutPanel_main.Controls)
							{
								if (userControl.GetType() == typeof(BookSimpleControl))
								{
									BookSimpleControl sControl = (BookSimpleControl)userControl;
									if (sControl.BookInfo.ID > book.ID)
									{
										MainInfo.MainForm.BooksControl.flowLayoutPanel_main.Controls.Add(simpleControl);
										MainInfo.MainForm.BooksControl.flowLayoutPanel_main.Controls.SetChildIndex(simpleControl, i);
										break;
									}
								}
								++i;
							}
						}
					}
				}
			}
		}
		
		
	}
}
