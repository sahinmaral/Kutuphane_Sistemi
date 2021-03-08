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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookWriter));
            this.label1 = new System.Windows.Forms.Label();
            this.GrpOrderBook = new System.Windows.Forms.GroupBox();
            this.BtnDeleteOrderBook = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOrderBook = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBookISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPersonSurname = new System.Windows.Forms.TextBox();
            this.TxtPersonName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtNow = new System.Windows.Forms.DateTimePicker();
            this.TxTBookName = new System.Windows.Forms.TextBox();
            this.TxtPersonTurkishId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnScanWriterBook = new DevExpress.XtraEditors.SimpleButton();
            this.WriterGridControl = new DevExpress.XtraGrid.GridControl();
            this.WriterGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SearchLookupEditScanWriter = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrpOrderBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WriterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WriterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookupEditScanWriter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
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
            this.GrpOrderBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GrpOrderBook.Controls.Add(this.BtnDeleteOrderBook);
            this.GrpOrderBook.Controls.Add(this.BtnOrderBook);
            this.GrpOrderBook.Controls.Add(this.BtnRefresh);
            this.GrpOrderBook.Controls.Add(this.TxtBookISBN);
            this.GrpOrderBook.Controls.Add(this.label8);
            this.GrpOrderBook.Controls.Add(this.TxtPersonSurname);
            this.GrpOrderBook.Controls.Add(this.TxtPersonName);
            this.GrpOrderBook.Controls.Add(this.label7);
            this.GrpOrderBook.Controls.Add(this.DtNow);
            this.GrpOrderBook.Controls.Add(this.TxTBookName);
            this.GrpOrderBook.Controls.Add(this.TxtPersonTurkishId);
            this.GrpOrderBook.Controls.Add(this.label4);
            this.GrpOrderBook.Controls.Add(this.label3);
            this.GrpOrderBook.Controls.Add(this.label2);
            this.GrpOrderBook.Location = new System.Drawing.Point(311, 599);
            this.GrpOrderBook.Name = "GrpOrderBook";
            this.GrpOrderBook.Size = new System.Drawing.Size(689, 233);
            this.GrpOrderBook.TabIndex = 36;
            this.GrpOrderBook.TabStop = false;
            // 
            // BtnDeleteOrderBook
            // 
            this.BtnDeleteOrderBook.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.BtnDeleteOrderBook.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnDeleteOrderBook.Appearance.Options.UseBackColor = true;
            this.BtnDeleteOrderBook.Appearance.Options.UseFont = true;
            this.BtnDeleteOrderBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteOrderBook.ImageOptions.Image")));
            this.BtnDeleteOrderBook.Location = new System.Drawing.Point(510, 91);
            this.BtnDeleteOrderBook.Name = "BtnDeleteOrderBook";
            this.BtnDeleteOrderBook.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnDeleteOrderBook.Size = new System.Drawing.Size(176, 47);
            this.BtnDeleteOrderBook.TabIndex = 100;
            this.BtnDeleteOrderBook.Text = "Kitabı\r\n iade et";
            this.BtnDeleteOrderBook.Click += new System.EventHandler(this.BtnDeleteOrderBook_Click);
            // 
            // BtnOrderBook
            // 
            this.BtnOrderBook.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.BtnOrderBook.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnOrderBook.Appearance.Options.UseBackColor = true;
            this.BtnOrderBook.Appearance.Options.UseFont = true;
            this.BtnOrderBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOrderBook.ImageOptions.Image")));
            this.BtnOrderBook.Location = new System.Drawing.Point(510, 22);
            this.BtnOrderBook.Name = "BtnOrderBook";
            this.BtnOrderBook.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnOrderBook.Size = new System.Drawing.Size(176, 47);
            this.BtnOrderBook.TabIndex = 99;
            this.BtnOrderBook.Text = "Kitabı al";
            this.BtnOrderBook.Click += new System.EventHandler(this.BtnOrderBook_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.BtnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnRefresh.Appearance.Options.UseBackColor = true;
            this.BtnRefresh.Appearance.Options.UseFont = true;
            this.BtnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRefresh.ImageOptions.SvgImage")));
            this.BtnRefresh.Location = new System.Drawing.Point(510, 166);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnRefresh.Size = new System.Drawing.Size(176, 46);
            this.BtnRefresh.TabIndex = 99;
            this.BtnRefresh.Text = "Kişinin \r\nbilgilerini getir";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
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
            // TxtPersonSurname
            // 
            this.TxtPersonSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonSurname.Location = new System.Drawing.Point(353, 19);
            this.TxtPersonSurname.Name = "TxtPersonSurname";
            this.TxtPersonSurname.Size = new System.Drawing.Size(128, 26);
            this.TxtPersonSurname.TabIndex = 53;
            // 
            // TxtPersonName
            // 
            this.TxtPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonName.Location = new System.Drawing.Point(204, 19);
            this.TxtPersonName.Name = "TxtPersonName";
            this.TxtPersonName.Size = new System.Drawing.Size(144, 26);
            this.TxtPersonName.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(34, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Kişinin adı , soyadı :";
            // 
            // DtNow
            // 
            this.DtNow.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtNow.Checked = false;
            this.DtNow.Enabled = false;
            this.DtNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtNow.Location = new System.Drawing.Point(204, 188);
            this.DtNow.Name = "DtNow";
            this.DtNow.Size = new System.Drawing.Size(278, 26);
            this.DtNow.TabIndex = 56;
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
            // TxtPersonTurkishId
            // 
            this.TxtPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonTurkishId.Location = new System.Drawing.Point(204, 57);
            this.TxtPersonTurkishId.Name = "TxtPersonTurkishId";
            this.TxtPersonTurkishId.Size = new System.Drawing.Size(278, 26);
            this.TxtPersonTurkishId.TabIndex = 54;
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
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Kişinin TC kimlik no : ";
            // 
            // BtnScanWriterBook
            // 
            this.BtnScanWriterBook.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.BtnScanWriterBook.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnScanWriterBook.Appearance.Options.UseBackColor = true;
            this.BtnScanWriterBook.Appearance.Options.UseFont = true;
            this.BtnScanWriterBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnScanWriterBook.ImageOptions.Image")));
            this.BtnScanWriterBook.Location = new System.Drawing.Point(528, 12);
            this.BtnScanWriterBook.Name = "BtnScanWriterBook";
            this.BtnScanWriterBook.Size = new System.Drawing.Size(144, 54);
            this.BtnScanWriterBook.TabIndex = 94;
            this.BtnScanWriterBook.Text = "Kitapları Tarat";
            this.BtnScanWriterBook.Click += new System.EventHandler(this.BtnScanWriterBook_Click);
            // 
            // WriterGridControl
            // 
            this.WriterGridControl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterGridControl.Location = new System.Drawing.Point(18, 110);
            this.WriterGridControl.MainView = this.WriterGridView;
            this.WriterGridControl.Name = "WriterGridControl";
            this.WriterGridControl.Size = new System.Drawing.Size(1230, 459);
            this.WriterGridControl.TabIndex = 95;
            this.WriterGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.WriterGridView});
            // 
            // WriterGridView
            // 
            this.WriterGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.WriterGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.WriterGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.WriterGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.WriterGridView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.WriterGridView.Appearance.Row.Options.UseFont = true;
            this.WriterGridView.GridControl = this.WriterGridControl;
            this.WriterGridView.Name = "WriterGridView";
            this.WriterGridView.OptionsBehavior.ReadOnly = true;
            this.WriterGridView.OptionsCustomization.AllowColumnMoving = false;
            this.WriterGridView.OptionsCustomization.AllowColumnResizing = false;
            this.WriterGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.WriterGridView.OptionsView.ShowGroupPanel = false;
            this.WriterGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.WriterGridView_FocusedRowChanged);
            // 
            // SearchLookupEditScanWriter
            // 
            this.SearchLookupEditScanWriter.EditValue = "";
            this.SearchLookupEditScanWriter.Location = new System.Drawing.Point(235, 14);
            this.SearchLookupEditScanWriter.Name = "SearchLookupEditScanWriter";
            this.SearchLookupEditScanWriter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SearchLookupEditScanWriter.Properties.Appearance.Options.UseFont = true;
            this.SearchLookupEditScanWriter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SearchLookupEditScanWriter.Properties.NullText = "";
            this.SearchLookupEditScanWriter.Properties.PopupView = this.searchLookUpEdit1View;
            this.SearchLookupEditScanWriter.Size = new System.Drawing.Size(278, 26);
            this.SearchLookupEditScanWriter.TabIndex = 98;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // BookWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1260, 844);
            this.ControlBox = false;
            this.Controls.Add(this.SearchLookupEditScanWriter);
            this.Controls.Add(this.WriterGridControl);
            this.Controls.Add(this.BtnScanWriterBook);
            this.Controls.Add(this.GrpOrderBook);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookWriter";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.BookWriter_Load);
            this.GrpOrderBook.ResumeLayout(false);
            this.GrpOrderBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WriterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WriterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookupEditScanWriter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpOrderBook;
        private System.Windows.Forms.TextBox TxtPersonSurname;
        private System.Windows.Forms.TextBox TxtPersonName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtNow;
        private System.Windows.Forms.TextBox TxTBookName;
        private System.Windows.Forms.TextBox TxtPersonTurkishId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBookISBN;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton BtnScanWriterBook;
        private DevExpress.XtraGrid.GridControl WriterGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView WriterGridView;
        private DevExpress.XtraEditors.SearchLookUpEdit SearchLookupEditScanWriter;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteOrderBook;
        private DevExpress.XtraEditors.SimpleButton BtnOrderBook;
    }
}