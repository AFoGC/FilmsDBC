
namespace FilmsDBC.Visual.UpdateElements.UpdateControls
{
    partial class DateUpdateControl
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
            this.textBox_day = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_month = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_day
            // 
            this.textBox_day.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_day.Location = new System.Drawing.Point(0, 3);
            this.textBox_day.Name = "textBox_day";
            this.textBox_day.Size = new System.Drawing.Size(15, 13);
            this.textBox_day.TabIndex = 0;
            this.textBox_day.Click += new System.EventHandler(this.textBox_date_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_month
            // 
            this.textBox_month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_month.Location = new System.Drawing.Point(16, 3);
            this.textBox_month.Name = "textBox_month";
            this.textBox_month.Size = new System.Drawing.Size(13, 13);
            this.textBox_month.TabIndex = 2;
            this.textBox_month.Click += new System.EventHandler(this.textBox_date_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ".";
            // 
            // textBox_year
            // 
            this.textBox_year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_year.Location = new System.Drawing.Point(32, 3);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(24, 13);
            this.textBox_year.TabIndex = 4;
            this.textBox_year.Click += new System.EventHandler(this.textBox_date_Click);
            // 
            // DateUpdateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_month);
            this.Controls.Add(this.textBox_day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "DateUpdateControl";
            this.Size = new System.Drawing.Size(58, 18);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_year;
    }
}
