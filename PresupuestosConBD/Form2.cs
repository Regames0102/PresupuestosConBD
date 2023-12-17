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
        bool modificar;
        int indice;
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
            dgPresupuestos.Rows.Clear();
            string query = "SELECT Id, Fecha, Total from presupuestos;";
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
            modificar = false;
            Form3 crearPresu = new Form3(cadenaconex,modificar,this);
            crearPresu.Show();
        }
        private void fecha()
        {
           
        }

        private void dgPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
         {
            modificar = true;
            Form3 modificarPresu = new Form3(cadenaconex,modificar,this);
           int  indices = (dgPresupuestos.CurrentRow != null) ? dgPresupuestos.CurrentRow.Index : -1;
            indices = indices + 1;
            try
            {

                string query = "SELECT id, idPresu, idArticulo, descripcion, Cantidad, Precio FROM lineas where IdPresu="+indices;
                MySqlCommand comando = new MySqlCommand(query,mycon);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = modificarPresu.dglineas.Rows.Add();
                        modificarPresu.dglineas.Rows[n].Cells[0].Value = reader.GetString(0);
                        modificarPresu.dglineas.Rows[n].Cells[1].Value = reader.GetString(1);
                        modificarPresu.dglineas.Rows[n].Cells[2].Value = reader.GetString(2);
                        modificarPresu.dglineas.Rows[n].Cells[3].Value = reader.GetString(3);
                        modificarPresu.dglineas.Rows[n].Cells[4].Value = reader.GetString(4);
                        modificarPresu.dglineas.Rows[n].Cells[5].Value = reader.GetString(5);
                    }
                    
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void dgPresupuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool EliminarPresu(int idEliminar)
        {
            try
            {
                string query = "DELETE FROM presupuestos WHERE Id = @ID";
                MySqlCommand comandoDB = new MySqlCommand(query, mycon);
                comandoDB.Parameters.AddWithValue("@ID", idEliminar);

                int filasAfectadas = comandoDB.ExecuteNonQuery();

                return filasAfectadas > 0;
                mostrardatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar fila: " + ex.Message);
                return false;
            }

        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgPresupuestos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("El presupuesto seleccionado será borrada, ¿Quieres continuar?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    // Obtén el valor de la clave primaria de la fila seleccionada
                    int idEliminar = Convert.ToInt32(dgPresupuestos.SelectedRows[0].Cells[0].Value);

                    // Realiza la eliminación en la base de datos   
                    if (EliminarPresu(idEliminar))
                    {
                        MessageBox.Show("Fila eliminada con éxito.");
                        dgPresupuestos.Rows.RemoveAt(dgPresupuestos.SelectedRows[0].Index);
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la fila.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de eliminar.");
            }
        }
         
        private void eliminarLineas()
        {

        }

        private void mostrarDatosFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrardatos();
        }
        public int ObtenerIndiceFilaPresupuesto(string codigoPresupuesto)
        {
            // Supongamos que la columna "Codigo" contiene los códigos de presupuesto en 'dgpresupuestos'
            string nombreColumnaCodigo = "Codigo";

            foreach (DataGridViewRow fila in dgPresupuestos.Rows)
            {
                if (fila.Cells[nombreColumnaCodigo].Value != null)
                {
                    string codigoPresupuestoFila = fila.Cells[nombreColumnaCodigo].Value.ToString();

                    // Comparar el código de presupuesto de la fila actual con el código proporcionado
                    if (codigoPresupuestoFila == codigoPresupuesto)
                    {
                        // Devolver el índice de la fila si se encuentra
                        return fila.Index;
                    }
                }
            }

            // Devolver -1 si no se encuentra la fila con el código de presupuesto proporcionado
            return -1;
        }
    }
}
