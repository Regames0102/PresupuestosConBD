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
    public partial class Form3 : Form
    {
        string cadenaconex;
        int siguienteId;
        public MySqlConnection mycon;
        public Form3(string cadenaconex)
        {
            this.cadenaconex = cadenaconex;
            conectar();
            InitializeComponent();
            int idalto = Convert.ToInt32(ObtenerSiguienteIdAlumnos());
            TXCodigo.Text = idalto.ToString();

            this.Size= new System.Drawing.Size(711, 200);
            
        }
        private int ObtenerSiguienteIdAlumnos()
        {
            siguienteId = 1; // Valor predeterminado si no hay registros en la base de datos
            try
            {
                string query = "SELECT MAX(Codigo) FROM presupuestos";
                MySqlCommand comandoDB = new MySqlCommand(query, mycon);

                // Ejecuta la consulta y obtén el resultado
                object resultado = comandoDB.ExecuteScalar();

                if (resultado != DBNull.Value)
                {
                    // Si hay registros, obtén el máximo y suma uno
                    siguienteId = Convert.ToInt32(resultado) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID: " + ex.Message);
            }

            return siguienteId;
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

        private void Guardar_Click(object sender, EventArgs e)
        {
            
            if (meterPresupuesto())
            {
                MessageBox.Show("Introducido correctamente");
            }
            else
            {
                this.Size = new System.Drawing.Size(1144, 702);
                CenterToScreen();
            }
            
        }
        private bool meterPresupuesto() {
            string id = TXCodigo.Text;
            string total = "0";
            string fecha = Fecha.Value.ToString("yyyy-MM-dd");
            try
            { 
                string query = "INSERT INTO presupuestos (Codigo,Fecha,Total) VALUES (@Id,@Fecha,@total)";
                MySqlCommand comandoDB = new MySqlCommand(query, mycon);
                comandoDB.Parameters.AddWithValue("@Id", id);
                comandoDB.Parameters.AddWithValue("@Fecha", fecha);
                comandoDB.Parameters.AddWithValue("@total", total);
                comandoDB.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar usuario a la base de datos: {ex.Message}");
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 lineas = new Form4();
            lineas.ShowDialog();
        }
    }
}
