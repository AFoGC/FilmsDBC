
namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.InfoMenus.UpdateInfo
{
    partial class UpdateControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateControl));
            this.flowLayoutPanel_main = new System.Windows.Forms.FlowLayoutPanel();
            this.button_update = new System.Windows.Forms.Button();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_main
            // 
            this.flowLayoutPanel_main.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel_main.Name = "flowLayoutPanel_main";
            this.flowLayoutPanel_main.Size = new System.Drawing.Size(940, 60);
            this.flowLayoutPanel_main.TabIndex = 1;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(3, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(90, 20);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Подтвердить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.InitialImage")));
            this.pictureBox_Close.Location = new System.Drawing.Point(917, 3);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 4;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // UpadateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.flowLayoutPanel_main);
            this.Name = "UpadateControl";
            this.Size = new System.Drawing.Size(940, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_main;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.PictureBox pictureBox_Close;
    }
}
