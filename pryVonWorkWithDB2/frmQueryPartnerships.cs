using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        }

        private void frmQueryPartnerships_Load(object sender, EventArgs e)
        {
            //openning the data base!
            OleDbConnection dbConnection = new OleDbConnection(frmMain.accessURL + "BIBLIOTECA.accdb");
            dbConnection.Open();

            //getting data from the db
            OleDbCommand bringFromDB = new OleDbCommand();

            bringFromDB.Connection = dbConnection; //connecting .net with the DB
            bringFromDB.CommandType = CommandType.TableDirect; //getting the data from a table
            bringFromDB.CommandText = "SOCIOS"; ///name of the table

            //data reading: reading only the data
            OleDbDataReader reader = bringFromDB.ExecuteReader();

            //we add the 
            while (reader.Read())
            {
                //date
                string day = Convert.ToDateTime(reader[3]).Day.ToString();
                string month = Convert.ToDateTime(reader[3]).Month.ToString();
                string year = Convert.ToDateTime(reader[3]).Year.ToString();
                string date = day + "/" + month + "/" + year;
                Console.WriteLine(date);

                grdPartners.Rows.Add(reader[0], reader[1], reader[2], date, reader[4]);
            }
            reader.Close();
            dbConnection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void grdPartners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
