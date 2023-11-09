using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Capa_Entidades;
using CL_Capa_Negocio;

namespace WF_MiniMarket
{
    public partial class FrmRegistrarProducto : Form
    {
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

     

        private void buttonGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto Objproducto = new Producto();
            Objproducto.nombre = textBoxNombreProducto.Text.Trim();
            Objproducto.marca = textBoxMarcaProducto.Text.Trim();
            Objproducto.stock = textBoxStockProducto.Text.Trim();
            Objproducto.pvp = textBoxPvpProducto.Text.Trim();
            Objproducto.descripcion = textBoxDescripcionProducto.Text.Trim();
            Objproducto.unidadMedida= textBoxUnidadMedidaProducto.Text.Trim();

            if (CN_Producto.InsertarProducto(Objproducto))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");
        }

    
    }
}
