﻿using System;
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
    public partial class frmQueryPartnerships : Form
    {
        frmMain frmMain = new frmMain();
        public frmQueryPartnerships()
        {
            InitializeComponent();
            frmMain.getDataFromDBQuery("BIBLIOTECA.accdb", "SOCIOS", grdPartners);
        }

        private void frmQueryPartnerships_Load(object sender, EventArgs e)
        {

        }
    }
}
