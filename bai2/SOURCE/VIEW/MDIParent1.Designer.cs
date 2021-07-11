namespace bai2.SOURCE.VIEW
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.thoosngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHóaĐơnĐiệnNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoosngToolStripMenuItem,
            this.thốngKêPhòngToolStripMenuItem,
            this.thốngKêHợpĐồngToolStripMenuItem,
            this.thốngKêHóaĐơnĐiệnNướcToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1469, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // thoosngToolStripMenuItem
            // 
            this.thoosngToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.thoosngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoosngToolStripMenuItem.Image")));
            this.thoosngToolStripMenuItem.Name = "thoosngToolStripMenuItem";
            this.thoosngToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.thoosngToolStripMenuItem.Text = "Thống kê sinh viên";
            this.thoosngToolStripMenuItem.Click += new System.EventHandler(this.thoosngToolStripMenuItem_Click);
            // 
            // thốngKêPhòngToolStripMenuItem
            // 
            this.thốngKêPhòngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêPhòngToolStripMenuItem.Image")));
            this.thốngKêPhòngToolStripMenuItem.Name = "thốngKêPhòngToolStripMenuItem";
            this.thốngKêPhòngToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thốngKêPhòngToolStripMenuItem.Text = "Thống kê phòng";
            this.thốngKêPhòngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêPhòngToolStripMenuItem_Click);
            // 
            // thốngKêHợpĐồngToolStripMenuItem
            // 
            this.thốngKêHợpĐồngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêHợpĐồngToolStripMenuItem.Image")));
            this.thốngKêHợpĐồngToolStripMenuItem.Name = "thốngKêHợpĐồngToolStripMenuItem";
            this.thốngKêHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.thốngKêHợpĐồngToolStripMenuItem.Text = "Thống kê hợp đồng";
            this.thốngKêHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêHợpĐồngToolStripMenuItem_Click);
            // 
            // thốngKêHóaĐơnĐiệnNướcToolStripMenuItem
            // 
            this.thốngKêHóaĐơnĐiệnNướcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêHóaĐơnĐiệnNướcToolStripMenuItem.Image")));
            this.thốngKêHóaĐơnĐiệnNướcToolStripMenuItem.Name = "thốngKêHóaĐơnĐiệnNướcToolStripMenuItem";
            this.thốngKêHóaĐơnĐiệnNướcToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.thốngKêHóaĐơnĐiệnNướcToolStripMenuItem.Text = "Thống kê hóa đơn điện nước";
            this.thốngKêHóaĐơnĐiệnNướcToolStripMenuItem.Click += new System.EventHandler(this.thốngKêHóaĐơnĐiệnNướcToolStripMenuItem_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.White;
            this.main.Controls.Add(this.pictureBox1);
            this.main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.main.Location = new System.Drawing.Point(0, 12);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1469, 723);
            this.main.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1469, 723);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 735);
            this.Controls.Add(this.main);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 400);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent1";
            this.TopMost = true;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem thoosngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHóaĐơnĐiệnNướcToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



