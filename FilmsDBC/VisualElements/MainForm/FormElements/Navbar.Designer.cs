
namespace FilmsDBC.VisualElements.MainForm.FormElements
{
    partial class Navbar
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
            this.pressButton_Books = new FilmsDBC.Visual.Buttons.PressButton();
            this.pressButton_Settings = new FilmsDBC.Visual.Buttons.PressButton();
            this.pressButton_Main = new FilmsDBC.Visual.Buttons.PressButton();
            this.SuspendLayout();
            // 
            // pressButton_Books
            // 
            this.pressButton_Books.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pressButton_Books.ClickLocked = false;
            this.pressButton_Books.DefaultColor = System.Drawing.SystemColors.ControlDark;
            this.pressButton_Books.Included = false;
            this.pressButton_Books.Included_DefaultColor = System.Drawing.SystemColors.Control;
            this.pressButton_Books.Included_MouseDownColor = System.Drawing.Color.Empty;
            this.pressButton_Books.Included_MouseEnterColor = System.Drawing.Color.Empty;
            this.pressButton_Books.Location = new System.Drawing.Point(120, 0);
            this.pressButton_Books.MouseDownColor = System.Drawing.Color.Empty;
            this.pressButton_Books.MouseEnterColor = System.Drawing.Color.Empty;
            this.pressButton_Books.Name = "pressButton_Books";
            this.pressButton_Books.Size = new System.Drawing.Size(100, 20);
            this.pressButton_Books.TabIndex = 2;
            this.pressButton_Books.Text = "Books";
            this.pressButton_Books.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pressButton_Books.Click += new System.EventHandler(this.pressButton_Books_Click);
            // 
            // pressButton_Settings
            // 
            this.pressButton_Settings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pressButton_Settings.ClickLocked = false;
            this.pressButton_Settings.DefaultColor = System.Drawing.SystemColors.ControlDark;
            this.pressButton_Settings.Included = false;
            this.pressButton_Settings.Included_DefaultColor = System.Drawing.SystemColors.Control;
            this.pressButton_Settings.Included_MouseDownColor = System.Drawing.Color.Empty;
            this.pressButton_Settings.Included_MouseEnterColor = System.Drawing.Color.Empty;
            this.pressButton_Settings.Location = new System.Drawing.Point(220, 0);
            this.pressButton_Settings.MouseDownColor = System.Drawing.Color.Empty;
            this.pressButton_Settings.MouseEnterColor = System.Drawing.Color.Empty;
            this.pressButton_Settings.Name = "pressButton_Settings";
            this.pressButton_Settings.Size = new System.Drawing.Size(110, 20);
            this.pressButton_Settings.TabIndex = 1;
            this.pressButton_Settings.Text = "Settings";
            this.pressButton_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pressButton_Settings.Click += new System.EventHandler(this.pressButton_Settings_Click);
            // 
            // pressButton_Main
            // 
            this.pressButton_Main.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pressButton_Main.ClickLocked = false;
            this.pressButton_Main.DefaultColor = System.Drawing.SystemColors.ControlDark;
            this.pressButton_Main.Included = false;
            this.pressButton_Main.Included_DefaultColor = System.Drawing.SystemColors.Control;
            this.pressButton_Main.Included_MouseDownColor = System.Drawing.Color.Empty;
            this.pressButton_Main.Included_MouseEnterColor = System.Drawing.Color.Empty;
            this.pressButton_Main.Location = new System.Drawing.Point(20, 0);
            this.pressButton_Main.MouseDownColor = System.Drawing.Color.Empty;
            this.pressButton_Main.MouseEnterColor = System.Drawing.Color.Empty;
            this.pressButton_Main.Name = "pressButton_Main";
            this.pressButton_Main.Size = new System.Drawing.Size(100, 20);
            this.pressButton_Main.TabIndex = 0;
            this.pressButton_Main.Text = "Films";
            this.pressButton_Main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pressButton_Main.Click += new System.EventHandler(this.pressButton_Main_Click);
            // 
            // Navbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.pressButton_Books);
            this.Controls.Add(this.pressButton_Settings);
            this.Controls.Add(this.pressButton_Main);
            this.Name = "Navbar";
            this.Size = new System.Drawing.Size(450, 20);
            this.ResumeLayout(false);

        }

        #endregion
        private FilmsDBC.Visual.Buttons.PressButton pressButton_Main;
        private Buttons.PressButton pressButton_Settings;
        private Buttons.PressButton pressButton_Books;
    }
}
