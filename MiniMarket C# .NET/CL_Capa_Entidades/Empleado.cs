using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Empleado
    {
        public int idEmpleado;
        public String tipo_Documento { get; set; }
        public String identificacion { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String correo_Electronico { get; set; }
        public String celular { get; set; }
        public String clave { get; set; }

    }
}
