
namespace FilmsDBC.Visual.Forms.GlobalControls
{
    partial class MainControl
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
            this.button_ShowCategories = new System.Windows.Forms.Button();
            this.button_ShowFilms = new System.Windows.Forms.Button();
            this.button_ShowSeries = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_addCategory = new System.Windows.Forms.Button();
            this.button_addFilm = new System.Windows.Forms.Button();
            this.flowLayoutPanel_requestsGenres = new System.Windows.Forms.FlowLayoutPanel();
            this.button_filter = new System.Windows.Forms.Button();
            this.watchedRequestControl = new FilmsDBC.Visual.Forms.WatchedRequestControl();
            this.clickButton = new FilmsDBC.Visual.Buttons.ClickButton();
            this.pressButton = new FilmsDBC.Visual.Buttons.PressButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_main
            // 
            this.flowLayoutPanel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_main.AutoScroll = true;
            this.flowLayoutPanel_main.Location = new System.Drawing.Point(235, 78);
            this.flowLayoutPanel_main.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_main.Name = "flowLayoutPanel_main";
            this.flowLayoutPanel_main.Size = new System.Drawing.Size(960, 527);
            this.flowLayoutPanel_main.TabIndex = 0;
            // 
            // button_ShowCategories
            // 
            this.button_ShowCategories.Location = new System.Drawing.Point(1346, 96);
            this.button_ShowCategories.Name = "button_ShowCategories";
            this.button_ShowCategories.Size = new System.Drawing.Size(111, 23);
            this.button_ShowCategories.TabIndex = 1;
            this.button_ShowCategories.Text = "Show Categories";
            this.button_ShowCategories.UseVisualStyleBackColor = true;
            this.button_ShowCategories.Click += new System.EventHandler(this.button_ShowCategories_Click);
            // 
            // button_ShowFilms
            // 
            this.button_ShowFilms.Location = new System.Drawing.Point(1346, 125);
            this.button_ShowFilms.Name = "button_ShowFilms";
            this.button_ShowFilms.Size = new System.Drawing.Size(111, 23);
            this.button_ShowFilms.TabIndex = 2;
            this.button_ShowFilms.Text = "Show Films";
            this.button_ShowFilms.UseVisualStyleBackColor = true;
            this.button_ShowFilms.Click += new System.EventHandler(this.button_ShowFilms_Click);
            // 
            // button_ShowSeries
            // 
            this.button_ShowSeries.Location = new System.Drawing.Point(1346, 154);
            this.button_ShowSeries.Name = "button_ShowSeries";
            this.button_ShowSeries.Size = new System.Drawing.Size(111, 23);
            this.button_ShowSeries.TabIndex = 3;
            this.button_ShowSeries.Text = "Show Series";
            this.button_ShowSeries.UseVisualStyleBackColor = true;
            this.button_ShowSeries.Click += new System.EventHandler(this.button_ShowSeries_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(235, 55);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(154, 20);
            this.textBox_Search.TabIndex = 4;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(395, 55);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 20);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(1346, 55);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(111, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save Tables";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_addCategory
            // 
            this.button_addCategory.Location = new System.Drawing.Point(1198, 96);
            this.button_addCategory.Name = "button_addCategory";
            this.button_addCategory.Size = new System.Drawing.Size(111, 23);
            this.button_addCategory.TabIndex = 7;
            this.button_addCategory.Text = "Add Category";
            this.button_addCategory.UseVisualStyleBackColor = true;
            this.button_addCategory.Click += new System.EventHandler(this.button_addCategory_Click);
            // 
            // button_addFilm
            // 
            this.button_addFilm.Location = new System.Drawing.Point(1198, 125);
            this.button_addFilm.Name = "button_addFilm";
            this.button_addFilm.Size = new System.Drawing.Size(111, 23);
            this.button_addFilm.TabIndex = 8;
            this.button_addFilm.Text = "Add Film";
            this.button_addFilm.UseVisualStyleBackColor = true;
            this.button_addFilm.Click += new System.EventHandler(this.button_addFilm_Click);
            // 
            // flowLayoutPanel_requestsGenres
            // 
            this.flowLayoutPanel_requestsGenres.Location = new System.Drawing.Point(1198, 268);
            this.flowLayoutPanel_requestsGenres.Name = "flowLayoutPanel_requestsGenres";
            this.flowLayoutPanel_requestsGenres.Size = new System.Drawing.Size(260, 100);
            this.flowLayoutPanel_requestsGenres.TabIndex = 10;
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(1346, 213);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(111, 23);
            this.button_filter.TabIndex = 11;
            this.button_filter.Text = "Search";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // watchedRequestControl
            // 
            this.watchedRequestControl.IsUnwatched = true;
            this.watchedRequestControl.IsWatched = true;
            this.watchedRequestControl.Location = new System.Drawing.Point(1198, 242);
            this.watchedRequestControl.Name = "watchedRequestControl";
            this.watchedRequestControl.Size = new System.Drawing.Size(259, 20);
            this.watchedRequestControl.TabIndex = 12;
            // 
            // clickButton
            // 
            this.clickButton.BackColor = System.Drawing.Color.Gray;
            this.clickButton.DefaultColor = System.Drawing.Color.Gray;
            this.clickButton.Location = new System.Drawing.Point(10, 10);
            this.clickButton.Margin = new System.Windows.Forms.Padding(0);
            this.clickButton.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.clickButton.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(129, 20);
            this.clickButton.TabIndex = 13;
            this.clickButton.Text = "Button";
            this.clickButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pressButton
            // 
            this.pressButton.BackColor = System.Drawing.SystemColors.Control;
            this.pressButton.ClickLocked = false;
            this.pressButton.DefaultColor = System.Drawing.SystemColors.Control;
            this.pressButton.Included = false;
            this.pressButton.Included_DefaultColor = System.Drawing.SystemColors.ControlDark;
            this.pressButton.Included_MouseDownColor = System.Drawing.Color.Empty;
            this.pressButton.Included_MouseEnterColor = System.Drawing.Color.Empty;
            this.pressButton.Location = new System.Drawing.Point(30, 30);
            this.pressButton.Margin = new System.Windows.Forms.Padding(0);
            this.pressButton.MouseDownColor = System.Drawing.Color.Empty;
            this.pressButton.MouseEnterColor = System.Drawing.Color.Empty;
            this.pressButton.Name = "pressButton";
            this.pressButton.Size = new System.Drawing.Size(129, 20);
            this.pressButton.TabIndex = 14;
            this.pressButton.Text = "Butt";
            this.pressButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pressButton.SetDefaultButtonBlink();
            this.pressButton.SetDefaultIncludedButtonBlink();
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.flowLayoutPanel_requestsGenres);
            this.Controls.Add(this.button_addFilm);
            this.Controls.Add(this.button_addCategory);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_ShowSeries);
            this.Controls.Add(this.button_ShowFilms);
            this.Controls.Add(this.button_ShowCategories);
            this.Controls.Add(this.flowLayoutPanel_main);
            this.Controls.Add(this.watchedRequestControl);
            this.Controls.Add(this.clickButton);
            this.Controls.Add(this.pressButton);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1485, 647);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_ShowCategories;
        private System.Windows.Forms.Button button_ShowFilms;
        private System.Windows.Forms.Button button_ShowSeries;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_addCategory;
        private System.Windows.Forms.Button button_addFilm;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_requestsGenres;
        private System.Windows.Forms.Button button_filter;
        private FilmsDBC.Visual.Forms.WatchedRequestControl watchedRequestControl;
        private FilmsDBC.Visual.Buttons.ClickButton clickButton;
        private FilmsDBC.Visual.Buttons.PressButton pressButton;
    }
}
