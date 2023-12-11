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
        public Form2(string cadenaconex,Form1 login)
        {
            InitializeComponent();
            this.login = login;
            this.cadenaconex = cadenaconex;
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
    }
}
