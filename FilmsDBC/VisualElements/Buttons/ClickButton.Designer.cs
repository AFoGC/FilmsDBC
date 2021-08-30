
namespace FilmsDBC.VisualElements.Buttons
{
    partial class ClickButton
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MouseEnter += new System.EventHandler(this.this_mouseEnter);
            this.MouseLeave += new System.EventHandler(this.this_mouseLeave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.this_mouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.this_mouseUp);
        }

        #endregion
    }
}
