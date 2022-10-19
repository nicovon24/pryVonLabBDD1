using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonWorkWithDB2
{
    public partial class frmQueryLends : Form
    {
        frmMain frmMain = new frmMain();
        public frmQueryLends()
        {
            InitializeComponent();
            frmMain.getDataFromDBQuery("BIBLIOTECA.accdb", "PRÉSTAMOS", grdLends);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQueryLends_Load(object sender, EventArgs e)
        {

        }
    }
}
