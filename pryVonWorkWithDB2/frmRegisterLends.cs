using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryVonWorkWithDB2
{
    public partial class pryRegisterLends : Form
    {
        frmMain frmMain = new frmMain();
        public pryRegisterLends()
        {
            InitializeComponent();
        }

        private void pryRegisterLends_Load(object sender, EventArgs e)
        {

            DateTimePicker varDateEntrega = dtpFechaEntrega;
            DateTimePicker varDateRetiro = dtpFechaRetiro;

            varDateEntrega.Format = DateTimePickerFormat.Custom;
            varDateEntrega.CustomFormat = "d/M/yyyy";

            varDateRetiro.Format = DateTimePickerFormat.Custom;
            varDateRetiro.CustomFormat = "d/M/yyyy";
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if(nudNumLibro.Text!="0" && nudNumSocio.Text != "0")
                {
                    OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BIBLIOTECA.accdb");
                    dbConnection.Open();
                    DateTimePicker dateRetiro = dtpFechaRetiro;

                    //we execute this code if the numLibro is not in the access file
                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = dbConnection;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO PRÉSTAMOS ([Fecha Retiro], [Fecha Entrega], [Nº Socio], [Nº Libro])" +
                    " VALUES('" + dateRetiro.Text + "','" + dtpFechaEntrega.Text + "','" + nudNumSocio.Text + "','" + nudNumLibro.Text + "')";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dato cargado");
                    dbConnection.Close();

                    nudNumLibro.Value = 0;
                    nudNumSocio.Value = 0;
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }
    }
}
