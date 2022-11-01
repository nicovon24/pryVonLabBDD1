using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
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
            //frmMain.getDataFromDBQuery("BIBLIOTECA.accdb", "PRÉSTAMOS", grdLends);
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
            //openning the data base!
            OleDbConnection dbConnection = new OleDbConnection(frmMain.accessURL + "BIBLIOTECA.accdb");
            dbConnection.Open();

            //getting data from the db
            OleDbCommand commandPrestamos = new OleDbCommand();

            commandPrestamos.Connection = dbConnection; //connecting .net with the DB
            commandPrestamos.CommandType = CommandType.TableDirect; //getting the data from a table
            commandPrestamos.CommandText = "PRÉSTAMOS"; ///name of the table

            //data reading: reading only the data
            OleDbDataReader readerPrestamos = commandPrestamos.ExecuteReader();

            //we add the 
            while (readerPrestamos.Read())
            {
                string socio = "", libro = "";

                OleDbCommand commandSocios = new OleDbCommand();
                OleDbCommand commandNumLibro = new OleDbCommand();

                //socio
                commandSocios.Connection = dbConnection; 
                commandSocios.CommandType = CommandType.TableDirect; 
                commandSocios.CommandText = "SELECT * FROM SOCIOS"; 
                OleDbDataReader readerSocios = commandSocios.ExecuteReader();

                //num libro
                commandNumLibro.Connection = dbConnection;
                commandNumLibro.CommandType = CommandType.TableDirect;
                commandNumLibro.CommandText = "SELECT * FROM LIBROS";
                OleDbDataReader readerNumLibro = commandNumLibro.ExecuteReader();

                //reading the socio
                while (readerSocios.Read())
                {
                    if (readerSocios["Nº Socio"].ToString() == readerPrestamos["Nº Socio"].ToString())
                    {
                        socio = readerSocios["Nombre"].ToString();
                    }
                }

                //reading the num libro
                while (readerNumLibro.Read())
                {
                    if (readerNumLibro["Nº Libro"].ToString() == readerPrestamos["Nº Libro"].ToString())
                    {
                        libro = readerNumLibro["Título"].ToString();
                    }
                }

                grdLends.Rows.Add(readerPrestamos[0], readerPrestamos[1], socio, libro, readerPrestamos[4]);
            }

            readerPrestamos.Close();
            dbConnection.Close();
        }
    }
}
