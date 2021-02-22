﻿using Kutuphane_Sistemi.UI.Student_Query;
using Kutuphane_Sistemi.UI.StudentQuery;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane_Sistemi.UI
{
    public partial class StudentQueryMainpage : Form
    {
        public StudentQueryMainpage()
        {
            InitializeComponent();
        }

        public static string name = "";
        public static string surname = "";
        public static string id_no = "";

        //name = txt_student_n.Text;
        //surname = txt_student_s.Text;
        //id_no = txt_student_no.Text;       

        public void FormShow(Form form)
        {
            StudentQueryPanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            StudentQueryPanel.Controls.Add(form);
            form.Show();
        }

        private void btn_student_n_s_MouseEnter(object sender, EventArgs e)
        {
            BtnScanByNameSurname.FlatAppearance.BorderSize = 1;
            BtnScanByNameSurname.FlatAppearance.BorderColor = Color.Red;
        }
        private void btn_student_n_s_MouseLeave(object sender, EventArgs e)
        {
            BtnScanByNameSurname.FlatAppearance.BorderSize = 1;
            BtnScanByNameSurname.FlatAppearance.BorderColor = Color.Black;
        }
        private void btn_tr_id_MouseEnter(object sender, EventArgs e)
        {
            BtnScanByTurkishId.FlatAppearance.BorderSize = 1;
            BtnScanByTurkishId.FlatAppearance.BorderColor = Color.Red;
        }
        private void btn_tr_id_MouseLeave(object sender, EventArgs e)
        {
            BtnScanByTurkishId.FlatAppearance.BorderSize = 1;
            BtnScanByTurkishId.FlatAppearance.BorderColor = Color.Black;
        }
        private void btn_penalty_MouseEnter(object sender, EventArgs e)
        {
            BtnScanByPenalty.FlatAppearance.BorderSize = 1;
            BtnScanByPenalty.FlatAppearance.BorderColor = Color.Red;
        }
        private void btn_penalty_MouseLeave(object sender, EventArgs e)
        {
            BtnScanByPenalty.FlatAppearance.BorderSize = 1;
            BtnScanByPenalty.FlatAppearance.BorderColor = Color.Black;
        }
        private void btn_book_MouseEnter(object sender, EventArgs e)
        {
            BtnScanByTakenBook.FlatAppearance.BorderSize = 1;
            BtnScanByTakenBook.FlatAppearance.BorderColor = Color.Red;
        }
        private void btn_book_MouseLeave(object sender, EventArgs e)
        {
            BtnScanByTakenBook.FlatAppearance.BorderSize = 1;
            BtnScanByTakenBook.FlatAppearance.BorderColor = Color.Black;
        }
        private void btn_student_n_s_Click(object sender, EventArgs e)
        {
            FormShow(new StudentQueryByNameSurname());
        }

        private void BtnScanByTurkishId_Click(object sender, EventArgs e)
        {
            FormShow(new StudentQueryByTurkishId());
        }

        private void BtnScanByPenalty_Click(object sender, EventArgs e)
        {
            FormShow(new StudentQueryByPenalty());
        }

        private void BtnScanByTakenBook_Click(object sender, EventArgs e)
        {
            FormShow(new StudentQueryByTakenBook());
        }
    }
}