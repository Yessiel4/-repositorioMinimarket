using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Proveedor
    {
        public int idProveedor;
        public String nit { get; set; }
        public String razonSocial { get; set; }
        public String telefono { get; set; }
        public String nomenclatura { get; set; }
        public String ciudad { get; set; }
        public String departamento { get; set; }

    }
}
