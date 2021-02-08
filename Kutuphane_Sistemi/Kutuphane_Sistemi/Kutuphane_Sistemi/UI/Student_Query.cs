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

namespace Kutuphane_Sistemi.UI
{
    public partial class Student_Query : Form
    {
        public Student_Query()
        {
            InitializeComponent();
        }

        public static string name = "";
        public static string surname = "";
        public static string id_no = "";


        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");

        private void btn_find_student_name_Click(object sender, EventArgs e)
        {
            if (txt_student_no.Text == "")
                MessageBox.Show("Öğrencinin numarasını yazmanız gerekiyor", "Bilgilendirme Ekranı");

            else
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT st_name FROM student where st_tr_id=@st_tr_id", con);
                com.Parameters.AddWithValue("@st_tr_id", txt_student_no.Text);
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    txt_student_n.Text = read[0].ToString();
                }
                con.Close();


                con.Open();
                SqlCommand com2 = new SqlCommand("SELECT st_surname FROM student where st_tr_id=@st_tr_id", con);
                com2.Parameters.AddWithValue("@st_tr_id", txt_student_no.Text);
                SqlDataReader read2 = com2.ExecuteReader();
                while (read2.Read())
                {
                    txt_student_s.Text = read2[0].ToString();
                }
                con.Close();
            }
 


        }
        private void btn_find_student_no_Click(object sender, EventArgs e)
        {

            if (txt_student_n.Text == "" && txt_student_s.Text == "")
                MessageBox.Show("Öğrencinin adını veya soyadını yazmanız gerekiyor", "Bilgilendirme Ekranı");

            else
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT st_tr_id FROM student where st_name=@st_name and st_surname=@st_surname", con);
                com.Parameters.AddWithValue("@st_name", txt_student_n.Text);
                com.Parameters.AddWithValue("@st_surname", txt_student_s.Text);
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    txt_student_no.Text = read[0].ToString();
                }
                con.Close();
            }

        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            name = txt_student_n.Text;
            surname = txt_student_s.Text;
            id_no = txt_student_no.Text;       
        }
    }
}
