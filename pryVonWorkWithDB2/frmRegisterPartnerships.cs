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
    public partial class frmRegisterPartnerships : Form
    {
        public frmRegisterPartnerships()
        {
            InitializeComponent();
            DateTimePicker varDateEntrega = dtpFechaInscripcion;

            varDateEntrega.Format = DateTimePickerFormat.Custom;
            varDateEntrega.CustomFormat = "d/M/yyyy";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();

        }

        private void frmRegisterPartnerships_Load(object sender, EventArgs e)
        {
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            try{
                if (txtNombre.Text != "" && txtDireccion.Text != "" && nudTelefono.Text != "100000000" && nudTelefono.Text != "100000000")
                {
                    OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BIBLIOTECA.accdb");
                    dbConnection.Open();

                    //we execute this code if the numLibro is not in the access file
                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = dbConnection;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO SOCIOS ([Nombre], [DIRECCIÓN], [Número teléfono], [Fecha Inscripción])" +
                    " VALUES('" + txtNombre.Text + "','" + txtDireccion.Text + "','" + nudTelefono.Text + "','" + dtpFechaInscripcion.Text + "')";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dato cargado");
                    dbConnection.Close();
                    txtDireccion.Text = "";
                    txtNombre.Text = "";
                    nudTelefono.Value = 100000000;
                    dtpFechaInscripcion.Text = DateTime.Now.Date.ToString();
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("Datos incompletos, idiota");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
