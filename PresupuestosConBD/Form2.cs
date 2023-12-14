using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresupuestosConBD
{
    public partial class Form2 : Form
    {
        Form1 login;
        string cadenaconex;
        public MySqlConnection mycon;
        public Form2(string cadenaconex,Form1 login)
        {
            InitializeComponent();
            this.login = login;
            this.cadenaconex = cadenaconex;
            conectar();
            mostrardatos();
        }
        public void mostrardatos()
        {
           
            string query = "SELECT Codigo, Fecha, Total from presupuestos;";
            MySqlCommand comandoDB = new MySqlCommand(query, mycon);
            MySqlDataReader reader;
            try
            {
                reader = comandoDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgPresupuestos.Rows.Add();
                        dgPresupuestos.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgPresupuestos.Rows[n].Cells[1].Value = reader.GetDateTime(1).ToShortDateString();
                        dgPresupuestos.Rows[n].Cells[2].Value = reader.GetString(2);

                        //MessageBox.Show(reader.GetString(1));
                    }
                }
                reader.Close();
                }
            catch (Exception)
            {

            }


        }



        public bool conectar()
        {
            try
            {

                mycon = new MySqlConnection(cadenaconex);
                mycon.Open();
                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("Credenciales Incorrectas");
                return false;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 crearPresu = new Form3(cadenaconex);
            crearPresu.Show();
        }
        private void fecha()
        {
           
        }

        private void dgPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
