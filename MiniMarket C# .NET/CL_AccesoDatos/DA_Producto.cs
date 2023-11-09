using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Capa_Entidades;

namespace CL_AccesoDatos
{
    public class DA_Producto : DA_BASE
    {
        public static bool InsertarProducto(Producto objProducto) 
        {
            string strSQL = "insert into producto" + "nombre,marca,stock,pvp,descripcion,unidadMedida) values(";
            strSQL += "'" + objProducto.nombre + "',";
            strSQL += "'" + objProducto.marca + "',";
            strSQL += "'" + objProducto.stock + "',";
            strSQL += "'" + objProducto.pvp + "',";
            strSQL += "'" + objProducto.descripcion + "',";
            strSQL += "'" + objProducto.unidadMedida + "',";

            return RealizarTransaccion(strSQL);
        }
    }
}
