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
    public partial class Frm_View_All_Student_List : Form
    {
        public Frm_View_All_Student_List()
        {
            InitializeComponent();
        }

        private void Frm_View_All_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Assginment1_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this._Assginment1_DBDataSet.Student_Details);

        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Student_List_Click(object sender, EventArgs e)
        {

        }
    }
}
