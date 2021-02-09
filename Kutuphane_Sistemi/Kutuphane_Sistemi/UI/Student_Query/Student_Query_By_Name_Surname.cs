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

namespace Kutuphane_Sistemi.UI.Student_Query
{
    public partial class Student_Query_By_Name_Surname : Form
    {
        public Student_Query_By_Name_Surname()
        {
            InitializeComponent();
        }

        public static string st_name;
        public static string st_surname;
        public static string st_tr_id;


        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");

        private void btn_scan_st_n_s_Click(object sender, EventArgs e)
        {

            if(txt_student_n.Text=="" && txt_student_s.Text == "")
                MessageBox.Show("Öğrencinin adını veya soyadını girmeniz gerekiyor.");

            else
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select * from student where st_name LIKE '" + txt_student_n.Text + "%' AND st_surname LIKE '" + txt_student_s.Text + "%'", con);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(com);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                student_dgw.DataSource = dtRecord;

                con.Close();
            }
            
        }

        private void student_dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = student_dgw.SelectedCells[0].RowIndex;
            txt_st_id.Text = student_dgw.Rows[secilen].Cells[0].Value.ToString();
            txt_st_name.Text = student_dgw.Rows[secilen].Cells[1].Value.ToString();
            txt_st_surname.Text = student_dgw.Rows[secilen].Cells[2].Value.ToString();
            txt_st_tr_id.Text = student_dgw.Rows[secilen].Cells[3].Value.ToString();
            txt_st_gender.Text = student_dgw.Rows[secilen].Cells[4].Value.ToString();         
     

            if (student_dgw.Rows[secilen].Cells[7].Value==DBNull.Value)
                txt_st_book_isbn.Text = "Aldığı kitabı yok";
            else
                txt_st_book_isbn.Text = student_dgw.Rows[secilen].Cells[7].Value.ToString();

            if (student_dgw.Rows[secilen].Cells[5].Value == DBNull.Value)
                txt_st_penalty.Text = "Ceza almamış";
            else
                txt_st_penalty.Text = student_dgw.Rows[secilen].Cells[5].Value.ToString();

            if (student_dgw.Rows[secilen].Cells[6].Value.ToString() == "True")
                txt_can_take.Text = "Alabilir";

            if (student_dgw.Rows[secilen].Cells[6].Value.ToString() == "False")
                txt_can_take.Text = "Alamaz";

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            st_name = txt_st_name.Text;
            st_surname = txt_st_surname.Text;
            st_tr_id = txt_st_tr_id.Text;

        }
    }
}
