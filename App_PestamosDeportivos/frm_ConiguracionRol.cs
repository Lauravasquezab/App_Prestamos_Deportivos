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
    public partial class frm_ConiguracionRol : Form
    {
        public frm_ConiguracionRol()
        {
            InitializeComponent();
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_ConiguracionRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet.tbl_rol' Puede moverla o quitarla según sea necesario.
            this.tbl_rolTableAdapter.Fill(this.dbs_prestamos_deportivosDataSet.tbl_rol);

        }
    }
}
