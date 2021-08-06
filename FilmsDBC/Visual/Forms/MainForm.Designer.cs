
namespace FilmsDBC.Visual.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainControl = new FilmsDBC.Visual.Forms.GlobalControls.MainControl();
            this.settingsControl = new FilmsDBC.Visual.Forms.GlobalControls.SettingsControl();
            this.navbar = new FilmsDBC.Visual.Forms.GlobalControls.Navbar();
            this.booksControl = new FilmsDBC.Visual.Forms.GlobalControls.BooksControl();
            this.SuspendLayout();
            // 
            // mainControl
            // 
            this.mainControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainControl.ControlInBuffer = null;
            this.mainControl.Location = new System.Drawing.Point(0, 20);
            this.mainControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainControl.Name = "mainControl";
            this.mainControl.Size = new System.Drawing.Size(1485, 647);
            this.mainControl.TabIndex = 0;
            //
            // settingsControl
            //
            this.settingsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsControl.Location = new System.Drawing.Point(0, 20);
            this.settingsControl.Margin = new System.Windows.Forms.Padding(0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(1485, 647);
            this.settingsControl.TabIndex = 1;
            //
            // navbar
            //
            this.navbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))));
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Margin = new System.Windows.Forms.Padding(0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1485, 20);
            this.navbar.TabIndex = 2;
            //
            // booksControl
            //
            this.booksControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksControl.Location = new System.Drawing.Point(0, 20);
            this.booksControl.Margin = new System.Windows.Forms.Padding(0);
            this.booksControl.Name = "settingsControl";
            this.booksControl.Size = new System.Drawing.Size(1485, 647);
            this.booksControl.TabIndex = 3;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 667);
            this.Controls.Add(this.mainControl);
            this.Controls.Add(this.settingsControl);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.booksControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private FilmsDBC.Visual.Forms.GlobalControls.MainControl mainControl;
        private FilmsDBC.Visual.Forms.GlobalControls.SettingsControl settingsControl;
        private FilmsDBC.Visual.Forms.GlobalControls.Navbar navbar;
        private FilmsDBC.Visual.Forms.GlobalControls.BooksControl booksControl;
    }
}