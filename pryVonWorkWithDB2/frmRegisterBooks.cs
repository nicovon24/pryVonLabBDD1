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
using System.Configuration;
using System.Runtime.InteropServices;

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
            DateTimePicker varDate = dtpFecha;
            varDate.Format = DateTimePickerFormat.Custom;
            varDate.CustomFormat = "d/M/yyyy";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAutor.Text != "" && txtTitulo.Text != "" && dtpFecha.Text != "")
                {
                    OleDbConnection dbConnection = new OleDbConnection(frmMain.accessURL + "BIBLIOTECA.accdb");
                    dbConnection.Open();

                    string varAutor = txtAutor.Text, varTitulo = txtTitulo.Text;

                    //we execute this code if the numLibro is not in the access file
                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = dbConnection;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO LIBROS (Título, Autor, [Fecha Editado])" +
                    " VALUES('" + varTitulo + "','" + varAutor + "','" + dtpFecha.Text + "')";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dato cargado");
                    dbConnection.Close();
                    txtAutor.Text = ""; txtTitulo.Text = "";
                    dtpFecha.Text = DateTime.Now.Date.ToString();
                    txtTitulo.Focus();
                }
                else
                {
                    MessageBox.Show("Datos incompletos, idiota");
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
