
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.UpdateControls
{
    partial class BookUpdateControl
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
            this.components = new System.ComponentModel.Container();
            this.toolTip_description = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_realiseYear = new System.Windows.Forms.TextBox();
            this.checkBox_readed = new System.Windows.Forms.CheckBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.dateUpdateControl_fullReadDate = new FilmsDBC.Visual.Buttons.DateUpdateControl();
            this.textBox_countOfReadings = new System.Windows.Forms.TextBox();
            this.comboBox_genre = new FilmsDBC.Visual.Buttons.DarkComboBox();
            this.comboBox_mark = new FilmsDBC.Visual.Buttons.DarkComboBox();
            this.label_comment = new FilmsDBC.Visual.Buttons.ClickButton();
            this.label_sources = new FilmsDBC.Visual.Buttons.ClickButton();
            this.textBox_bookmark = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_name.Location = new System.Drawing.Point(30, 0);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_name.TabIndex = 32;
            this.toolTip_description.SetToolTip(this.textBox_name, "name");
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_id.Location = new System.Drawing.Point(0, 0);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(30, 20);
            this.textBox_id.TabIndex = 31;
            this.toolTip_description.SetToolTip(this.textBox_id, "id");
            // 
            // textBox_realiseYear
            // 
            this.textBox_realiseYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_realiseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_realiseYear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_realiseYear.Location = new System.Drawing.Point(310, 0);
            this.textBox_realiseYear.Name = "textBox_realiseYear";
            this.textBox_realiseYear.Size = new System.Drawing.Size(30, 20);
            this.textBox_realiseYear.TabIndex = 34;
            this.toolTip_description.SetToolTip(this.textBox_realiseYear, "realise year");
            // 
            // checkBox_readed
            // 
            this.checkBox_readed.AutoSize = true;
            this.checkBox_readed.Location = new System.Drawing.Point(360, 3);
            this.checkBox_readed.Name = "checkBox_readed";
            this.checkBox_readed.Size = new System.Drawing.Size(15, 14);
            this.checkBox_readed.TabIndex = 35;
            this.toolTip_description.SetToolTip(this.checkBox_readed, "is readed");
            this.checkBox_readed.UseVisualStyleBackColor = true;
            // 
            // textBox_author
            // 
            this.textBox_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_author.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_author.Location = new System.Drawing.Point(395, 0);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(100, 20);
            this.textBox_author.TabIndex = 36;
            this.toolTip_description.SetToolTip(this.textBox_author, "author");
            // 
            // dateUpdateControl_fullReadDate
            // 
            this.dateUpdateControl_fullReadDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.dateUpdateControl_fullReadDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateUpdateControl_fullReadDate.Date = new System.DateTime(((long)(0)));
            this.dateUpdateControl_fullReadDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateUpdateControl_fullReadDate.Location = new System.Drawing.Point(596, 0);
            this.dateUpdateControl_fullReadDate.Name = "dateUpdateControl_fullReadDate";
            this.dateUpdateControl_fullReadDate.Size = new System.Drawing.Size(60, 20);
            this.dateUpdateControl_fullReadDate.TabIndex = 37;
            this.toolTip_description.SetToolTip(this.dateUpdateControl_fullReadDate, "full read date");
            // 
            // textBox_countOfReadings
            // 
            this.textBox_countOfReadings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_countOfReadings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_countOfReadings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_countOfReadings.Location = new System.Drawing.Point(701, 0);
            this.textBox_countOfReadings.Name = "textBox_countOfReadings";
            this.textBox_countOfReadings.Size = new System.Drawing.Size(30, 20);
            this.textBox_countOfReadings.TabIndex = 39;
            this.toolTip_description.SetToolTip(this.textBox_countOfReadings, "count of readings");
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.comboBox_genre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.comboBox_genre.BorderSize = 1;
            this.comboBox_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_genre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_genre.IconColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_genre.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.comboBox_genre.ListTextColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_genre.Location = new System.Drawing.Point(210, 0);
            this.comboBox_genre.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_genre.MinimumSize = new System.Drawing.Size(100, 20);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Padding = new System.Windows.Forms.Padding(1);
            this.comboBox_genre.Size = new System.Drawing.Size(100, 20);
            this.comboBox_genre.TabIndex = 45;
            this.comboBox_genre.Texts = "";
            this.toolTip_description.SetToolTip(this.comboBox_genre, "genre");
            // 
            // comboBox_mark
            // 
            this.comboBox_mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.comboBox_mark.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.comboBox_mark.BorderSize = 1;
            this.comboBox_mark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_mark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_mark.IconColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_mark.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.comboBox_mark.ListTextColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_mark.Location = new System.Drawing.Point(656, 0);
            this.comboBox_mark.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_mark.MinimumSize = new System.Drawing.Size(10, 20);
            this.comboBox_mark.Name = "comboBox_mark";
            this.comboBox_mark.Padding = new System.Windows.Forms.Padding(1);
            this.comboBox_mark.Size = new System.Drawing.Size(45, 20);
            this.comboBox_mark.TabIndex = 46;
            this.comboBox_mark.Texts = "";
            this.toolTip_description.SetToolTip(this.comboBox_mark, "mark");
            // 
            // label_comment
            // 
            this.label_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_comment.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_comment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_comment.Location = new System.Drawing.Point(737, 0);
            this.label_comment.MouseDownColor = System.Drawing.Color.Empty;
            this.label_comment.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(100, 20);
            this.label_comment.TabIndex = 44;
            this.label_comment.Text = "comment";
            this.label_comment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_sources
            // 
            this.label_sources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_sources.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_sources.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_sources.Location = new System.Drawing.Point(837, 0);
            this.label_sources.MouseDownColor = System.Drawing.Color.Empty;
            this.label_sources.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_sources.Name = "label_sources";
            this.label_sources.Size = new System.Drawing.Size(100, 20);
            this.label_sources.TabIndex = 43;
            this.label_sources.Text = "update source";
            this.label_sources.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_sources.Click += new System.EventHandler(this.label_sources_Click);
            // 
            // textBox_bookmark
            // 
            this.textBox_bookmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_bookmark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_bookmark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_bookmark.Location = new System.Drawing.Point(495, 0);
            this.textBox_bookmark.Name = "textBox_bookmark";
            this.textBox_bookmark.Size = new System.Drawing.Size(101, 20);
            this.textBox_bookmark.TabIndex = 47;
            this.toolTip_description.SetToolTip(this.textBox_bookmark, "bookmark");
            // 
            // BookUpdateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.textBox_bookmark);
            this.Controls.Add(this.comboBox_mark);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.label_sources);
            this.Controls.Add(this.textBox_countOfReadings);
            this.Controls.Add(this.dateUpdateControl_fullReadDate);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.checkBox_readed);
            this.Controls.Add(this.textBox_realiseYear);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BookUpdateControl";
            this.Size = new System.Drawing.Size(940, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip_description;
        internal System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.TextBox textBox_realiseYear;
        internal System.Windows.Forms.CheckBox checkBox_readed;
        internal System.Windows.Forms.TextBox textBox_author;
        internal Buttons.DateUpdateControl dateUpdateControl_fullReadDate;
        private System.Windows.Forms.TextBox textBox_countOfReadings;
        private Buttons.ClickButton label_comment;
        private Buttons.ClickButton label_sources;
        private Buttons.DarkComboBox comboBox_genre;
        private Buttons.DarkComboBox comboBox_mark;
        private System.Windows.Forms.TextBox textBox_bookmark;
    }
}
