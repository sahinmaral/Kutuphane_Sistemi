using Kutuphane_Sistemi.Properties;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Kutuphane_Sistemi.Models;
using DevExpress.XtraEditors;

namespace Kutuphane_Sistemi.UI.StudentQuery
{
    public partial class StudentQueryByPenalty : Form
    {
        public StudentQueryByPenalty()
        {
            InitializeComponent();
        }

        ConnectionClass Shortcon = new ConnectionClass();

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Student.StudentId = TxtStudentId.Text;
            Student.StudentName = TxtStudentName.Text;
            Student.StudentSurname = TxtStudentSurname.Text;
            Student.StudentTurkishId = TxtStudentTurkishId.Text;
        }

        private void TxtStudentWithPenalty_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BRING_STUDENT_BYPENALTY @CONTROL=1", DbConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            StudentGridControl.DataSource = dataTable;
        }

        private void TxtStudentWithoutPenalty_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BRING_STUDENT_BYPENALTY @CONTROL=0", DbConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            StudentGridControl.DataSource = dataTable;
        }

        private void StudentGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
                DataRow dataRow = StudentGridView.GetFocusedDataRow();
                if (dataRow != null)
                {
                    TxtStudentId.Text = dataRow[0].ToString();
                    TxtStudentName.Text = dataRow[1].ToString();
                    TxtStudentSurname.Text = dataRow[2].ToString();
                    TxtStudentTurkishId.Text = dataRow[3].ToString();
                    TxtStudentGender.Text = dataRow[4].ToString();
                    TxtStudentPenalty.Text = dataRow[5].ToString();
                    TxtCanTake.Text = dataRow[6].ToString();
                    TxtTakenBookName.Text = dataRow[7].ToString();
                }
            }     
    }
}
