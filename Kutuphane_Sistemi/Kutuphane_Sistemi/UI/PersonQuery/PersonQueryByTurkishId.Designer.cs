namespace Kutuphane_Sistemi.UI.Person_Query
{
    partial class PersonQueryByTurkishId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonQueryByTurkishId));
            this.TxtScanPersonTurkishId = new System.Windows.Forms.TextBox();
            this.LblPersonTurkishId = new System.Windows.Forms.Label();
            this.PersonGridControl = new DevExpress.XtraGrid.GridControl();
            this.PersonGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.BtnScanPerson = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPersonName = new System.Windows.Forms.TextBox();
            this.TxtTakenBookName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCanTake = new System.Windows.Forms.TextBox();
            this.TxtPersonSurname = new System.Windows.Forms.TextBox();
            this.TxtPersonPenalty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPersonGender = new System.Windows.Forms.TextBox();
            this.TxtPersonId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPersonTurkishId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtScanPersonTurkishId
            // 
            this.tablePanel2.SetColumn(this.TxtScanPersonTurkishId, 1);
            this.TxtScanPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtScanPersonTurkishId.Location = new System.Drawing.Point(213, 7);
            this.TxtScanPersonTurkishId.Name = "TxtScanPersonTurkishId";
            this.tablePanel2.SetRow(this.TxtScanPersonTurkishId, 0);
            this.TxtScanPersonTurkishId.Size = new System.Drawing.Size(363, 26);
            this.TxtScanPersonTurkishId.TabIndex = 80;
            // 
            // LblPersonTurkishId
            // 
            this.LblPersonTurkishId.AutoSize = true;
            this.tablePanel2.SetColumn(this.LblPersonTurkishId, 0);
            this.LblPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPersonTurkishId.Location = new System.Drawing.Point(3, 10);
            this.LblPersonTurkishId.Name = "LblPersonTurkishId";
            this.tablePanel2.SetRow(this.LblPersonTurkishId, 0);
            this.LblPersonTurkishId.Size = new System.Drawing.Size(201, 20);
            this.LblPersonTurkishId.TabIndex = 82;
            this.LblPersonTurkishId.Text = "Kişinin TC Kimlik Numarası :";
            // 
            // PersonGridControl
            // 
            this.PersonGridControl.Location = new System.Drawing.Point(47, 151);
            this.PersonGridControl.MainView = this.PersonGridView;
            this.PersonGridControl.Name = "PersonGridControl";
            this.PersonGridControl.Size = new System.Drawing.Size(1185, 416);
            this.PersonGridControl.TabIndex = 101;
            this.PersonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PersonGridView});
            // 
            // PersonGridView
            // 
            this.PersonGridView.GridControl = this.PersonGridControl;
            this.PersonGridView.Name = "PersonGridView";
            this.PersonGridView.OptionsBehavior.ReadOnly = true;
            this.PersonGridView.OptionsView.ShowGroupPanel = false;
            this.PersonGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.PersonGridView_FocusedRowChanged);
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 21.72F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.28F)});
            this.tablePanel2.Controls.Add(this.BtnScanPerson);
            this.tablePanel2.Controls.Add(this.TxtScanPersonTurkishId);
            this.tablePanel2.Controls.Add(this.LblPersonTurkishId);
            this.tablePanel2.Location = new System.Drawing.Point(48, 15);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 42F)});
            this.tablePanel2.Size = new System.Drawing.Size(579, 84);
            this.tablePanel2.TabIndex = 103;
            // 
            // BtnScanPerson
            // 
            this.BtnScanPerson.Appearance.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnScanPerson.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnScanPerson.Appearance.Options.UseBackColor = true;
            this.BtnScanPerson.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.BtnScanPerson, 1);
            this.BtnScanPerson.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnScanPerson.ImageOptions.Image")));
            this.BtnScanPerson.Location = new System.Drawing.Point(213, 46);
            this.BtnScanPerson.Name = "BtnScanPerson";
            this.BtnScanPerson.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel2.SetRow(this.BtnScanPerson, 1);
            this.BtnScanPerson.Size = new System.Drawing.Size(363, 32);
            this.BtnScanPerson.TabIndex = 81;
            this.BtnScanPerson.Text = "Tarat";
            this.BtnScanPerson.Click += new System.EventHandler(this.BtnScanPerson_Click);
            // 
            // tablePanel3
            // 
            this.tablePanel3.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tablePanel3.Appearance.Options.UseBackColor = true;
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 54.5F)});
            this.tablePanel3.Controls.Add(this.checkBox3);
            this.tablePanel3.Controls.Add(this.checkBox4);
            this.tablePanel3.Controls.Add(this.checkBox2);
            this.tablePanel3.Controls.Add(this.checkBox1);
            this.tablePanel3.Controls.Add(this.label1);
            this.tablePanel3.Location = new System.Drawing.Point(883, 15);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F)});
            this.tablePanel3.Size = new System.Drawing.Size(349, 122);
            this.tablePanel3.TabIndex = 104;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox3.Location = new System.Drawing.Point(171, 63);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 24);
            this.checkBox3.TabIndex = 83;
            this.checkBox3.Text = "Soyadı";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox4.Location = new System.Drawing.Point(171, 94);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(163, 24);
            this.checkBox4.TabIndex = 82;
            this.checkBox4.Text = "TC Kimlik Numarası";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox2.Location = new System.Drawing.Point(3, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 24);
            this.checkBox2.TabIndex = 80;
            this.checkBox2.Text = "Adı";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox1.Location = new System.Drawing.Point(3, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 24);
            this.checkBox1.TabIndex = 79;
            this.checkBox1.Text = "ID";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 46);
            this.label1.TabIndex = 78;
            this.label1.Text = "Sayfalara Götürülecek Bilgiler";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.BtnPrint);
            this.tablePanel1.Controls.Add(this.label9);
            this.tablePanel1.Controls.Add(this.TxtPersonName);
            this.tablePanel1.Controls.Add(this.TxtTakenBookName);
            this.tablePanel1.Controls.Add(this.label6);
            this.tablePanel1.Controls.Add(this.TxtCanTake);
            this.tablePanel1.Controls.Add(this.TxtPersonSurname);
            this.tablePanel1.Controls.Add(this.TxtPersonPenalty);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.TxtPersonGender);
            this.tablePanel1.Controls.Add(this.TxtPersonId);
            this.tablePanel1.Controls.Add(this.label4);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label8);
            this.tablePanel1.Controls.Add(this.TxtPersonTurkishId);
            this.tablePanel1.Controls.Add(this.label7);
            this.tablePanel1.Controls.Add(this.label5);
            this.tablePanel1.Location = new System.Drawing.Point(219, 582);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F)});
            this.tablePanel1.Size = new System.Drawing.Size(784, 379);
            this.tablePanel1.TabIndex = 105;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Appearance.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnPrint.Appearance.Options.UseBackColor = true;
            this.BtnPrint.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.BtnPrint, 1);
            this.BtnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.ImageOptions.Image")));
            this.BtnPrint.Location = new System.Drawing.Point(297, 324);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel1.SetRow(this.BtnPrint, 8);
            this.BtnPrint.Size = new System.Drawing.Size(484, 51);
            this.BtnPrint.TabIndex = 109;
            this.BtnPrint.Text = "Sayfalara yukarıdaki \r\nbilgileri götür";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tablePanel1.SetColumn(this.label9, 0);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 290);
            this.label9.Name = "label9";
            this.tablePanel1.SetRow(this.label9, 7);
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 108;
            this.label9.Text = "Aldığı Kitabın İsmi :";
            // 
            // TxtPersonName
            // 
            this.tablePanel1.SetColumn(this.TxtPersonName, 1);
            this.TxtPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonName.Location = new System.Drawing.Point(297, 47);
            this.TxtPersonName.Name = "TxtPersonName";
            this.tablePanel1.SetRow(this.TxtPersonName, 1);
            this.TxtPersonName.Size = new System.Drawing.Size(484, 26);
            this.TxtPersonName.TabIndex = 90;
            // 
            // TxtTakenBookName
            // 
            this.tablePanel1.SetColumn(this.TxtTakenBookName, 1);
            this.TxtTakenBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTakenBookName.Location = new System.Drawing.Point(297, 287);
            this.TxtTakenBookName.Name = "TxtTakenBookName";
            this.tablePanel1.SetRow(this.TxtTakenBookName, 7);
            this.TxtTakenBookName.Size = new System.Drawing.Size(484, 26);
            this.TxtTakenBookName.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tablePanel1.SetColumn(this.label6, 0);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 250);
            this.label6.Name = "label6";
            this.tablePanel1.SetRow(this.label6, 6);
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 107;
            this.label6.Text = "Kitap  Alabilir Mi :";
            // 
            // TxtCanTake
            // 
            this.tablePanel1.SetColumn(this.TxtCanTake, 1);
            this.TxtCanTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCanTake.Location = new System.Drawing.Point(297, 247);
            this.TxtCanTake.Name = "TxtCanTake";
            this.tablePanel1.SetRow(this.TxtCanTake, 6);
            this.TxtCanTake.Size = new System.Drawing.Size(484, 26);
            this.TxtCanTake.TabIndex = 105;
            // 
            // TxtPersonSurname
            // 
            this.tablePanel1.SetColumn(this.TxtPersonSurname, 1);
            this.TxtPersonSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonSurname.Location = new System.Drawing.Point(297, 87);
            this.TxtPersonSurname.Name = "TxtPersonSurname";
            this.tablePanel1.SetRow(this.TxtPersonSurname, 2);
            this.TxtPersonSurname.Size = new System.Drawing.Size(484, 26);
            this.TxtPersonSurname.TabIndex = 91;
            // 
            // TxtPersonPenalty
            // 
            this.tablePanel1.SetColumn(this.TxtPersonPenalty, 1);
            this.TxtPersonPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonPenalty.Location = new System.Drawing.Point(297, 207);
            this.TxtPersonPenalty.Name = "TxtPersonPenalty";
            this.tablePanel1.SetRow(this.TxtPersonPenalty, 5);
            this.TxtPersonPenalty.Size = new System.Drawing.Size(484, 26);
            this.TxtPersonPenalty.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 0);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "ID :";
            // 
            // TxtPersonGender
            // 
            this.tablePanel1.SetColumn(this.TxtPersonGender, 1);
            this.TxtPersonGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonGender.Location = new System.Drawing.Point(297, 167);
            this.TxtPersonGender.Name = "TxtPersonGender";
            this.tablePanel1.SetRow(this.TxtPersonGender, 4);
            this.TxtPersonGender.Size = new System.Drawing.Size(484, 26);
            this.TxtPersonGender.TabIndex = 103;
            // 
            // TxtPersonId
            // 
            this.tablePanel1.SetColumn(this.TxtPersonId, 1);
            this.TxtPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonId.Location = new System.Drawing.Point(297, 7);
            this.TxtPersonId.Name = "TxtPersonId";
            this.tablePanel1.SetRow(this.TxtPersonId, 0);
            this.TxtPersonId.Size = new System.Drawing.Size(484, 26);
            this.TxtPersonId.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tablePanel1.SetColumn(this.label4, 0);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.tablePanel1.SetRow(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel1.SetColumn(this.label3, 0);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 1);
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Adı : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tablePanel1.SetColumn(this.label8, 0);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 210);
            this.label8.Name = "label8";
            this.tablePanel1.SetRow(this.label8, 5);
            this.label8.Size = new System.Drawing.Size(236, 20);
            this.label8.TabIndex = 101;
            this.label8.Text = "Varsa Cezasının Biteceği Tarih : ";
            // 
            // TxtPersonTurkishId
            // 
            this.tablePanel1.SetColumn(this.TxtPersonTurkishId, 1);
            this.TxtPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonTurkishId.Location = new System.Drawing.Point(297, 127);
            this.TxtPersonTurkishId.Name = "TxtPersonTurkishId";
            this.tablePanel1.SetRow(this.TxtPersonTurkishId, 3);
            this.TxtPersonTurkishId.Size = new System.Drawing.Size(484, 26);
            this.TxtPersonTurkishId.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tablePanel1.SetColumn(this.label7, 0);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 170);
            this.label7.Name = "label7";
            this.tablePanel1.SetRow(this.label7, 4);
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 100;
            this.label7.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tablePanel1.SetColumn(this.label5, 0);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.tablePanel1.SetRow(this.label5, 3);
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 99;
            this.label5.Text = "Kişinin TC Kimlik No : ";
            // 
            // PersonQueryByTurkishId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 980);
            this.ControlBox = false;
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.tablePanel3);
            this.Controls.Add(this.tablePanel2);
            this.Controls.Add(this.PersonGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonQueryByTurkishId";
            this.Text = "PersonQueryByTurkishId";
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.tablePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtScanPersonTurkishId;
        private System.Windows.Forms.Label LblPersonTurkishId;
        private DevExpress.XtraGrid.GridControl PersonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PersonGridView;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton BtnScanPerson;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton BtnPrint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPersonName;
        private System.Windows.Forms.TextBox TxtTakenBookName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCanTake;
        private System.Windows.Forms.TextBox TxtPersonSurname;
        private System.Windows.Forms.TextBox TxtPersonPenalty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPersonGender;
        private System.Windows.Forms.TextBox TxtPersonId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPersonTurkishId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}