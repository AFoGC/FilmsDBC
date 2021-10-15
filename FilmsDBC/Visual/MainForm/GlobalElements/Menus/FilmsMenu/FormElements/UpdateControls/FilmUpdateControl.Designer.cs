using FilmsDBC.Visual.Buttons;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.UpdateControls
{
    partial class FilmUpdateControl
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_realiseYear = new System.Windows.Forms.TextBox();
            this.checkBox_watched = new System.Windows.Forms.CheckBox();
            this.textBox_countOfviews = new System.Windows.Forms.TextBox();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.toolTip_description = new System.Windows.Forms.ToolTip(this.components);
            this.dateUpdateControl_watchDate = new FilmsDBC.Visual.Buttons.DateUpdateControl();
            this.comboBox_genre = new FilmsDBC.Visual.Buttons.DarkComboBox();
            this.label_comment = new FilmsDBC.Visual.Buttons.ClickButton();
            this.label_sources = new FilmsDBC.Visual.Buttons.ClickButton();
            this.comboBox_mark = new FilmsDBC.Visual.Buttons.DarkComboBox();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_id.Location = new System.Drawing.Point(0, 0);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(30, 20);
            this.textBox_id.TabIndex = 1;
            this.toolTip_description.SetToolTip(this.textBox_id, "id");
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_name.Location = new System.Drawing.Point(30, 0);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_name.TabIndex = 15;
            this.toolTip_description.SetToolTip(this.textBox_name, "name");
            // 
            // textBox_realiseYear
            // 
            this.textBox_realiseYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_realiseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_realiseYear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_realiseYear.Location = new System.Drawing.Point(310, 0);
            this.textBox_realiseYear.Name = "textBox_realiseYear";
            this.textBox_realiseYear.Size = new System.Drawing.Size(30, 20);
            this.textBox_realiseYear.TabIndex = 26;
            this.toolTip_description.SetToolTip(this.textBox_realiseYear, "realise year");
            // 
            // checkBox_watched
            // 
            this.checkBox_watched.AutoSize = true;
            this.checkBox_watched.Location = new System.Drawing.Point(360, 3);
            this.checkBox_watched.Name = "checkBox_watched";
            this.checkBox_watched.Size = new System.Drawing.Size(15, 14);
            this.checkBox_watched.TabIndex = 27;
            this.toolTip_description.SetToolTip(this.checkBox_watched, "is watched");
            this.checkBox_watched.UseVisualStyleBackColor = true;
            this.checkBox_watched.Click += new System.EventHandler(this.checkBox_watched_Click);
            // 
            // textBox_countOfviews
            // 
            this.textBox_countOfviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_countOfviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_countOfviews.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_countOfviews.Location = new System.Drawing.Point(500, 0);
            this.textBox_countOfviews.Name = "textBox_countOfviews";
            this.textBox_countOfviews.Size = new System.Drawing.Size(30, 20);
            this.textBox_countOfviews.TabIndex = 32;
            this.toolTip_description.SetToolTip(this.textBox_countOfviews, "count of views");
            // 
            // textBox_comment
            // 
            this.textBox_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_comment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_comment.Location = new System.Drawing.Point(30, 20);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(500, 20);
            this.textBox_comment.TabIndex = 43;
            // 
            // dateUpdateControl_watchDate
            // 
            this.dateUpdateControl_watchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.dateUpdateControl_watchDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateUpdateControl_watchDate.Date = new System.DateTime(((long)(0)));
            this.dateUpdateControl_watchDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateUpdateControl_watchDate.Location = new System.Drawing.Point(395, 0);
            this.dateUpdateControl_watchDate.Name = "dateUpdateControl_watchDate";
            this.dateUpdateControl_watchDate.Size = new System.Drawing.Size(60, 20);
            this.dateUpdateControl_watchDate.TabIndex = 34;
            this.toolTip_description.SetToolTip(this.dateUpdateControl_watchDate, "watch date");
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
            this.comboBox_genre.Size = new System.Drawing.Size(100, 20);
            this.comboBox_genre.TabIndex = 44;
            this.comboBox_genre.Texts = "";
            this.toolTip_description.SetToolTip(this.comboBox_genre, "genre");
            // 
            // label_comment
            // 
            this.label_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_comment.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_comment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_comment.Location = new System.Drawing.Point(670, 0);
            this.label_comment.MouseDownColor = System.Drawing.Color.Empty;
            this.label_comment.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(100, 20);
            this.label_comment.TabIndex = 42;
            this.label_comment.Text = "comment";
            this.label_comment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_comment.Click += new System.EventHandler(this.label_comment_Click);
            // 
            // label_sources
            // 
            this.label_sources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_sources.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_sources.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_sources.Location = new System.Drawing.Point(770, 0);
            this.label_sources.MouseDownColor = System.Drawing.Color.Empty;
            this.label_sources.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_sources.Name = "label_sources";
            this.label_sources.Size = new System.Drawing.Size(100, 20);
            this.label_sources.TabIndex = 33;
            this.label_sources.Text = "update source";
            this.label_sources.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_sources.Click += new System.EventHandler(this.label_sources_Click);
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
            this.comboBox_mark.Location = new System.Drawing.Point(455, 0);
            this.comboBox_mark.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_mark.MinimumSize = new System.Drawing.Size(10, 20);
            this.comboBox_mark.Name = "comboBox_mark";
            this.comboBox_mark.Size = new System.Drawing.Size(45, 20);
            this.comboBox_mark.TabIndex = 45;
            this.comboBox_mark.Texts = "";
            this.toolTip_description.SetToolTip(this.comboBox_mark, "mark");
            // 
            // FilmUpdateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.comboBox_mark);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.dateUpdateControl_watchDate);
            this.Controls.Add(this.label_sources);
            this.Controls.Add(this.textBox_countOfviews);
            this.Controls.Add(this.checkBox_watched);
            this.Controls.Add(this.textBox_realiseYear);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Name = "FilmUpdateControl";
            this.Size = new System.Drawing.Size(940, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox textBox_name;
        internal System.Windows.Forms.TextBox textBox_realiseYear;
        internal System.Windows.Forms.CheckBox checkBox_watched;
        internal System.Windows.Forms.TextBox textBox_countOfviews;
        internal System.Windows.Forms.TextBox textBox_id;
        private FilmsDBC.Visual.Buttons.ClickButton label_sources;
        internal DateUpdateControl dateUpdateControl_watchDate;
        private FilmsDBC.Visual.Buttons.ClickButton label_comment;
        internal System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.ToolTip toolTip_description;
        private DarkComboBox comboBox_genre;
        private DarkComboBox comboBox_mark;
    }
}
