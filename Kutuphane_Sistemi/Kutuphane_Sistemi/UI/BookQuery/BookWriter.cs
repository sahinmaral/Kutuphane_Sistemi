﻿using Kutuphane_Sistemi.Models;
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
        
        string StudentId;
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
            StudentId = Student.StudentId;
            TxtStudentName.Text = Student.StudentName;
            TxtStudentSurname.Text = Student.StudentSurname;
            TxtStudentTurkishId.Text = Student.StudentTurkishId;
        }


        private void BtnOrderBook_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);

            if (TxtStudentName.Text == "" && TxtStudentSurname.Text == "")
                MessageBox.Show("Kitabı almak için öğrencinin adını ve soyadını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxtStudentTurkishId.Text == "")
                MessageBox.Show("Kitabı almak için öğrencinin TC kimlik numarasını yazmanız gerekir", "Bilgilendirme Ekranı");
            else if (TxTBookName.Text == "")
                MessageBox.Show("Kitabı tablodan işaretlemeniz gerekir", "Bilgilendirme Ekranı");


            else
            {
                DbConnection.Open();
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("ORDER_BOOK", DbConnection);
                    sqlCommand.Parameters.AddWithValue("@STUDENTID", StudentId);
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
            TxtStudentName.Text = "";
            TxtStudentSurname.Text = "";
            TxtStudentTurkishId.Text = "";

            DataRow dataRow = WriterGridView.GetFocusedDataRow();
            if (dataRow != null)
            {
                KitapNo = (int)dataRow[0];
                TxtBookISBN.Text = dataRow[1].ToString();
                TxTBookName.Text = dataRow[2].ToString();
                StudentId = dataRow[6].ToString();
                TxtStudentName.Text = dataRow[7].ToString();
                TxtStudentSurname.Text = dataRow[8].ToString();
                TxtStudentTurkishId.Text = dataRow[9].ToString();
            }
        }

    }
}
