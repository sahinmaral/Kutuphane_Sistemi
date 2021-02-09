using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Kutuphane_Sistemi.UI.Student_Query;

namespace Kutuphane_Sistemi.UI
{
    public partial class Student_Query_Mainpage : Form
    {
        public Student_Query_Mainpage()
        {
            InitializeComponent();
        }

        public static string name = "";
        public static string surname = "";
        public static string id_no = "";

        //name = txt_student_n.Text;
        //surname = txt_student_s.Text;
        //id_no = txt_student_no.Text;       

        public void FormShow(Form form)
        {
            st_query_panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            st_query_panel.Controls.Add(form);
            form.Show();
        }

        private void btn_student_n_s_MouseEnter(object sender, EventArgs e)
        {
            btn_student_n_s.FlatAppearance.BorderSize = 1;
            btn_student_n_s.FlatAppearance.BorderColor = Color.Red;
        }
        private void btn_student_n_s_MouseLeave(object sender, EventArgs e)
        {
            btn_student_n_s.FlatAppearance.BorderSize = 1;
            btn_student_n_s.FlatAppearance.BorderColor = Color.Black;
        }
        private void btn_tr_id_MouseEnter(object sender, EventArgs e)
        {
            btn_tr_id.FlatAppearance.BorderSize = 1;
            btn_tr_id.FlatAppearance.BorderColor = Color.Red;
        }
        private void btn_tr_id_MouseLeave(object sender, EventArgs e)
        {
            btn_tr_id.FlatAppearance.BorderSize = 1;
            btn_tr_id.FlatAppearance.BorderColor = Color.Black;
        }
        private void btn_penalty_MouseEnter(object sender, EventArgs e)
        {
            btn_penalty.FlatAppearance.BorderSize = 1;
            btn_penalty.FlatAppearance.BorderColor = Color.Red;
        }
        private void btn_penalty_MouseLeave(object sender, EventArgs e)
        {
            btn_penalty.FlatAppearance.BorderSize = 1;
            btn_penalty.FlatAppearance.BorderColor = Color.Black;
        }
        private void btn_book_MouseEnter(object sender, EventArgs e)
        {
            btn_book.FlatAppearance.BorderSize = 1;
            btn_book.FlatAppearance.BorderColor = Color.Red;
        }
        private void btn_book_MouseLeave(object sender, EventArgs e)
        {
            btn_book.FlatAppearance.BorderSize = 1;
            btn_book.FlatAppearance.BorderColor = Color.Black;
        }
        private void btn_student_n_s_Click(object sender, EventArgs e)
        {
            FormShow(new Student_Query_By_Name_Surname());
        }
    }
}
