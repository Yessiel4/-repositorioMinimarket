using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Cliente
    {
        public int idCliente;
        public String tipo_Documento { get; set; }
        public String identificacion { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String correo_Electronico { get; set; }
        public String celular { get; set;    }
    }
}
