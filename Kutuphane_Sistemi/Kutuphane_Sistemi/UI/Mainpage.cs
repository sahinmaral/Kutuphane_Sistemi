using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Kutuphane_Sistemi.UI.Mainpage
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }
        
        private void FormShow(Form form)
        {
            MainpagePanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            MainpagePanel.Controls.Add(form);
            form.Show();
        }

        private void BtnBookQueryByWriterName_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormShow(new BookWriter());
        }

        private void BtnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("https://github.com/sahinmaral tarafından hazırlanmıştır.","Hakkında",MessageBoxButtons.OK);
        }

        private void BtnMainpage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainpagePanel.Controls.Clear();
        }

        private void BtnByBookQueryBookISBN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnBookQueryByTypeName_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnBookQueryByBookName_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void BtnPersonQueryByNameSurname_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormShow(new Person_Query.PersonQueryByNameSurname());
        }

        private void BtnPersonQueryByTurkishId_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormShow(new Person_Query.PersonQueryByTurkishId());
        }

        private void BtnPersonQueryByPenalty_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormShow(new Person_Query.PersonQueryByPenalty());
        }

        private void BtnPersonQueryByTakenBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormShow(new Person_Query.PersonQueryByTakenBook());
        }
    }
}
