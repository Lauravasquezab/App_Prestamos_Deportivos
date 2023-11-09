using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_ModuloUsuarios : Form
    {
        public frm_ModuloUsuarios()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_ModuloUsuarios obj_guardar = new cls_ModuloUsuarios();


            string id = txt_id.Text;
            string pnombre = txt_pnombre.Text;
            string snombre = txt_snombre.Text;
            string papellido = txt_papellido.Text;
            string sapellido = txt_sapellido.Text;
            string sexo = cbx_sexo.Text;
            string contacto = txt_contacto.Text;
            string correo = txt_correo.Text;
            string direccion = txt_direccion.Text;

            obj_guardar.fnt_guardar(id, pnombre, snombre, papellido, sapellido, contacto, correo, direccion, sexo);
        }
    }
}
