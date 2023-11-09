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
            //  Negocio.cls_ModuloUsuarios obj_cls_credito_agregar = new Negocio.cls_ModuloUsuarios();
            //obj_cls_credito_agregar.fnt_guardar
            //    (
            //    txt_id.Text,
            //    txt_pnombre.Text,
            //    txt_snombre.Text,
            //    txt_papellido.Text,
            //    txt_sapellido.Text,
            //    txt_contacto.Text,
            //    cbx_sexo.SelectedText,
            //    txt_correo.Text,
            //    txt_direccion.Text

            //    );
            cls_ModuloUsuarios obj_guardar = new cls_ModuloUsuarios();

            string id = txt_id.Text;
            string pnombre = txt_pnombre.Text;
            string snombre = txt_snombre.Text;
            string papellido = txt_papellido.Text;
            string sapellido = txt_sapellido.Text;
            string sexo = cbx_sexo.SelectedValue.ToString();
            string contacto = txt_contacto.Text;
            string correo = txt_correo.Text;
            string direccion = txt_direccion.Text;
            obj_guardar.fnt_guardar(id, pnombre, snombre, papellido, sapellido, contacto, correo, direccion, sexo);
        }

        private void frm_ModuloUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet1.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter1.Fill(this.dbs_prestamos_deportivosDataSet1.tbl_sexo);
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter.Fill(this.dbs_prestamos_deportivosDataSet.tbl_sexo);

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_snombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_papellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
