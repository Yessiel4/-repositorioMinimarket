using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Minimarket : DA_BASE
    {
        public static bool InsertarMiniMarket(Minimarket objMinimarket) 
        {
            string strSQL = "Insert into minimarket" +
                "(nit,razonSocial,telefono,nomenclatura,ciudad,departamento,correo,sitioWeb,facebook,whatsapp) values (";
            strSQL += "'" + objMinimarket.Nit + "',";
            strSQL += "'" + objMinimarket.RazonSocial + "',";
            strSQL += "'" + objMinimarket.Telefono + "',";
            strSQL += "'" + objMinimarket.Nomenclatura + "',";
            strSQL += "'" + objMinimarket.Ciudad + "',";
            strSQL += "'" + objMinimarket.Departamento + "',";
            strSQL += "'" + objMinimarket.Correo + "',";
            strSQL += "'" + objMinimarket.SitioWeb + "',";
            strSQL += "'" + objMinimarket.Facebook + "',";
            strSQL += "'" + objMinimarket.Whatsapp + "');";

            return RealizarTransaccion(strSQL);

        }
    }
}
