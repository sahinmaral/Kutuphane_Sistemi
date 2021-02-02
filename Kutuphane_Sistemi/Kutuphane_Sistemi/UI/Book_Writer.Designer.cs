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
            this.btn_find_student_no = new System.Windows.Forms.Button();
            this.txt_student_s = new System.Windows.Forms.TextBox();
            this.txt_student_n = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_writer_code = new System.Windows.Forms.Label();
            this.pnl_writer_info = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.kitap_dgw = new System.Windows.Forms.DataGridView();
            this.kitapnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarnoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinantarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimedilecektarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimedildimiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet = new Kutuphane_Sistemi.DataSet.kutuphaneDataSet();
            this.yazar_dgw = new System.Windows.Forms.DataGridView();
            this.yazarnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazaradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_scan_writer = new System.Windows.Forms.Button();
            this.dt_now = new System.Windows.Forms.DateTimePicker();
            this.btn_delete_order_book = new System.Windows.Forms.Button();
            this.txt_book_name = new System.Windows.Forms.TextBox();
            this.txt_student_no = new System.Windows.Forms.TextBox();
            this.btn_order_book = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_writer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yazarTableAdapter = new Kutuphane_Sistemi.DataSet.kutuphaneDataSetTableAdapters.yazarTableAdapter();
            this.kitapTableAdapter = new Kutuphane_Sistemi.DataSet.kutuphaneDataSetTableAdapters.kitapTableAdapter();
            this.btn_find_student_name = new System.Windows.Forms.Button();
            this.pnl_writer_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazar_dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_scan_writer_book
            // 
            this.btn_scan_writer_book.BackColor = System.Drawing.Color.Thistle;
            this.btn_scan_writer_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scan_writer_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_scan_writer_book.Location = new System.Drawing.Point(483, 56);
            this.btn_scan_writer_book.Margin = new System.Windows.Forms.Padding(4);
            this.btn_scan_writer_book.Name = "btn_scan_writer_book";
            this.btn_scan_writer_book.Size = new System.Drawing.Size(177, 36);
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
            this.lbl_writer_s.Location = new System.Drawing.Point(347, 9);
            this.lbl_writer_s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_writer_s.Name = "lbl_writer_s";
            this.lbl_writer_s.Size = new System.Drawing.Size(34, 25);
            this.lbl_writer_s.TabIndex = 25;
            this.lbl_writer_s.Text = "00";
            // 
            // lbl_writer_n
            // 
            this.lbl_writer_n.AutoSize = true;
            this.lbl_writer_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_writer_n.Location = new System.Drawing.Point(259, 9);
            this.lbl_writer_n.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_writer_n.Name = "lbl_writer_n";
            this.lbl_writer_n.Size = new System.Drawing.Size(34, 25);
            this.lbl_writer_n.TabIndex = 24;
            this.lbl_writer_n.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Yazarın Adı , Soyadı :";
            // 
            // btn_find_student_no
            // 
            this.btn_find_student_no.BackColor = System.Drawing.Color.Thistle;
            this.btn_find_student_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find_student_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_find_student_no.Location = new System.Drawing.Point(13, 785);
            this.btn_find_student_no.Margin = new System.Windows.Forms.Padding(4);
            this.btn_find_student_no.Name = "btn_find_student_no";
            this.btn_find_student_no.Size = new System.Drawing.Size(164, 39);
            this.btn_find_student_no.TabIndex = 8;
            this.btn_find_student_no.Text = "Öğrenci no bul";
            this.btn_find_student_no.UseVisualStyleBackColor = false;
            this.btn_find_student_no.Click += new System.EventHandler(this.btn_find_student_no_Click);
            // 
            // txt_student_s
            // 
            this.txt_student_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_student_s.Location = new System.Drawing.Point(472, 577);
            this.txt_student_s.Margin = new System.Windows.Forms.Padding(4);
            this.txt_student_s.Name = "txt_student_s";
            this.txt_student_s.Size = new System.Drawing.Size(170, 30);
            this.txt_student_s.TabIndex = 4;
            // 
            // txt_student_n
            // 
            this.txt_student_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_student_n.Location = new System.Drawing.Point(273, 577);
            this.txt_student_n.Margin = new System.Windows.Forms.Padding(4);
            this.txt_student_n.Name = "txt_student_n";
            this.txt_student_n.Size = new System.Drawing.Size(191, 30);
            this.txt_student_n.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 581);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Öğrenci adı , soyadı :";
            // 
            // lbl_writer_code
            // 
            this.lbl_writer_code.AutoSize = true;
            this.lbl_writer_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_writer_code.Location = new System.Drawing.Point(259, 44);
            this.lbl_writer_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_writer_code.Name = "lbl_writer_code";
            this.lbl_writer_code.Size = new System.Drawing.Size(34, 25);
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
            this.pnl_writer_info.Location = new System.Drawing.Point(757, 12);
            this.pnl_writer_info.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_writer_info.Name = "pnl_writer_info";
            this.pnl_writer_info.Size = new System.Drawing.Size(879, 80);
            this.pnl_writer_info.TabIndex = 35;
            this.pnl_writer_info.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Yazarın kodu :";
            // 
            // kitap_dgw
            // 
            this.kitap_dgw.AutoGenerateColumns = false;
            this.kitap_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitap_dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.kitap_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapnoDataGridViewTextBoxColumn,
            this.isbnnoDataGridViewTextBoxColumn,
            this.kitapadiDataGridViewTextBoxColumn,
            this.yazarnoDataGridViewTextBoxColumn1,
            this.turnoDataGridViewTextBoxColumn,
            this.sayfasayisiDataGridViewTextBoxColumn,
            this.ogrnoDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.alinantarihDataGridViewTextBoxColumn,
            this.teslimedilecektarihDataGridViewTextBoxColumn,
            this.teslimedildimiDataGridViewCheckBoxColumn});
            this.kitap_dgw.DataSource = this.kitapBindingSource;
            this.kitap_dgw.Location = new System.Drawing.Point(674, 100);
            this.kitap_dgw.Margin = new System.Windows.Forms.Padding(4);
            this.kitap_dgw.Name = "kitap_dgw";
            this.kitap_dgw.RowHeadersWidth = 51;
            this.kitap_dgw.Size = new System.Drawing.Size(962, 453);
            this.kitap_dgw.TabIndex = 34;
            this.kitap_dgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitap_dgw_CellDoubleClick);
            // 
            // kitapnoDataGridViewTextBoxColumn
            // 
            this.kitapnoDataGridViewTextBoxColumn.DataPropertyName = "kitapno";
            this.kitapnoDataGridViewTextBoxColumn.HeaderText = "kitapno";
            this.kitapnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapnoDataGridViewTextBoxColumn.Name = "kitapnoDataGridViewTextBoxColumn";
            this.kitapnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnnoDataGridViewTextBoxColumn
            // 
            this.isbnnoDataGridViewTextBoxColumn.DataPropertyName = "isbnno";
            this.isbnnoDataGridViewTextBoxColumn.HeaderText = "isbnno";
            this.isbnnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnnoDataGridViewTextBoxColumn.Name = "isbnnoDataGridViewTextBoxColumn";
            // 
            // kitapadiDataGridViewTextBoxColumn
            // 
            this.kitapadiDataGridViewTextBoxColumn.DataPropertyName = "kitapadi";
            this.kitapadiDataGridViewTextBoxColumn.HeaderText = "kitapadi";
            this.kitapadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapadiDataGridViewTextBoxColumn.Name = "kitapadiDataGridViewTextBoxColumn";
            // 
            // yazarnoDataGridViewTextBoxColumn1
            // 
            this.yazarnoDataGridViewTextBoxColumn1.DataPropertyName = "yazarno";
            this.yazarnoDataGridViewTextBoxColumn1.HeaderText = "yazarno";
            this.yazarnoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.yazarnoDataGridViewTextBoxColumn1.Name = "yazarnoDataGridViewTextBoxColumn1";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            // 
            // sayfasayisiDataGridViewTextBoxColumn
            // 
            this.sayfasayisiDataGridViewTextBoxColumn.DataPropertyName = "sayfasayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.HeaderText = "sayfasayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sayfasayisiDataGridViewTextBoxColumn.Name = "sayfasayisiDataGridViewTextBoxColumn";
            // 
            // ogrnoDataGridViewTextBoxColumn
            // 
            this.ogrnoDataGridViewTextBoxColumn.DataPropertyName = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.HeaderText = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrnoDataGridViewTextBoxColumn.Name = "ogrnoDataGridViewTextBoxColumn";
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // alinantarihDataGridViewTextBoxColumn
            // 
            this.alinantarihDataGridViewTextBoxColumn.DataPropertyName = "alinantarih";
            this.alinantarihDataGridViewTextBoxColumn.HeaderText = "alinantarih";
            this.alinantarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alinantarihDataGridViewTextBoxColumn.Name = "alinantarihDataGridViewTextBoxColumn";
            // 
            // teslimedilecektarihDataGridViewTextBoxColumn
            // 
            this.teslimedilecektarihDataGridViewTextBoxColumn.DataPropertyName = "teslimedilecektarih";
            this.teslimedilecektarihDataGridViewTextBoxColumn.HeaderText = "teslimedilecektarih";
            this.teslimedilecektarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teslimedilecektarihDataGridViewTextBoxColumn.Name = "teslimedilecektarihDataGridViewTextBoxColumn";
            // 
            // teslimedildimiDataGridViewCheckBoxColumn
            // 
            this.teslimedildimiDataGridViewCheckBoxColumn.DataPropertyName = "teslimedildimi";
            this.teslimedildimiDataGridViewCheckBoxColumn.HeaderText = "teslimedildimi";
            this.teslimedildimiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.teslimedildimiDataGridViewCheckBoxColumn.Name = "teslimedildimiDataGridViewCheckBoxColumn";
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "kitap";
            this.kitapBindingSource.DataSource = this.kutuphaneDataSetBindingSource;
            // 
            // kutuphaneDataSetBindingSource
            // 
            this.kutuphaneDataSetBindingSource.DataSource = this.kutuphaneDataSet;
            this.kutuphaneDataSetBindingSource.Position = 0;
            // 
            // kutuphaneDataSet
            // 
            this.kutuphaneDataSet.DataSetName = "kutuphaneDataSet";
            this.kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazar_dgw
            // 
            this.yazar_dgw.AutoGenerateColumns = false;
            this.yazar_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.yazar_dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.yazar_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yazar_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yazarnoDataGridViewTextBoxColumn,
            this.yazaradDataGridViewTextBoxColumn,
            this.yazarsoyadDataGridViewTextBoxColumn});
            this.yazar_dgw.DataSource = this.yazarBindingSource;
            this.yazar_dgw.Location = new System.Drawing.Point(21, 100);
            this.yazar_dgw.Margin = new System.Windows.Forms.Padding(4);
            this.yazar_dgw.Name = "yazar_dgw";
            this.yazar_dgw.RowHeadersWidth = 51;
            this.yazar_dgw.Size = new System.Drawing.Size(639, 453);
            this.yazar_dgw.TabIndex = 33;
            this.yazar_dgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yazar_dgw_CellDoubleClick);
            // 
            // yazarnoDataGridViewTextBoxColumn
            // 
            this.yazarnoDataGridViewTextBoxColumn.DataPropertyName = "yazarno";
            this.yazarnoDataGridViewTextBoxColumn.HeaderText = "yazarno";
            this.yazarnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarnoDataGridViewTextBoxColumn.Name = "yazarnoDataGridViewTextBoxColumn";
            this.yazarnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yazaradDataGridViewTextBoxColumn
            // 
            this.yazaradDataGridViewTextBoxColumn.DataPropertyName = "yazarad";
            this.yazaradDataGridViewTextBoxColumn.HeaderText = "yazarad";
            this.yazaradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazaradDataGridViewTextBoxColumn.Name = "yazaradDataGridViewTextBoxColumn";
            // 
            // yazarsoyadDataGridViewTextBoxColumn
            // 
            this.yazarsoyadDataGridViewTextBoxColumn.DataPropertyName = "yazarsoyad";
            this.yazarsoyadDataGridViewTextBoxColumn.HeaderText = "yazarsoyad";
            this.yazarsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarsoyadDataGridViewTextBoxColumn.Name = "yazarsoyadDataGridViewTextBoxColumn";
            // 
            // yazarBindingSource
            // 
            this.yazarBindingSource.DataMember = "yazar";
            this.yazarBindingSource.DataSource = this.kutuphaneDataSetBindingSource;
            // 
            // btn_scan_writer
            // 
            this.btn_scan_writer.BackColor = System.Drawing.Color.Thistle;
            this.btn_scan_writer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scan_writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_scan_writer.Location = new System.Drawing.Point(317, 56);
            this.btn_scan_writer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_scan_writer.Name = "btn_scan_writer";
            this.btn_scan_writer.Size = new System.Drawing.Size(136, 36);
            this.btn_scan_writer.TabIndex = 1;
            this.btn_scan_writer.Text = "Tarat";
            this.btn_scan_writer.UseVisualStyleBackColor = false;
            this.btn_scan_writer.Click += new System.EventHandler(this.btn_scan_writer_Click);
            // 
            // dt_now
            // 
            this.dt_now.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_now.Location = new System.Drawing.Point(273, 732);
            this.dt_now.Margin = new System.Windows.Forms.Padding(4);
            this.dt_now.Name = "dt_now";
            this.dt_now.Size = new System.Drawing.Size(369, 30);
            this.dt_now.TabIndex = 7;
            // 
            // btn_delete_order_book
            // 
            this.btn_delete_order_book.BackColor = System.Drawing.Color.Thistle;
            this.btn_delete_order_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_order_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete_order_book.Location = new System.Drawing.Point(489, 785);
            this.btn_delete_order_book.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete_order_book.Name = "btn_delete_order_book";
            this.btn_delete_order_book.Size = new System.Drawing.Size(153, 39);
            this.btn_delete_order_book.TabIndex = 10;
            this.btn_delete_order_book.Text = "Kitabı iade et";
            this.btn_delete_order_book.UseVisualStyleBackColor = false;
            this.btn_delete_order_book.Click += new System.EventHandler(this.btn_delete_order_book_Click);
            // 
            // txt_book_name
            // 
            this.txt_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_book_name.Location = new System.Drawing.Point(273, 677);
            this.txt_book_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_book_name.Name = "txt_book_name";
            this.txt_book_name.Size = new System.Drawing.Size(369, 30);
            this.txt_book_name.TabIndex = 6;
            // 
            // txt_student_no
            // 
            this.txt_student_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_student_no.Location = new System.Drawing.Point(273, 624);
            this.txt_student_no.Margin = new System.Windows.Forms.Padding(4);
            this.txt_student_no.Name = "txt_student_no";
            this.txt_student_no.Size = new System.Drawing.Size(369, 30);
            this.txt_student_no.TabIndex = 5;
            // 
            // btn_order_book
            // 
            this.btn_order_book.BackColor = System.Drawing.Color.Thistle;
            this.btn_order_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_order_book.Location = new System.Drawing.Point(357, 785);
            this.btn_order_book.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order_book.Name = "btn_order_book";
            this.btn_order_book.Size = new System.Drawing.Size(124, 39);
            this.btn_order_book.TabIndex = 9;
            this.btn_order_book.Text = "Kitabı al";
            this.btn_order_book.UseVisualStyleBackColor = false;
            this.btn_order_book.Click += new System.EventHandler(this.btn_order_book_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(99, 737);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Şu anki tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(135, 683);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kitap adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(108, 626);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Öğrenci no : ";
            // 
            // txt_writer
            // 
            this.txt_writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_writer.Location = new System.Drawing.Point(317, 16);
            this.txt_writer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_writer.Name = "txt_writer";
            this.txt_writer.Size = new System.Drawing.Size(343, 30);
            this.txt_writer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kitabın yazarının adını giriniz :";
            // 
            // yazarTableAdapter
            // 
            this.yazarTableAdapter.ClearBeforeFill = true;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // btn_find_student_name
            // 
            this.btn_find_student_name.BackColor = System.Drawing.Color.Thistle;
            this.btn_find_student_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find_student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_find_student_name.Location = new System.Drawing.Point(185, 785);
            this.btn_find_student_name.Margin = new System.Windows.Forms.Padding(4);
            this.btn_find_student_name.Name = "btn_find_student_name";
            this.btn_find_student_name.Size = new System.Drawing.Size(164, 39);
            this.btn_find_student_name.TabIndex = 38;
            this.btn_find_student_name.Text = "Öğrenci adı bul";
            this.btn_find_student_name.UseVisualStyleBackColor = false;
            this.btn_find_student_name.Click += new System.EventHandler(this.btn_find_student_name_Click);
            // 
            // Book_Writer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1669, 870);
            this.ControlBox = false;
            this.Controls.Add(this.btn_find_student_name);
            this.Controls.Add(this.btn_scan_writer_book);
            this.Controls.Add(this.btn_find_student_no);
            this.Controls.Add(this.txt_student_s);
            this.Controls.Add(this.txt_student_n);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnl_writer_info);
            this.Controls.Add(this.kitap_dgw);
            this.Controls.Add(this.yazar_dgw);
            this.Controls.Add(this.btn_scan_writer);
            this.Controls.Add(this.dt_now);
            this.Controls.Add(this.btn_delete_order_book);
            this.Controls.Add(this.txt_book_name);
            this.Controls.Add(this.txt_student_no);
            this.Controls.Add(this.btn_order_book);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_writer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Book_Writer";
            this.Text = "Book";
            this.pnl_writer_info.ResumeLayout(false);
            this.pnl_writer_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazar_dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_scan_writer_book;
        private System.Windows.Forms.Label lbl_writer_s;
        private System.Windows.Forms.Label lbl_writer_n;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_find_student_no;
        private System.Windows.Forms.TextBox txt_student_s;
        private System.Windows.Forms.TextBox txt_student_n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_writer_code;
        private System.Windows.Forms.Panel pnl_writer_info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView kitap_dgw;
        private System.Windows.Forms.DataGridView yazar_dgw;
        private System.Windows.Forms.Button btn_scan_writer;
        private System.Windows.Forms.DateTimePicker dt_now;
        private System.Windows.Forms.Button btn_delete_order_book;
        private System.Windows.Forms.TextBox txt_book_name;
        private System.Windows.Forms.TextBox txt_student_no;
        private System.Windows.Forms.Button btn_order_book;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_writer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kutuphaneDataSetBindingSource;
        private DataSet.kutuphaneDataSet kutuphaneDataSet;
        private System.Windows.Forms.BindingSource yazarBindingSource;
        private DataSet.kutuphaneDataSetTableAdapters.yazarTableAdapter yazarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazaradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private DataSet.kutuphaneDataSetTableAdapters.kitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarnoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinantarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimedilecektarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn teslimedildimiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btn_find_student_name;
    }
}