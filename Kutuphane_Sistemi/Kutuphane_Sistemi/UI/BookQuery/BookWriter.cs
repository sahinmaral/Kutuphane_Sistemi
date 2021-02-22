using Kutuphane_Sistemi.Models;
using Kutuphane_Sistemi.Properties;
using Kutuphane_Sistemi.UI.Student_Query;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Sistemi.UI
{
    public partial class BookWriter : Form
    {
        public BookWriter()
        {
            InitializeComponent();
        }

        ConnectionClass Shortcon = new ConnectionClass();
        ConnectionClass Join = new ConnectionClass();
        ConnectionClass Query = new ConnectionClass();

        string KitapNo;
        string Teslimedildimi;
        public bool Iade;
        string StudentId;
        int WriterCode;

        private void BtnScanWriter_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);
            DgwWriter.Visible = true;
            DbConnection.Open();

            SqlCommand com = new SqlCommand(Query.WriterQuery + " writer_name LIKE '" + TxTScanWriter.Text + "%' ", DbConnection);
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(com);
            DataTable dtRecord = new DataTable();

            sqlDataAdap.Fill(dtRecord);
            DgwWriter.DataSource = dtRecord;
            DbConnection.Close();

            if (WriterCode > 0)
                DgwBook.DataSource = null;

        }
        private void BtnScanWriterBook_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);
            DgwBook.Visible = true;
            DbConnection.Open();
            SqlCommand com = new SqlCommand(Join.BookJoin + " w.id="+ WriterCode + "", DbConnection);

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(com);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            DgwBook.DataSource = dtRecord;
            DbConnection.Close();
        }
        private void DgwWriter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Secilen = DgwWriter.SelectedCells[0].RowIndex;
            WriterCode = (int)DgwWriter.Rows[Secilen].Cells[0].Value;
            BtnScanWriterBook.Visible = true;

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            StudentId = Student.StudentId;
            TxtStudentName.Text = Student.StudentName;
            TxtStudentSurname.Text = Student.StudentSurname;
            TxtStudentTurkishId.Text = Student.StudentTurkishId;
        }

        private void DgwBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtStudentName.Text = "";
            TxtStudentSurname.Text = "";
            TxtStudentTurkishId.Text = "";

            int Secilen = DgwBook.SelectedCells[0].RowIndex;
            KitapNo = DgwBook.Rows[Secilen].Cells[0].Value.ToString();
            TxtBookISBN.Text = DgwBook.Rows[Secilen].Cells[1].Value.ToString();
            TxTBookName.Text = DgwBook.Rows[Secilen].Cells[2].Value.ToString();
            StudentId = DgwBook.Rows[Secilen].Cells[6].Value.ToString();
            TxtStudentName.Text = DgwBook.Rows[Secilen].Cells[7].Value.ToString();
            TxtStudentSurname.Text = DgwBook.Rows[Secilen].Cells[8].Value.ToString();
            TxtStudentTurkishId.Text = DgwBook.Rows[Secilen].Cells[9].Value.ToString();
            Teslimedildimi = DgwBook.Rows[Secilen].Cells[11].Value.ToString();
        }

        private void BtnOrderBook_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);
            int i = 0;
            int Control = 0;
            DateTime CezaTarih = new DateTime();
            int Gun = 0;
            int Saat = 0;
            int Dakika = 0;



            DbConnection.Open();
            SqlCommand sqlCommandCeza = new SqlCommand("SELECT penalty_date FROM student where st_tr_id=@st_tr_id", DbConnection);
            sqlCommandCeza.Parameters.AddWithValue("@st_tr_id", TxtStudentTurkishId.Text);
            SqlDataReader sqlDataReader = sqlCommandCeza.ExecuteReader();
            if (sqlDataReader.Read())
            {
                if (sqlDataReader[0] != DBNull.Value) CezaTarih = Convert.ToDateTime(sqlDataReader[0]);
            }

            DbConnection.Close();

            TimeSpan DifferenceGun = CezaTarih - DtNow.Value;
            Gun = (int)DifferenceGun.Days;
            Saat = (int)DifferenceGun.Hours;
            Dakika = (int)DifferenceGun.Minutes;


            if (TxtStudentName.Text == "" && TxtStudentSurname.Text == "")
                MessageBox.Show("Kitabı almak için öğrencinin adını ve soyadını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxtStudentTurkishId.Text == "")
                MessageBox.Show("Kitabı almak için öğrencinin TC kimlik numarasını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxTBookName.Text == "")
                MessageBox.Show("Kitabı tablodan işaretlemeniz gerekir", "Bilgilendirme Ekranı");
            else if (Saat > 0 || Gun > 0 || Dakika > 0)
                MessageBox.Show("Kitap alma yasağınızın bitmesi için kalan süre" + "\n" + "Gün:" + Gun + "\n" + "Saat:" + Saat + "\n" + "Dakika:" + Dakika);


            else
            {
                DbConnection.Open();
                SqlCommand sqlCommand2 = new SqlCommand("SELECT st_tr_id from student where can_take=0", DbConnection);
                sqlCommand2.Parameters.AddWithValue("@st_tr_id", TxtStudentTurkishId.Text);
                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();

                while (sqlDataReader2.Read())
                {
                    if (sqlDataReader2[0].ToString() == TxtStudentTurkishId.Text)
                    {
                        MessageBox.Show(TxtStudentTurkishId.Text + " TC kimlik numaralı öğrenci zaten kitap almıştır", "Bilgilendirme Ekranı");
                        Control += 1;
                        break;
                    }
                    i++;
                }
                DbConnection.Close();





                if (Control == 0)
                {
                    if ((Gun == 0 && Saat == 0 && Dakika == 0) || (Gun == 0 && Saat < 0) || (Gun == 0 && Saat == 0 && Dakika < 0))
                    {
                        DbConnection.Open();
                        SqlCommand sqlCommandPenaltyDate = new SqlCommand("UPDATE student SET can_take=1 , penalty_date=@penalty_date where st_tr_id=@st_tr_id", DbConnection);
                        sqlCommandPenaltyDate.Parameters.AddWithValue("@penalty_date", DBNull.Value);
                        sqlCommandPenaltyDate.Parameters.AddWithValue("@st_tr_id", TxtStudentTurkishId.Text);
                        sqlCommandPenaltyDate.ExecuteNonQuery();
                        DbConnection.Close();
                        MessageBox.Show(TxtStudentTurkishId.Text + " TC kimlik numaralı öğrencinin cezası bittiği için kitap alabilir.");
                    }
                    DtNow.Value = DateTime.Now;
                    DateTime Answer = DtNow.Value.AddDays(15);



                    DbConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(Join.OrderQuery + " id=@id ", DbConnection);
                    sqlCommand.Parameters.AddWithValue("@st_id", StudentId);
                    sqlCommand.Parameters.AddWithValue("@id", KitapNo);
                    sqlCommand.Parameters.AddWithValue("@taken_date", DtNow.Value);

                    sqlCommand.Parameters.AddWithValue("@delivery_date", Answer);
                    sqlCommand.Parameters.AddWithValue("@is_delivered", "False");
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show(TxTBookName.Text + " kitabı alınmıştır.", "Bilgilendirme Ekranı");
                    DbConnection.Close();



                    DbConnection.Open();
                    SqlCommand sqlCommand3 = new SqlCommand("UPDATE student SET can_take=0 , book_id=@book_id where id=@id", DbConnection);
                    sqlCommand3.Parameters.AddWithValue("@id", StudentId);
                    sqlCommand3.Parameters.AddWithValue("@book_id", KitapNo);

                    sqlCommand3.ExecuteNonQuery();
                    DbConnection.Close();
                    this.Close();
                }




            }
        }

        private void BtnDeleteOrderBook_Click(object sender, EventArgs e)
        {
            int Control = 0;

            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);

            DateTime TeslimTarihi = new DateTime();
            

            if (TxtStudentName.Text == "" && TxtStudentSurname.Text == "")
                MessageBox.Show("Kitabı iade etmek için öğrencinin adını ve soyadını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxtStudentTurkishId.Text == "")
                MessageBox.Show("Kitabı iade etmek için öğrencinin TC kimlik numarasını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxTBookName.Text == "")
                MessageBox.Show("Kitabı tablodan işaretlemeniz gerekir", "Bilgilendirme Ekranı");
            else if (Teslimedildimi == "True")
                MessageBox.Show(TxTBookName.Text + " " + "kitabı zaten teslim edilmiş");



            else
            {

                DbConnection.Open();
                SqlCommand SqlCommand2 = new SqlCommand("SELECT delivery_date from book where st_id=@st_id", DbConnection);
                SqlCommand2.Parameters.AddWithValue("@st_id", StudentId);
                SqlDataReader SqlDataReader = SqlCommand2.ExecuteReader();
                if (SqlDataReader.Read())
                {
                    TeslimTarihi = Convert.ToDateTime(SqlDataReader[0]);

                }
                DbConnection.Close();

                DbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(Join.DeleteOrderQuery + " id=@id ", DbConnection);
                sqlCommand.Parameters.AddWithValue("@st_id", DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@book_name", TxTBookName.Text);
                sqlCommand.Parameters.AddWithValue("@id", KitapNo.ToString());
                sqlCommand.Parameters.AddWithValue("@taken_date", DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@delivery_date", DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@is_delivered", "True");


                sqlCommand.ExecuteNonQuery();
                DbConnection.Close();


                TimeSpan Interval = DtNow.Value - TeslimTarihi;
                Control = Interval.Days;
                DateTime CezaIslem = DtNow.Value.AddDays(Control);

                if (Control > 0)
                {


                    DbConnection.Open();
                    SqlCommand sqlCommandUpdate = new SqlCommand("UPDATE student SET can_take=0 , book_id=@book_id , penalty_date=@penalty_date where id=@id", DbConnection);
                    sqlCommandUpdate.Parameters.AddWithValue("@penalty_date", CezaIslem);
                    sqlCommandUpdate.Parameters.AddWithValue("@id", StudentId);
                    sqlCommandUpdate.Parameters.AddWithValue("@book_id", DBNull.Value);
                    sqlCommandUpdate.ExecuteNonQuery();
                    DbConnection.Close();
                    MessageBox.Show(TxTBookName.Text + " " + "kitabı iade edilmiştir fakat gecikmeden dolayı " + TxtStudentTurkishId.Text + "TC kimlik nolu öğrenci " + Control.ToString() + " gün ceza almıştır");
                    this.Close();
                }

                else
                {
                    DbConnection.Open();
                    SqlCommand sqlCommand3 = new SqlCommand("UPDATE student SET can_take=1 , book_id=@book_id where id=@id", DbConnection);
                    sqlCommand3.Parameters.AddWithValue("@book_id", DBNull.Value);
                    sqlCommand3.Parameters.AddWithValue("@id", StudentId);
                    sqlCommand3.ExecuteNonQuery();
                    DbConnection.Close();
                    MessageBox.Show(TxTBookName.Text + " " + "kitabı iade edilmiştir");
                    this.Close();
                }
            }



        }
    }
}
