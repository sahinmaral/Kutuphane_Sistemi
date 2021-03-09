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
            this.BtnScanWriterBook = new DevExpress.XtraEditors.SimpleButton();
            this.WriterGridControl = new DevExpress.XtraGrid.GridControl();
            this.WriterGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SearchLookupEditScanWriter = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.DtNow = new System.Windows.Forms.DateTimePicker();
            this.TxtBookISBN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtPersonSurname = new System.Windows.Forms.TextBox();
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPersonTurkishId = new System.Windows.Forms.TextBox();
            this.TxtPersonName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDeleteOrderBook = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.WriterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WriterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookupEditScanWriter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel3.SetColumn(this.label1, 0);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.tablePanel3.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kitabın yazarının adını giriniz :";
            // 
            // BtnScanWriterBook
            // 
            this.BtnScanWriterBook.Appearance.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnScanWriterBook.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnScanWriterBook.Appearance.Options.UseBackColor = true;
            this.BtnScanWriterBook.Appearance.Options.UseFont = true;
            this.tablePanel3.SetColumn(this.BtnScanWriterBook, 1);
            this.BtnScanWriterBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnScanWriterBook.ImageOptions.Image")));
            this.BtnScanWriterBook.Location = new System.Drawing.Point(287, 33);
            this.BtnScanWriterBook.Name = "BtnScanWriterBook";
            this.BtnScanWriterBook.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel3.SetRow(this.BtnScanWriterBook, 1);
            this.BtnScanWriterBook.Size = new System.Drawing.Size(301, 46);
            this.BtnScanWriterBook.TabIndex = 94;
            this.BtnScanWriterBook.Text = "Kitapları Tarat";
            this.BtnScanWriterBook.Click += new System.EventHandler(this.BtnScanWriterBook_Click);
            // 
            // WriterGridControl
            // 
            this.WriterGridControl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterGridControl.Location = new System.Drawing.Point(47, 151);
            this.WriterGridControl.MainView = this.WriterGridView;
            this.WriterGridControl.Name = "WriterGridControl";
            this.WriterGridControl.Size = new System.Drawing.Size(1185, 416);
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
            this.tablePanel3.SetColumn(this.SearchLookupEditScanWriter, 1);
            this.SearchLookupEditScanWriter.EditValue = "";
            this.SearchLookupEditScanWriter.Location = new System.Drawing.Point(287, 3);
            this.SearchLookupEditScanWriter.Name = "SearchLookupEditScanWriter";
            this.SearchLookupEditScanWriter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SearchLookupEditScanWriter.Properties.Appearance.Options.UseFont = true;
            this.SearchLookupEditScanWriter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SearchLookupEditScanWriter.Properties.NullText = "";
            this.SearchLookupEditScanWriter.Properties.PopupView = this.searchLookUpEdit1View;
            this.tablePanel3.SetRow(this.SearchLookupEditScanWriter, 0);
            this.SearchLookupEditScanWriter.Size = new System.Drawing.Size(301, 26);
            this.SearchLookupEditScanWriter.TabIndex = 98;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.DtNow);
            this.tablePanel1.Controls.Add(this.TxtBookISBN);
            this.tablePanel1.Controls.Add(this.label12);
            this.tablePanel1.Controls.Add(this.TxtPersonSurname);
            this.tablePanel1.Controls.Add(this.TxtBookName);
            this.tablePanel1.Controls.Add(this.label11);
            this.tablePanel1.Controls.Add(this.TxtPersonTurkishId);
            this.tablePanel1.Controls.Add(this.TxtPersonName);
            this.tablePanel1.Controls.Add(this.label10);
            this.tablePanel1.Controls.Add(this.label9);
            this.tablePanel1.Controls.Add(this.label6);
            this.tablePanel1.Controls.Add(this.label5);
            this.tablePanel1.Location = new System.Drawing.Point(219, 582);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(724, 300);
            this.tablePanel1.TabIndex = 99;
            // 
            // DtNow
            // 
            this.DtNow.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtNow.Checked = false;
            this.tablePanel1.SetColumn(this.DtNow, 1);
            this.DtNow.Enabled = false;
            this.DtNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtNow.Location = new System.Drawing.Point(365, 262);
            this.DtNow.Name = "DtNow";
            this.tablePanel1.SetRow(this.DtNow, 5);
            this.DtNow.Size = new System.Drawing.Size(356, 26);
            this.DtNow.TabIndex = 71;
            // 
            // TxtBookISBN
            // 
            this.tablePanel1.SetColumn(this.TxtBookISBN, 1);
            this.TxtBookISBN.Enabled = false;
            this.TxtBookISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBookISBN.Location = new System.Drawing.Point(365, 212);
            this.TxtBookISBN.Name = "TxtBookISBN";
            this.tablePanel1.SetRow(this.TxtBookISBN, 4);
            this.TxtBookISBN.Size = new System.Drawing.Size(356, 26);
            this.TxtBookISBN.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.tablePanel1.SetColumn(this.label12, 0);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 265);
            this.label12.Name = "label12";
            this.tablePanel1.SetRow(this.label12, 5);
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 70;
            this.label12.Text = "Şu anki tarih :";
            // 
            // TxtPersonSurname
            // 
            this.tablePanel1.SetColumn(this.TxtPersonSurname, 1);
            this.TxtPersonSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonSurname.Location = new System.Drawing.Point(365, 62);
            this.TxtPersonSurname.Name = "TxtPersonSurname";
            this.tablePanel1.SetRow(this.TxtPersonSurname, 1);
            this.TxtPersonSurname.Size = new System.Drawing.Size(356, 26);
            this.TxtPersonSurname.TabIndex = 68;
            // 
            // TxtBookName
            // 
            this.tablePanel1.SetColumn(this.TxtBookName, 1);
            this.TxtBookName.Enabled = false;
            this.TxtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBookName.Location = new System.Drawing.Point(365, 162);
            this.TxtBookName.Name = "TxtBookName";
            this.tablePanel1.SetRow(this.TxtBookName, 3);
            this.TxtBookName.Size = new System.Drawing.Size(356, 26);
            this.TxtBookName.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.tablePanel1.SetColumn(this.label11, 0);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 215);
            this.label11.Name = "label11";
            this.tablePanel1.SetRow(this.label11, 4);
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "ISBN No :";
            // 
            // TxtPersonTurkishId
            // 
            this.tablePanel1.SetColumn(this.TxtPersonTurkishId, 1);
            this.TxtPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonTurkishId.Location = new System.Drawing.Point(365, 112);
            this.TxtPersonTurkishId.Name = "TxtPersonTurkishId";
            this.tablePanel1.SetRow(this.TxtPersonTurkishId, 2);
            this.TxtPersonTurkishId.Size = new System.Drawing.Size(356, 26);
            this.TxtPersonTurkishId.TabIndex = 69;
            // 
            // TxtPersonName
            // 
            this.tablePanel1.SetColumn(this.TxtPersonName, 1);
            this.TxtPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonName.Location = new System.Drawing.Point(365, 12);
            this.TxtPersonName.Name = "TxtPersonName";
            this.tablePanel1.SetRow(this.TxtPersonName, 0);
            this.TxtPersonName.Size = new System.Drawing.Size(356, 26);
            this.TxtPersonName.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.tablePanel1.SetColumn(this.label10, 0);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 165);
            this.label10.Name = "label10";
            this.tablePanel1.SetRow(this.label10, 3);
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Kitap adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tablePanel1.SetColumn(this.label9, 0);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 115);
            this.label9.Name = "label9";
            this.tablePanel1.SetRow(this.label9, 2);
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Kişinin TC kimlik no : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tablePanel1.SetColumn(this.label6, 0);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.tablePanel1.SetRow(this.label6, 1);
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Kişinin soyadı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tablePanel1.SetColumn(this.label5, 0);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.tablePanel1.SetRow(this.label5, 0);
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Kişinin adı :";
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.simpleButton2);
            this.tablePanel2.Controls.Add(this.BtnRefresh);
            this.tablePanel2.Controls.Add(this.BtnDeleteOrderBook);
            this.tablePanel2.Location = new System.Drawing.Point(218, 884);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F)});
            this.tablePanel2.Size = new System.Drawing.Size(724, 49);
            this.tablePanel2.TabIndex = 105;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.simpleButton2, 0);
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(3, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel2.SetRow(this.simpleButton2, 0);
            this.simpleButton2.Size = new System.Drawing.Size(235, 44);
            this.simpleButton2.TabIndex = 101;
            this.simpleButton2.Text = "Kitabı al";
            this.simpleButton2.Click += new System.EventHandler(this.BtnOrderBook_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Appearance.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnRefresh.Appearance.Options.UseBackColor = true;
            this.BtnRefresh.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.BtnRefresh, 2);
            this.BtnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRefresh.ImageOptions.SvgImage")));
            this.BtnRefresh.Location = new System.Drawing.Point(486, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel2.SetRow(this.BtnRefresh, 0);
            this.BtnRefresh.Size = new System.Drawing.Size(235, 44);
            this.BtnRefresh.TabIndex = 102;
            this.BtnRefresh.Text = "Kişinin \r\nbilgilerini getir";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnDeleteOrderBook
            // 
            this.BtnDeleteOrderBook.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.BtnDeleteOrderBook.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnDeleteOrderBook.Appearance.Options.UseBackColor = true;
            this.BtnDeleteOrderBook.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.BtnDeleteOrderBook, 1);
            this.BtnDeleteOrderBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteOrderBook.ImageOptions.Image")));
            this.BtnDeleteOrderBook.Location = new System.Drawing.Point(244, 3);
            this.BtnDeleteOrderBook.Name = "BtnDeleteOrderBook";
            this.BtnDeleteOrderBook.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel2.SetRow(this.BtnDeleteOrderBook, 0);
            this.BtnDeleteOrderBook.Size = new System.Drawing.Size(235, 44);
            this.BtnDeleteOrderBook.TabIndex = 103;
            this.BtnDeleteOrderBook.Text = "Kitabı\r\n iade et";
            this.BtnDeleteOrderBook.Click += new System.EventHandler(this.BtnDeleteOrderBook_Click);
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.79F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.21F)});
            this.tablePanel3.Controls.Add(this.SearchLookupEditScanWriter);
            this.tablePanel3.Controls.Add(this.label1);
            this.tablePanel3.Controls.Add(this.BtnScanWriterBook);
            this.tablePanel3.Location = new System.Drawing.Point(48, 15);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F)});
            this.tablePanel3.Size = new System.Drawing.Size(591, 82);
            this.tablePanel3.TabIndex = 106;
            // 
            // BookWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 980);
            this.ControlBox = false;
            this.Controls.Add(this.tablePanel3);
            this.Controls.Add(this.tablePanel2);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.WriterGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookWriter";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.BookWriter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WriterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WriterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookupEditScanWriter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.tablePanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton BtnScanWriterBook;
        private DevExpress.XtraGrid.GridControl WriterGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView WriterGridView;
        private DevExpress.XtraEditors.SearchLookUpEdit SearchLookupEditScanWriter;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.DateTimePicker DtNow;
        private System.Windows.Forms.TextBox TxtBookISBN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtPersonSurname;
        private System.Windows.Forms.TextBox TxtBookName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPersonTurkishId;
        private System.Windows.Forms.TextBox TxtPersonName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteOrderBook;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
    }
}