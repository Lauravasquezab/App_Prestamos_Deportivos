﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PestamosDeportivos
{
    public class cls_Conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9HKGPQV\\SQLEXPRESS03;Initial Catalog=dbs_prestamos_deportivos;Integrated Security=True");
    }
}