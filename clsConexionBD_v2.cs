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

namespace pryLantieriLucasIventario
{
    internal class clsConexionBD
    {
        //cadena de conexion
        //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../dbGestionInventario1.accdb";
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
            comandoBaseDatos.CommandText = "SELECT categoria_de_producto FROM Productos";
            lectorDataReader = comandoBaseDatos.ExecuteReader();

            while (lectorDataReader.Read()) 
            {
                if (!cbxCategoria.Items.Contains(Convert.ToInt32(lectorDataReader[0])))
                  {
                    cbxCategoria.Items.Add(lectorDataReader[0]);
                }
               
            }
        }
        public void cargarDatos(Int32 txtCodigo, int cbxCategoria, string txtNombre, string txtObservaciones)
        {
            try
            {
                // Creo el comando y le asigno la conexión
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText =
                    "INSERT INTO Productos (Id1, categoria_de_producto, NOMBRE, observaciones) " +
                    $"VALUES ({txtCodigo}, {cbxCategoria}, {txtNombre}, {txtObservaciones})";

                // Agrego parámetros
                comandoBaseDatos.Parameters.AddWithValue("ID", txtCodigo);
                comandoBaseDatos.Parameters.AddWithValue("Categoria", cbxCategoria);
                comandoBaseDatos.Parameters.AddWithValue("Nombre", txtNombre);
                comandoBaseDatos.Parameters.AddWithValue("Observaciones", txtObservaciones);

                // Ejecuto la consulta
                int filasAfectadas = comandoBaseDatos.ExecuteNonQuery();

                MessageBox.Show($"Filas insertadas: {filasAfectadas}");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }
    }
}
