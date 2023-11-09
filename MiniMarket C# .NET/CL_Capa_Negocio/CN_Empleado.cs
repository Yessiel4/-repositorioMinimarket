using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_AccesoDatos;
using CL_Capa_Entidades;

namespace CL_Capa_Negocio
{
    public class CN_Empleado
    {
        public static bool InsertarEmpleado(Empleado objEmpleado)
        {
            return DA_Empleado.insertarEmpleado(objEmpleado);
        }
    }
}
