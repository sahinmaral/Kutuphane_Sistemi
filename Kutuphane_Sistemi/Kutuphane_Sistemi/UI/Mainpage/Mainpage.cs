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
            MainpagePanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            MainpagePanel.Controls.Add(form);
            form.Show();
        }

        private void ismineGöreSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yazarınaGöreSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new BookWriter());
        }

        private void öğrenciSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new StudentQueryMainpage());
        }

        private void ProgramıKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
