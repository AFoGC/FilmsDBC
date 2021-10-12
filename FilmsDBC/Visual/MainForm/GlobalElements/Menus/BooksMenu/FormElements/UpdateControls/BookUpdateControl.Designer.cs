
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
            this.comboBox_mark = new System.Windows.Forms.ComboBox();
            this.textBox_countOfReadings = new System.Windows.Forms.TextBox();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.label_comment = new FilmsDBC.Visual.Buttons.ClickButton();
            this.label_sources = new FilmsDBC.Visual.Buttons.ClickButton();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Location = new System.Drawing.Point(30, 0);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_name.TabIndex = 32;
            this.toolTip_description.SetToolTip(this.textBox_name, "name");
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(0, 0);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(30, 20);
            this.textBox_id.TabIndex = 31;
            this.toolTip_description.SetToolTip(this.textBox_id, "id");
            // 
            // textBox_realiseYear
            // 
            this.textBox_realiseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.textBox_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_author.Location = new System.Drawing.Point(395, 0);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(100, 20);
            this.textBox_author.TabIndex = 36;
            this.toolTip_description.SetToolTip(this.textBox_author, "author");
            // 
            // dateUpdateControl_fullReadDate
            // 
            this.dateUpdateControl_fullReadDate.BackColor = System.Drawing.SystemColors.Window;
            this.dateUpdateControl_fullReadDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateUpdateControl_fullReadDate.Date = new System.DateTime(((long)(0)));
            this.dateUpdateControl_fullReadDate.Location = new System.Drawing.Point(495, 0);
            this.dateUpdateControl_fullReadDate.Name = "dateUpdateControl_fullReadDate";
            this.dateUpdateControl_fullReadDate.Size = new System.Drawing.Size(60, 20);
            this.dateUpdateControl_fullReadDate.TabIndex = 37;
            this.toolTip_description.SetToolTip(this.dateUpdateControl_fullReadDate, "full read date");
            // 
            // comboBox_mark
            // 
            this.comboBox_mark.FormattingEnabled = true;
            this.comboBox_mark.Location = new System.Drawing.Point(555, 0);
            this.comboBox_mark.Name = "comboBox_mark";
            this.comboBox_mark.Size = new System.Drawing.Size(45, 21);
            this.comboBox_mark.TabIndex = 38;
            this.toolTip_description.SetToolTip(this.comboBox_mark, "mark");
            // 
            // textBox_countOfReadings
            // 
            this.textBox_countOfReadings.Location = new System.Drawing.Point(600, 0);
            this.textBox_countOfReadings.Name = "textBox_countOfReadings";
            this.textBox_countOfReadings.Size = new System.Drawing.Size(30, 20);
            this.textBox_countOfReadings.TabIndex = 39;
            this.toolTip_description.SetToolTip(this.textBox_countOfReadings, "count of readings");
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(210, 0);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(100, 21);
            this.comboBox_genre.TabIndex = 33;
            this.toolTip_description.SetToolTip(this.comboBox_genre, "genre");
            // 
            // label_comment
            // 
            this.label_comment.BackColor = System.Drawing.SystemColors.Control;
            this.label_comment.DefaultColor = System.Drawing.SystemColors.Control;
            this.label_comment.Location = new System.Drawing.Point(670, 0);
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
            this.label_sources.BackColor = System.Drawing.SystemColors.Control;
            this.label_sources.DefaultColor = System.Drawing.SystemColors.Control;
            this.label_sources.Location = new System.Drawing.Point(770, 0);
            this.label_sources.MouseDownColor = System.Drawing.Color.Empty;
            this.label_sources.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_sources.Name = "label_sources";
            this.label_sources.Size = new System.Drawing.Size(100, 20);
            this.label_sources.TabIndex = 43;
            this.label_sources.Text = "update source";
            this.label_sources.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_sources.Click += new System.EventHandler(this.label_sources_Click);
            // 
            // BookUpdateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.label_sources);
            this.Controls.Add(this.textBox_countOfReadings);
            this.Controls.Add(this.comboBox_mark);
            this.Controls.Add(this.dateUpdateControl_fullReadDate);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.checkBox_readed);
            this.Controls.Add(this.textBox_realiseYear);
            this.Controls.Add(this.comboBox_genre);
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
        private System.Windows.Forms.ComboBox comboBox_genre;
        internal System.Windows.Forms.TextBox textBox_realiseYear;
        internal System.Windows.Forms.CheckBox checkBox_readed;
        internal System.Windows.Forms.TextBox textBox_author;
        internal Buttons.DateUpdateControl dateUpdateControl_fullReadDate;
        internal System.Windows.Forms.ComboBox comboBox_mark;
        private System.Windows.Forms.TextBox textBox_countOfReadings;
        private Buttons.ClickButton label_comment;
        private Buttons.ClickButton label_sources;
    }
}
