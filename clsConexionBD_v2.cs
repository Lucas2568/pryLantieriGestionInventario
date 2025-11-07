using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

//para conexion de ACcess
using System.Data.OleDb;

using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryLantieriLucasIventario
{
    internal class clsConexionBD
    {
        //cadena de conexion
        //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../dbGestionInventario2.accdb";
        //conector
        //SqlConnection coneccionBaseDatos;
        OleDbConnection coneccionBaseDatos;
        //comando
        //SqlCommand comandoBaseDatos;
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;
        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                //coneccionBaseDatos = new SqlConnection(cadenaConexion);
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                
                nombreBaseDeDatos = coneccionBaseDatos.DataSource;

                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }     

        }

        public void cargarCategorias(ComboBox cbxCategoria) 
        { 
            //creo en memoria
            comandoBaseDatos = new OleDbCommand();
            //cargo la conexion a la base
            comandoBaseDatos.Connection = coneccionBaseDatos;
            //dar inidicaciones
            comandoBaseDatos.CommandText = "SELECT Categoría FROM Productos";
            lectorDataReader = comandoBaseDatos.ExecuteReader();

            while (lectorDataReader.Read()) 
            {
                if (!cbxCategoria.Items.Contains(Convert.ToInt32(lectorDataReader[0])))
                  {
                    cbxCategoria.Items.Add(lectorDataReader[0]);
                }
               
            }
        }
        public void cargarDatos(Int32 txtCodigo, Int32 cbxCategoria, string txtNombre, string txtObservaciones, decimal txtPrecio, string txtStock)
        {
            try 
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "INSERT INTO Productos (Código, Nombre, Descripción, Precio, Stock, Categoría) " +
            $"VALUES ({txtCodigo}, '{txtNombre}', '{txtObservaciones}', {txtPrecio}, {txtStock}, {cbxCategoria})";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                MessageBox.Show("Producto agregado con éxito.");
            } 
            
            
            catch (Exception error) 
            {
                MessageBox.Show("Los datos ingresados son incorrectos. - " + error.Message);
            }
        }
        public void buscarPorCodigo(int codigo, TextBox txtNombre, TextBox txtDescripcion, TextBox txtStock, TextBox txtPrecio, ComboBox cbxCategoria)
        {
            try
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT * FROM Productos WHERE Código = @codigo";
                comandoBaseDatos.Parameters.AddWithValue("@codigo", codigo);
                lectorDataReader = comandoBaseDatos.ExecuteReader();

                if (lectorDataReader.Read())
                {
                    txtNombre.Text = lectorDataReader["Nombre"].ToString();
                    txtDescripcion.Text = lectorDataReader["Descripción"].ToString();
                    txtStock.Text = lectorDataReader["Stock"].ToString();
                    txtPrecio.Text = lectorDataReader["Precio"].ToString();
                    cbxCategoria.Text = lectorDataReader["Categoría"].ToString();
                    MessageBox.Show("Código encontrado");
                }
                else
                {
                    MessageBox.Show("No se encontró un producto con ese código.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                if (coneccionBaseDatos != null)
                    coneccionBaseDatos.Close();
            }
        }

        public void modificarDatos(Int32 txtCodigo, Int32 cbxCategoria, string txtNombre, string txtDescripcion, decimal txtPrecio, string txtStock)
        {
            try
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = $"UPDATE Productos SET Nombre = '{txtNombre}', Descripción = '{txtDescripcion}', Precio = {txtPrecio}, Stock = {txtStock}, Categoría = {cbxCategoria} WHERE Código = {txtCodigo}";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                MessageBox.Show("Modificación exitosa.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al intentar modificar el producto buscado. - " + error.Message);
            }
        }

        public void eliminarProductos(int codigo)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este producto?"
                    , "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                    coneccionBaseDatos.Open();
                    comandoBaseDatos = new OleDbCommand();
                    comandoBaseDatos.Connection = coneccionBaseDatos;
                    comandoBaseDatos.CommandText = $"DELETE FROM Productos WHERE Código = {codigo}";
                    comandoBaseDatos.ExecuteNonQuery();
                    MessageBox.Show("¡El producto ha sido eliminado exitosamente!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo eliminar el producto. - " + e.Message);
            }
        }
        public void CargarChartStockDesdeBD(Chart chartProductos)
        {
            try
            {
                chartProductos.Series.Add("Iventario");
                chartProductos.ChartAreas[0].AxisX.Title = "Productos";
                chartProductos.ChartAreas[0].AxisY.Title = "Stock";
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Nombre, Stock FROM Productos";
                lectorDataReader = comandoBaseDatos.ExecuteReader();

                while (lectorDataReader.Read())
                {
                    string producto = lectorDataReader[0].ToString();
                    Int32 stock = Convert.ToInt32(lectorDataReader[1]);
                    int indice = chartProductos.Series[0].Points.AddY(stock);
                    chartProductos.Series[0].Points[indice].AxisLabel = producto;
                    if (stock < 3)
                    {
                        chartProductos.Series[0].Points[indice].Color = Color.Red;
                    }
                    else if (stock > 10)
                    {
                        chartProductos.Series[0].Points[indice].Color = Color.Green;
                    }

                }
            }
            catch
            {
                MessageBox.Show("No se pudieron obtener los datos solicitados");
            }

        }
        public void buscarPorCategoria(string categoria, string elemento, DataGridView dgvCategoria)
        {
            try
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                if (categoria != "Nombre")
                {
                    Convert.ToInt32(elemento);
                }
                comandoBaseDatos.CommandText = $"SELECT * FROM Productos WHERE {categoria}=@elemento";
                comandoBaseDatos.Parameters.AddWithValue("@elemento", elemento);
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                while (lectorDataReader.Read())
                {
                    dgvCategoria.Rows.Add(lectorDataReader[0], lectorDataReader[1], lectorDataReader[2], lectorDataReader[3], lectorDataReader[4], lectorDataReader[5]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la categoría o el valor ingresado.");
            }
        }
    }
}
