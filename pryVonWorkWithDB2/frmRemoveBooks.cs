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
    public partial class frmRemoveBooks : Form
    {
        public frmMain frmMain = new frmMain();
        public frmRemoveBooks()
        {
            InitializeComponent();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain.Show();
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
                int codigoLibro = int.Parse(txtNumber.Text);
                bool flagNumIsInDB = false;

                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(frmMain.accessURL + "BIBLIOTECA.accdb");
                conexionDB.Open();

                //checking if the person is in the db, if he is we can update his debt
                OleDbCommand commandFlag = new OleDbCommand();
                commandFlag.Connection = conexionDB;
                commandFlag.CommandType = CommandType.TableDirect;
                commandFlag.CommandText = "SELECT * FROM Libros";
                OleDbDataReader reader = commandFlag.ExecuteReader();
                while (reader.Read())
                {
                    if (int.Parse(reader["Nº Libro"].ToString()) == codigoLibro)
                    {
                        Console.WriteLine("La persona está en la base de datos, podemos seguir con el programa");
                        flagNumIsInDB = true;
                    }
                }

                //only if he/she is in the db, we can update his debt
                if (flagNumIsInDB == true)
                {
                    //I found this in internet, bcs i couldn't make it work out the other way
                    //defines the query, the conection and the parameters in the command, 
                    using (System.Data.OleDb.OleDbCommand commandDelete = new System.Data.OleDb.OleDbCommand(
                        "DELETE FROM Libros WHERE [Nº Libro]=@numLibro", conexionDB))
                    {
                        commandDelete.Parameters.Add(new System.Data.OleDb.OleDbParameter("numLibro", codigoLibro));
                        commandDelete.ExecuteNonQuery();
                    }

                    conexionDB.Close();
                    MessageBox.Show(" Cliente eliminado");
                }
                else
                {
                    MessageBox.Show("La persona no se encuentra en la base de datos");
                }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRemoveBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
