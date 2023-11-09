using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Categoria :DA_BASE
    {
        public static bool InsertarCategoria(Categoria objCategoria) 
        {
            string strSQL = "Insert into Categoria" + "(nombre,decripcion) values (";
            strSQL += "'" + objCategoria.nombre;
            strSQL += "'" + objCategoria.decripcion;

            return RealizarTransaccion(strSQL);

        }
    }
}
