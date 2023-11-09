using CL_Capa_Entidades;
using CL_Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_MiniMarket
{
    public partial class FrmRegistrarEmpleado : Form
    {
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }



        private void GuardarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado objempleado = new Empleado();
            objempleado.tipo_Documento = textBoxTipoDocEmpleado.Text;
            objempleado.identificacion = textBoxNumeroDocEmpleado.Text;
            objempleado.nombres = textBoxNombreEmpleado.Text;
            objempleado.apellidos = textBoxApellidoEmpleado.Text;
            objempleado.correo_Electronico = textBoxCorreoEmpleado.Text;
            objempleado.celular = textBoxTelefonoEmpleado.Text;
            objempleado.clave = textBoxClaveEmpleado.Text;

            if (CN_Empleado.InsertarEmpleado(objempleado))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");
        }

      
    }
}
