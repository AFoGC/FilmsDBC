
namespace FilmsDBC.Visual.Forms.GlobalControls
{
    partial class MainHeaderControl
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
            this.clickButton_close = new FilmsDBC.Visual.Buttons.ClickButton();
            this.clickButton_maximize = new FilmsDBC.Visual.Buttons.ClickButton();
            this.clickButton_minimize = new FilmsDBC.Visual.Buttons.ClickButton();
            this.SuspendLayout();
            // 
            // clickButton_close
            // 
            this.clickButton_close.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_close.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_close.Location = new System.Drawing.Point(460, 0);
            this.clickButton_close.Margin = new System.Windows.Forms.Padding(0);
            this.clickButton_close.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_close.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_close.Name = "clickButton_close";
            this.clickButton_close.Size = new System.Drawing.Size(40, 30);
            this.clickButton_close.TabIndex = 33;
            this.clickButton_close.Text = "X";
            this.clickButton_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_close.Click += new System.EventHandler(this.clickButton_close_Click);
            // 
            // clickButton_maximize
            // 
            this.clickButton_maximize.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_maximize.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_maximize.Location = new System.Drawing.Point(420, 0);
            this.clickButton_maximize.Margin = new System.Windows.Forms.Padding(0);
            this.clickButton_maximize.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_maximize.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_maximize.Name = "clickButton_maximize";
            this.clickButton_maximize.Size = new System.Drawing.Size(40, 30);
            this.clickButton_maximize.TabIndex = 34;
            this.clickButton_maximize.Text = "#";
            this.clickButton_maximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_maximize.Click += new System.EventHandler(this.clickButton_maximize_Click);
            // 
            // clickButton_minimize
            // 
            this.clickButton_minimize.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_minimize.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_minimize.Location = new System.Drawing.Point(380, 0);
            this.clickButton_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.clickButton_minimize.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_minimize.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_minimize.Name = "clickButton_minimize";
            this.clickButton_minimize.Size = new System.Drawing.Size(40, 30);
            this.clickButton_minimize.TabIndex = 35;
            this.clickButton_minimize.Text = "_";
            this.clickButton_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_minimize.Click += new System.EventHandler(this.clickButton_minimize_Click);
            // 
            // MainHeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clickButton_minimize);
            this.Controls.Add(this.clickButton_maximize);
            this.Controls.Add(this.clickButton_close);
            this.Name = "MainHeaderControl";
            this.Size = new System.Drawing.Size(500, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Buttons.ClickButton clickButton_close;
        private Buttons.ClickButton clickButton_maximize;
        private Buttons.ClickButton clickButton_minimize;
    }
}
