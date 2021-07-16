
namespace DBConnection
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemDB = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDBDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDBConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDB});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemDB
            // 
            this.MenuItemDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDBConnect,
            this.MenuItemDBDisconnect});
            this.MenuItemDB.Name = "MenuItemDB";
            this.MenuItemDB.Size = new System.Drawing.Size(192, 36);
            this.MenuItemDB.Text = "DB connection";
            // 
            // MenuItemDBDisconnect
            // 
            this.MenuItemDBDisconnect.Name = "MenuItemDBDisconnect";
            this.MenuItemDBDisconnect.Size = new System.Drawing.Size(359, 44);
            this.MenuItemDBDisconnect.Text = "Disconnect";
            this.MenuItemDBDisconnect.Click += new System.EventHandler(this.MenuItemDBDisconnect_Click);
            // 
            // MenuItemDBConnect
            // 
            this.MenuItemDBConnect.Name = "MenuItemDBConnect";
            this.MenuItemDBConnect.Size = new System.Drawing.Size(359, 44);
            this.MenuItemDBConnect.Text = "Connect";
            this.MenuItemDBConnect.Click += new System.EventHandler(this.MenuItemDBConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDB;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDBDisconnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDBConnect;
    }
}

