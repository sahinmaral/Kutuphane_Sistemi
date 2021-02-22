namespace Kutuphane_Sistemi.UI
{
    partial class BookWriter
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
            this.BtnScanWriterBook = new System.Windows.Forms.Button();
            this.DgwWriter = new System.Windows.Forms.DataGridView();
            this.BtnScanWriter = new System.Windows.Forms.Button();
            this.TxTScanWriter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpOrderBook = new System.Windows.Forms.GroupBox();
            this.TxtBookISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtNow = new System.Windows.Forms.DateTimePicker();
            this.BtnDeleteOrderBook = new System.Windows.Forms.Button();
            this.TxTBookName = new System.Windows.Forms.TextBox();
            this.TxtStudentTurkishId = new System.Windows.Forms.TextBox();
            this.BtnOrderBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgwBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgwWriter)).BeginInit();
            this.GrpOrderBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwBook)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnScanWriterBook
            // 
            this.BtnScanWriterBook.BackColor = System.Drawing.Color.Thistle;
            this.BtnScanWriterBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanWriterBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnScanWriterBook.Location = new System.Drawing.Point(363, 45);
            this.BtnScanWriterBook.Name = "BtnScanWriterBook";
            this.BtnScanWriterBook.Size = new System.Drawing.Size(133, 29);
            this.BtnScanWriterBook.TabIndex = 2;
            this.BtnScanWriterBook.Text = "Kitaplarını Tarat";
            this.BtnScanWriterBook.UseVisualStyleBackColor = false;
            this.BtnScanWriterBook.Visible = false;
            this.BtnScanWriterBook.Click += new System.EventHandler(this.BtnScanWriterBook_Click);
            // 
            // DgwWriter
            // 
            this.DgwWriter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwWriter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgwWriter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwWriter.Location = new System.Drawing.Point(16, 82);
            this.DgwWriter.Name = "DgwWriter";
            this.DgwWriter.ReadOnly = true;
            this.DgwWriter.RowHeadersWidth = 51;
            this.DgwWriter.Size = new System.Drawing.Size(1224, 312);
            this.DgwWriter.TabIndex = 33;
            this.DgwWriter.Visible = false;
            this.DgwWriter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwWriter_CellDoubleClick);
            // 
            // BtnScanWriter
            // 
            this.BtnScanWriter.BackColor = System.Drawing.Color.Thistle;
            this.BtnScanWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnScanWriter.Location = new System.Drawing.Point(239, 45);
            this.BtnScanWriter.Name = "BtnScanWriter";
            this.BtnScanWriter.Size = new System.Drawing.Size(102, 29);
            this.BtnScanWriter.TabIndex = 1;
            this.BtnScanWriter.Text = "Tarat";
            this.BtnScanWriter.UseVisualStyleBackColor = false;
            this.BtnScanWriter.Click += new System.EventHandler(this.BtnScanWriter_Click);
            // 
            // TxTScanWriter
            // 
            this.TxTScanWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxTScanWriter.Location = new System.Drawing.Point(239, 12);
            this.TxTScanWriter.Name = "TxTScanWriter";
            this.TxTScanWriter.Size = new System.Drawing.Size(258, 26);
            this.TxTScanWriter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kitabın yazarının adını giriniz :";
            // 
            // GrpOrderBook
            // 
            this.GrpOrderBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GrpOrderBook.Controls.Add(this.TxtBookISBN);
            this.GrpOrderBook.Controls.Add(this.label8);
            this.GrpOrderBook.Controls.Add(this.BtnRefresh);
            this.GrpOrderBook.Controls.Add(this.TxtStudentSurname);
            this.GrpOrderBook.Controls.Add(this.TxtStudentName);
            this.GrpOrderBook.Controls.Add(this.label7);
            this.GrpOrderBook.Controls.Add(this.DtNow);
            this.GrpOrderBook.Controls.Add(this.BtnDeleteOrderBook);
            this.GrpOrderBook.Controls.Add(this.TxTBookName);
            this.GrpOrderBook.Controls.Add(this.TxtStudentTurkishId);
            this.GrpOrderBook.Controls.Add(this.BtnOrderBook);
            this.GrpOrderBook.Controls.Add(this.label4);
            this.GrpOrderBook.Controls.Add(this.label3);
            this.GrpOrderBook.Controls.Add(this.label2);
            this.GrpOrderBook.Location = new System.Drawing.Point(16, 845);
            this.GrpOrderBook.Name = "GrpOrderBook";
            this.GrpOrderBook.Size = new System.Drawing.Size(646, 233);
            this.GrpOrderBook.TabIndex = 36;
            this.GrpOrderBook.TabStop = false;
            // 
            // TxtBookISBN
            // 
            this.TxtBookISBN.Enabled = false;
            this.TxtBookISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBookISBN.Location = new System.Drawing.Point(204, 146);
            this.TxtBookISBN.Name = "TxtBookISBN";
            this.TxtBookISBN.Size = new System.Drawing.Size(278, 26);
            this.TxtBookISBN.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(99, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "ISBN No :";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnRefresh.Image = global::Kutuphane_Sistemi.Properties.Resources.refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(510, 182);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(115, 30);
            this.BtnRefresh.TabIndex = 64;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentSurname.Location = new System.Drawing.Point(353, 19);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(128, 26);
            this.TxtStudentSurname.TabIndex = 53;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentName.Location = new System.Drawing.Point(204, 19);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(144, 26);
            this.TxtStudentName.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Öğrenci adı , soyadı :";
            // 
            // DtNow
            // 
            this.DtNow.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtNow.Checked = false;
            this.DtNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtNow.Location = new System.Drawing.Point(204, 188);
            this.DtNow.Name = "DtNow";
            this.DtNow.Size = new System.Drawing.Size(278, 26);
            this.DtNow.TabIndex = 56;
            // 
            // BtnDeleteOrderBook
            // 
            this.BtnDeleteOrderBook.BackColor = System.Drawing.Color.Thistle;
            this.BtnDeleteOrderBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteOrderBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDeleteOrderBook.Location = new System.Drawing.Point(510, 95);
            this.BtnDeleteOrderBook.Name = "BtnDeleteOrderBook";
            this.BtnDeleteOrderBook.Size = new System.Drawing.Size(115, 40);
            this.BtnDeleteOrderBook.TabIndex = 59;
            this.BtnDeleteOrderBook.Text = "Kitabı iade et";
            this.BtnDeleteOrderBook.UseVisualStyleBackColor = false;
            this.BtnDeleteOrderBook.Click += new System.EventHandler(this.BtnDeleteOrderBook_Click);
            // 
            // TxTBookName
            // 
            this.TxTBookName.Enabled = false;
            this.TxTBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxTBookName.Location = new System.Drawing.Point(204, 100);
            this.TxTBookName.Name = "TxTBookName";
            this.TxTBookName.Size = new System.Drawing.Size(278, 26);
            this.TxTBookName.TabIndex = 55;
            // 
            // TxtStudentTurkishId
            // 
            this.TxtStudentTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentTurkishId.Location = new System.Drawing.Point(204, 57);
            this.TxtStudentTurkishId.Name = "TxtStudentTurkishId";
            this.TxtStudentTurkishId.Size = new System.Drawing.Size(278, 26);
            this.TxtStudentTurkishId.TabIndex = 54;
            // 
            // BtnOrderBook
            // 
            this.BtnOrderBook.BackColor = System.Drawing.Color.Thistle;
            this.BtnOrderBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrderBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOrderBook.Location = new System.Drawing.Point(510, 19);
            this.BtnOrderBook.Name = "BtnOrderBook";
            this.BtnOrderBook.Size = new System.Drawing.Size(115, 40);
            this.BtnOrderBook.TabIndex = 58;
            this.BtnOrderBook.Text = "Kitabı al";
            this.BtnOrderBook.UseVisualStyleBackColor = false;
            this.BtnOrderBook.Click += new System.EventHandler(this.BtnOrderBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Şu anki tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(100, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Kitap adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Öğrenci kimlik no : ";
            // 
            // DgwBook
            // 
            this.DgwBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwBook.Location = new System.Drawing.Point(16, 402);
            this.DgwBook.Name = "DgwBook";
            this.DgwBook.ReadOnly = true;
            this.DgwBook.RowHeadersWidth = 51;
            this.DgwBook.Size = new System.Drawing.Size(1224, 424);
            this.DgwBook.TabIndex = 34;
            this.DgwBook.Visible = false;
            this.DgwBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBook_CellDoubleClick);
            // 
            // BookWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1260, 1100);
            this.ControlBox = false;
            this.Controls.Add(this.GrpOrderBook);
            this.Controls.Add(this.BtnScanWriterBook);
            this.Controls.Add(this.DgwBook);
            this.Controls.Add(this.DgwWriter);
            this.Controls.Add(this.BtnScanWriter);
            this.Controls.Add(this.TxTScanWriter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookWriter";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.DgwWriter)).EndInit();
            this.GrpOrderBook.ResumeLayout(false);
            this.GrpOrderBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnScanWriterBook;
        private System.Windows.Forms.DataGridView DgwWriter;
        private System.Windows.Forms.Button BtnScanWriter;
        private System.Windows.Forms.TextBox TxTScanWriter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpOrderBook;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtNow;
        private System.Windows.Forms.Button BtnDeleteOrderBook;
        private System.Windows.Forms.TextBox TxTBookName;
        private System.Windows.Forms.TextBox TxtStudentTurkishId;
        private System.Windows.Forms.Button BtnOrderBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridView DgwBook;
        private System.Windows.Forms.TextBox TxtBookISBN;
        private System.Windows.Forms.Label label8;
    }
}