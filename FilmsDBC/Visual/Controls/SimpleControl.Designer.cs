
namespace FilmsDBC.Visual.Controls
{
    partial class SimpleControl
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
            this.label_info = new System.Windows.Forms.Label();
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
            // textBox_genre
            // 
            this.textBox_genre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_genre.Location = new System.Drawing.Point(210, 0);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(100, 20);
            this.textBox_genre.TabIndex = 26;
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
            // label_info
            // 
            this.label_info.Location = new System.Drawing.Point(395, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(80, 20);
            this.label_info.TabIndex = 40;
            this.label_info.Text = "More Info";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.checkBox_watched);
            this.Controls.Add(this.textBox_realiseYear);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SimpleControl";
            this.Size = new System.Drawing.Size(475, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        internal System.Windows.Forms.TextBox textBox_name;
        internal System.Windows.Forms.TextBox textBox_genre;
        internal System.Windows.Forms.TextBox textBox_realiseYear;
        internal System.Windows.Forms.CheckBox checkBox_watched;
        private System.Windows.Forms.Label label_info;
    }
}
