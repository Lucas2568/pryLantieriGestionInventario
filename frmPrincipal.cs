using pryLantieriLucasIventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLantieriGestionInventario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pryLantieriLucasIventario.clsConexionBD clsConexionBD = new pryLantieriLucasIventario.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.cargarCategorias(cbxCategoria);

            //clsConexionBDv3 conexionSQL = new clsConexionBDv3();
            //conexionSQL.ConectarBD();
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pryLantieriLucasIventario.clsConexionBD clsConexionBD = new pryLantieriLucasIventario.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.cargarDatos(Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(cbxCategoria.Text), txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToString(txtStock.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pryLantieriLucasIventario.clsConexionBD clsConexionBD = new pryLantieriLucasIventario.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.buscarPorCodigo(Convert.ToInt32(txtCodigo.Text), txtNombre, txtDescripcion,txtStock, txtPrecio, cbxCategoria);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pryLantieriLucasIventario.clsConexionBD clsConexionBD = new pryLantieriLucasIventario.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.modificarDatos(Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(cbxCategoria.Text), txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToString(txtStock.Text));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pryLantieriLucasIventario.clsConexionBD clsConexionBD = new pryLantieriLucasIventario.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.eliminarProductos(Convert.ToInt32(txtCodigo.Text));
        }
    }
}
