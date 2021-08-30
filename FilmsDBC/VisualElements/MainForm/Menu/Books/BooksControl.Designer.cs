
namespace FilmsDBC.VisualElements.MainForm.Menu.Books
{
    partial class BooksControl
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
            this.flowLayoutPanel_main = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_main
            // 
            this.flowLayoutPanel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_main.AutoScroll = true;
            this.flowLayoutPanel_main.Location = new System.Drawing.Point(235, 78);
            this.flowLayoutPanel_main.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_main.Name = "flowLayoutPanel_main";
            this.flowLayoutPanel_main.Size = new System.Drawing.Size(960, 569);
            this.flowLayoutPanel_main.TabIndex = 1;
            // 
            // BooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_main);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(1485, 647);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_main;
    }
}
