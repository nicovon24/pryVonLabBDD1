﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;

namespace pryVonWorkWithDB2
{
    public partial class frmMain : Form
    {
        //-----global variables and functions for all the formulares in the projecy-----
        public string accessURL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";

        //-----FUNCTION GET DATA FROM DATA BASE, will be used in the other 3 query formulares-----
        public void getDataFromDBQuery(string endpoint, string tableName, DataGridView gridName)
        {
            //openning the data base!
            OleDbConnection dbConnection = new OleDbConnection(accessURL + endpoint);
            dbConnection.Open();

            //getting data from the db
            OleDbCommand bringFromDB = new OleDbCommand();

            bringFromDB.Connection = dbConnection; //connecting .net with the DB
            bringFromDB.CommandType = CommandType.TableDirect; //getting the data from a table
            bringFromDB.CommandText = tableName.ToUpper(); ///name of the table

            //data reading: reading only the data
            OleDbDataReader lectorDeConsulta = bringFromDB.ExecuteReader();

            //we add the 
            while (lectorDeConsulta.Read())
            {
                switch (gridName.Columns.Count)
                {
                    case 1: gridName.Rows.Add(lectorDeConsulta[0]); break;
                    case 2: gridName.Rows.Add(lectorDeConsulta[0], lectorDeConsulta[1]); break;
                    case 3: gridName.Rows.Add(lectorDeConsulta[0], lectorDeConsulta[1], lectorDeConsulta[2]); break;
                    case 4: gridName.Rows.Add(lectorDeConsulta[0], lectorDeConsulta[1], lectorDeConsulta[2], lectorDeConsulta[3]); break;
                    case 5: gridName.Rows.Add(lectorDeConsulta[0], lectorDeConsulta[1], lectorDeConsulta[2], lectorDeConsulta[3], lectorDeConsulta[4]); break;
                    case 6: gridName.Rows.Add(lectorDeConsulta[0], lectorDeConsulta[1], lectorDeConsulta[2], lectorDeConsulta[3], lectorDeConsulta[4], lectorDeConsulta[5]); break;
                    case 7: gridName.Rows.Add(lectorDeConsulta[0], lectorDeConsulta[1], lectorDeConsulta[2], lectorDeConsulta[3], lectorDeConsulta[4], lectorDeConsulta[5], lectorDeConsulta[6]); break;
                    case 8: gridName.Rows.Add(lectorDeConsulta[0], lectorDeConsulta[1], lectorDeConsulta[2], lectorDeConsulta[3], lectorDeConsulta[4], lectorDeConsulta[5], lectorDeConsulta[6], lectorDeConsulta[7]); break;
                    default: MessageBox.Show("Invalid table, too much columns for this program!"); break;
                }
            }

            dbConnection.Close();
        }

        public frmMain()
        {
            InitializeComponent();
        }
        private void queryBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryBooks frmQueryBooks = new frmQueryBooks();
            frmQueryBooks.Show();
        }

        private void queryLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void queryLendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryLends frmQueryLends = new frmQueryLends();
            frmQueryLends.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
             
        }

        private void registerBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterBooks frmRegisterBooks = new frmRegisterBooks();
            frmRegisterBooks.Show();
        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registerLendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pryRegisterLends frmRegisterLends = new pryRegisterLends();
            frmRegisterLends.Show();
        }

        private void queryPartnershipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryPartnerships frmNew = new frmQueryPartnerships();
            frmNew.Show();
        }

        private void registerPartnershipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterPartnerships frmNew = new frmRegisterPartnerships();
            frmNew.Show();
        }

        private void registerPartnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterPartnerships frmRegisterPartnerships = new frmRegisterPartnerships();
            frmRegisterPartnerships.Show();
        }
    }
}
