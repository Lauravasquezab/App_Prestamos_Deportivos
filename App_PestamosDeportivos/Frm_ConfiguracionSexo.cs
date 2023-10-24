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
    public partial class Frm_ConfiguracionSexo : Form
    {
        public Frm_ConfiguracionSexo()
        {
            InitializeComponent();
        }

        private void Frm_ConfiguracionSexo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet2.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter.Fill(this.dbs_prestamos_deportivosDataSet2.tbl_sexo);

        }
    }
}
