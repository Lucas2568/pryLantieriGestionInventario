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
            clsConexionBD.cargarCategorias(cbxNombre);
            clsConexionBD.cargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
