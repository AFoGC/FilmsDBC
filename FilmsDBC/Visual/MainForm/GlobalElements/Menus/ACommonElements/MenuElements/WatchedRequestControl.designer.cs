
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.MenuElements
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
            this.label_requestWatched = new FilmsDBC.Visual.Buttons.PressButton();
            this.label_requestUnwatched = new FilmsDBC.Visual.Buttons.PressButton();
            this.SuspendLayout();
            // 
            // label_requestWatched
            // 
            this.label_requestWatched.BackColor = System.Drawing.SystemColors.Control;
            this.label_requestWatched.ClickLocked = false;
            this.label_requestWatched.DefaultColor = System.Drawing.SystemColors.Control;
            this.label_requestWatched.Included = false;
            this.label_requestWatched.Included_DefaultColor = System.Drawing.SystemColors.ControlDark;
            this.label_requestWatched.Included_MouseDownColor = System.Drawing.Color.Empty;
            this.label_requestWatched.Included_MouseEnterColor = System.Drawing.Color.Empty;
            this.label_requestWatched.Location = new System.Drawing.Point(0, 0);
            this.label_requestWatched.MouseDownColor = System.Drawing.Color.Empty;
            this.label_requestWatched.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_requestWatched.Name = "label_requestWatched";
            this.label_requestWatched.Size = new System.Drawing.Size(129, 20);
            this.label_requestWatched.TabIndex = 11;
            this.label_requestWatched.Text = "Watched";
            this.label_requestWatched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_requestUnwatched
            // 
            this.label_requestUnwatched.BackColor = System.Drawing.SystemColors.Control;
            this.label_requestUnwatched.ClickLocked = false;
            this.label_requestUnwatched.DefaultColor = System.Drawing.SystemColors.Control;
            this.label_requestUnwatched.Included = false;
            this.label_requestUnwatched.Included_DefaultColor = System.Drawing.SystemColors.ControlDark;
            this.label_requestUnwatched.Included_MouseDownColor = System.Drawing.Color.Empty;
            this.label_requestUnwatched.Included_MouseEnterColor = System.Drawing.Color.Empty;
            this.label_requestUnwatched.Location = new System.Drawing.Point(130, 0);
            this.label_requestUnwatched.MouseDownColor = System.Drawing.Color.Empty;
            this.label_requestUnwatched.MouseEnterColor = System.Drawing.Color.Empty;
            this.label_requestUnwatched.Name = "label_requestUnwatched";
            this.label_requestUnwatched.Size = new System.Drawing.Size(129, 20);
            this.label_requestUnwatched.TabIndex = 12;
            this.label_requestUnwatched.Text = "Unwatched";
            this.label_requestUnwatched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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

        private FilmsDBC.Visual.Buttons.PressButton label_requestWatched;
        private FilmsDBC.Visual.Buttons.PressButton label_requestUnwatched;
    }
}
