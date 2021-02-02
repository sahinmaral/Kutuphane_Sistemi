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
    public partial class Book_Writer : Form
    {
        public Book_Writer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");
       

        string kitapno;
        string teslimedildimi;
        public bool iade;

        private void btn_scan_writer_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand com = new SqlCommand("Select * from yazar where yazarad LIKE '"+txt_writer.Text+"%' ", con);
            
            

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(com);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            yazar_dgw.DataSource = dtRecord;

            con.Close();
        }
        private void btn_scan_writer_book_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("Select * from kitap where yazarno=@yazarno ", con);
            com.Parameters.AddWithValue("@yazarno", lbl_writer_code.Text);

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(com);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            kitap_dgw.DataSource = dtRecord;
            con.Close();
        }
        private void lbl_writer_code_TextChanged(object sender, EventArgs e)
        {
            btn_scan_writer_book.Visible = true;
        }
        private void btn_find_student_no_Click(object sender, EventArgs e)
        {

            if (txt_student_n.Text == "" && txt_student_s.Text == "")
                MessageBox.Show("Öğrencinin adını veya soyadını yazmanız gerekiyor", "Bilgilendirme Ekranı");

            else
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT ogrno FROM ogrenci where ograd=@ograd and ogrsoyad=@ogrsoyad", con);
                com.Parameters.AddWithValue("@ograd", txt_student_n.Text);
                com.Parameters.AddWithValue("@ogrsoyad", txt_student_s.Text);
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    txt_student_no.Text = read[0].ToString();
                }
                con.Close();
            }
           
        }
        private void btn_delete_order_book_Click(object sender, EventArgs e)
        {

            int cezai_islem = 0;

             if (txt_student_n.Text == "" && txt_student_s.Text == "")
                MessageBox.Show("Kitabı iade etmek için öğrencinin adını ve soyadını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (txt_student_no.Text == "")
                MessageBox.Show("Kitabı iade etmek için öğrencinin numarasını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (txt_book_name.Text == "")
                MessageBox.Show("Kitabı tablodan işaretlemeniz gerekir", "Bilgilendirme Ekranı");
            else if (teslimedildimi == "True")
                MessageBox.Show(txt_book_name.Text + " " + "kitabı zaten teslim edilmiş");
            


            else
            {
                DateTime date = new DateTime();
                con.Open();
                SqlCommand com2 = new SqlCommand("SELECT teslimedilecektarih from kitap where ogrno=@ogrno", con);
                com2.Parameters.AddWithValue("@ogrno", txt_student_no.Text);
                SqlDataReader read = com2.ExecuteReader();
                if (read.Read())
                {
                    date = Convert.ToDateTime(read[0]);
                    TimeSpan ceza = dt_now.Value - date;

                     cezai_islem = (int)ceza.Days;
                    
                }
                con.Close();
                
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE kitap SET ograd=@ograd , ogrsoyad=@ogrsoyad , ogrno=@ogrno , alinantarih=@alinantarih, kitapadi=@kitapadi , teslimedildimi=@teslimedildimi, teslimedilecektarih=@teslimedilecektarih where kitapno=@kitapno ", con);
                com.Parameters.AddWithValue("@ograd", DBNull.Value);
                com.Parameters.AddWithValue("@ogrsoyad", DBNull.Value);
                com.Parameters.AddWithValue("@ogrno", DBNull.Value);
                com.Parameters.AddWithValue("@kitapadi", txt_book_name.Text);
                com.Parameters.AddWithValue("@kitapno", kitapno.ToString());
                com.Parameters.AddWithValue("@alinantarih", DBNull.Value);
                com.Parameters.AddWithValue("@teslimedilecektarih", DBNull.Value);
                com.Parameters.AddWithValue("@teslimedildimi", "True");
                

                com.ExecuteNonQuery();
                con.Close();

                if (cezai_islem > 0)
                {
                    con.Open();
                    SqlCommand up = new SqlCommand("UPDATE ogrenci SET ceza_gun=@ceza_gun where ogrno=@ogrno", con);
                    up.Parameters.AddWithValue("@ceza_gun", cezai_islem);
                    up.Parameters.AddWithValue("@ogrno", txt_student_no.Text);
                    up.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(txt_book_name.Text + " " + "kitabı iade edilmiştir fakat gecikmeden dolayı "+txt_student_no.Text+" nolu öğrenci "+cezai_islem.ToString() + " gün ceza almıştır");
                    this.Close();
                }

                else
                {
                    MessageBox.Show(txt_book_name.Text + " " + "kitabı iade edilmiştir");
                    this.Close();
                }

                


            }
            
        }
        private void btn_order_book_Click(object sender, EventArgs e)
        {
            int[] sonuc = new int[99];
            int i = 0;
            int control = 0;
            int gun=0;

            con.Open();
            SqlCommand conceza = new SqlCommand("SELECT ceza_gun FROM ogrenci where ogrno=@ogrno", con);
            conceza.Parameters.AddWithValue("@ogrno", txt_student_no.Text);
            SqlDataReader concezareader = conceza.ExecuteReader();
            if (concezareader.Read())
                gun = Convert.ToInt32(concezareader[0]);
            con.Close();

            if (txt_student_n.Text == "" && txt_student_s.Text == "")
                MessageBox.Show("Kitabı almak için öğrencinin adını ve soyadını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (txt_student_no.Text == "")
                MessageBox.Show("Kitabı almak için öğrencinin numarasını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (txt_book_name.Text == "")
                MessageBox.Show("Kitabı tablodan işaretlemeniz gerekir", "Bilgilendirme Ekranı");
            else if (gun > 0)
                MessageBox.Show(gun + " günlük cezanız bitene kadar kitap alamazsınız");
            else
            {
                con.Open();
                SqlCommand com2 = new SqlCommand("SELECT ogrno from ogrenci where kitapalmahakki=0", con);
                com2.Parameters.AddWithValue("@ogrno", txt_student_no.Text);
                SqlDataReader read = com2.ExecuteReader();

                while (read.Read())
                {
                    sonuc[i] = Convert.ToInt32(read[0]);
                    i++;
                }
                con.Close();

                for (int k = 0; k < i; k++)
                {
                    if (sonuc[k].ToString() == txt_student_no.Text) control += 1;
                }


                if (control == 1) MessageBox.Show(txt_student_no.Text + " numaralı öğrenci zaten kitap almıştır", "Bilgilendirme Ekranı");
                else
                {

                    dt_now.Value = DateTime.Now;
                    DateTime answer = dt_now.Value.AddDays(15);
                    con.Open();
                    SqlCommand com = new SqlCommand("UPDATE kitap SET ograd=@ograd , ogrsoyad=@ogrsoyad , ogrno=@ogrno , teslimedildimi = @teslimedildimi , kitapadi=@kitapadi , alinantarih=@alinantarih , teslimedilecektarih=@teslimedilecektarih where kitapno=@kitapno ", con);
                    com.Parameters.AddWithValue("@ograd", txt_student_n.Text);
                    com.Parameters.AddWithValue("@ogrsoyad", txt_student_s.Text);
                    com.Parameters.AddWithValue("@ogrno", txt_student_no.Text);
                    com.Parameters.AddWithValue("@kitapadi", txt_book_name.Text);
                    com.Parameters.AddWithValue("@alinantarih", dt_now.Value);
                    com.Parameters.AddWithValue("@kitapno", kitapno.ToString());
                    com.Parameters.AddWithValue("@teslimedilecektarih", answer);
                    com.Parameters.AddWithValue("@teslimedildimi", "False");
                    com.ExecuteNonQuery();
                    MessageBox.Show(txt_book_name.Text + " kitabı alınmıştır", "Bilgilendirme Ekranı");
                    con.Close();



                    con.Open();
                    SqlCommand com3 = new SqlCommand("UPDATE ogrenci SET kitapalmahakki=0 where ogrno=@ogrno", con);
                    com3.Parameters.AddWithValue("@ogrno", txt_student_no.Text);
                    com.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }








            }

           
        }
        private void yazar_dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pnl_writer_info.Visible = true;
            int secilen = yazar_dgw.SelectedCells[0].RowIndex;
            lbl_writer_code.Text = yazar_dgw.Rows[secilen].Cells[0].Value.ToString();
            lbl_writer_n.Text = yazar_dgw.Rows[secilen].Cells[1].Value.ToString();
            lbl_writer_s.Text = yazar_dgw.Rows[secilen].Cells[2].Value.ToString();
        }
        private void kitap_dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = kitap_dgw.SelectedCells[0].RowIndex;
            kitapno = kitap_dgw.Rows[secilen].Cells[0].Value.ToString();
            txt_book_name.Text = kitap_dgw.Rows[secilen].Cells[2].Value.ToString();
            txt_student_no.Text = kitap_dgw.Rows[secilen].Cells[6].Value.ToString();
            teslimedildimi = kitap_dgw.Rows[secilen].Cells[11].Value.ToString();
            txt_student_n.Text = kitap_dgw.Rows[secilen].Cells[7].Value.ToString();
            txt_student_s.Text = kitap_dgw.Rows[secilen].Cells[8].Value.ToString();

            con.Open();
            SqlCommand com = new SqlCommand("SELECT ograd,ogrsoyad FROM ogrenci where ogrno=@ogrno", con);
            com.Parameters.AddWithValue("@ogrno", txt_student_no.Text);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                txt_student_n.Text = read[0].ToString();
                txt_student_s.Text = read[1].ToString();
            }
            con.Close();
        }
        private void btn_find_student_name_Click(object sender, EventArgs e)
        {
            if (txt_student_no.Text == "")
                MessageBox.Show("Öğrencinin numarasını yazmanız gerekiyor", "Bilgilendirme Ekranı");

            else
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT ograd FROM ogrenci where ogrno=@ogrno", con);
                com.Parameters.AddWithValue("@ogrno", txt_student_no.Text);
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    txt_student_n.Text = read[0].ToString();
                }
                con.Close();


                con.Open();
                SqlCommand com2 = new SqlCommand("SELECT ogrsoyad FROM ogrenci where ogrno=@ogrno", con);
                com2.Parameters.AddWithValue("@ogrno", txt_student_no.Text);
                SqlDataReader read2 = com2.ExecuteReader();
                while (read2.Read())
                {
                    txt_student_s.Text = read2[0].ToString();
                }
                con.Close();
            }


        }






        


    }
}
