using Kutuphane_Sistemi.UI.Person_Query;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Kutuphane_Sistemi.UI
{
    public partial class PersonQueryMainpage : Form
    {
        public PersonQueryMainpage()
        {
            InitializeComponent();
        }

        public static string name = "";
        public static string surname = "";
        public static string id_no = "";
     

        public void FormShow(Form form)
        {
            PersonQueryPanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            PersonQueryPanel.Controls.Add(form);
            form.Show();
        }

        private void BtnScanByTurkishId_Click(object sender, EventArgs e)
        {
            FormShow(new PersonQueryByTurkishId());
        }

        private void BtnScanByPenalty_Click(object sender, EventArgs e)
        {
            FormShow(new PersonQueryByPenalty());
        }

        private void BtnScanByTakenBook_Click(object sender, EventArgs e)
        {
            FormShow(new PersonQueryByTakenBook());
        }

        private void BtnScanByNameSurname_Click(object sender, EventArgs e)
        {
            FormShow(new PersonQueryByNameSurname());
        }

        private void BtnScanByNameSurname_MouseLeave(object sender, EventArgs e)
        {
            BtnScanByNameSurname.FlatAppearance.BorderSize = 1;
            BtnScanByNameSurname.FlatAppearance.BorderColor = Color.Black;
        }

        private void BtnScanByNameSurname_MouseEnter(object sender, EventArgs e)
        {
            BtnScanByNameSurname.FlatAppearance.BorderSize = 1;
            BtnScanByNameSurname.FlatAppearance.BorderColor = Color.Red;
        }

        private void BtnScanByTurkishId_MouseEnter(object sender, EventArgs e)
        {
            BtnScanByTurkishId.FlatAppearance.BorderSize = 1;
            BtnScanByTurkishId.FlatAppearance.BorderColor = Color.Red;
        }

        private void BtnScanByTurkishId_MouseLeave(object sender, EventArgs e)
        {
            BtnScanByTurkishId.FlatAppearance.BorderSize = 1;
            BtnScanByTurkishId.FlatAppearance.BorderColor = Color.Black;
        }

        private void BtnScanByPenalty_MouseEnter(object sender, EventArgs e)
        {
            BtnScanByPenalty.FlatAppearance.BorderSize = 1;
            BtnScanByPenalty.FlatAppearance.BorderColor = Color.Red;
        }

        private void BtnScanByPenalty_MouseLeave(object sender, EventArgs e)
        {
            BtnScanByPenalty.FlatAppearance.BorderSize = 1;
            BtnScanByPenalty.FlatAppearance.BorderColor = Color.Black;
        }

        private void BtnScanByTakenBook_MouseLeave(object sender, EventArgs e)
        {
            BtnScanByTakenBook.FlatAppearance.BorderSize = 1;
            BtnScanByTakenBook.FlatAppearance.BorderColor = Color.Black;
        }

        private void BtnScanByTakenBook_MouseEnter(object sender, EventArgs e)
        {
            BtnScanByTakenBook.FlatAppearance.BorderSize = 1;
            BtnScanByTakenBook.FlatAppearance.BorderColor = Color.Red;
        }
    }
}
