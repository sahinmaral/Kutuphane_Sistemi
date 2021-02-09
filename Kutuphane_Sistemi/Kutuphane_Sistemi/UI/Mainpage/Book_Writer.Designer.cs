namespace Kutuphane_Sistemi.UI
{
    partial class Book_Writer
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
            this.btn_scan_writer_book = new System.Windows.Forms.Button();
            this.lbl_writer_s = new System.Windows.Forms.Label();
            this.lbl_writer_n = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_writer_code = new System.Windows.Forms.Label();
            this.pnl_writer_info = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.book_dgw = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takendateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isdeliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet = new Kutuphane_Sistemi.DataSet.kutuphaneDataSet();
            this.writer_dgw = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writersurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_scan_writer = new System.Windows.Forms.Button();
            this.txt_writer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_order_book = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_student_s = new System.Windows.Forms.TextBox();
            this.txt_student_n = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_now = new System.Windows.Forms.DateTimePicker();
            this.btn_delete_order_book = new System.Windows.Forms.Button();
            this.txt_book_name = new System.Windows.Forms.TextBox();
            this.txt_student_no = new System.Windows.Forms.TextBox();
            this.btn_order_book = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.writerTableAdapter = new Kutuphane_Sistemi.DataSet.kutuphaneDataSetTableAdapters.writerTableAdapter();
            this.bookTableAdapter = new Kutuphane_Sistemi.DataSet.kutuphaneDataSetTableAdapters.bookTableAdapter();
            this.pnl_writer_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writer_dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).BeginInit();
            this.grp_order_book.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_scan_writer_book
            // 
            this.btn_scan_writer_book.BackColor = System.Drawing.Color.Thistle;
            this.btn_scan_writer_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scan_writer_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_scan_writer_book.Location = new System.Drawing.Point(362, 46);
            this.btn_scan_writer_book.Name = "btn_scan_writer_book";
            this.btn_scan_writer_book.Size = new System.Drawing.Size(133, 29);
            this.btn_scan_writer_book.TabIndex = 2;
            this.btn_scan_writer_book.Text = "Kitaplarını Tarat";
            this.btn_scan_writer_book.UseVisualStyleBackColor = false;
            this.btn_scan_writer_book.Visible = false;
            this.btn_scan_writer_book.Click += new System.EventHandler(this.btn_scan_writer_book_Click);
            // 
            // lbl_writer_s
            // 
            this.lbl_writer_s.AutoSize = true;
            this.lbl_writer_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_writer_s.Location = new System.Drawing.Point(260, 7);
            this.lbl_writer_s.Name = "lbl_writer_s";
            this.lbl_writer_s.Size = new System.Drawing.Size(27, 20);
            this.lbl_writer_s.TabIndex = 25;
            this.lbl_writer_s.Text = "00";
            // 
            // lbl_writer_n
            // 
            this.lbl_writer_n.AutoSize = true;
            this.lbl_writer_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_writer_n.Location = new System.Drawing.Point(194, 7);
            this.lbl_writer_n.Name = "lbl_writer_n";
            this.lbl_writer_n.Size = new System.Drawing.Size(27, 20);
            this.lbl_writer_n.TabIndex = 24;
            this.lbl_writer_n.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Yazarın Adı , Soyadı :";
            // 
            // lbl_writer_code
            // 
            this.lbl_writer_code.AutoSize = true;
            this.lbl_writer_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_writer_code.Location = new System.Drawing.Point(194, 36);
            this.lbl_writer_code.Name = "lbl_writer_code";
            this.lbl_writer_code.Size = new System.Drawing.Size(27, 20);
            this.lbl_writer_code.TabIndex = 22;
            this.lbl_writer_code.Text = "00";
            this.lbl_writer_code.TextChanged += new System.EventHandler(this.lbl_writer_code_TextChanged);
            // 
            // pnl_writer_info
            // 
            this.pnl_writer_info.Controls.Add(this.lbl_writer_s);
            this.pnl_writer_info.Controls.Add(this.lbl_writer_n);
            this.pnl_writer_info.Controls.Add(this.label6);
            this.pnl_writer_info.Controls.Add(this.lbl_writer_code);
            this.pnl_writer_info.Controls.Add(this.label5);
            this.pnl_writer_info.Location = new System.Drawing.Point(686, 10);
            this.pnl_writer_info.Name = "pnl_writer_info";
            this.pnl_writer_info.Size = new System.Drawing.Size(554, 65);
            this.pnl_writer_info.TabIndex = 35;
            this.pnl_writer_info.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Yazarın kodu :";
            // 
            // book_dgw
            // 
            this.book_dgw.AutoGenerateColumns = false;
            this.book_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.book_dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.book_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.isbnnoDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.writernoDataGridViewTextBoxColumn,
            this.typenoDataGridViewTextBoxColumn,
            this.pageamountDataGridViewTextBoxColumn,
            this.stidDataGridViewTextBoxColumn,
            this.takendateDataGridViewTextBoxColumn,
            this.deliverydateDataGridViewTextBoxColumn,
            this.isdeliveredDataGridViewCheckBoxColumn});
            this.book_dgw.DataSource = this.bookBindingSource;
            this.book_dgw.Location = new System.Drawing.Point(16, 400);
            this.book_dgw.Name = "book_dgw";
            this.book_dgw.RowHeadersWidth = 51;
            this.book_dgw.Size = new System.Drawing.Size(1224, 424);
            this.book_dgw.TabIndex = 34;
            this.book_dgw.Visible = false;
            this.book_dgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.book_dgw_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isbnnoDataGridViewTextBoxColumn
            // 
            this.isbnnoDataGridViewTextBoxColumn.DataPropertyName = "isbn_no";
            this.isbnnoDataGridViewTextBoxColumn.HeaderText = "ISBN No";
            this.isbnnoDataGridViewTextBoxColumn.Name = "isbnnoDataGridViewTextBoxColumn";
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            // 
            // writernoDataGridViewTextBoxColumn
            // 
            this.writernoDataGridViewTextBoxColumn.DataPropertyName = "writer_no";
            this.writernoDataGridViewTextBoxColumn.HeaderText = "Yazar No";
            this.writernoDataGridViewTextBoxColumn.Name = "writernoDataGridViewTextBoxColumn";
            // 
            // typenoDataGridViewTextBoxColumn
            // 
            this.typenoDataGridViewTextBoxColumn.DataPropertyName = "type_no";
            this.typenoDataGridViewTextBoxColumn.HeaderText = "Tür No";
            this.typenoDataGridViewTextBoxColumn.Name = "typenoDataGridViewTextBoxColumn";
            // 
            // pageamountDataGridViewTextBoxColumn
            // 
            this.pageamountDataGridViewTextBoxColumn.DataPropertyName = "page_amount";
            this.pageamountDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            this.pageamountDataGridViewTextBoxColumn.Name = "pageamountDataGridViewTextBoxColumn";
            // 
            // stidDataGridViewTextBoxColumn
            // 
            this.stidDataGridViewTextBoxColumn.DataPropertyName = "st_id";
            this.stidDataGridViewTextBoxColumn.HeaderText = "Öğrenci ID";
            this.stidDataGridViewTextBoxColumn.Name = "stidDataGridViewTextBoxColumn";
            // 
            // takendateDataGridViewTextBoxColumn
            // 
            this.takendateDataGridViewTextBoxColumn.DataPropertyName = "taken_date";
            this.takendateDataGridViewTextBoxColumn.HeaderText = "Alınan Tarih";
            this.takendateDataGridViewTextBoxColumn.Name = "takendateDataGridViewTextBoxColumn";
            // 
            // deliverydateDataGridViewTextBoxColumn
            // 
            this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "delivery_date";
            this.deliverydateDataGridViewTextBoxColumn.HeaderText = "Teslim Edilecek Tarih";
            this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
            // 
            // isdeliveredDataGridViewCheckBoxColumn
            // 
            this.isdeliveredDataGridViewCheckBoxColumn.DataPropertyName = "is_delivered";
            this.isdeliveredDataGridViewCheckBoxColumn.HeaderText = "Teslim Edildi Mi";
            this.isdeliveredDataGridViewCheckBoxColumn.Name = "isdeliveredDataGridViewCheckBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.kutuphaneDataSet;
            // 
            // kutuphaneDataSet
            // 
            this.kutuphaneDataSet.DataSetName = "kutuphaneDataSet";
            this.kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // writer_dgw
            // 
            this.writer_dgw.AutoGenerateColumns = false;
            this.writer_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.writer_dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.writer_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.writer_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.writernameDataGridViewTextBoxColumn,
            this.writersurnameDataGridViewTextBoxColumn});
            this.writer_dgw.DataSource = this.writerBindingSource;
            this.writer_dgw.Location = new System.Drawing.Point(16, 82);
            this.writer_dgw.Name = "writer_dgw";
            this.writer_dgw.RowHeadersWidth = 51;
            this.writer_dgw.Size = new System.Drawing.Size(1224, 312);
            this.writer_dgw.TabIndex = 33;
            this.writer_dgw.Visible = false;
            this.writer_dgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.writer_dgw_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // writernameDataGridViewTextBoxColumn
            // 
            this.writernameDataGridViewTextBoxColumn.DataPropertyName = "writer_name";
            this.writernameDataGridViewTextBoxColumn.HeaderText = "Yazarın Adı";
            this.writernameDataGridViewTextBoxColumn.Name = "writernameDataGridViewTextBoxColumn";
            // 
            // writersurnameDataGridViewTextBoxColumn
            // 
            this.writersurnameDataGridViewTextBoxColumn.DataPropertyName = "writer_surname";
            this.writersurnameDataGridViewTextBoxColumn.HeaderText = "Yazarın Soyadı";
            this.writersurnameDataGridViewTextBoxColumn.Name = "writersurnameDataGridViewTextBoxColumn";
            // 
            // writerBindingSource
            // 
            this.writerBindingSource.DataMember = "writer";
            this.writerBindingSource.DataSource = this.kutuphaneDataSet;
            // 
            // btn_scan_writer
            // 
            this.btn_scan_writer.BackColor = System.Drawing.Color.Thistle;
            this.btn_scan_writer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scan_writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_scan_writer.Location = new System.Drawing.Point(238, 46);
            this.btn_scan_writer.Name = "btn_scan_writer";
            this.btn_scan_writer.Size = new System.Drawing.Size(102, 29);
            this.btn_scan_writer.TabIndex = 1;
            this.btn_scan_writer.Text = "Tarat";
            this.btn_scan_writer.UseVisualStyleBackColor = false;
            this.btn_scan_writer.Click += new System.EventHandler(this.btn_scan_writer_Click);
            // 
            // txt_writer
            // 
            this.txt_writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_writer.Location = new System.Drawing.Point(238, 13);
            this.txt_writer.Name = "txt_writer";
            this.txt_writer.Size = new System.Drawing.Size(258, 26);
            this.txt_writer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kitabın yazarının adını giriniz :";
            // 
            // grp_order_book
            // 
            this.grp_order_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grp_order_book.Controls.Add(this.btn_refresh);
            this.grp_order_book.Controls.Add(this.txt_student_s);
            this.grp_order_book.Controls.Add(this.txt_student_n);
            this.grp_order_book.Controls.Add(this.label7);
            this.grp_order_book.Controls.Add(this.dt_now);
            this.grp_order_book.Controls.Add(this.btn_delete_order_book);
            this.grp_order_book.Controls.Add(this.txt_book_name);
            this.grp_order_book.Controls.Add(this.txt_student_no);
            this.grp_order_book.Controls.Add(this.btn_order_book);
            this.grp_order_book.Controls.Add(this.label4);
            this.grp_order_book.Controls.Add(this.label3);
            this.grp_order_book.Controls.Add(this.label2);
            this.grp_order_book.Location = new System.Drawing.Point(17, 841);
            this.grp_order_book.Name = "grp_order_book";
            this.grp_order_book.Size = new System.Drawing.Size(646, 233);
            this.grp_order_book.TabIndex = 36;
            this.grp_order_book.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_refresh.Image = global::Kutuphane_Sistemi.Properties.Resources.refresh_30;
            this.btn_refresh.Location = new System.Drawing.Point(28, 188);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(30, 30);
            this.btn_refresh.TabIndex = 64;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_student_s
            // 
            this.txt_student_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_student_s.Location = new System.Drawing.Point(353, 19);
            this.txt_student_s.Name = "txt_student_s";
            this.txt_student_s.Size = new System.Drawing.Size(128, 26);
            this.txt_student_s.TabIndex = 53;
            // 
            // txt_student_n
            // 
            this.txt_student_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_student_n.Location = new System.Drawing.Point(204, 19);
            this.txt_student_n.Name = "txt_student_n";
            this.txt_student_n.Size = new System.Drawing.Size(144, 26);
            this.txt_student_n.TabIndex = 52;
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
            // dt_now
            // 
            this.dt_now.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_now.Location = new System.Drawing.Point(204, 145);
            this.dt_now.Name = "dt_now";
            this.dt_now.Size = new System.Drawing.Size(278, 26);
            this.dt_now.TabIndex = 56;
            // 
            // btn_delete_order_book
            // 
            this.btn_delete_order_book.BackColor = System.Drawing.Color.Thistle;
            this.btn_delete_order_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_order_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete_order_book.Location = new System.Drawing.Point(510, 69);
            this.btn_delete_order_book.Name = "btn_delete_order_book";
            this.btn_delete_order_book.Size = new System.Drawing.Size(115, 35);
            this.btn_delete_order_book.TabIndex = 59;
            this.btn_delete_order_book.Text = "Kitabı iade et";
            this.btn_delete_order_book.UseVisualStyleBackColor = false;
            this.btn_delete_order_book.Click += new System.EventHandler(this.btn_delete_order_book_Click);
            // 
            // txt_book_name
            // 
            this.txt_book_name.Enabled = false;
            this.txt_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_book_name.Location = new System.Drawing.Point(204, 100);
            this.txt_book_name.Name = "txt_book_name";
            this.txt_book_name.Size = new System.Drawing.Size(278, 26);
            this.txt_book_name.TabIndex = 55;
            // 
            // txt_student_no
            // 
            this.txt_student_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_student_no.Location = new System.Drawing.Point(204, 57);
            this.txt_student_no.Name = "txt_student_no";
            this.txt_student_no.Size = new System.Drawing.Size(278, 26);
            this.txt_student_no.TabIndex = 54;
            // 
            // btn_order_book
            // 
            this.btn_order_book.BackColor = System.Drawing.Color.Thistle;
            this.btn_order_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_order_book.Location = new System.Drawing.Point(510, 19);
            this.btn_order_book.Name = "btn_order_book";
            this.btn_order_book.Size = new System.Drawing.Size(115, 40);
            this.btn_order_book.TabIndex = 58;
            this.btn_order_book.Text = "Kitabı al";
            this.btn_order_book.UseVisualStyleBackColor = false;
            this.btn_order_book.Click += new System.EventHandler(this.btn_order_book_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 149);
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
            // writerTableAdapter
            // 
            this.writerTableAdapter.ClearBeforeFill = true;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // Book_Writer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1252, 1100);
            this.ControlBox = false;
            this.Controls.Add(this.grp_order_book);
            this.Controls.Add(this.btn_scan_writer_book);
            this.Controls.Add(this.pnl_writer_info);
            this.Controls.Add(this.book_dgw);
            this.Controls.Add(this.writer_dgw);
            this.Controls.Add(this.btn_scan_writer);
            this.Controls.Add(this.txt_writer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book_Writer";
            this.Text = "Book";
            this.pnl_writer_info.ResumeLayout(false);
            this.pnl_writer_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writer_dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).EndInit();
            this.grp_order_book.ResumeLayout(false);
            this.grp_order_book.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_scan_writer_book;
        private System.Windows.Forms.Label lbl_writer_s;
        private System.Windows.Forms.Label lbl_writer_n;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_writer_code;
        private System.Windows.Forms.Panel pnl_writer_info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView book_dgw;
        private System.Windows.Forms.DataGridView writer_dgw;
        private System.Windows.Forms.Button btn_scan_writer;
        private System.Windows.Forms.TextBox txt_writer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_order_book;
        private System.Windows.Forms.TextBox txt_student_s;
        private System.Windows.Forms.TextBox txt_student_n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_now;
        private System.Windows.Forms.Button btn_delete_order_book;
        private System.Windows.Forms.TextBox txt_book_name;
        private System.Windows.Forms.TextBox txt_student_no;
        private System.Windows.Forms.Button btn_order_book;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DataSet.kutuphaneDataSet kutuphaneDataSet;
        private System.Windows.Forms.BindingSource writerBindingSource;
        private DataSet.kutuphaneDataSetTableAdapters.writerTableAdapter writerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writersurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DataSet.kutuphaneDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takendateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isdeliveredDataGridViewCheckBoxColumn;
    }
}