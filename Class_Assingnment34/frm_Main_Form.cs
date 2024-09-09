using System;
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
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Serch_Student_By_Roll_No obj = new Frm_Serch_Student_By_Roll_No();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Student obj = new Frm_Add_New_Student();
            obj.MdiParent = this;
            obj.Show();

        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void serchStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_All_Student_List obj = new Frm_View_All_Student_List();
            obj.MdiParent = this;
            obj.Show();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure want to Logout", "Warning", MessageBoxButtons.YesNo);
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void frm_Main_Form_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared_Content.Uname;
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
