
namespace Kutuphane_Sistemi.UI.Student_Query
{
    partial class StudentQueryByNameSurname
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
            this.TxtScanStudentSurName = new System.Windows.Forms.TextBox();
            this.TxtScanStudentName = new System.Windows.Forms.TextBox();
            this.LblStudentName = new System.Windows.Forms.Label();
            this.LblStudentSurname = new System.Windows.Forms.Label();
            this.BtnScanStudent = new System.Windows.Forms.Button();
            this.DgwStudent = new System.Windows.Forms.DataGridView();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.GrpCheckInfo = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpInfo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTakenBookName = new System.Windows.Forms.TextBox();
            this.TxtCanTake = new System.Windows.Forms.TextBox();
            this.TxtStudentPenalty = new System.Windows.Forms.TextBox();
            this.TxtStudentGender = new System.Windows.Forms.TextBox();
            this.TxtStudentTurkishId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtStudentId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgwStudent)).BeginInit();
            this.GrpCheckInfo.SuspendLayout();
            this.GrpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtScanStudentSurName
            // 
            this.TxtScanStudentSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtScanStudentSurName.Location = new System.Drawing.Point(219, 98);
            this.TxtScanStudentSurName.Name = "TxtScanStudentSurName";
            this.TxtScanStudentSurName.Size = new System.Drawing.Size(360, 26);
            this.TxtScanStudentSurName.TabIndex = 65;
            // 
            // TxtScanStudentName
            // 
            this.TxtScanStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtScanStudentName.Location = new System.Drawing.Point(219, 32);
            this.TxtScanStudentName.Name = "TxtScanStudentName";
            this.TxtScanStudentName.Size = new System.Drawing.Size(360, 26);
            this.TxtScanStudentName.TabIndex = 64;
            // 
            // LblStudentName
            // 
            this.LblStudentName.AutoSize = true;
            this.LblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentName.Location = new System.Drawing.Point(92, 35);
            this.LblStudentName.Name = "LblStudentName";
            this.LblStudentName.Size = new System.Drawing.Size(97, 20);
            this.LblStudentName.TabIndex = 68;
            this.LblStudentName.Text = "Öğrenci adı :";
            // 
            // LblStudentSurname
            // 
            this.LblStudentSurname.AutoSize = true;
            this.LblStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentSurname.Location = new System.Drawing.Point(43, 104);
            this.LblStudentSurname.Name = "LblStudentSurname";
            this.LblStudentSurname.Size = new System.Drawing.Size(146, 20);
            this.LblStudentSurname.TabIndex = 69;
            this.LblStudentSurname.Text = "Öğrencinin soyadı : ";
            // 
            // BtnScanStudent
            // 
            this.BtnScanStudent.BackColor = System.Drawing.Color.Thistle;
            this.BtnScanStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnScanStudent.Location = new System.Drawing.Point(612, 32);
            this.BtnScanStudent.Name = "BtnScanStudent";
            this.BtnScanStudent.Size = new System.Drawing.Size(130, 92);
            this.BtnScanStudent.TabIndex = 70;
            this.BtnScanStudent.Text = "Tarat";
            this.BtnScanStudent.UseVisualStyleBackColor = false;
            this.BtnScanStudent.Click += new System.EventHandler(this.BtnScanStudent_Click);
            // 
            // DgwStudent
            // 
            this.DgwStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwStudent.Location = new System.Drawing.Point(47, 155);
            this.DgwStudent.Name = "DgwStudent";
            this.DgwStudent.Size = new System.Drawing.Size(975, 405);
            this.DgwStudent.TabIndex = 71;
            this.DgwStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwStudent_CellDoubleClick);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Thistle;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPrint.Location = new System.Drawing.Point(938, 591);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(84, 193);
            this.BtnPrint.TabIndex = 72;
            this.BtnPrint.Text = "Sayfalara yukarıdaki bilgileri götür";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // GrpCheckInfo
            // 
            this.GrpCheckInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GrpCheckInfo.Controls.Add(this.checkBox4);
            this.GrpCheckInfo.Controls.Add(this.checkBox3);
            this.GrpCheckInfo.Controls.Add(this.checkBox2);
            this.GrpCheckInfo.Controls.Add(this.checkBox1);
            this.GrpCheckInfo.Controls.Add(this.label1);
            this.GrpCheckInfo.Location = new System.Drawing.Point(780, 32);
            this.GrpCheckInfo.Name = "GrpCheckInfo";
            this.GrpCheckInfo.Size = new System.Drawing.Size(243, 92);
            this.GrpCheckInfo.TabIndex = 78;
            this.GrpCheckInfo.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox4.Location = new System.Drawing.Point(23, 66);
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
            this.checkBox3.Location = new System.Drawing.Point(140, 37);
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
            this.checkBox2.Location = new System.Drawing.Point(74, 37);
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
            this.checkBox1.Location = new System.Drawing.Point(23, 37);
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
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Sayfalara Götürülecek Bilgiler";
            // 
            // GrpInfo
            // 
            this.GrpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GrpInfo.Controls.Add(this.label9);
            this.GrpInfo.Controls.Add(this.label6);
            this.GrpInfo.Controls.Add(this.TxtTakenBookName);
            this.GrpInfo.Controls.Add(this.TxtCanTake);
            this.GrpInfo.Controls.Add(this.TxtStudentPenalty);
            this.GrpInfo.Controls.Add(this.TxtStudentGender);
            this.GrpInfo.Controls.Add(this.TxtStudentTurkishId);
            this.GrpInfo.Controls.Add(this.label8);
            this.GrpInfo.Controls.Add(this.label7);
            this.GrpInfo.Controls.Add(this.label5);
            this.GrpInfo.Controls.Add(this.TxtStudentSurname);
            this.GrpInfo.Controls.Add(this.TxtStudentName);
            this.GrpInfo.Controls.Add(this.TxtStudentId);
            this.GrpInfo.Controls.Add(this.label4);
            this.GrpInfo.Controls.Add(this.label3);
            this.GrpInfo.Controls.Add(this.label2);
            this.GrpInfo.Enabled = false;
            this.GrpInfo.Location = new System.Drawing.Point(47, 591);
            this.GrpInfo.Name = "GrpInfo";
            this.GrpInfo.Size = new System.Drawing.Size(877, 193);
            this.GrpInfo.TabIndex = 79;
            this.GrpInfo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(500, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 98;
            this.label9.Text = "Aldığı Kitabın İsmi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(513, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Kitap  Alabilir Mi :";
            // 
            // TxtTakenBookName
            // 
            this.TxtTakenBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTakenBookName.Location = new System.Drawing.Point(646, 145);
            this.TxtTakenBookName.Name = "TxtTakenBookName";
            this.TxtTakenBookName.Size = new System.Drawing.Size(224, 26);
            this.TxtTakenBookName.TabIndex = 96;
            // 
            // TxtCanTake
            // 
            this.TxtCanTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCanTake.Location = new System.Drawing.Point(646, 98);
            this.TxtCanTake.Name = "TxtCanTake";
            this.TxtCanTake.Size = new System.Drawing.Size(224, 26);
            this.TxtCanTake.TabIndex = 95;
            // 
            // TxtStudentPenalty
            // 
            this.TxtStudentPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentPenalty.Location = new System.Drawing.Point(646, 55);
            this.TxtStudentPenalty.Name = "TxtStudentPenalty";
            this.TxtStudentPenalty.Size = new System.Drawing.Size(224, 26);
            this.TxtStudentPenalty.TabIndex = 94;
            // 
            // TxtStudentGender
            // 
            this.TxtStudentGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentGender.Location = new System.Drawing.Point(646, 14);
            this.TxtStudentGender.Name = "TxtStudentGender";
            this.TxtStudentGender.Size = new System.Drawing.Size(224, 26);
            this.TxtStudentGender.TabIndex = 93;
            // 
            // TxtStudentTurkishId
            // 
            this.TxtStudentTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentTurkishId.Location = new System.Drawing.Point(179, 145);
            this.TxtStudentTurkishId.Name = "TxtStudentTurkishId";
            this.TxtStudentTurkishId.Size = new System.Drawing.Size(206, 26);
            this.TxtStudentTurkishId.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(411, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 20);
            this.label8.TabIndex = 91;
            this.label8.Text = "Varsa Cezasının Biteceği Tarih : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(568, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Öğrenci TC Kimlik No : ";
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentSurname.Location = new System.Drawing.Point(179, 98);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(206, 26);
            this.TxtStudentSurname.TabIndex = 87;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentName.Location = new System.Drawing.Point(179, 55);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(206, 26);
            this.TxtStudentName.TabIndex = 86;
            // 
            // TxtStudentId
            // 
            this.TxtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStudentId.Location = new System.Drawing.Point(179, 19);
            this.TxtStudentId.Name = "TxtStudentId";
            this.TxtStudentId.Size = new System.Drawing.Size(206, 26);
            this.TxtStudentId.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(101, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(126, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(136, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "ID :";
            // 
            // StudentQueryByNameSurname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1068, 800);
            this.ControlBox = false;
            this.Controls.Add(this.GrpInfo);
            this.Controls.Add(this.GrpCheckInfo);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.DgwStudent);
            this.Controls.Add(this.BtnScanStudent);
            this.Controls.Add(this.LblStudentSurname);
            this.Controls.Add(this.TxtScanStudentSurName);
            this.Controls.Add(this.TxtScanStudentName);
            this.Controls.Add(this.LblStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentQueryByNameSurname";
            this.Text = "Student_Query_By_Name_Surname";
            ((System.ComponentModel.ISupportInitialize)(this.DgwStudent)).EndInit();
            this.GrpCheckInfo.ResumeLayout(false);
            this.GrpCheckInfo.PerformLayout();
            this.GrpInfo.ResumeLayout(false);
            this.GrpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtScanStudentName;
        private System.Windows.Forms.TextBox TxtScanStudentSurName;
        private System.Windows.Forms.Label LblStudentName;
        private System.Windows.Forms.Label LblStudentSurname;
        private System.Windows.Forms.Button BtnScanStudent;
        private System.Windows.Forms.DataGridView DgwStudent;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.GroupBox GrpCheckInfo;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpInfo;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtStudentId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTakenBookName;
        private System.Windows.Forms.TextBox TxtCanTake;
        private System.Windows.Forms.TextBox TxtStudentPenalty;
        private System.Windows.Forms.TextBox TxtStudentGender;
        private System.Windows.Forms.TextBox TxtStudentTurkishId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}