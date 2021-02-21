using Kutuphane_Sistemi.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Kutuphane_Sistemi.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ConnectionClass Shortcon = new ConnectionClass();
       
        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(Shortcon.Address);

            DbConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM admin where username=@username and password=@password", DbConnection);
            sqlCommand.Parameters.AddWithValue("@username", TxtUsername.Text);
            sqlCommand.Parameters.AddWithValue("@password", TxtPassword.Text);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                MessageBox.Show("Hoşgeldiniz","Bilgilendirme Ekranı");
                UI.Mainpage frm = new UI.Mainpage();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı veya şifrenizi kontrol ediniz", "Bilgilendirme Ekranı");
            }

            DbConnection.Close();
        }
    }
}
