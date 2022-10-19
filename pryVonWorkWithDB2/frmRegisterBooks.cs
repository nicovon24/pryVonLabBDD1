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

namespace pryVonWorkWithDB2
{
    public partial class frmRegisterBooks : Form
    {
        frmMain frmMain = new frmMain();
        public frmRegisterBooks()
        {
            InitializeComponent();
        }

        private void frmRegisterBooks_Load(object sender, EventArgs e)
        {


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                int varNumLibro = Convert.ToInt32(nudNumLibro.Text);

                OleDbConnection dbConnection = new OleDbConnection(frmMain.accessURL + "BIBLIOTECA.accdb");
                dbConnection.Open();

                OleDbCommand bringFromDB = new OleDbCommand();

                bringFromDB.Connection = dbConnection; //connecting .net with the DB
                bringFromDB.CommandType = CommandType.TableDirect; //getting the data from a table
                bringFromDB.CommandText = "LIBROS"; ///name of the table

                OleDbDataReader lectorDeConsulta = bringFromDB.ExecuteReader();

                bool flag = false;

                while (lectorDeConsulta.Read())
                {
                    if (Convert.ToInt32(lectorDeConsulta[3].ToString()) == varNumLibro)
                    {
                        flag = true;
                    }
                }

                //we execute this code if the numLibro is not in the access file
                if (flag == false)
                {
                    OleDbCommand ComandoDb = new OleDbCommand();
                    ComandoDb.Connection = dbConnection;
                    ComandoDb.CommandType = CommandType.Text;
                    ComandoDb.CommandText = "INSERT INTO " +
                    "LIBROS (Título, Autor, Fecha Editado, Nº Libro) " +
                    "VALUES(' " + txtAutor + " ', ' " + txtTitulo + " ' , ' " + dtpFecha.Text + " ' ," + 
                    nudNumLibro.Text + ")";

                    MessageBox.Show("Dato cargado");
                }
                else
                {
                    MessageBox.Show("ID repetido");
                }
                lectorDeConsulta.Close();
                dbConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
