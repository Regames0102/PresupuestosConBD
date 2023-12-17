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
    public partial class Form1 : Form
    {
        string cadenaconex;
        public Form1()
        {
            InitializeComponent();
        }
        public MySqlConnection mycon;


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
        private void button1_Click(object sender, EventArgs e)
        {
            string host = TXHost.Text;
            string user = TXUser.Text;
            string password = TXContra.Text;
            string bd = TXBD.Text;
            cadenaconex = "server=" + host + ";user id=" + user + ";password=" + password + ";database=" + bd + ";persistsecurityinfo=True";
            Form2 MenuPresupuesto = new Form2(cadenaconex, this);
            if (conectar())
            {
                MenuPresupuesto.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
