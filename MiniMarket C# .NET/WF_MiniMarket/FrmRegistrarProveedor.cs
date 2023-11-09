using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Capa_Entidades;
using CL_Capa_Negocio;

namespace WF_MiniMarket
{
    public partial class FrmRegistrarProveedor : Form
    {
        public FrmRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void buttonGuardarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor = new Proveedor();
            objProveedor.nit = textBoxNitProveedor.Text.Trim();
            objProveedor.razonSocial = textBoxRazonSocialProveedor.Text.Trim();
            objProveedor.telefono = textBoxTelefonoProveedor.Text.Trim();
            objProveedor.nomenclatura = textBoxNomenclaturaProveedor.Text.Trim();
            objProveedor.ciudad = textBoxCiudadProveedor.Text.Trim();
            objProveedor.departamento = textBoxDepartamentoProveedor.Text.Trim();

            if (CN_Proveedor.InsertarProveedor(objProveedor))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");

        }
    }
}
