using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Cliente : DA_BASE
    {
        public static bool InsertarCliente(Cliente objCliente)
        {
            string strSQL = "Insert into cliente" + "(tipo_Documento,identificacion,nombre,apellido,correo_Electronico,celular) values(";
            strSQL += "'" + objCliente.tipo_Documento + "',";
            strSQL += "'" + objCliente.identificacion + "',";
            strSQL += "'" + objCliente.nombre + "',";
            strSQL += "'" + objCliente.apellido + "',";
            strSQL += "'" + objCliente.correo_Electronico + "',";
            strSQL += "'" + objCliente.celular + "',";

            return RealizarTransaccion(strSQL);
        }
    }
}