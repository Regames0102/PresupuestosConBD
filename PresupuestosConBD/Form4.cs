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
    public partial class Form4 : Form
    {
        public int id;
        public int idPresu;
        public int idArt;
        public string desc;
        public int cant;
        public int precio;
        public int siguienteId;
        string cadenaconex;
        public MySqlConnection mycon;
        public MySqlConnection mycon2;
        public Form4(string cadenaconex)
        {
            InitializeComponent();
            this.cadenaconex = cadenaconex;
            conectar();
        }
        public bool conectar()
        {
            try
            {

                mycon = new MySqlConnection(cadenaconex);
                mycon2 = new MySqlConnection(cadenaconex);
                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("Credenciales Incorrectas");
                return false;
            }
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.id = (int)TXID.Value;
            this.idPresu = (int)TXIDPresu.Value;
            this.idArt = (int)TXIDArt.Value;
            this.desc = TXdesc.Text;
            this.cant = (int)TXCant.Value;
            this.precio = (int)TXprec.Value;
        }

        private void TXIDArt_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TXIDArt.Value); // No es necesario convertir a cadena y luego a entero

            string query = "SELECT Descripcion, Precio FROM articulos WHERE Id = " + id;

            try
            {
                using (MySqlCommand comando = new MySqlCommand(query, mycon))
                {
                    mycon.Open();
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string descripcion = reader["Descripcion"].ToString();
                            double precio = Convert.ToDouble(reader["Precio"]);

                            TXdesc.Text = descripcion;
                            TXprec.Value = Convert.ToDecimal(precio);
                        }
                        else
                        {
                            TXdesc.Text = string.Empty;
                            TXprec.Value = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mycon.Close(); // Asegúrate de cerrar la conexión en caso de error
            }
        }
        private int ObtenerSiguientesIds()
        {
            mycon.Open();
            mycon2.Open();
            siguienteId = 1; // Valor predeterminado si no hay registros en la base de datos
            try
            {
                string query = "SELECT MAX(Id) FROM lineas";
                string query2 = "SELECT MAX(Id) FROM presupuestos";
                MySqlCommand comandoDB = new MySqlCommand(query, mycon);
                MySqlCommand comandoDB2 = new MySqlCommand(query2, mycon2);

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
            finally
            {
                mycon.Close();
            }

            return siguienteId;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ObtenerSiguientesIds();
            this.TXID.Value = siguienteId;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
