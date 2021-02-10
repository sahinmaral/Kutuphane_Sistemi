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
using Kutuphane_Sistemi.Properties;

namespace Kutuphane_Sistemi.UI
{
    public partial class Book_Writer : Form
    {
        public Book_Writer()
        {
            InitializeComponent();
        }

        ConnectionClass shortcon = new ConnectionClass();
        ConnectionClass join = new ConnectionClass();

        string kitapno;
        string teslimedildimi;
        public bool iade;
        string s_id;
        string s_tr_id;

        private void btn_scan_writer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(shortcon.address);
            writer_dgw.Visible = true;
            con.Open();
            SqlCommand com = new SqlCommand("Select * from writer where writer_name LIKE '"+txt_writer.Text+"%' ", con);         

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(com);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            writer_dgw.DataSource = dtRecord;

            con.Close();
        }
        private void btn_scan_writer_book_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(shortcon.address);
            book_dgw.Visible = true;
            con.Open();
            SqlCommand com = new SqlCommand(join.book_join+" writer_no LIKE '" + lbl_writer_code.Text + "%' ", con);




            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(com);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            book_dgw.DataSource = dtRecord;
            con.Close();
        }
        private void lbl_writer_code_TextChanged(object sender, EventArgs e)
        {
            btn_scan_writer_book.Visible = true;
        }     
        private void btn_delete_order_book_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(shortcon.address);
            DateTime teslim_tarihi = new DateTime();


            if (txt_student_n.Text == "" && txt_student_s.Text == "")
                MessageBox.Show("Kitabı iade etmek için öğrencinin adını ve soyadını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (txt_student_tr_no.Text == "")
                MessageBox.Show("Kitabı iade etmek için öğrencinin TC kimlik numarasını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (txt_book_name.Text == "")
                MessageBox.Show("Kitabı tablodan işaretlemeniz gerekir", "Bilgilendirme Ekranı");
            else if (teslimedildimi == "True")
                MessageBox.Show(txt_book_name.Text + " " + "kitabı zaten teslim edilmiş");
            


            else
            {
               
                con.Open();
                SqlCommand com2 = new SqlCommand("SELECT delivery_date from book where st_id=@st_id", con);
                com2.Parameters.AddWithValue("@st_id", s_id);
                SqlDataReader read = com2.ExecuteReader();
                if (read.Read())
                {
                    teslim_tarihi = Convert.ToDateTime(read[0]);                   
                }
                con.Close();
                
                con.Open();
                SqlCommand com = new SqlCommand(join.delete_order_query+" id=@id ", con);
                com.Parameters.AddWithValue("@st_id", DBNull.Value);
                com.Parameters.AddWithValue("@book_name", txt_book_name.Text);
                com.Parameters.AddWithValue("@id", kitapno.ToString());
                com.Parameters.AddWithValue("@taken_date", DBNull.Value);
                com.Parameters.AddWithValue("@delivery_date", DBNull.Value);
                com.Parameters.AddWithValue("@is_delivered", "True");
                

                com.ExecuteNonQuery();
                con.Close();



                int cezai_islem = 0;

                if (cezai_islem > 0)
                {
                    con.Open();
                    SqlCommand up = new SqlCommand("UPDATE student SET penalty_date=@penalty_date where id=@id", con);
                    up.Parameters.AddWithValue("@penalty_date", cezai_islem);
                    up.Parameters.AddWithValue("@id", s_id);
                    up.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(txt_book_name.Text + " " + "kitabı iade edilmiştir fakat gecikmeden dolayı "+txt_student_tr_no.Text+"TC kimlik nolu öğrenci "+cezai_islem.ToString() + " gün ceza almıştır");
                    this.Close();
                }

                else
                {
                    con.Open();
                    SqlCommand com3 = new SqlCommand("UPDATE student SET can_take=1 , book_id=@book_id where id=@id", con);
                    com3.Parameters.AddWithValue("@book_id", DBNull.Value);
                    com3.Parameters.AddWithValue("@id", s_id);
                    com3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(txt_book_name.Text + " " + "kitabı iade edilmiştir");
                    this.Close();
                }

                


            }
            
        }
        private void btn_order_book_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(shortcon.address);
            int[] sonuc = new int[999];
            int i = 0;
            int control = 0;
            DateTime ceza_tarih = new DateTime();
            int gun = 0;
            int saat = 0;
            int dakika = 0;

          
            
            con.Open();
            SqlCommand conceza = new SqlCommand("SELECT penalty_date FROM student where st_tr_id=@st_tr_id", con);
            conceza.Parameters.AddWithValue("@st_tr_id", txt_student_tr_no.Text);
            SqlDataReader concezareader = conceza.ExecuteReader();
            if (concezareader.Read())
            {
                if (concezareader[0]!=DBNull.Value)         ceza_tarih = Convert.ToDateTime(concezareader[0]);
            }            

            con.Close();

            TimeSpan dif_gun = ceza_tarih - dt_now.Value;
            gun = (int)dif_gun.Days;
            saat = (int)dif_gun.Hours;
            dakika = (int)dif_gun.Minutes;


            if (txt_student_n.Text == "" && txt_student_s.Text == "")
                MessageBox.Show("Kitabı almak için öğrencinin adını ve soyadını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (txt_student_tr_no.Text == "")
                MessageBox.Show("Kitabı almak için öğrencinin TC kimlik numarasını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (txt_book_name.Text == "")
                MessageBox.Show("Kitabı tablodan işaretlemeniz gerekir", "Bilgilendirme Ekranı");
            else if (saat > 0 || gun > 0 || dakika > 0)
                MessageBox.Show("Kitap alma yasağınızın bitmesi için kalan süre"+"\n"+"Gün:"+gun+"\n"+"Saat:"+saat+"\n"+"Dakika:"+dakika); 
            

            else
            {
                con.Open();
                SqlCommand com2 = new SqlCommand("SELECT st_tr_id from student where can_take=0", con);
                com2.Parameters.AddWithValue("@st_tr_id", txt_student_tr_no.Text);
                SqlDataReader read = com2.ExecuteReader();

                while (read.Read())
                { 
                    if (read[0].ToString() == txt_student_tr_no.Text)
                    {
                        MessageBox.Show(txt_student_tr_no.Text + " TC kimlik numaralı öğrenci zaten kitap almıştır", "Bilgilendirme Ekranı");
                        control += 1;
                        break;
                    }
                    i++;
                }
                con.Close();

               


                 
                if(control==0)
                {
                    if ((gun == 0 && saat == 0 && dakika == 0) || (gun==0 && saat<0) || (gun==0 && saat==0 && dakika<0))
                    {
                        con.Open();
                        SqlCommand penalty_update = new SqlCommand("UPDATE student SET penalty_date=@penalty_date where st_tr_id=@st_tr_id", con);
                        penalty_update.Parameters.AddWithValue("@penalty_date", DBNull.Value);
                        penalty_update.Parameters.AddWithValue("@st_tr_id", txt_student_tr_no.Text);
                        penalty_update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(txt_student_tr_no.Text+" TC kimlik numaralı öğrencinin cezası bittiği için kitap alabilir.");
                    }
                    dt_now.Value = DateTime.Now;
                    DateTime answer = dt_now.Value.AddDays(15);

                    

                    con.Open();
                    SqlCommand com = new SqlCommand(join.order_query+" id=@id ", con);
                    com.Parameters.AddWithValue("@st_id", s_id);
                    com.Parameters.AddWithValue("@id", kitapno);
                    com.Parameters.AddWithValue("@taken_date", dt_now.Value);
                    
                    com.Parameters.AddWithValue("@delivery_date", answer);
                    com.Parameters.AddWithValue("@is_delivered", "False");
                    com.ExecuteNonQuery();
                    MessageBox.Show(txt_book_name.Text + " kitabı alınmıştır.", "Bilgilendirme Ekranı");
                    con.Close();



                    con.Open();
                    SqlCommand com3 = new SqlCommand("UPDATE student SET can_take=0 , book_id=@book_id where id=@id", con);
                    com3.Parameters.AddWithValue("@id", s_id);
                    com3.Parameters.AddWithValue("@book_id", kitapno);

                    com3.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }

               


            }

           
        }
        private void writer_dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = writer_dgw.SelectedCells[0].RowIndex;
            lbl_writer_code.Text = writer_dgw.Rows[secilen].Cells[0].Value.ToString();
            lbl_writer_n.Text = writer_dgw.Rows[secilen].Cells[1].Value.ToString();
            lbl_writer_s.Text = writer_dgw.Rows[secilen].Cells[2].Value.ToString();
        }
        private void book_dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_student_n.Text = "";
            txt_student_s.Text = "";
            txt_student_tr_no.Text = "";

            int secilen = book_dgw.SelectedCells[0].RowIndex;
            kitapno = book_dgw.Rows[secilen].Cells[0].Value.ToString();
            txt_book_isbn.Text = book_dgw.Rows[secilen].Cells[1].Value.ToString(); 
            txt_book_name.Text = book_dgw.Rows[secilen].Cells[2].Value.ToString();
            s_id = book_dgw.Rows[secilen].Cells[6].Value.ToString();       
            txt_student_n.Text = book_dgw.Rows[secilen].Cells[7].Value.ToString();
            txt_student_s.Text = book_dgw.Rows[secilen].Cells[8].Value.ToString();
            txt_student_tr_no.Text = book_dgw.Rows[secilen].Cells[9].Value.ToString();
            teslimedildimi = book_dgw.Rows[secilen].Cells[11].Value.ToString();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_student_n.Text = Student_Query_By_Name_Surname.st_name;
            txt_student_s.Text = Student_Query_By_Name_Surname.st_surname;
            s_tr_id = Student_Query_By_Name_Surname.st_tr_id;
            s_id = Student_Query_By_Name_Surname.st_id;
            txt_student_tr_no.Text = s_tr_id;
           
        }

    }
}
