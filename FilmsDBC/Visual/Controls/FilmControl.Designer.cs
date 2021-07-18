
namespace FilmsDBC.Visual.Controls
{
    partial class FilmControl
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
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_realiseYear = new System.Windows.Forms.TextBox();
            this.checkBox_watched = new System.Windows.Forms.CheckBox();
            this.textBox_watchDate = new System.Windows.Forms.TextBox();
            this.textBox_mark = new System.Windows.Forms.TextBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.label_copyUrl = new System.Windows.Forms.Label();
            this.textBox_countOfviews = new System.Windows.Forms.TextBox();
            this.label_update = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(0, 0);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(30, 20);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.Click += new System.EventHandler(this.textBox_id_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Location = new System.Drawing.Point(30, 0);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_name.TabIndex = 14;
            // 
            // textBox_genre
            // 
            this.textBox_genre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_genre.Location = new System.Drawing.Point(210, 0);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.ReadOnly = true;
            this.textBox_genre.Size = new System.Drawing.Size(100, 20);
            this.textBox_genre.TabIndex = 24;
            // 
            // textBox_realiseYear
            // 
            this.textBox_realiseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_realiseYear.Location = new System.Drawing.Point(310, 0);
            this.textBox_realiseYear.Name = "textBox_realiseYear";
            this.textBox_realiseYear.ReadOnly = true;
            this.textBox_realiseYear.Size = new System.Drawing.Size(30, 20);
            this.textBox_realiseYear.TabIndex = 25;
            // 
            // checkBox_watched
            // 
            this.checkBox_watched.AutoSize = true;
            this.checkBox_watched.Location = new System.Drawing.Point(360, 3);
            this.checkBox_watched.Name = "checkBox_watched";
            this.checkBox_watched.Size = new System.Drawing.Size(15, 14);
            this.checkBox_watched.TabIndex = 26;
            this.checkBox_watched.UseVisualStyleBackColor = true;
            this.checkBox_watched.Click += new System.EventHandler(this.checkBox_watched_Click);
            // 
            // textBox_watchDate
            // 
            this.textBox_watchDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_watchDate.Location = new System.Drawing.Point(395, 0);
            this.textBox_watchDate.Name = "textBox_watchDate";
            this.textBox_watchDate.ReadOnly = true;
            this.textBox_watchDate.Size = new System.Drawing.Size(60, 20);
            this.textBox_watchDate.TabIndex = 27;
            // 
            // textBox_mark
            // 
            this.textBox_mark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_mark.Location = new System.Drawing.Point(455, 0);
            this.textBox_mark.Name = "textBox_mark";
            this.textBox_mark.ReadOnly = true;
            this.textBox_mark.Size = new System.Drawing.Size(45, 20);
            this.textBox_mark.TabIndex = 28;
            // 
            // label_comment
            // 
            this.label_comment.Location = new System.Drawing.Point(660, 0);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(80, 20);
            this.label_comment.TabIndex = 29;
            this.label_comment.Text = "comment";
            this.label_comment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_comment.Click += new System.EventHandler(this.label_comment_Click);
            // 
            // label_copyUrl
            // 
            this.label_copyUrl.Location = new System.Drawing.Point(750, 0);
            this.label_copyUrl.Name = "label_copyUrl";
            this.label_copyUrl.Size = new System.Drawing.Size(80, 20);
            this.label_copyUrl.TabIndex = 30;
            this.label_copyUrl.Text = "copy url";
            this.label_copyUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_copyUrl.Click += new System.EventHandler(this.label_copyUrl_Click);
            // 
            // textBox_countOfviews
            // 
            this.textBox_countOfviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_countOfviews.Location = new System.Drawing.Point(500, 0);
            this.textBox_countOfviews.Name = "textBox_countOfviews";
            this.textBox_countOfviews.ReadOnly = true;
            this.textBox_countOfviews.Size = new System.Drawing.Size(30, 20);
            this.textBox_countOfviews.TabIndex = 31;
            // 
            // label_update
            // 
            this.label_update.Location = new System.Drawing.Point(845, 0);
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(80, 20);
            this.label_update.TabIndex = 32;
            this.label_update.Text = "update";
            this.label_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_update.Click += new System.EventHandler(this.label_update_Click);
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(30, 20);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.ReadOnly = true;
            this.textBox_comment.Size = new System.Drawing.Size(500, 20);
            this.textBox_comment.TabIndex = 33;
            // 
            // FilmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_update);
            this.Controls.Add(this.textBox_countOfviews);
            this.Controls.Add(this.label_copyUrl);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.textBox_mark);
            this.Controls.Add(this.textBox_watchDate);
            this.Controls.Add(this.checkBox_watched);
            this.Controls.Add(this.textBox_realiseYear);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FilmControl";
            this.Size = new System.Drawing.Size(940, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.TextBox textBox_name;
        internal System.Windows.Forms.TextBox textBox_genre;
        internal System.Windows.Forms.TextBox textBox_realiseYear;
        internal System.Windows.Forms.CheckBox checkBox_watched;
        internal System.Windows.Forms.TextBox textBox_watchDate;
        internal System.Windows.Forms.TextBox textBox_mark;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.Label label_copyUrl;
        internal System.Windows.Forms.TextBox textBox_countOfviews;
        private System.Windows.Forms.Label label_update;
        private System.Windows.Forms.TextBox textBox_comment;
    }
}
