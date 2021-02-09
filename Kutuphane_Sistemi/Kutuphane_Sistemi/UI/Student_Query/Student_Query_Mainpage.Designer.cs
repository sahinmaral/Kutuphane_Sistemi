
namespace Kutuphane_Sistemi.UI
{
    partial class Student_Query_Mainpage
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
            this.menu = new System.Windows.Forms.TableLayoutPanel();
            this.btn_tr_id = new System.Windows.Forms.Button();
            this.btn_student_n_s = new System.Windows.Forms.Button();
            this.btn_penalty = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.st_query_panel = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu.ColumnCount = 1;
            this.menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menu.Controls.Add(this.btn_tr_id, 0, 2);
            this.menu.Controls.Add(this.btn_student_n_s, 0, 1);
            this.menu.Controls.Add(this.btn_penalty, 0, 3);
            this.menu.Controls.Add(this.btn_book, 0, 4);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RowCount = 6;
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.menu.Size = new System.Drawing.Size(199, 800);
            this.menu.TabIndex = 82;
            // 
            // btn_tr_id
            // 
            this.btn_tr_id.BackColor = System.Drawing.Color.Thistle;
            this.btn_tr_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tr_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tr_id.Location = new System.Drawing.Point(3, 223);
            this.btn_tr_id.Name = "btn_tr_id";
            this.btn_tr_id.Size = new System.Drawing.Size(193, 64);
            this.btn_tr_id.TabIndex = 72;
            this.btn_tr_id.Text = "Öğrencinin TC kimlik numarasına göre";
            this.btn_tr_id.UseVisualStyleBackColor = false;
            this.btn_tr_id.MouseEnter += new System.EventHandler(this.btn_tr_id_MouseEnter);
            this.btn_tr_id.MouseLeave += new System.EventHandler(this.btn_tr_id_MouseLeave);
            // 
            // btn_student_n_s
            // 
            this.btn_student_n_s.BackColor = System.Drawing.Color.Thistle;
            this.btn_student_n_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student_n_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_student_n_s.Location = new System.Drawing.Point(3, 153);
            this.btn_student_n_s.Name = "btn_student_n_s";
            this.btn_student_n_s.Size = new System.Drawing.Size(193, 64);
            this.btn_student_n_s.TabIndex = 73;
            this.btn_student_n_s.Text = "Öğrencinin Adına Ve Soyadına Göre";
            this.btn_student_n_s.UseVisualStyleBackColor = false;
            this.btn_student_n_s.Click += new System.EventHandler(this.btn_student_n_s_Click);
            this.btn_student_n_s.MouseEnter += new System.EventHandler(this.btn_student_n_s_MouseEnter);
            this.btn_student_n_s.MouseLeave += new System.EventHandler(this.btn_student_n_s_MouseLeave);
            // 
            // btn_penalty
            // 
            this.btn_penalty.BackColor = System.Drawing.Color.Thistle;
            this.btn_penalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_penalty.Location = new System.Drawing.Point(3, 293);
            this.btn_penalty.Name = "btn_penalty";
            this.btn_penalty.Size = new System.Drawing.Size(193, 64);
            this.btn_penalty.TabIndex = 74;
            this.btn_penalty.Text = "Ceza Alan Öğrencilere Göre";
            this.btn_penalty.UseVisualStyleBackColor = false;
            this.btn_penalty.MouseEnter += new System.EventHandler(this.btn_penalty_MouseEnter);
            this.btn_penalty.MouseLeave += new System.EventHandler(this.btn_penalty_MouseLeave);
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.Thistle;
            this.btn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_book.Location = new System.Drawing.Point(3, 363);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(193, 64);
            this.btn_book.TabIndex = 75;
            this.btn_book.Text = "Aldığı kitaba göre";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.MouseEnter += new System.EventHandler(this.btn_book_MouseEnter);
            this.btn_book.MouseLeave += new System.EventHandler(this.btn_book_MouseLeave);
            // 
            // st_query_panel
            // 
            this.st_query_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.st_query_panel.Location = new System.Drawing.Point(199, 0);
            this.st_query_panel.Name = "st_query_panel";
            this.st_query_panel.Size = new System.Drawing.Size(1037, 800);
            this.st_query_panel.TabIndex = 83;
            // 
            // Student_Query_Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1236, 800);
            this.ControlBox = false;
            this.Controls.Add(this.st_query_panel);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student_Query_Mainpage";
            this.Text = "Öğrenci Sorgulama";
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel menu;
        private System.Windows.Forms.Button btn_tr_id;
        private System.Windows.Forms.Button btn_student_n_s;
        private System.Windows.Forms.Button btn_penalty;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Panel st_query_panel;
    }
}