
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu
{
    partial class BooksControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel_main = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.panel_buttonInterface = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_requestsGenres = new System.Windows.Forms.FlowLayoutPanel();
            this.button_filter = new System.Windows.Forms.Button();
            this.button_ShowPriorityFilms = new System.Windows.Forms.Button();
            this.button_AddToPriority = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_addCategory = new System.Windows.Forms.Button();
            this.button_addBook = new System.Windows.Forms.Button();
            this.button_ShowCategories = new System.Windows.Forms.Button();
            this.button_ShowBooks = new System.Windows.Forms.Button();
            this.watchedRequestControl = new FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.MenuElements.WatchedRequestControl();
            this.panel_buttonInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_main
            // 
            this.flowLayoutPanel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_main.AutoScroll = true;
            this.flowLayoutPanel_main.Location = new System.Drawing.Point(35, 122);
            this.flowLayoutPanel_main.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_main.Name = "flowLayoutPanel_main";
            this.flowLayoutPanel_main.Size = new System.Drawing.Size(960, 583);
            this.flowLayoutPanel_main.TabIndex = 1;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(195, 99);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 20);
            this.button_Search.TabIndex = 7;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(35, 99);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(154, 20);
            this.textBox_Search.TabIndex = 6;
            // 
            // panel_Info
            // 
            this.panel_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Info.Location = new System.Drawing.Point(35, 3);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(940, 90);
            this.panel_Info.TabIndex = 17;
            // 
            // panel_buttonInterface
            // 
            this.panel_buttonInterface.Controls.Add(this.flowLayoutPanel_requestsGenres);
            this.panel_buttonInterface.Controls.Add(this.button_filter);
            this.panel_buttonInterface.Controls.Add(this.button_ShowPriorityFilms);
            this.panel_buttonInterface.Controls.Add(this.button_AddToPriority);
            this.panel_buttonInterface.Controls.Add(this.button_save);
            this.panel_buttonInterface.Controls.Add(this.watchedRequestControl);
            this.panel_buttonInterface.Controls.Add(this.button_addCategory);
            this.panel_buttonInterface.Controls.Add(this.button_addBook);
            this.panel_buttonInterface.Controls.Add(this.button_ShowCategories);
            this.panel_buttonInterface.Controls.Add(this.button_ShowBooks);
            this.panel_buttonInterface.Location = new System.Drawing.Point(998, 99);
            this.panel_buttonInterface.Name = "panel_buttonInterface";
            this.panel_buttonInterface.Size = new System.Drawing.Size(260, 439);
            this.panel_buttonInterface.TabIndex = 18;
            // 
            // flowLayoutPanel_requestsGenres
            // 
            this.flowLayoutPanel_requestsGenres.Location = new System.Drawing.Point(0, 339);
            this.flowLayoutPanel_requestsGenres.Name = "flowLayoutPanel_requestsGenres";
            this.flowLayoutPanel_requestsGenres.Size = new System.Drawing.Size(260, 100);
            this.flowLayoutPanel_requestsGenres.TabIndex = 10;
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(149, 284);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(111, 23);
            this.button_filter.TabIndex = 11;
            this.button_filter.Text = "Search";
            this.button_filter.UseVisualStyleBackColor = true;
            // 
            // button_ShowPriorityFilms
            // 
            this.button_ShowPriorityFilms.Location = new System.Drawing.Point(149, 99);
            this.button_ShowPriorityFilms.Name = "button_ShowPriorityFilms";
            this.button_ShowPriorityFilms.Size = new System.Drawing.Size(111, 23);
            this.button_ShowPriorityFilms.TabIndex = 13;
            this.button_ShowPriorityFilms.Text = "Show Priority Books";
            this.button_ShowPriorityFilms.UseVisualStyleBackColor = true;
            // 
            // button_AddToPriority
            // 
            this.button_AddToPriority.Location = new System.Drawing.Point(0, 99);
            this.button_AddToPriority.Name = "button_AddToPriority";
            this.button_AddToPriority.Size = new System.Drawing.Size(111, 23);
            this.button_AddToPriority.TabIndex = 14;
            this.button_AddToPriority.Text = "Add To Priority";
            this.button_AddToPriority.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(149, 0);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(111, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save Tables";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_addCategory
            // 
            this.button_addCategory.Location = new System.Drawing.Point(0, 41);
            this.button_addCategory.Name = "button_addCategory";
            this.button_addCategory.Size = new System.Drawing.Size(111, 23);
            this.button_addCategory.TabIndex = 7;
            this.button_addCategory.Text = "Add Category";
            this.button_addCategory.UseVisualStyleBackColor = true;
            // 
            // button_addBook
            // 
            this.button_addBook.Location = new System.Drawing.Point(0, 70);
            this.button_addBook.Name = "button_addBook";
            this.button_addBook.Size = new System.Drawing.Size(111, 23);
            this.button_addBook.TabIndex = 8;
            this.button_addBook.Text = "Add Book";
            this.button_addBook.UseVisualStyleBackColor = true;
            this.button_addBook.Click += new System.EventHandler(this.button_addBook_Click);
            // 
            // button_ShowCategories
            // 
            this.button_ShowCategories.Location = new System.Drawing.Point(149, 41);
            this.button_ShowCategories.Name = "button_ShowCategories";
            this.button_ShowCategories.Size = new System.Drawing.Size(111, 23);
            this.button_ShowCategories.TabIndex = 1;
            this.button_ShowCategories.Text = "Show Categories";
            this.button_ShowCategories.UseVisualStyleBackColor = true;
            // 
            // button_ShowBooks
            // 
            this.button_ShowBooks.Location = new System.Drawing.Point(149, 70);
            this.button_ShowBooks.Name = "button_ShowBooks";
            this.button_ShowBooks.Size = new System.Drawing.Size(111, 23);
            this.button_ShowBooks.TabIndex = 2;
            this.button_ShowBooks.Text = "Show Books";
            this.button_ShowBooks.UseVisualStyleBackColor = true;
            // 
            // watchedRequestControl
            // 
            this.watchedRequestControl.IsUnwatched = true;
            this.watchedRequestControl.IsWatched = true;
            this.watchedRequestControl.Location = new System.Drawing.Point(0, 313);
            this.watchedRequestControl.Name = "watchedRequestControl";
            this.watchedRequestControl.Size = new System.Drawing.Size(259, 20);
            this.watchedRequestControl.TabIndex = 12;
            // 
            // BooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_buttonInterface);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.flowLayoutPanel_main);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(1485, 705);
            this.panel_buttonInterface.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_main;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Panel panel_buttonInterface;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_requestsGenres;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button button_ShowPriorityFilms;
        private System.Windows.Forms.Button button_AddToPriority;
        private System.Windows.Forms.Button button_save;
        private ACommonElements.MenuElements.WatchedRequestControl watchedRequestControl;
        private System.Windows.Forms.Button button_addCategory;
        private System.Windows.Forms.Button button_addBook;
        private System.Windows.Forms.Button button_ShowCategories;
        private System.Windows.Forms.Button button_ShowBooks;
    }
}
