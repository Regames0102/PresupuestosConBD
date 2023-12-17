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
        int idalto;
        int idlinea;
        int idart;
        string desc;
        int cant;
        int precio;
        bool modificar;
        public Form3(string cadenaconex, bool modificar)
        {
            this.cadenaconex = cadenaconex;
            conectar();
            InitializeComponent();
            idalto = Convert.ToInt32(ObtenerSiguienteIdAlumnos());
            TXCodigo.Text = idalto.ToString();
            this.modificar = modificar;

            this.Size= new System.Drawing.Size(711, 200);
            
        }
        private int ObtenerSiguienteIdAlumnos()
        {
            siguienteId = 1; // Valor predeterminado si no hay registros en la base de datos
            try
            {
                string query = "SELECT MAX(Id) FROM presupuestos";
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
            if (!modificar)
            {
                if (meterPresupuesto())
                {
                    MessageBox.Show("Introducido correctamente");
                    this.Size = new Size(1144, 702);
                    CenterToScreen();
                }
                else
                {

                }
            }
            
            
        }
        private bool meterPresupuesto() {
            string id = TXCodigo.Text;
            string total = "0";
            string fecha = Fecha.Value.ToString("yyyy-MM-dd");
            try
            { 
                string query = "INSERT INTO presupuestos (Id,Fecha,Total) VALUES (@Id,@Fecha,@total)";
                MySqlCommand comandoDB = new MySqlCommand(query, mycon);
                comandoDB.Parameters.AddWithValue("@Id", id);
                comandoDB.Parameters.AddWithValue("@Fecha", fecha);
                comandoDB.Parameters.AddWithValue("@total", total);
                comandoDB.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar presupuestos a la base de datos: {ex.Message}");
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 lineas = new Form4(cadenaconex);
            lineas.TXIDPresu.Value = idalto;
            if (lineas.ShowDialog()==DialogResult.OK)
            {
                 idlinea = lineas.id;
                 idart = lineas.idArt;
                 desc = lineas.desc;
                 cant = lineas.cant;
                 precio = lineas.precio;
                dglineas.Rows.Add();
                int rowIndex = dglineas.Rows.Count - 1;
                dglineas.Rows[rowIndex].Cells[0].Value=idlinea;
                dglineas.Rows[rowIndex].Cells[1].Value=idalto.ToString();
                dglineas.Rows[rowIndex].Cells[2].Value=idart;
                dglineas.Rows[rowIndex].Cells[3].Value=desc;
                dglineas.Rows[rowIndex].Cells[4].Value=cant;
                dglineas.Rows[rowIndex].Cells[5].Value=precio;
                añadirlineaBD();
            }
        }
        private void añadirlineaBD()
        {
            try
            {
                string query = "INSERT INTO lineas (Id,IdPresu,IdArticulo,Descripcion,Cantidad,Precio) VALUES (@id,@idpresu,@idart,@desc,@cant,@precio)";
                MySqlCommand comandoDB = new MySqlCommand(query, mycon);
                comandoDB.Parameters.AddWithValue("@id", idlinea);
                comandoDB.Parameters.AddWithValue("@idpresu", idalto.ToString()); ;
                comandoDB.Parameters.AddWithValue("@idart", idart);
                comandoDB.Parameters.AddWithValue("@desc", desc);
                comandoDB.Parameters.AddWithValue("@cant", cant);
                comandoDB.Parameters.AddWithValue("@precio", precio);
                comandoDB.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar lineas a la base de datos: {ex.Message}");
            }
        }
    }
}
