
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.BooksControls
{
    partial class BookControl
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
            this.checkBox_readed = new System.Windows.Forms.CheckBox();
            this.textBox_realiseYear = new System.Windows.Forms.TextBox();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_fullReadDate = new System.Windows.Forms.TextBox();
            this.textBox_mark = new System.Windows.Forms.TextBox();
            this.textBox_countOfReadings = new System.Windows.Forms.TextBox();
            this.clickButton_copyUrl = new FilmsDBC.Visual.Buttons.ClickButton();
            this.clickButton_update = new FilmsDBC.Visual.Buttons.ClickButton();
            this.SuspendLayout();
            // 
            // checkBox_readed
            // 
            this.checkBox_readed.AutoSize = true;
            this.checkBox_readed.Location = new System.Drawing.Point(360, 1);
            this.checkBox_readed.Name = "checkBox_readed";
            this.checkBox_readed.Size = new System.Drawing.Size(15, 14);
            this.checkBox_readed.TabIndex = 33;
            this.toolTip_description.SetToolTip(this.checkBox_readed, "is watched");
            this.checkBox_readed.UseVisualStyleBackColor = true;
            // 
            // textBox_realiseYear
            // 
            this.textBox_realiseYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_realiseYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_realiseYear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_realiseYear.Location = new System.Drawing.Point(311, 1);
            this.textBox_realiseYear.Name = "textBox_realiseYear";
            this.textBox_realiseYear.ReadOnly = true;
            this.textBox_realiseYear.Size = new System.Drawing.Size(28, 13);
            this.textBox_realiseYear.TabIndex = 32;
            this.toolTip_description.SetToolTip(this.textBox_realiseYear, "realise year");
            // 
            // textBox_genre
            // 
            this.textBox_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_genre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_genre.Location = new System.Drawing.Point(211, 1);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.ReadOnly = true;
            this.textBox_genre.Size = new System.Drawing.Size(98, 13);
            this.textBox_genre.TabIndex = 31;
            this.toolTip_description.SetToolTip(this.textBox_genre, "genre");
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_name.Location = new System.Drawing.Point(31, 1);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(178, 13);
            this.textBox_name.TabIndex = 30;
            this.toolTip_description.SetToolTip(this.textBox_name, "name");
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_id.Location = new System.Drawing.Point(2, 1);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(27, 13);
            this.textBox_id.TabIndex = 29;
            this.toolTip_description.SetToolTip(this.textBox_id, "id");
            // 
            // textBox_author
            // 
            this.textBox_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_author.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_author.Location = new System.Drawing.Point(396, 1);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.ReadOnly = true;
            this.textBox_author.Size = new System.Drawing.Size(98, 13);
            this.textBox_author.TabIndex = 34;
            this.toolTip_description.SetToolTip(this.textBox_author, "author");
            // 
            // textBox_fullReadDate
            // 
            this.textBox_fullReadDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_fullReadDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fullReadDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_fullReadDate.Location = new System.Drawing.Point(496, 1);
            this.textBox_fullReadDate.Name = "textBox_fullReadDate";
            this.textBox_fullReadDate.ReadOnly = true;
            this.textBox_fullReadDate.Size = new System.Drawing.Size(58, 13);
            this.textBox_fullReadDate.TabIndex = 35;
            this.toolTip_description.SetToolTip(this.textBox_fullReadDate, "last read date");
            // 
            // textBox_mark
            // 
            this.textBox_mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_mark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mark.Location = new System.Drawing.Point(556, 1);
            this.textBox_mark.Name = "textBox_mark";
            this.textBox_mark.ReadOnly = true;
            this.textBox_mark.Size = new System.Drawing.Size(43, 13);
            this.textBox_mark.TabIndex = 36;
            this.toolTip_description.SetToolTip(this.textBox_mark, "mark");
            // 
            // textBox_countOfReadings
            // 
            this.textBox_countOfReadings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_countOfReadings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_countOfReadings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_countOfReadings.Location = new System.Drawing.Point(601, 1);
            this.textBox_countOfReadings.Name = "textBox_countOfReadings";
            this.textBox_countOfReadings.ReadOnly = true;
            this.textBox_countOfReadings.Size = new System.Drawing.Size(28, 13);
            this.textBox_countOfReadings.TabIndex = 37;
            this.toolTip_description.SetToolTip(this.textBox_countOfReadings, "count of readings");
            // 
            // clickButton_copyUrl
            // 
            this.clickButton_copyUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clickButton_copyUrl.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clickButton_copyUrl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clickButton_copyUrl.Location = new System.Drawing.Point(650, 1);
            this.clickButton_copyUrl.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_copyUrl.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_copyUrl.Name = "clickButton_copyUrl";
            this.clickButton_copyUrl.Size = new System.Drawing.Size(105, 13);
            this.clickButton_copyUrl.TabIndex = 38;
            this.clickButton_copyUrl.Text = "copy url";
            this.clickButton_copyUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_description.SetToolTip(this.clickButton_copyUrl, "copy url");
            this.clickButton_copyUrl.Click += new System.EventHandler(this.clickButton_copyUrl_Click);
            // 
            // clickButton_update
            // 
            this.clickButton_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clickButton_update.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clickButton_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clickButton_update.Location = new System.Drawing.Point(761, 1);
            this.clickButton_update.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_update.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_update.Name = "clickButton_update";
            this.clickButton_update.Size = new System.Drawing.Size(105, 13);
            this.clickButton_update.TabIndex = 39;
            this.clickButton_update.Text = "update";
            this.clickButton_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_description.SetToolTip(this.clickButton_update, "open update menu");
            this.clickButton_update.Click += new System.EventHandler(this.clickButton_update_Click);
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.clickButton_update);
            this.Controls.Add(this.textBox_countOfReadings);
            this.Controls.Add(this.textBox_mark);
            this.Controls.Add(this.textBox_fullReadDate);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.checkBox_readed);
            this.Controls.Add(this.textBox_realiseYear);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.clickButton_copyUrl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BookControl";
            this.Size = new System.Drawing.Size(940, 15);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip_description;
        internal System.Windows.Forms.CheckBox checkBox_readed;
        internal System.Windows.Forms.TextBox textBox_realiseYear;
        internal System.Windows.Forms.TextBox textBox_genre;
        internal System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.TextBox textBox_fullReadDate;
        private System.Windows.Forms.TextBox textBox_mark;
        private System.Windows.Forms.TextBox textBox_countOfReadings;
        private FilmsDBC.Visual.Buttons.ClickButton clickButton_copyUrl;
        private Buttons.ClickButton clickButton_update;
    }
}
