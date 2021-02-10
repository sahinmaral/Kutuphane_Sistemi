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

        ConnectionClass shortcon = new ConnectionClass();
       
        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(shortcon.address);

            con.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM admin where username=@username and password=@password", con);
            com.Parameters.AddWithValue("@username", txt_username.Text);
            com.Parameters.AddWithValue("@password", txt_password.Text);

            SqlDataReader read = com.ExecuteReader();
            if (read.Read())
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

            con.Close();
        }
    }
}
