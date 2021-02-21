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
using Kutuphane_Sistemi.Properties;
using Kutuphane_Sistemi.Models;

namespace Kutuphane_Sistemi.UI.Student_Query
{
    public partial class StudentQueryByNameSurname : Form
    {
        public StudentQueryByNameSurname()
        {
            InitializeComponent();
        }

        ConnectionClass Shortcon = new ConnectionClass();
        ConnectionClass Join = new ConnectionClass();
        private void BtnScanStudent_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);

            if (TxtScanStudentName.Text == "" && TxtScanStudentSurName.Text == "")
                MessageBox.Show("Öğrencinin adını veya soyadını girmeniz gerekiyor.");

            else
            {
                DbConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(Join.StudentJoin + " st_name LIKE '" + TxtScanStudentName.Text + "%' AND st_surname LIKE '" + TxtScanStudentSurName.Text + "%'", DbConnection);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCommand);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                DgwStudent.DataSource = dtRecord;

                DbConnection.Close();
            }
        }

        private void DgwStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Secilen = DgwStudent.SelectedCells[0].RowIndex;
            TxtStudentId.Text = DgwStudent.Rows[Secilen].Cells[0].Value.ToString();
            TxtStudentName.Text = DgwStudent.Rows[Secilen].Cells[1].Value.ToString();
            TxtStudentSurname.Text = DgwStudent.Rows[Secilen].Cells[2].Value.ToString();
            TxtStudentTurkishId.Text = DgwStudent.Rows[Secilen].Cells[3].Value.ToString();
            TxtStudentGender.Text = DgwStudent.Rows[Secilen].Cells[4].Value.ToString();
            TxtStudentPenalty.Text = DgwStudent.Rows[Secilen].Cells[5].Value.ToString();
            TxtCanTake.Text = DgwStudent.Rows[Secilen].Cells[6].Value.ToString();
            TxtTakenBookName.Text = DgwStudent.Rows[Secilen].Cells[7].Value.ToString();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Student.StudentId = TxtStudentId.Text;
            Student.StudentName = TxtStudentName.Text;
            Student.StudentSurname = TxtStudentSurname.Text;
            Student.StudentTurkishId = TxtStudentTurkishId.Text;
        }
    }
}
