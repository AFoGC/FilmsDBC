
namespace FilmsDBC.Visual.Forms
{
    partial class WatchedRequestControl
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
            this.label_requestWatched = new System.Windows.Forms.Label();
            this.label_requestUnwatched = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_requestWatched
            // 
            this.label_requestWatched.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_requestWatched.Location = new System.Drawing.Point(0, 0);
            this.label_requestWatched.Name = "label_requestWatched";
            this.label_requestWatched.Size = new System.Drawing.Size(129, 20);
            this.label_requestWatched.TabIndex = 11;
            this.label_requestWatched.Text = "Watched";
            this.label_requestWatched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_requestWatched.Click += new System.EventHandler(this.label_requestWatched_Click);
            // 
            // label_requestUnwatched
            // 
            this.label_requestUnwatched.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_requestUnwatched.Location = new System.Drawing.Point(130, 0);
            this.label_requestUnwatched.Name = "label_requestUnwatched";
            this.label_requestUnwatched.Size = new System.Drawing.Size(129, 20);
            this.label_requestUnwatched.TabIndex = 12;
            this.label_requestUnwatched.Text = "Unwatched";
            this.label_requestUnwatched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_requestUnwatched.Click += new System.EventHandler(this.label_requestUnwatched_Click);
            // 
            // WatchedRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_requestUnwatched);
            this.Controls.Add(this.label_requestWatched);
            this.Name = "WatchedRequestControl";
            this.Size = new System.Drawing.Size(259, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_requestWatched;
        private System.Windows.Forms.Label label_requestUnwatched;
    }
}
