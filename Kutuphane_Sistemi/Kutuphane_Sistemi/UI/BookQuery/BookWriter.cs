using Kutuphane_Sistemi.Models;
using Kutuphane_Sistemi.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kutuphane_Sistemi.UI
{
    public partial class BookWriter : Form
    {
        public BookWriter()
        { 
            InitializeComponent();
        }

        ConnectionClass Shortcon = new ConnectionClass();
        
        string PersonId;
        int WriterId;
        int KitapNo;
        private void BtnScanWriterBook_Click(object sender, EventArgs e)
        {

            WriterId = (int)SearchLookupEditScanWriter.Properties.View.GetFocusedRowCellValue("ID");
            
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);          
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BRING_BOOK_BYWRITERID @WRITERID='" + WriterId + "'", DbConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                WriterGridControl.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            PersonId = Person.Id;
            TxtPersonName.Text = Person.Name;
            TxtPersonSurname.Text = Person.Surname;
            TxtPersonTurkishId.Text = Person.TurkishId;
        }


        private void BtnOrderBook_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);

            if (TxtPersonName.Text == "" && TxtPersonSurname.Text == "")
                MessageBox.Show("Kitabı almak için kişinin adını ve soyadını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxtPersonTurkishId.Text == "")
                MessageBox.Show("Kitabı almak için kişinin TC kimlik numarasını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxtBookName.Text == "")
                MessageBox.Show("Kitabı tablodan işaretlemeniz gerekir", "Bilgilendirme Ekranı");


            else
            {
                DbConnection.Open();
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("ORDER_BOOK", DbConnection);
                    sqlCommand.Parameters.AddWithValue("@PERSONID", PersonId);
                    sqlCommand.Parameters.AddWithValue("@TAKENDATE", DtNow.Value);
                    sqlCommand.Parameters.AddWithValue("@BOOKID", KitapNo);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                   SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DbConnection.Close();
            }

            XtraMessageBox.Show("Kitabınız alınmıştır", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnDeleteOrderBook_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);

            if (TxtPersonName.Text == "" && TxtPersonSurname.Text == "")
                MessageBox.Show("Kitabı almak için kişinin adını ve soyadını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxtPersonTurkishId.Text == "")
                MessageBox.Show("Kitabı almak için kişinin TC kimlik numarasını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxtBookName.Text == "")
                MessageBox.Show("Kitabı tablodan işaretlemeniz gerekir", "Bilgilendirme Ekranı");

            DbConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DEORDER_BOOK", DbConnection);
                sqlCommand.Parameters.AddWithValue("@P_PERSONID", PersonId);
                sqlCommand.Parameters.AddWithValue("@BOOKID", KitapNo);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DbConnection.Close();
            this.Close();

        }



        private void BookWriter_Load(object sender, EventArgs e)
        {
            
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);
            DbConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BRING_WRITER", DbConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            SearchLookupEditScanWriter.Properties.ValueMember = "ID";
            SearchLookupEditScanWriter.Properties.DisplayMember = "Adı";
            SearchLookupEditScanWriter.Properties.DataSource = dataTable;
           
        }

        private void WriterGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtPersonName.Text = "";
            TxtPersonSurname.Text = "";
            TxtPersonTurkishId.Text = "";

            DataRow dataRow = WriterGridView.GetFocusedDataRow();
            if (dataRow != null)
            {
                KitapNo = (int)dataRow[0];
                TxtBookISBN.Text = dataRow[1].ToString();
                TxtBookName.Text = dataRow[2].ToString();
                PersonId = dataRow[6].ToString();
                TxtPersonName.Text = dataRow[7].ToString();
                TxtPersonSurname.Text = dataRow[8].ToString();
                TxtPersonTurkishId.Text = dataRow[9].ToString();
            }
        }

    }
}
