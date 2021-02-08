namespace Kutuphane_Sistemi.UI
{
    partial class Mainpage
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
            this.grp_writer = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ismineGöreSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarınaGöreSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türüneGöreSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kodunaGöreSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelShow = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_writer
            // 
            this.grp_writer.Location = new System.Drawing.Point(3, 3);
            this.grp_writer.Name = "grp_writer";
            this.grp_writer.Size = new System.Drawing.Size(731, 707);
            this.grp_writer.TabIndex = 7;
            this.grp_writer.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapSorgulamaToolStripMenuItem,
            this.öğrenciSorgulamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapSorgulamaToolStripMenuItem
            // 
            this.kitapSorgulamaToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.kitapSorgulamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ismineGöreSorgulamaToolStripMenuItem,
            this.yazarınaGöreSorgulamaToolStripMenuItem,
            this.türüneGöreSorgulamaToolStripMenuItem,
            this.kodunaGöreSorgulamaToolStripMenuItem});
            this.kitapSorgulamaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kitapSorgulamaToolStripMenuItem.Name = "kitapSorgulamaToolStripMenuItem";
            this.kitapSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.kitapSorgulamaToolStripMenuItem.Text = "Kitap sorgulama";
            // 
            // ismineGöreSorgulamaToolStripMenuItem
            // 
            this.ismineGöreSorgulamaToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.ismineGöreSorgulamaToolStripMenuItem.Name = "ismineGöreSorgulamaToolStripMenuItem";
            this.ismineGöreSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.ismineGöreSorgulamaToolStripMenuItem.Text = "İsmine göre sorgulama";
            this.ismineGöreSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.ismineGöreSorgulamaToolStripMenuItem_Click);
            // 
            // yazarınaGöreSorgulamaToolStripMenuItem
            // 
            this.yazarınaGöreSorgulamaToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.yazarınaGöreSorgulamaToolStripMenuItem.Name = "yazarınaGöreSorgulamaToolStripMenuItem";
            this.yazarınaGöreSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.yazarınaGöreSorgulamaToolStripMenuItem.Text = "Yazarına göre sorgulama";
            this.yazarınaGöreSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.yazarınaGöreSorgulamaToolStripMenuItem_Click);
            // 
            // türüneGöreSorgulamaToolStripMenuItem
            // 
            this.türüneGöreSorgulamaToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.türüneGöreSorgulamaToolStripMenuItem.Name = "türüneGöreSorgulamaToolStripMenuItem";
            this.türüneGöreSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.türüneGöreSorgulamaToolStripMenuItem.Text = "Türüne göre sorgulama";
            // 
            // kodunaGöreSorgulamaToolStripMenuItem
            // 
            this.kodunaGöreSorgulamaToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.kodunaGöreSorgulamaToolStripMenuItem.Name = "kodunaGöreSorgulamaToolStripMenuItem";
            this.kodunaGöreSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.kodunaGöreSorgulamaToolStripMenuItem.Text = "Koduna göre sorgulama";
            // 
            // öğrenciSorgulamaToolStripMenuItem
            // 
            this.öğrenciSorgulamaToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.öğrenciSorgulamaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.öğrenciSorgulamaToolStripMenuItem.Name = "öğrenciSorgulamaToolStripMenuItem";
            this.öğrenciSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.öğrenciSorgulamaToolStripMenuItem.Text = "Öğrenci sorgulama";
            this.öğrenciSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.öğrenciSorgulamaToolStripMenuItem_Click);
            // 
            // panelShow
            // 
            this.panelShow.AutoScroll = true;
            this.panelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 28);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1280, 679);
            this.panelShow.TabIndex = 9;
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1280, 707);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Mainpage";
            this.Text = "Kütüphane Paneli";
            this.Load += new System.EventHandler(this.Mainpage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_writer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ismineGöreSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarınaGöreSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türüneGöreSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kodunaGöreSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciSorgulamaToolStripMenuItem;
        private System.Windows.Forms.Panel panelShow;
    }
}