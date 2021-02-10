
namespace Kutuphane_Sistemi.UI.Student_Query
{
    partial class Student_Query_By_Name_Surname
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
            this.txt_student_s = new System.Windows.Forms.TextBox();
            this.txt_student_n = new System.Windows.Forms.TextBox();
            this.lbl_std_name = new System.Windows.Forms.Label();
            this.lbl_std_surname = new System.Windows.Forms.Label();
            this.btn_scan_st_n_s = new System.Windows.Forms.Button();
            this.student_dgw = new System.Windows.Forms.DataGridView();
            this.kutuphaneDataSet = new Kutuphane_Sistemi.DataSet.kutuphaneDataSet();
            this.btn_print = new System.Windows.Forms.Button();
            this.grp_check_info = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_info = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_book_name = new System.Windows.Forms.TextBox();
            this.txt_can_take = new System.Windows.Forms.TextBox();
            this.txt_st_penalty = new System.Windows.Forms.TextBox();
            this.txt_st_gender = new System.Windows.Forms.TextBox();
            this.txt_st_tr_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_st_surname = new System.Windows.Forms.TextBox();
            this.txt_st_name = new System.Windows.Forms.TextBox();
            this.txt_st_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.student_dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).BeginInit();
            this.grp_check_info.SuspendLayout();
            this.grp_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_student_s
            // 
            this.txt_student_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_student_s.Location = new System.Drawing.Point(187, 90);
            this.txt_student_s.Name = "txt_student_s";
            this.txt_student_s.Size = new System.Drawing.Size(360, 26);
            this.txt_student_s.TabIndex = 65;
            // 
            // txt_student_n
            // 
            this.txt_student_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_student_n.Location = new System.Drawing.Point(187, 24);
            this.txt_student_n.Name = "txt_student_n";
            this.txt_student_n.Size = new System.Drawing.Size(360, 26);
            this.txt_student_n.TabIndex = 64;
            // 
            // lbl_std_name
            // 
            this.lbl_std_name.AutoSize = true;
            this.lbl_std_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_std_name.Location = new System.Drawing.Point(60, 27);
            this.lbl_std_name.Name = "lbl_std_name";
            this.lbl_std_name.Size = new System.Drawing.Size(97, 20);
            this.lbl_std_name.TabIndex = 68;
            this.lbl_std_name.Text = "Öğrenci adı :";
            // 
            // lbl_std_surname
            // 
            this.lbl_std_surname.AutoSize = true;
            this.lbl_std_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_std_surname.Location = new System.Drawing.Point(11, 96);
            this.lbl_std_surname.Name = "lbl_std_surname";
            this.lbl_std_surname.Size = new System.Drawing.Size(146, 20);
            this.lbl_std_surname.TabIndex = 69;
            this.lbl_std_surname.Text = "Öğrencinin soyadı : ";
            // 
            // btn_scan_st_n_s
            // 
            this.btn_scan_st_n_s.BackColor = System.Drawing.Color.Thistle;
            this.btn_scan_st_n_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scan_st_n_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_scan_st_n_s.Location = new System.Drawing.Point(580, 27);
            this.btn_scan_st_n_s.Name = "btn_scan_st_n_s";
            this.btn_scan_st_n_s.Size = new System.Drawing.Size(130, 89);
            this.btn_scan_st_n_s.TabIndex = 70;
            this.btn_scan_st_n_s.Text = "Tarat";
            this.btn_scan_st_n_s.UseVisualStyleBackColor = false;
            this.btn_scan_st_n_s.Click += new System.EventHandler(this.btn_scan_st_n_s_Click);
            // 
            // student_dgw
            // 
            this.student_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.student_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_dgw.Location = new System.Drawing.Point(-1, 147);
            this.student_dgw.Name = "student_dgw";
            this.student_dgw.Size = new System.Drawing.Size(1002, 353);
            this.student_dgw.TabIndex = 71;
            this.student_dgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_dgw_CellDoubleClick);
            // 
            // kutuphaneDataSet
            // 
            this.kutuphaneDataSet.DataSetName = "kutuphaneDataSet";
            this.kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Thistle;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_print.Location = new System.Drawing.Point(909, 530);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(92, 193);
            this.btn_print.TabIndex = 72;
            this.btn_print.Text = "Sayfalara yukarıdaki bilgileri götür";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // grp_check_info
            // 
            this.grp_check_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grp_check_info.Controls.Add(this.checkBox4);
            this.grp_check_info.Controls.Add(this.checkBox3);
            this.grp_check_info.Controls.Add(this.checkBox2);
            this.grp_check_info.Controls.Add(this.checkBox1);
            this.grp_check_info.Controls.Add(this.label1);
            this.grp_check_info.Location = new System.Drawing.Point(747, 12);
            this.grp_check_info.Name = "grp_check_info";
            this.grp_check_info.Size = new System.Drawing.Size(254, 112);
            this.grp_check_info.TabIndex = 78;
            this.grp_check_info.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox4.Location = new System.Drawing.Point(19, 78);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(163, 24);
            this.checkBox4.TabIndex = 82;
            this.checkBox4.Text = "TC Kimlik Numarası";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox3.Location = new System.Drawing.Point(137, 48);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 24);
            this.checkBox3.TabIndex = 81;
            this.checkBox3.Text = "Soyadı";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox2.Location = new System.Drawing.Point(83, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 24);
            this.checkBox2.TabIndex = 80;
            this.checkBox2.Text = "Adı";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox1.Location = new System.Drawing.Point(19, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 24);
            this.checkBox1.TabIndex = 79;
            this.checkBox1.Text = "ID";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Sayfalara Götürülecek Bilgiler";
            // 
            // grp_info
            // 
            this.grp_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grp_info.Controls.Add(this.label9);
            this.grp_info.Controls.Add(this.label6);
            this.grp_info.Controls.Add(this.txt_book_name);
            this.grp_info.Controls.Add(this.txt_can_take);
            this.grp_info.Controls.Add(this.txt_st_penalty);
            this.grp_info.Controls.Add(this.txt_st_gender);
            this.grp_info.Controls.Add(this.txt_st_tr_id);
            this.grp_info.Controls.Add(this.label8);
            this.grp_info.Controls.Add(this.label7);
            this.grp_info.Controls.Add(this.label5);
            this.grp_info.Controls.Add(this.txt_st_surname);
            this.grp_info.Controls.Add(this.txt_st_name);
            this.grp_info.Controls.Add(this.txt_st_id);
            this.grp_info.Controls.Add(this.label4);
            this.grp_info.Controls.Add(this.label3);
            this.grp_info.Controls.Add(this.label2);
            this.grp_info.Enabled = false;
            this.grp_info.Location = new System.Drawing.Point(-1, 530);
            this.grp_info.Name = "grp_info";
            this.grp_info.Size = new System.Drawing.Size(893, 193);
            this.grp_info.TabIndex = 79;
            this.grp_info.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(496, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 98;
            this.label9.Text = "Aldığı Kitabın İsmi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(509, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Kitap  Alabilir Mi :";
            // 
            // txt_book_name
            // 
            this.txt_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_book_name.Location = new System.Drawing.Point(642, 145);
            this.txt_book_name.Name = "txt_book_name";
            this.txt_book_name.Size = new System.Drawing.Size(240, 26);
            this.txt_book_name.TabIndex = 96;
            // 
            // txt_can_take
            // 
            this.txt_can_take.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_can_take.Location = new System.Drawing.Point(642, 98);
            this.txt_can_take.Name = "txt_can_take";
            this.txt_can_take.Size = new System.Drawing.Size(240, 26);
            this.txt_can_take.TabIndex = 95;
            // 
            // txt_st_penalty
            // 
            this.txt_st_penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_st_penalty.Location = new System.Drawing.Point(642, 55);
            this.txt_st_penalty.Name = "txt_st_penalty";
            this.txt_st_penalty.Size = new System.Drawing.Size(240, 26);
            this.txt_st_penalty.TabIndex = 94;
            // 
            // txt_st_gender
            // 
            this.txt_st_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_st_gender.Location = new System.Drawing.Point(642, 14);
            this.txt_st_gender.Name = "txt_st_gender";
            this.txt_st_gender.Size = new System.Drawing.Size(240, 26);
            this.txt_st_gender.TabIndex = 93;
            // 
            // txt_st_tr_id
            // 
            this.txt_st_tr_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_st_tr_id.Location = new System.Drawing.Point(175, 145);
            this.txt_st_tr_id.Name = "txt_st_tr_id";
            this.txt_st_tr_id.Size = new System.Drawing.Size(206, 26);
            this.txt_st_tr_id.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(407, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 20);
            this.label8.TabIndex = 91;
            this.label8.Text = "Varsa Cezasının Biteceği Tarih : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(564, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Öğrenci TC Kimlik No : ";
            // 
            // txt_st_surname
            // 
            this.txt_st_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_st_surname.Location = new System.Drawing.Point(175, 98);
            this.txt_st_surname.Name = "txt_st_surname";
            this.txt_st_surname.Size = new System.Drawing.Size(206, 26);
            this.txt_st_surname.TabIndex = 87;
            // 
            // txt_st_name
            // 
            this.txt_st_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_st_name.Location = new System.Drawing.Point(175, 55);
            this.txt_st_name.Name = "txt_st_name";
            this.txt_st_name.Size = new System.Drawing.Size(206, 26);
            this.txt_st_name.TabIndex = 86;
            // 
            // txt_st_id
            // 
            this.txt_st_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_st_id.Location = new System.Drawing.Point(175, 19);
            this.txt_st_id.Name = "txt_st_id";
            this.txt_st_id.Size = new System.Drawing.Size(206, 26);
            this.txt_st_id.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(122, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "ID :";
            // 
            // Student_Query_By_Name_Surname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1002, 758);
            this.ControlBox = false;
            this.Controls.Add(this.grp_info);
            this.Controls.Add(this.grp_check_info);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.student_dgw);
            this.Controls.Add(this.btn_scan_st_n_s);
            this.Controls.Add(this.lbl_std_surname);
            this.Controls.Add(this.txt_student_s);
            this.Controls.Add(this.txt_student_n);
            this.Controls.Add(this.lbl_std_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Query_By_Name_Surname";
            this.Text = "Student_Query_By_Name_Surname";
            ((System.ComponentModel.ISupportInitialize)(this.student_dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).EndInit();
            this.grp_check_info.ResumeLayout(false);
            this.grp_check_info.PerformLayout();
            this.grp_info.ResumeLayout(false);
            this.grp_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_student_s;
        private System.Windows.Forms.TextBox txt_student_n;
        private System.Windows.Forms.Label lbl_std_name;
        private System.Windows.Forms.Label lbl_std_surname;
        private System.Windows.Forms.Button btn_scan_st_n_s;
        private System.Windows.Forms.DataGridView student_dgw;
        private System.Windows.Forms.Button btn_print;
        private DataSet.kutuphaneDataSet kutuphaneDataSet;
        private System.Windows.Forms.GroupBox grp_check_info;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_info;
        private System.Windows.Forms.TextBox txt_st_surname;
        private System.Windows.Forms.TextBox txt_st_name;
        private System.Windows.Forms.TextBox txt_st_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_book_name;
        private System.Windows.Forms.TextBox txt_can_take;
        private System.Windows.Forms.TextBox txt_st_penalty;
        private System.Windows.Forms.TextBox txt_st_gender;
        private System.Windows.Forms.TextBox txt_st_tr_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}