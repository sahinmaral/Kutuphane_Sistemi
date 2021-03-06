using Kutuphane_Sistemi.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace Kutuphane_Sistemi.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ConnectionClass Shortcon = new ConnectionClass();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);

            DbConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("CHECK_ADMIN", DbConnection);
            sqlCommand.Parameters.AddWithValue("@USERNAME", TxtUsername.Text);
            sqlCommand.Parameters.AddWithValue("@PASSWORD", TxtPassword.Text);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    XtraMessageBox.Show("Hoşgeldiniz", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mainpage frm = new Mainpage();
                    frm.Show();
                    this.Hide();
                }

                else
                {
                    XtraMessageBox.Show("Kullanıcı adınızı veya şifrenizi kontrol ediniz", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




            DbConnection.Close();
        }
    }
}
