using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Proveedor : DA_BASE
    {
        public static bool InsertarProveedor(Proveedor objProveedor)
        {
            string strSQL = "Insert into proveedor" + "(nit, razonSocial,telefono,nomenclatura,ciudad,departamento) values(";
            strSQL += "'" + objProveedor.nit + "',";
            strSQL += "'" + objProveedor.razonSocial + "',";
            strSQL += "'" + objProveedor.telefono + "',";
            strSQL += "'" + objProveedor.nomenclatura + "',";
            strSQL += "'" + objProveedor.ciudad + "',";
            strSQL += "'" + objProveedor.departamento + "',";

            return RealizarTransaccion(strSQL);
        }
    }
}