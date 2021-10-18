﻿
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.FilmsMenu.FormElements.FilmsControls
{
    partial class SerieControl
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
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_realiseYear = new System.Windows.Forms.TextBox();
            this.checkBox_watched = new System.Windows.Forms.CheckBox();
            this.textBox_startWatchDate = new System.Windows.Forms.TextBox();
            this.textBox_countOfWatchedSeries = new System.Windows.Forms.TextBox();
            this.textBox_watchDate = new System.Windows.Forms.TextBox();
            this.textBox_totalSeries = new System.Windows.Forms.TextBox();
            this.textBox_mark = new System.Windows.Forms.TextBox();
            this.textBox_countOfviews = new System.Windows.Forms.TextBox();
            this.label_update = new FilmsDBC.Visual.Buttons.ClickButton();
            this.label_copyUrl = new FilmsDBC.Visual.Buttons.ClickButton();
            this.label_comment = new FilmsDBC.Visual.Buttons.ClickButton();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.toolTip_description = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
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
            this.textBox_id.TabIndex = 1;
            this.toolTip_description.SetToolTip(this.textBox_id, "id");
            this.textBox_id.Click += new System.EventHandler(this.textBox_id_Click);
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
            this.textBox_name.TabIndex = 15;
            this.toolTip_description.SetToolTip(this.textBox_name, "name");
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
            this.textBox_genre.TabIndex = 25;
            this.toolTip_description.SetToolTip(this.textBox_genre, "genre");
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
            this.textBox_realiseYear.TabIndex = 26;
            this.toolTip_description.SetToolTip(this.textBox_realiseYear, "realise year");
            // 
            // checkBox_watched
            // 
            this.checkBox_watched.AutoSize = true;
            this.checkBox_watched.Location = new System.Drawing.Point(360, 1);
            this.checkBox_watched.Name = "checkBox_watched";
            this.checkBox_watched.Size = new System.Drawing.Size(15, 14);
            this.checkBox_watched.TabIndex = 27;
            this.toolTip_description.SetToolTip(this.checkBox_watched, "is watched");
            this.checkBox_watched.UseVisualStyleBackColor = true;
            this.checkBox_watched.Click += new System.EventHandler(this.checkBox_watched_Click);
            // 
            // textBox_startWatchDate
            // 
            this.textBox_startWatchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_startWatchDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_startWatchDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_startWatchDate.Location = new System.Drawing.Point(396, 1);
            this.textBox_startWatchDate.Name = "textBox_startWatchDate";
            this.textBox_startWatchDate.ReadOnly = true;
            this.textBox_startWatchDate.Size = new System.Drawing.Size(58, 13);
            this.textBox_startWatchDate.TabIndex = 28;
            this.toolTip_description.SetToolTip(this.textBox_startWatchDate, "start watch date");
            // 
            // textBox_countOfWatchedSeries
            // 
            this.textBox_countOfWatchedSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_countOfWatchedSeries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_countOfWatchedSeries.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_countOfWatchedSeries.Location = new System.Drawing.Point(456, 1);
            this.textBox_countOfWatchedSeries.Name = "textBox_countOfWatchedSeries";
            this.textBox_countOfWatchedSeries.ReadOnly = true;
            this.textBox_countOfWatchedSeries.Size = new System.Drawing.Size(28, 13);
            this.textBox_countOfWatchedSeries.TabIndex = 32;
            this.toolTip_description.SetToolTip(this.textBox_countOfWatchedSeries, "count of watched series");
            // 
            // textBox_watchDate
            // 
            this.textBox_watchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_watchDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_watchDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_watchDate.Location = new System.Drawing.Point(486, 1);
            this.textBox_watchDate.Name = "textBox_watchDate";
            this.textBox_watchDate.ReadOnly = true;
            this.textBox_watchDate.Size = new System.Drawing.Size(58, 13);
            this.textBox_watchDate.TabIndex = 33;
            this.toolTip_description.SetToolTip(this.textBox_watchDate, "final watch date");
            // 
            // textBox_totalSeries
            // 
            this.textBox_totalSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_totalSeries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_totalSeries.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_totalSeries.Location = new System.Drawing.Point(546, 1);
            this.textBox_totalSeries.Name = "textBox_totalSeries";
            this.textBox_totalSeries.ReadOnly = true;
            this.textBox_totalSeries.Size = new System.Drawing.Size(28, 13);
            this.textBox_totalSeries.TabIndex = 34;
            this.toolTip_description.SetToolTip(this.textBox_totalSeries, "total series");
            // 
            // textBox_mark
            // 
            this.textBox_mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_mark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mark.Location = new System.Drawing.Point(576, 1);
            this.textBox_mark.Name = "textBox_mark";
            this.textBox_mark.ReadOnly = true;
            this.textBox_mark.Size = new System.Drawing.Size(43, 13);
            this.textBox_mark.TabIndex = 35;
            this.toolTip_description.SetToolTip(this.textBox_mark, "mark");
            // 
            // textBox_countOfviews
            // 
            this.textBox_countOfviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_countOfviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_countOfviews.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_countOfviews.Location = new System.Drawing.Point(621, 1);
            this.textBox_countOfviews.Name = "textBox_countOfviews";
            this.textBox_countOfviews.ReadOnly = true;
            this.textBox_countOfviews.Size = new System.Drawing.Size(28, 13);
            this.textBox_countOfviews.TabIndex = 36;
            this.toolTip_description.SetToolTip(this.textBox_countOfviews, "count of views");
            // 
            // label_update
            // 
            this.label_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_update.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_update.Location = new System.Drawing.Point(847, 1);
            this.label_update.MouseDownColor = System.Drawing.Color.Empty;
            this.label_update.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(76, 13);
            this.label_update.TabIndex = 39;
            this.label_update.Text = "update";
            this.label_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_update.Click += new System.EventHandler(this.label_update_Click);
            // 
            // label_copyUrl
            // 
            this.label_copyUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_copyUrl.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_copyUrl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_copyUrl.Location = new System.Drawing.Point(742, 1);
            this.label_copyUrl.MouseDownColor = System.Drawing.Color.Empty;
            this.label_copyUrl.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_copyUrl.Name = "label_copyUrl";
            this.label_copyUrl.Size = new System.Drawing.Size(101, 13);
            this.label_copyUrl.TabIndex = 38;
            this.label_copyUrl.Text = "copy url";
            this.label_copyUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_copyUrl.Click += new System.EventHandler(this.label_copyUrl_Click);
            // 
            // label_comment
            // 
            this.label_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_comment.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label_comment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_comment.Location = new System.Drawing.Point(662, 1);
            this.label_comment.MouseDownColor = System.Drawing.Color.Empty;
            this.label_comment.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(76, 13);
            this.label_comment.TabIndex = 37;
            this.label_comment.Text = "comment";
            this.label_comment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_comment.Click += new System.EventHandler(this.label_comment_Click);
            // 
            // textBox_comment
            // 
            this.textBox_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox_comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_comment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_comment.Location = new System.Drawing.Point(31, 16);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.ReadOnly = true;
            this.textBox_comment.Size = new System.Drawing.Size(618, 13);
            this.textBox_comment.TabIndex = 40;
            // 
            // SerieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_update);
            this.Controls.Add(this.label_copyUrl);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.textBox_countOfviews);
            this.Controls.Add(this.textBox_mark);
            this.Controls.Add(this.textBox_totalSeries);
            this.Controls.Add(this.textBox_watchDate);
            this.Controls.Add(this.textBox_countOfWatchedSeries);
            this.Controls.Add(this.textBox_startWatchDate);
            this.Controls.Add(this.checkBox_watched);
            this.Controls.Add(this.textBox_realiseYear);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SerieControl";
            this.Size = new System.Drawing.Size(940, 15);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.TextBox textBox_name;
        internal System.Windows.Forms.TextBox textBox_genre;
        internal System.Windows.Forms.TextBox textBox_realiseYear;
        internal System.Windows.Forms.CheckBox checkBox_watched;
        internal System.Windows.Forms.TextBox textBox_startWatchDate;
        internal System.Windows.Forms.TextBox textBox_countOfWatchedSeries;
        internal System.Windows.Forms.TextBox textBox_watchDate;
        internal System.Windows.Forms.TextBox textBox_totalSeries;
        internal System.Windows.Forms.TextBox textBox_mark;
        internal System.Windows.Forms.TextBox textBox_countOfviews;
        private FilmsDBC.Visual.Buttons.ClickButton label_update;
        private FilmsDBC.Visual.Buttons.ClickButton label_copyUrl;
        private FilmsDBC.Visual.Buttons.ClickButton label_comment;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.ToolTip toolTip_description;
    }
}
