
namespace FilmsDBC.Visual.Forms.GlobalControls.SettingsControlElements
{
    partial class ProfileSettingControl
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
            this.textBox_profileName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.comboBox_Profiles = new System.Windows.Forms.ComboBox();
            this.label_rename = new System.Windows.Forms.Label();
            this.label_add = new System.Windows.Forms.Label();
            this.label_remove = new System.Windows.Forms.Label();
            this.textBox_rename = new System.Windows.Forms.TextBox();
            this.comboBox_rename = new System.Windows.Forms.ComboBox();
            this.comboBox_remove = new System.Windows.Forms.ComboBox();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.clickButton_add = new FilmsDBC.Visual.Buttons.ClickButton();
            this.clickButton_remove = new FilmsDBC.Visual.Buttons.ClickButton();
            this.clickButton_rename = new FilmsDBC.Visual.Buttons.ClickButton();
            this.clickButton_expand_reduce = new FilmsDBC.Visual.Buttons.ClickButton();
            this.clickButton_changeDirectory = new FilmsDBC.Visual.Buttons.ClickButton();
            this.SuspendLayout();
            // 
            // textBox_profileName
            // 
            this.textBox_profileName.Location = new System.Drawing.Point(210, 0);
            this.textBox_profileName.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_profileName.Name = "textBox_profileName";
            this.textBox_profileName.ReadOnly = true;
            this.textBox_profileName.Size = new System.Drawing.Size(290, 20);
            this.textBox_profileName.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(0, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(204, 20);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Profile:";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_Profiles
            // 
            this.comboBox_Profiles.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_Profiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Profiles.FormattingEnabled = true;
            this.comboBox_Profiles.Location = new System.Drawing.Point(500, -1);
            this.comboBox_Profiles.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_Profiles.Name = "comboBox_Profiles";
            this.comboBox_Profiles.Size = new System.Drawing.Size(120, 21);
            this.comboBox_Profiles.TabIndex = 3;
            // 
            // label_rename
            // 
            this.label_rename.Location = new System.Drawing.Point(0, 20);
            this.label_rename.Name = "label_rename";
            this.label_rename.Size = new System.Drawing.Size(204, 20);
            this.label_rename.TabIndex = 5;
            this.label_rename.Text = "Rename profile:";
            this.label_rename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_add
            // 
            this.label_add.Location = new System.Drawing.Point(0, 60);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(204, 20);
            this.label_add.TabIndex = 6;
            this.label_add.Text = "Add profile:";
            this.label_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_remove
            // 
            this.label_remove.Location = new System.Drawing.Point(0, 40);
            this.label_remove.Name = "label_remove";
            this.label_remove.Size = new System.Drawing.Size(204, 20);
            this.label_remove.TabIndex = 7;
            this.label_remove.Text = "Remove profile:";
            this.label_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_rename
            // 
            this.textBox_rename.Location = new System.Drawing.Point(211, 20);
            this.textBox_rename.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_rename.Name = "textBox_rename";
            this.textBox_rename.Size = new System.Drawing.Size(150, 20);
            this.textBox_rename.TabIndex = 8;
            // 
            // comboBox_rename
            // 
            this.comboBox_rename.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_rename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rename.FormattingEnabled = true;
            this.comboBox_rename.Location = new System.Drawing.Point(361, 19);
            this.comboBox_rename.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_rename.Name = "comboBox_rename";
            this.comboBox_rename.Size = new System.Drawing.Size(120, 21);
            this.comboBox_rename.TabIndex = 9;
            // 
            // comboBox_remove
            // 
            this.comboBox_remove.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_remove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_remove.FormattingEnabled = true;
            this.comboBox_remove.Location = new System.Drawing.Point(211, 39);
            this.comboBox_remove.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_remove.Name = "comboBox_remove";
            this.comboBox_remove.Size = new System.Drawing.Size(120, 21);
            this.comboBox_remove.TabIndex = 11;
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(211, 60);
            this.textBox_add.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(120, 20);
            this.textBox_add.TabIndex = 13;
            // 
            // clickButton_add
            // 
            this.clickButton_add.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_add.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_add.Location = new System.Drawing.Point(331, 60);
            this.clickButton_add.Margin = new System.Windows.Forms.Padding(0);
            this.clickButton_add.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_add.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_add.Name = "clickButton_add";
            this.clickButton_add.Size = new System.Drawing.Size(100, 20);
            this.clickButton_add.TabIndex = 14;
            this.clickButton_add.Text = "Add Profile";
            this.clickButton_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_add.Click += new System.EventHandler(this.clickButton_add_Click);
            // 
            // clickButton_remove
            // 
            this.clickButton_remove.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_remove.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_remove.Location = new System.Drawing.Point(331, 40);
            this.clickButton_remove.Margin = new System.Windows.Forms.Padding(0);
            this.clickButton_remove.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_remove.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_remove.Name = "clickButton_remove";
            this.clickButton_remove.Size = new System.Drawing.Size(100, 20);
            this.clickButton_remove.TabIndex = 12;
            this.clickButton_remove.Text = "Remove Profile";
            this.clickButton_remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_remove.Click += new System.EventHandler(this.clickButton_remove_Click);
            // 
            // clickButton_rename
            // 
            this.clickButton_rename.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_rename.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_rename.Location = new System.Drawing.Point(481, 20);
            this.clickButton_rename.Margin = new System.Windows.Forms.Padding(0);
            this.clickButton_rename.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_rename.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_rename.Name = "clickButton_rename";
            this.clickButton_rename.Size = new System.Drawing.Size(100, 20);
            this.clickButton_rename.TabIndex = 10;
            this.clickButton_rename.Text = "Rename Profile";
            this.clickButton_rename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_rename.Click += new System.EventHandler(this.clickButton_rename_Click);
            // 
            // clickButton_expand_reduce
            // 
            this.clickButton_expand_reduce.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_expand_reduce.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_expand_reduce.Location = new System.Drawing.Point(935, 0);
            this.clickButton_expand_reduce.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_expand_reduce.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_expand_reduce.Name = "clickButton_expand_reduce";
            this.clickButton_expand_reduce.Size = new System.Drawing.Size(100, 20);
            this.clickButton_expand_reduce.TabIndex = 4;
            this.clickButton_expand_reduce.Text = "Expand";
            this.clickButton_expand_reduce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_expand_reduce.Click += new System.EventHandler(this.clickButton_expand_reduce_Click);
            // 
            // clickButton_changeDirectory
            // 
            this.clickButton_changeDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_changeDirectory.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_changeDirectory.Location = new System.Drawing.Point(620, 0);
            this.clickButton_changeDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.clickButton_changeDirectory.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_changeDirectory.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_changeDirectory.Name = "clickButton_changeDirectory";
            this.clickButton_changeDirectory.Size = new System.Drawing.Size(100, 20);
            this.clickButton_changeDirectory.TabIndex = 0;
            this.clickButton_changeDirectory.Text = "Change Profile";
            this.clickButton_changeDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clickButton_changeDirectory.Click += new System.EventHandler(this.clickButton_changeDirectory_Click);
            // 
            // ProfileSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clickButton_add);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.clickButton_remove);
            this.Controls.Add(this.comboBox_remove);
            this.Controls.Add(this.clickButton_rename);
            this.Controls.Add(this.comboBox_rename);
            this.Controls.Add(this.textBox_rename);
            this.Controls.Add(this.label_remove);
            this.Controls.Add(this.label_add);
            this.Controls.Add(this.label_rename);
            this.Controls.Add(this.clickButton_expand_reduce);
            this.Controls.Add(this.comboBox_Profiles);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_profileName);
            this.Controls.Add(this.clickButton_changeDirectory);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProfileSettingControl";
            this.Size = new System.Drawing.Size(1035, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_profileName;
        private FilmsDBC.Visual.Buttons.ClickButton clickButton_changeDirectory;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ComboBox comboBox_Profiles;
        private Buttons.ClickButton clickButton_expand_reduce;
        private System.Windows.Forms.Label label_rename;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_remove;
        private System.Windows.Forms.TextBox textBox_rename;
        private System.Windows.Forms.ComboBox comboBox_rename;
        private Buttons.ClickButton clickButton_rename;
        private System.Windows.Forms.ComboBox comboBox_remove;
        private Buttons.ClickButton clickButton_remove;
        private System.Windows.Forms.TextBox textBox_add;
        private Buttons.ClickButton clickButton_add;
    }
}
