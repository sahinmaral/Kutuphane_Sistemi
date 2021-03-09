
namespace Kutuphane_Sistemi.UI.Mainpage
{
    partial class Mainpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpage));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnBookQueryByBookName = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBookQueryByWriterName = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMainpage = new DevExpress.XtraBars.BarButtonItem();
            this.BtnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersonQueryByNameSurname = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBookQueryByTypeName = new DevExpress.XtraBars.BarButtonItem();
            this.BtnByBookQueryBookISBN = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersonQueryByTurkishId = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersonQueryByPenalty = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersonQueryByTakenBook = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MainpagePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnBookQueryByBookName,
            this.BtnBookQueryByWriterName,
            this.BtnMainpage,
            this.BtnInfo,
            this.BtnPersonQueryByNameSurname,
            this.BtnBookQueryByTypeName,
            this.BtnByBookQueryBookISBN,
            this.BtnPersonQueryByTurkishId,
            this.BtnPersonQueryByPenalty,
            this.BtnPersonQueryByTakenBook});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1,
            this.ribbonPage3});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1279, 169);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // BtnBookQueryByBookName
            // 
            this.BtnBookQueryByBookName.Caption = "Kitabın Adına Göre Sorgulama";
            this.BtnBookQueryByBookName.Id = 1;
            this.BtnBookQueryByBookName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBookQueryByBookName.ImageOptions.Image")));
            this.BtnBookQueryByBookName.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBookQueryByBookName.ImageOptions.LargeImage")));
            this.BtnBookQueryByBookName.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.BtnBookQueryByBookName.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnBookQueryByBookName.Name = "BtnBookQueryByBookName";
            this.BtnBookQueryByBookName.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBookQueryByBookName_ItemClick);
            // 
            // BtnBookQueryByWriterName
            // 
            this.BtnBookQueryByWriterName.Caption = "Kitabın Yazarına Göre Sorgulama";
            this.BtnBookQueryByWriterName.Id = 2;
            this.BtnBookQueryByWriterName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBookQueryByWriterName.ImageOptions.Image")));
            this.BtnBookQueryByWriterName.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBookQueryByWriterName.ImageOptions.LargeImage")));
            this.BtnBookQueryByWriterName.Name = "BtnBookQueryByWriterName";
            this.BtnBookQueryByWriterName.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBookQueryByWriterName_ItemClick);
            // 
            // BtnMainpage
            // 
            this.BtnMainpage.Caption = "Anasayfa";
            this.BtnMainpage.Id = 3;
            this.BtnMainpage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainpage.ImageOptions.Image")));
            this.BtnMainpage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMainpage.ImageOptions.LargeImage")));
            this.BtnMainpage.Name = "BtnMainpage";
            this.BtnMainpage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMainpage_ItemClick);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Caption = "Hakkında";
            this.BtnInfo.Id = 4;
            this.BtnInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfo.ImageOptions.Image")));
            this.BtnInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnInfo.ImageOptions.LargeImage")));
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnInfo_ItemClick);
            // 
            // BtnPersonQueryByNameSurname
            // 
            this.BtnPersonQueryByNameSurname.Caption = "Adına Veya Soyadına Göre Kişi Sorgulama";
            this.BtnPersonQueryByNameSurname.Id = 5;
            this.BtnPersonQueryByNameSurname.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonQueryByNameSurname.ImageOptions.Image")));
            this.BtnPersonQueryByNameSurname.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonQueryByNameSurname.ImageOptions.LargeImage")));
            this.BtnPersonQueryByNameSurname.Name = "BtnPersonQueryByNameSurname";
            this.BtnPersonQueryByNameSurname.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersonQueryByNameSurname_ItemClick);
            // 
            // BtnBookQueryByTypeName
            // 
            this.BtnBookQueryByTypeName.Caption = "Kitabın Türüne Göre Sorgulama";
            this.BtnBookQueryByTypeName.Id = 6;
            this.BtnBookQueryByTypeName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBookQueryByTypeName.ImageOptions.Image")));
            this.BtnBookQueryByTypeName.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBookQueryByTypeName.ImageOptions.LargeImage")));
            this.BtnBookQueryByTypeName.Name = "BtnBookQueryByTypeName";
            this.BtnBookQueryByTypeName.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBookQueryByTypeName_ItemClick);
            // 
            // BtnByBookQueryBookISBN
            // 
            this.BtnByBookQueryBookISBN.Caption = "Kitabın ISBN Koduna \r\nGöre Sorgulama";
            this.BtnByBookQueryBookISBN.Id = 7;
            this.BtnByBookQueryBookISBN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnByBookQueryBookISBN.ImageOptions.Image")));
            this.BtnByBookQueryBookISBN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnByBookQueryBookISBN.ImageOptions.LargeImage")));
            this.BtnByBookQueryBookISBN.Name = "BtnByBookQueryBookISBN";
            this.BtnByBookQueryBookISBN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnByBookQueryBookISBN_ItemClick);
            // 
            // BtnPersonQueryByTurkishId
            // 
            this.BtnPersonQueryByTurkishId.Caption = "TC Kimlik Numarasına Göre Kişi Sorgulama";
            this.BtnPersonQueryByTurkishId.Id = 8;
            this.BtnPersonQueryByTurkishId.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonQueryByTurkishId.ImageOptions.Image")));
            this.BtnPersonQueryByTurkishId.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonQueryByTurkishId.ImageOptions.LargeImage")));
            this.BtnPersonQueryByTurkishId.Name = "BtnPersonQueryByTurkishId";
            this.BtnPersonQueryByTurkishId.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersonQueryByTurkishId_ItemClick);
            // 
            // BtnPersonQueryByPenalty
            // 
            this.BtnPersonQueryByPenalty.Caption = "Ceza Alan Veya Almayanlara Göre Kişi Sorgulama";
            this.BtnPersonQueryByPenalty.Id = 9;
            this.BtnPersonQueryByPenalty.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonQueryByPenalty.ImageOptions.Image")));
            this.BtnPersonQueryByPenalty.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonQueryByPenalty.ImageOptions.LargeImage")));
            this.BtnPersonQueryByPenalty.Name = "BtnPersonQueryByPenalty";
            this.BtnPersonQueryByPenalty.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersonQueryByPenalty_ItemClick);
            // 
            // BtnPersonQueryByTakenBook
            // 
            this.BtnPersonQueryByTakenBook.Caption = "Aldığı Kitaba Göre Kişi Sorgulama";
            this.BtnPersonQueryByTakenBook.Id = 10;
            this.BtnPersonQueryByTakenBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonQueryByTakenBook.ImageOptions.Image")));
            this.BtnPersonQueryByTakenBook.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonQueryByTakenBook.ImageOptions.LargeImage")));
            this.BtnPersonQueryByTakenBook.Name = "BtnPersonQueryByTakenBook";
            this.BtnPersonQueryByTakenBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersonQueryByTakenBook_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Anasayfa ve Diğerleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnMainpage);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnInfo);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kitap Sorgulama";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnBookQueryByBookName);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnBookQueryByWriterName);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.BtnBookQueryByTypeName);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.BtnByBookQueryBookISBN);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ribbonPage3.Appearance.Options.UseFont = true;
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Kişi Sorgulama";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.BtnPersonQueryByNameSurname);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.BtnPersonQueryByTurkishId);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.BtnPersonQueryByPenalty);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.BtnPersonQueryByTakenBook);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // MainpagePanel
            // 
            this.MainpagePanel.AutoScroll = true;
            this.MainpagePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MainpagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainpagePanel.Location = new System.Drawing.Point(0, 169);
            this.MainpagePanel.Name = "MainpagePanel";
            this.MainpagePanel.Size = new System.Drawing.Size(1279, 742);
            this.MainpagePanel.TabIndex = 2;
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 911);
            this.Controls.Add(this.MainpagePanel);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Mainpage";
            this.Text = "İstanbul Kütüphanesi";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem BtnBookQueryByBookName;
        private DevExpress.XtraBars.BarButtonItem BtnBookQueryByWriterName;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.Panel MainpagePanel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem BtnMainpage;
        private DevExpress.XtraBars.BarButtonItem BtnInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem BtnPersonQueryByNameSurname;
        private DevExpress.XtraBars.BarButtonItem BtnBookQueryByTypeName;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem BtnByBookQueryBookISBN;
        private DevExpress.XtraBars.BarButtonItem BtnPersonQueryByTurkishId;
        private DevExpress.XtraBars.BarButtonItem BtnPersonQueryByPenalty;
        private DevExpress.XtraBars.BarButtonItem BtnPersonQueryByTakenBook;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
    }
}