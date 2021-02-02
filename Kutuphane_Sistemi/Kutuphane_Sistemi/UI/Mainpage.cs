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

        
        private void Mainpage_Load(object sender, EventArgs e)
        {
            
           
            

        }


        public void FormShow(Form form)
        {
            panelShow.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            panelShow.Controls.Add(form);
            form.Show();
        }


        private void ismineGöreSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yazarınaGöreSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new Book_Writer());
        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
