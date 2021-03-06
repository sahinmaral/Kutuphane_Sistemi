
namespace Kutuphane_Sistemi.UI
{
    partial class StudentQueryMainpage
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
            this.MenuForButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnScanByTurkishId = new System.Windows.Forms.Button();
            this.BtnScanByNameSurname = new System.Windows.Forms.Button();
            this.BtnScanByPenalty = new System.Windows.Forms.Button();
            this.BtnScanByTakenBook = new System.Windows.Forms.Button();
            this.StudentQueryPanel = new System.Windows.Forms.Panel();
            this.MenuForButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuForButtons
            // 
            this.MenuForButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MenuForButtons.ColumnCount = 1;
            this.MenuForButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuForButtons.Controls.Add(this.BtnScanByTurkishId, 0, 2);
            this.MenuForButtons.Controls.Add(this.BtnScanByNameSurname, 0, 1);
            this.MenuForButtons.Controls.Add(this.BtnScanByPenalty, 0, 3);
            this.MenuForButtons.Controls.Add(this.BtnScanByTakenBook, 0, 4);
            this.MenuForButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuForButtons.Location = new System.Drawing.Point(0, 0);
            this.MenuForButtons.Name = "MenuForButtons";
            this.MenuForButtons.RowCount = 6;
            this.MenuForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MenuForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.MenuForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.MenuForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.MenuForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.MenuForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.MenuForButtons.Size = new System.Drawing.Size(199, 800);
            this.MenuForButtons.TabIndex = 82;
            // 
            // BtnScanByTurkishId
            // 
            this.BtnScanByTurkishId.BackColor = System.Drawing.Color.Thistle;
            this.BtnScanByTurkishId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanByTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnScanByTurkishId.Location = new System.Drawing.Point(3, 223);
            this.BtnScanByTurkishId.Name = "BtnScanByTurkishId";
            this.BtnScanByTurkishId.Size = new System.Drawing.Size(193, 64);
            this.BtnScanByTurkishId.TabIndex = 72;
            this.BtnScanByTurkishId.Text = "Öğrencinin TC kimlik numarasına göre";
            this.BtnScanByTurkishId.UseVisualStyleBackColor = false;
            this.BtnScanByTurkishId.Click += new System.EventHandler(this.BtnScanByTurkishId_Click);
            this.BtnScanByTurkishId.MouseEnter += new System.EventHandler(this.BtnScanByTurkishId_MouseEnter);
            this.BtnScanByTurkishId.MouseLeave += new System.EventHandler(this.BtnScanByTurkishId_MouseLeave);
            // 
            // BtnScanByNameSurname
            // 
            this.BtnScanByNameSurname.BackColor = System.Drawing.Color.Thistle;
            this.BtnScanByNameSurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanByNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnScanByNameSurname.Location = new System.Drawing.Point(3, 153);
            this.BtnScanByNameSurname.Name = "BtnScanByNameSurname";
            this.BtnScanByNameSurname.Size = new System.Drawing.Size(193, 64);
            this.BtnScanByNameSurname.TabIndex = 73;
            this.BtnScanByNameSurname.Text = "Öğrencinin Adına Ve Soyadına Göre";
            this.BtnScanByNameSurname.UseVisualStyleBackColor = false;
            this.BtnScanByNameSurname.Click += new System.EventHandler(this.BtnScanByNameSurname_Click);
            this.BtnScanByNameSurname.MouseEnter += new System.EventHandler(this.BtnScanByNameSurname_MouseEnter);
            this.BtnScanByNameSurname.MouseLeave += new System.EventHandler(this.BtnScanByNameSurname_MouseLeave);
            // 
            // BtnScanByPenalty
            // 
            this.BtnScanByPenalty.BackColor = System.Drawing.Color.Thistle;
            this.BtnScanByPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanByPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnScanByPenalty.Location = new System.Drawing.Point(3, 293);
            this.BtnScanByPenalty.Name = "BtnScanByPenalty";
            this.BtnScanByPenalty.Size = new System.Drawing.Size(193, 64);
            this.BtnScanByPenalty.TabIndex = 74;
            this.BtnScanByPenalty.Text = "Ceza Alan Öğrencilere Göre";
            this.BtnScanByPenalty.UseVisualStyleBackColor = false;
            this.BtnScanByPenalty.Click += new System.EventHandler(this.BtnScanByPenalty_Click);
            this.BtnScanByPenalty.MouseEnter += new System.EventHandler(this.BtnScanByPenalty_MouseEnter);
            this.BtnScanByPenalty.MouseLeave += new System.EventHandler(this.BtnScanByPenalty_MouseLeave);
            // 
            // BtnScanByTakenBook
            // 
            this.BtnScanByTakenBook.BackColor = System.Drawing.Color.Thistle;
            this.BtnScanByTakenBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanByTakenBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnScanByTakenBook.Location = new System.Drawing.Point(3, 363);
            this.BtnScanByTakenBook.Name = "BtnScanByTakenBook";
            this.BtnScanByTakenBook.Size = new System.Drawing.Size(193, 64);
            this.BtnScanByTakenBook.TabIndex = 75;
            this.BtnScanByTakenBook.Text = "Aldığı kitaba göre";
            this.BtnScanByTakenBook.UseVisualStyleBackColor = false;
            this.BtnScanByTakenBook.Click += new System.EventHandler(this.BtnScanByTakenBook_Click);
            this.BtnScanByTakenBook.MouseEnter += new System.EventHandler(this.BtnScanByTakenBook_MouseEnter);
            this.BtnScanByTakenBook.MouseLeave += new System.EventHandler(this.BtnScanByTakenBook_MouseLeave);
            // 
            // StudentQueryPanel
            // 
            this.StudentQueryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentQueryPanel.Location = new System.Drawing.Point(199, 0);
            this.StudentQueryPanel.Name = "StudentQueryPanel";
            this.StudentQueryPanel.Size = new System.Drawing.Size(1037, 800);
            this.StudentQueryPanel.TabIndex = 83;
            // 
            // StudentQueryMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1236, 800);
            this.ControlBox = false;
            this.Controls.Add(this.StudentQueryPanel);
            this.Controls.Add(this.MenuForButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentQueryMainpage";
            this.Text = "Öğrenci Sorgulama";
            this.MenuForButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MenuForButtons;
        private System.Windows.Forms.Button BtnScanByTurkishId;
        private System.Windows.Forms.Button BtnScanByNameSurname;
        private System.Windows.Forms.Button BtnScanByPenalty;
        private System.Windows.Forms.Button BtnScanByTakenBook;
        private System.Windows.Forms.Panel StudentQueryPanel;
    }
}