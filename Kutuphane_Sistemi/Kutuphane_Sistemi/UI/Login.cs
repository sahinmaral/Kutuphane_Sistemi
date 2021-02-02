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
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");
        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM admin where kadi=@kadi and sifre=@sifre", con);
            com.Parameters.AddWithValue("@kadi", txt_username.Text);
            com.Parameters.AddWithValue("@sifre", txt_password.Text);

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
