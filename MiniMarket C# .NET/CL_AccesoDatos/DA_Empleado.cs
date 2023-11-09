using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Empleado : DA_BASE
    {
        public static bool insertarEmpleado(Empleado objEmpleado)
            {
            string strSQL = "Insert into empleado" + "(tipo_Documento,identificacion,nombres,apellidos,correo,celular,clave) values(";
            strSQL += "'" + objEmpleado.tipo_Documento;
            strSQL += "'" + objEmpleado.identificacion;
            strSQL += "'" + objEmpleado.nombres;
            strSQL += "'" + objEmpleado.apellidos;
            strSQL += "'" + objEmpleado.correo_Electronico;
            strSQL += "'" + objEmpleado.celular;
            strSQL += "'" + objEmpleado.clave;

            return RealizarTransaccion(strSQL);


        }
    }
}
