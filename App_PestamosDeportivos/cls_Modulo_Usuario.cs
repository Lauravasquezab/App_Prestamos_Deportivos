using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_PestamosDeportivos
{
    public class cls_Modulo_Usuario
    {
        private String str_id;
        private String str_pnombre;
        private String str_snombre;
        private String str_papellido;
        private String str_sapellido;
        private String str_contacto;
        private String str_correo;
        private String str_direccion;
        private String str_sexo; 
        cls_Conexion objConectar = new cls_Conexion();

        public void fnt_guardar(string id,string pnombre,string snombre,string papellido, string sapellidoString,string contacto,String corrreo,string direccion,string sexo)
        {
            if(id.Equals("")||pnombre.Equals("")||snombre.Equals("")||papellido.Equals("")||sapellido.equals("")||contacto.Equals("")||str_correo.Equals("")||direccion.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos","Registro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand con = new SqlCommand("SP_Registrar_Personas", objConectar.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", id);
                con.Parameters.AddWithValue("@p_nombre", pnombre);
                con.Parameters.AddWithValue("@s_nombre", snombre);
                con.Parameters.AddWithValue("@p_apellido", papellido);
                con.Parameters.AddWithValue("@s_apellido", sapellido);
                con.Parameters.AddWithValue("@contacto", contacto);
                con.Parameters.AddWithValue("@direccion", direccion);
                con.Parameters.AddWithValue("@sexo", sexo);
                con.Parameters.AddWithValue("@correo", correo);
                objConectar.connection.Open();
                con.ExecuteNonQuery();
                objConectar.connection.Close();
                MessageBox.Show("Datos registrados con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    } 
}
