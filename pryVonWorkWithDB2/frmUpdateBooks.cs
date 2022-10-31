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
    public partial class frmUpdateBooks : Form
    {
        public frmMain frmMain = new frmMain();
        public frmUpdateBooks()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain.Show();
        }

        private void bntActualizar_Click(object sender, EventArgs e)
        {
            string nuevoTitulo = txtTitulo.Text;
            int codLibro = int.Parse(txtNumber.Text);
            bool flagIsInDB = false;

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
                if (int.Parse(reader[3].ToString()) == codLibro)
                {
                    Console.WriteLine("La persona está en la base de datos, podemos seguir con el programa");
                    flagIsInDB = true;
                }

                Console.WriteLine(reader[3].ToString());
            }

            //only if he/she is in the db, we can update his debt
            if (flagIsInDB == true)
            {
                //I found this in internet, bcs i couldn't make it work out the other way
                //defines the query, the conection and the parameters in the command, 
                using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                    "UPDATE Libros SET Título=@titulo WHERE [Nº Libro]=@numLibro", conexionDB))
                {
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@titulo", nuevoTitulo));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@numLibro", codLibro));
                    commandUpdate.ExecuteNonQuery();
                }

                conexionDB.Close();
                MessageBox.Show("Dato actualizado");
            }
            else
            {
                MessageBox.Show("La persona no se encuentra en la base de datos");
            }
        }
    }
}
