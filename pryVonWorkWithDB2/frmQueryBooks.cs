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
using System.Security.AccessControl;

namespace pryVonWorkWithDB2
{
    public partial class frmQueryBooks : Form
    {
        frmMain frmMain = new frmMain();
        public frmQueryBooks()
        {
            InitializeComponent();
            //openning the data base!
            OleDbConnection dbConnection = new OleDbConnection(frmMain.accessURL + "BIBLIOTECA.accdb");
            dbConnection.Open();

            //getting data from the db
            OleDbCommand bringFromDB = new OleDbCommand();

            bringFromDB.Connection = dbConnection; //connecting .net with the DB
            bringFromDB.CommandType = CommandType.TableDirect; //getting the data from a table
            bringFromDB.CommandText = "LIBROS"; ///name of the table

            //data reading: reading only the data
            OleDbDataReader reader = bringFromDB.ExecuteReader();

            //we add the 
            while (reader.Read())
            {
                //date
                string day = Convert.ToDateTime(reader[2]).Day.ToString();
                string month = Convert.ToDateTime(reader[2]).Month.ToString();
                string year = Convert.ToDateTime(reader[2]).Year.ToString();
                string date = day + "/" + month + "/" + year;

                grdBOOKS.Rows.Add(reader[0], reader[1], date, reader[3]); 
            }

            dbConnection.Close();
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
