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
    public partial class Frm_ConfiguracionEstado : Form
    {
        public Frm_ConfiguracionEstado()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ConfiguracionEstado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet1.tbl_estado' Puede moverla o quitarla según sea necesario.
            this.tbl_estadoTableAdapter.Fill(this.dbs_prestamos_deportivosDataSet1.tbl_estado);

        }
    }
}
