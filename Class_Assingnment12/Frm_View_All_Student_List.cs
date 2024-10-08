﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingnment123
{
    public partial class Frm_View_All_Student_List : Form
    {
        public Frm_View_All_Student_List()
        {
            InitializeComponent();
        }

        private void Frm_View_All_Student_List_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared_Content.Uname;
            // TODO: This line of code loads data into the '_Assginment1_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this._Assginment1_DBDataSet.Student_Details);

        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            Frm_Serch_Student_By_Roll_No obj = new Frm_Serch_Student_By_Roll_No();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Student obj = new Frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure want to Logout", "Warning", MessageBoxButtons.YesNo);
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }
    }
}
