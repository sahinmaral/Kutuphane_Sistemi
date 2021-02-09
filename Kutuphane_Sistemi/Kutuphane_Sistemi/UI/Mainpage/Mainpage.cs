using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Sistemi.UI
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }


        public void FormShow(Form form)
        {
            mainpage_panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            mainpage_panel.Controls.Add(form);
            form.Show();
        }

        private void ismineGöreSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yazarınaGöreSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new Book_Writer());
        }

        private void öğrenciSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new Student_Query_Mainpage());
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
