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
    public partial class FrmRegistrarCliente : Form
    {
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

      

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            objCliente.tipo_Documento = textBoxTipoDocumentoCliente.Text.Trim();
            objCliente.identificacion = textBoxIdentifacionCliente.Text.Trim();
            objCliente.nombre = textBoxNombreCliente.Text.Trim();
            objCliente.apellido = textBoxApellidoCliente.Text.Trim();
            objCliente.apellido = textBoxApellidoCliente.Text.Trim();
            objCliente.correo_Electronico = textBoxCorreoElectronicoCliente.Text.Trim();
            objCliente.celular = textBoxCelularCliente.Text.Trim();

            if (CN_Cliente.InsertarCliente(objCliente))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");
        }
    }
}
