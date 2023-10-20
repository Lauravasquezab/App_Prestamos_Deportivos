using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_PestamosDeportivos
{
    public partial class frm_prestamos : Form
    {
        public frm_prestamos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtImplemento.Clear();
            txtDescripcion.Clear();
            txtExistencias.Clear();
            txtNombreImpedimento.Clear();
            txtCantidadaPrestar.Clear();
            txtobservaciones.Clear();

        }
    }
}
