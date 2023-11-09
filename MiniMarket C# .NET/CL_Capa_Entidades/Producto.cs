using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Producto
    {
        public int Idproducto { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string stock { get; set; }
        public string pvp { get; set; }
        public string descripcion { get; set; }
        public string unidadMedida { get; set; }
    }
}
