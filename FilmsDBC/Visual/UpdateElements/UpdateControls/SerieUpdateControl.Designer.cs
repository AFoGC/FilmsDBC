﻿
namespace FilmsDBC.Visual.UpdateElements.UpdateControls
{
    partial class SerieUpdateControl
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.textBox_realiseYear = new System.Windows.Forms.TextBox();
            this.checkBox_watched = new System.Windows.Forms.CheckBox();
            this.textBox_startWatchDate = new System.Windows.Forms.TextBox();
            this.textBox_countOfWatchedSeries = new System.Windows.Forms.TextBox();
            this.textBox_watchDate = new System.Windows.Forms.TextBox();
            this.textBox_totalSeries = new System.Windows.Forms.TextBox();
            this.comboBox_mark = new System.Windows.Forms.ComboBox();
            this.textBox_countOfviews = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(0, 0);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(30, 20);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Location = new System.Drawing.Point(30, 0);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_name.TabIndex = 16;
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(210, 0);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(100, 21);
            this.comboBox_genre.TabIndex = 17;
            // 
            // textBox_realiseYear
            // 
            this.textBox_realiseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_realiseYear.Location = new System.Drawing.Point(310, 0);
            this.textBox_realiseYear.Name = "textBox_realiseYear";
            this.textBox_realiseYear.Size = new System.Drawing.Size(30, 20);
            this.textBox_realiseYear.TabIndex = 27;
            // 
            // checkBox_watched
            // 
            this.checkBox_watched.AutoSize = true;
            this.checkBox_watched.Location = new System.Drawing.Point(360, 3);
            this.checkBox_watched.Name = "checkBox_watched";
            this.checkBox_watched.Size = new System.Drawing.Size(15, 14);
            this.checkBox_watched.TabIndex = 28;
            this.checkBox_watched.UseVisualStyleBackColor = true;
            // 
            // textBox_startWatchDate
            // 
            this.textBox_startWatchDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_startWatchDate.Location = new System.Drawing.Point(395, 0);
            this.textBox_startWatchDate.Name = "textBox_startWatchDate";
            this.textBox_startWatchDate.Size = new System.Drawing.Size(60, 20);
            this.textBox_startWatchDate.TabIndex = 29;
            // 
            // textBox_countOfWatchedSeries
            // 
            this.textBox_countOfWatchedSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_countOfWatchedSeries.Location = new System.Drawing.Point(455, 0);
            this.textBox_countOfWatchedSeries.Name = "textBox_countOfWatchedSeries";
            this.textBox_countOfWatchedSeries.Size = new System.Drawing.Size(30, 20);
            this.textBox_countOfWatchedSeries.TabIndex = 33;
            // 
            // textBox_watchDate
            // 
            this.textBox_watchDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_watchDate.Location = new System.Drawing.Point(485, 0);
            this.textBox_watchDate.Name = "textBox_watchDate";
            this.textBox_watchDate.Size = new System.Drawing.Size(60, 20);
            this.textBox_watchDate.TabIndex = 34;
            // 
            // textBox_totalSeries
            // 
            this.textBox_totalSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_totalSeries.Location = new System.Drawing.Point(545, 0);
            this.textBox_totalSeries.Name = "textBox_totalSeries";
            this.textBox_totalSeries.Size = new System.Drawing.Size(30, 20);
            this.textBox_totalSeries.TabIndex = 35;
            // 
            // comboBox_mark
            // 
            this.comboBox_mark.FormattingEnabled = true;
            this.comboBox_mark.Location = new System.Drawing.Point(575, 0);
            this.comboBox_mark.Name = "comboBox_mark";
            this.comboBox_mark.Size = new System.Drawing.Size(45, 21);
            this.comboBox_mark.TabIndex = 36;
            // 
            // textBox_countOfviews
            // 
            this.textBox_countOfviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_countOfviews.Location = new System.Drawing.Point(620, 0);
            this.textBox_countOfviews.Name = "textBox_countOfviews";
            this.textBox_countOfviews.Size = new System.Drawing.Size(30, 20);
            this.textBox_countOfviews.TabIndex = 37;
            // 
            // SerieUpdateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_countOfviews);
            this.Controls.Add(this.comboBox_mark);
            this.Controls.Add(this.textBox_totalSeries);
            this.Controls.Add(this.textBox_watchDate);
            this.Controls.Add(this.textBox_countOfWatchedSeries);
            this.Controls.Add(this.textBox_startWatchDate);
            this.Controls.Add(this.checkBox_watched);
            this.Controls.Add(this.textBox_realiseYear);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Name = "SerieUpdateControl";
            this.Size = new System.Drawing.Size(940, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.TextBox textBox_name;
        internal System.Windows.Forms.TextBox textBox_realiseYear;
        internal System.Windows.Forms.CheckBox checkBox_watched;
        internal System.Windows.Forms.TextBox textBox_startWatchDate;
        internal System.Windows.Forms.TextBox textBox_countOfWatchedSeries;
        internal System.Windows.Forms.TextBox textBox_watchDate;
        internal System.Windows.Forms.TextBox textBox_totalSeries;
        internal System.Windows.Forms.TextBox textBox_countOfviews;
        internal System.Windows.Forms.ComboBox comboBox_genre;
        internal System.Windows.Forms.ComboBox comboBox_mark;
    }
}
