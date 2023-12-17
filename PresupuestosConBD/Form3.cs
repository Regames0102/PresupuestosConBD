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
        public MySqlConnection mycon2;
        int idalto;
        int idlinea;
        int idart;
        string desc;
        int cant;
        decimal precio;
        bool modificar;
        int idfila;
        Form2 form2;
        public Form3(string cadenaconex, bool modificar, Form2 form2)
        {
            this.cadenaconex = cadenaconex;
            conectar();
            InitializeComponent();
            idalto = Convert.ToInt32(ObtenerSiguienteIdAlumnos());
            TXCodigo.Text = idalto.ToString();
            this.modificar = modificar;
            this.form2 = form2;

            this.Size= new System.Drawing.Size(711, 200);
            
        }
        private int ObtenerSiguienteIdAlumnos()
        {
            mycon.Open();
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
                mycon2 = new MySqlConnection(cadenaconex);
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
                    label1.Hide();
                    label2.Hide();
                    TXCodigo.Hide();
                    Fecha.Hide();
                    Guardar.Hide();
                    dglineas.Show();
                    menu.Show();
                }
                else
                {

                }
            }
            
            
        }
        private bool meterPresupuesto()
        {
            mycon.Open();
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
                form2.mostrardatos();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar presupuestos a la base de datos: {ex.Message}");
            }
            finally
            {
                mycon.Close();
            }
            return false;
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

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 lineas = new Form4(cadenaconex,modificar);
            lineas.TXIDPresu.Value = idalto;
            lineas.TXID.Value = siguienteId;
            cogervalordg();
            if (lineas.ShowDialog() == DialogResult.OK)
            {
                idlinea = lineas.id;
                idart = lineas.idArt;
                desc = lineas.desc;
                cant = lineas.cant;
                precio = lineas.precio;
                dglineas.Rows.Add();
                int rowIndex = dglineas.Rows.Count - 1;
                dglineas.Rows[rowIndex].Cells[0].Value = idlinea;
                dglineas.Rows[rowIndex].Cells[1].Value = idalto.ToString();
                dglineas.Rows[rowIndex].Cells[2].Value = idart;
                dglineas.Rows[rowIndex].Cells[3].Value = desc;
                dglineas.Rows[rowIndex].Cells[4].Value = cant;
                dglineas.Rows[rowIndex].Cells[5].Value = precio;
                calculartotal();
                calcularymostrarTotal();
                siguienteId++;
            }
        }

        private void dglineas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dglineas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("La nota seleccionada será borrada, ¿Quieres continuar?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    // Obtén el valor de la clave primaria de la fila seleccionada
                    int idEliminar = Convert.ToInt32(dglineas.SelectedRows[0].Cells[0].Value);
                        MessageBox.Show("Fila eliminada con éxito.");
                        dglineas.Rows.RemoveAt(dglineas.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de eliminar.");
            }
        }
        private void cogervalordg()
        {
            int valorMaximo = int.MinValue; // Inicializar con el valor mínimo posible para enteros

            foreach (DataGridViewRow fila in dglineas.Rows)
            {
                if (fila.Cells["Codigo"].Value != null)
                {
                    int valorActual = Convert.ToInt32(fila.Cells["Codigo"].Value);
                    valorMaximo = Math.Max(valorMaximo, valorActual);
                    int idalto = valorMaximo++;
                }
            }

        }
        private void calcularymostrarTotal()
        {
            decimal sumaTotales = 0;
            foreach (DataGridViewRow fila in dglineas.Rows)
            {
                if (!fila.IsNewRow) // Excluye la fila nueva si está presente
                {
                    decimal totalLinea = Convert.ToDecimal(fila.Cells["Total"].Value);
                    sumaTotales += totalLinea;
                }
            }
            TXTotal.Text = sumaTotales.ToString();
        }
        private void calcularyasignartotal() {
            decimal sumaTotales = 0;

            foreach (DataGridViewRow fila in dglineas.Rows)
            {
                if (!fila.IsNewRow) // Excluye la fila nueva si está presente
                {
                    decimal totalLinea = Convert.ToDecimal(fila.Cells["Total"].Value);
                    sumaTotales += totalLinea;
                }
            }
            int indiceFilaPresupuesto = (form2.ObtenerIndiceFilaPresupuesto(idalto.ToString()))+1; // Debes implementar este método
            try
            {

                // Supongamos que tienes una tabla 'Presupuestos' con columnas 'Codigo' y 'Total'
                string query = "UPDATE presupuestos SET Total = @total WHERE Id = @codigoPresupuesto";

                using (MySqlCommand comando = new MySqlCommand(query, mycon))
                {
                    comando.Parameters.AddWithValue("@total", sumaTotales);
                    comando.Parameters.AddWithValue("@codigoPresupuesto", indiceFilaPresupuesto);

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Actualización exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message);
            }
            finally
            {
                mycon.Close();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indice;
            modificar = true;
            indice = (dglineas.CurrentRow != null) ? dglineas.CurrentRow.Index : -1;

            cogervalordg();


            if (indice != -1 && indice < dglineas.Rows.Count)
            {
                int idAntiguo;
                int idNuevo;
                string nombrenuevo;
                string apellidonuevo;
                if (modificar)
                {
                    Form4 modificaForm = new Form4(cadenaconex, modificar);
                    modificaForm.BackColor = Color.DarkGray;
                    //cargo los datos de la fila seleccionada en el formulario

                    idAntiguo = Convert.ToInt32(dglineas.Rows[indice].Cells[0].Value);
                    modificaForm.TXID.Text = dglineas.Rows[indice].Cells[0].Value.ToString();
                    modificaForm.TXIDPresu.Text = dglineas.Rows[indice].Cells[1].Value.ToString();
                    modificaForm.TXIDArt.Text = dglineas.Rows[indice].Cells[2].Value.ToString();
                    modificaForm.TXdesc.Text = dglineas.Rows[indice].Cells[3].Value.ToString();
                    modificaForm.TXCant.Text = dglineas.Rows[indice].Cells[4].Value.ToString();
                    modificaForm.TXprec.Text = dglineas.Rows[indice].Cells[5].Value.ToString();

                    //muestro el formulario
                    DialogResult resu = modificaForm.ShowDialog();

                    if (resu == DialogResult.OK)
                    {
                        dglineas.Rows[indice].Cells[0].Value = modificaForm.id;
                        dglineas.Rows[indice].Cells[1].Value = modificaForm.idPresu;
                        dglineas.Rows[indice].Cells[2].Value = modificaForm.idArt;
                        dglineas.Rows[indice].Cells[3].Value = modificaForm.desc;
                        dglineas.Rows[indice].Cells[4].Value = modificaForm.cant;
                        dglineas.Rows[indice].Cells[5].Value = modificaForm.precio;
                    }
                }
 
            }
        }

        private void dglineas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int ObtenerSiguientesIds()
        { 
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

        private void Form3_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Size = new Size(1144, 702);
                CenterToScreen();
                label1.Hide();
                label2.Hide();
                TXCodigo.Hide();
                Fecha.Hide();
                Guardar.Hide();
                dglineas.Show();
                menu.Show();
            }
            ObtenerSiguientesIds();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mycon.Open();

                foreach (DataGridViewRow fila in dglineas.Rows)
                {
                    if (!fila.IsNewRow) // Excluye la fila nueva si está presente
                    {
                        // Obtén los valores de las celdas en cada fila
                        int id = Convert.ToInt32(fila.Cells["Codigo"].Value);
                        int idpresu = Convert.ToInt32(fila.Cells["CodigoPresupuesto"].Value);
                        int idart = Convert.ToInt32(fila.Cells["CodigoArticulo"].Value);
                        
                        string descripcion = fila.Cells["Descripcion"].Value.ToString();
                        int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        double precio = Convert.ToDouble(fila.Cells["Prec"].Value);

                        // Construye la consulta de inserción
                        string query = "INSERT INTO lineas (Id,IdPresu,IdArticulo,Descripcion,Cantidad,Precio) VALUES (@id, @idpresu,@idart,@descripcion,@cantidad,@precio)";

                        using (MySqlCommand comando = new MySqlCommand(query, mycon))
                        {
                            // Añade parámetros para evitar la inyección de SQL
                            comando.Parameters.AddWithValue("@id", id);
                            comando.Parameters.AddWithValue("@idpresu", idpresu);
                            comando.Parameters.AddWithValue("@idart", idart);
                            comando.Parameters.AddWithValue("@descripcion", descripcion);
                            comando.Parameters.AddWithValue("@cantidad", cantidad);
                            comando.Parameters.AddWithValue("@precio", precio);

                            // Ejecuta la consulta de inserción
                            comando.ExecuteNonQuery();
                        }
                    }
                }
                calcularyasignartotal();
                MessageBox.Show("Inserción exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en la base de datos: " + ex.Message);
            }
            finally
            {
                mycon.Close();
                form2.mostrardatos();
                this.Close();
            }
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool EliminarPresu(int idEliminar)
        {
            mycon.Open();
            try
            {
                string query = "DELETE FROM presupuestos WHERE Id = @ID";
                MySqlCommand comandoDB = new MySqlCommand(query, mycon);
                comandoDB.Parameters.AddWithValue("@ID", idEliminar);

                int filasAfectadas = comandoDB.ExecuteNonQuery();

                return filasAfectadas > 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar fila: " + ex.Message);
                return false;
            }
            finally
            {
                mycon.Close();
            }
        }
        public void calculartotal()
        {
            foreach (DataGridViewRow fila in dglineas.Rows)
            {
                // Acceder a las celdas "Cantidad" y "Precio"
                object cantidadObj = fila.Cells["Cantidad"].Value;
                object precioObj = fila.Cells["Prec"].Value;

                // Verificar si los valores no son nulos o vacíos antes de convertir
                if (cantidadObj != null && precioObj != null && !string.IsNullOrEmpty(cantidadObj.ToString()) && !string.IsNullOrEmpty(precioObj.ToString()))
                {
                    int cantidad = Convert.ToInt32(cantidadObj);
                    decimal precio = Convert.ToDecimal(precioObj);

                    // Calcular el total
                    decimal total = Math.Round(cantidad * precio, 2);

                    // Asignar el total a la nueva columna
                    fila.Cells["Total"].Value = total;
                }
                else
                {
                    // Manejar el caso cuando los valores son nulos o vacíos
                    fila.Cells["Total"].Value = DBNull.Value;
                }
            }
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("El presupuesto seleccionado será borrada, ¿Quieres continuar?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                // Obtén el valor de la clave primaria de la fila seleccionada
                int idEliminar = idalto;

                // Realiza la eliminación en la base de datos   
                if (EliminarPresu(idEliminar))
                {
                    MessageBox.Show("Presupuesto eliminada con éxito.");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error al eliminar el presupuesto.");
                }
            }
        }

        private void calcularTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
