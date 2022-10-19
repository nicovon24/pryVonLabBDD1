using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using System.IO;
using System.Net;

namespace pryVonWorkWithDB2
{
    public partial class frmQueryBooks : Form
    {
        frmMain frmMain = new frmMain();
        public frmQueryBooks()
        {
            InitializeComponent();
            frmMain.getDataFromDBQuery("BIBLIOTECA.accdb", "LIBROS", grdBOOKS);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQueryBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            frmMain.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
    }
