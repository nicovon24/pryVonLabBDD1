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
    public partial class frmQueryTitle : Form
    {
        public frmMain frmMain = new frmMain();
        public frmQueryTitle()
        {
            InitializeComponent();
            try
            {
                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(frmMain.accessURL + "BIBLIOTECA.accdb");
                conexionDB.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = conexionDB;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = "SELECT * FROM Libros";

                //data reading: reading only the data
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbTitle.Items.Add(reader["Título"].ToString());
                }
                reader.Close();
                conexionDB.Close();
            }
            catch
            {
                MessageBox.Show("Error en el pasado de datos al combo box");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbTitle.Text != "")
            {
                try
                {
                    OleDbConnection conexionDB;
                    conexionDB = new OleDbConnection(frmMain.accessURL + "BIBLIOTECA.accdb");
                    conexionDB.Open();

                    OleDbCommand command = new OleDbCommand();

                    command.Connection = conexionDB;
                    command.CommandType = CommandType.TableDirect;
                    command.CommandText = "SELECT * FROM Libros";

                    //data reading: reading only the data
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["Título"].ToString() == cbTitle.Text)
                        {
                            //author
                            lblAuthorRes.Text = reader["Autor"].ToString();

                            //date
                            string day = Convert.ToDateTime(reader["Fecha Editado"]).Day.ToString();
                            string month = Convert.ToDateTime(reader["Fecha Editado"]).Month.ToString();
                            string year = Convert.ToDateTime(reader["Fecha Editado"]).Year.ToString();
                            lblDateRes.Text = day + "/" + month + "/" + year;
                        }
                    }
                    reader.Close();
                    conexionDB.Close();
                }
                catch
                {
                    MessageBox.Show("Error en la consulta");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain.Show();
        }

        private void gbData_Enter(object sender, EventArgs e)
        {

        }
    }
}
