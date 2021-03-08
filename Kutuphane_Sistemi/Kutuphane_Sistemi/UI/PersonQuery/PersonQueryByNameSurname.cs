using DevExpress.XtraEditors;
using Kutuphane_Sistemi.Models;
using Kutuphane_Sistemi.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Sistemi.UI.Person_Query
{
    public partial class PersonQueryByNameSurname : Form
    {
        public PersonQueryByNameSurname()
        {
            InitializeComponent();
        }


        ConnectionClass Shortcon = new ConnectionClass();
        private void BtnScanPerson_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BRING_PERSON_BYNAMESURNAME @PERSONNAME='" + TxtScanPersonName.Text + "'," + "@PERSONSURNAME='" + TxtScanPersonSurname.Text + "'", DbConnection);
            try
            {
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                PersonGridControl.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Bilgilendirme Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Person.Id = TxtPersonId.Text;
            Person.Name = TxtPersonName.Text;
            Person.Surname = TxtPersonSurname.Text;
            Person.TurkishId = TxtPersonTurkishId.Text;
        }

        private void PersonGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = PersonGridView.GetFocusedDataRow();
            if (dataRow != null)
            {
                TxtPersonId.Text = dataRow[0].ToString();
                TxtPersonName.Text = dataRow[1].ToString();
                TxtPersonSurname.Text = dataRow[2].ToString();
                TxtPersonTurkishId.Text = dataRow[3].ToString();
                TxtPersonGender.Text = dataRow[4].ToString();
                TxtPersonPenalty.Text = dataRow[5].ToString();
                TxtCanTake.Text = dataRow[6].ToString();
                TxtTakenBookName.Text = dataRow[7].ToString();
            }
        }
    }
}
