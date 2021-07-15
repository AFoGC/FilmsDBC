
namespace FilmsDBC.Visual.Forms
{
    partial class GenreRequestControl
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
            this.label_genre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_genre
            // 
            this.label_genre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_genre.Location = new System.Drawing.Point(0, 0);
            this.label_genre.Margin = new System.Windows.Forms.Padding(0);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(129, 20);
            this.label_genre.TabIndex = 0;
            this.label_genre.Text = "genre";
            this.label_genre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_genre.Click += new System.EventHandler(this.label_genre_Click);
            // 
            // GenreRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_genre);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.Name = "GenreRequestControl";
            this.Size = new System.Drawing.Size(129, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_genre;
    }
}
