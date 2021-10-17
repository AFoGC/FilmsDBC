
namespace FilmsDBC.Visual.HelpForms.ExitForm
{
    partial class ExitForm
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
            this.button_DontSave = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_DontSave
            // 
            this.button_DontSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button_DontSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_DontSave.FlatAppearance.BorderSize = 0;
            this.button_DontSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button_DontSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_DontSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DontSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_DontSave.Location = new System.Drawing.Point(88, 163);
            this.button_DontSave.Name = "button_DontSave";
            this.button_DontSave.Size = new System.Drawing.Size(75, 20);
            this.button_DontSave.TabIndex = 21;
            this.button_DontSave.Text = "Dont save";
            this.button_DontSave.UseVisualStyleBackColor = false;
            this.button_DontSave.Click += new System.EventHandler(this.button_DontSave_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_Save.Location = new System.Drawing.Point(272, 163);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 20);
            this.button_Save.TabIndex = 22;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_close.Location = new System.Drawing.Point(420, 1);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 20);
            this.button_close.TabIndex = 23;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(452, 254);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_DontSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExitForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ExitForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_DontSave;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_close;
    }
}