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
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pryLantieriLucasIventario.clsConexionBD clsConexionBD = new pryLantieriLucasIventario.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.cargarDatos(Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(cbxCategoria.SelectedValue), Convert.ToString(txtNombre.Text), Convert.ToString(txtDescripcion.Text));
        }
    }
}
