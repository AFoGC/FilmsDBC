
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.SettingsMenu.FormElements
{
    partial class MarkSystemSettingControl
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
            this.label_name = new System.Windows.Forms.Label();
            this.comboBox_marksSystem = new System.Windows.Forms.ComboBox();
            this.clickButton_changeMarkSystem = new FilmsDBC.Visual.Buttons.ClickButton();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(0, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(200, 20);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Films Mark System:";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_marksSystem
            // 
            this.comboBox_marksSystem.FormattingEnabled = true;
            this.comboBox_marksSystem.Items.AddRange(new object[] {
            "3/3",
            "5/5",
            "6/5",
            "10/10",
            "100/100"});
            this.comboBox_marksSystem.Location = new System.Drawing.Point(200, 0);
            this.comboBox_marksSystem.Name = "comboBox_marksSystem";
            this.comboBox_marksSystem.Size = new System.Drawing.Size(121, 21);
            this.comboBox_marksSystem.TabIndex = 4;
            // 
            // clickButton_changeMarkSystem
            // 
            this.clickButton_changeMarkSystem.BackColor = System.Drawing.SystemColors.Control;
            this.clickButton_changeMarkSystem.DefaultColor = System.Drawing.SystemColors.Control;
            this.clickButton_changeMarkSystem.Location = new System.Drawing.Point(323, 0);
            this.clickButton_changeMarkSystem.MouseDownColor = System.Drawing.Color.Empty;
            this.clickButton_changeMarkSystem.MouseEnterColor = System.Drawing.Color.Empty;
            this.clickButton_changeMarkSystem.Name = "clickButton_changeMarkSystem";
            this.clickButton_changeMarkSystem.Size = new System.Drawing.Size(130, 20);
            this.clickButton_changeMarkSystem.TabIndex = 5;
            this.clickButton_changeMarkSystem.Text = "Change Marks System";
            this.clickButton_changeMarkSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarkSystemSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clickButton_changeMarkSystem);
            this.Controls.Add(this.comboBox_marksSystem);
            this.Controls.Add(this.label_name);
            this.Name = "MarkSystemSettingControl";
            this.Size = new System.Drawing.Size(1035, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ComboBox comboBox_marksSystem;
        private Buttons.ClickButton clickButton_changeMarkSystem;
    }
}
