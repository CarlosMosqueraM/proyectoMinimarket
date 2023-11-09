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
    public partial class FrmRegistrarCliente : Form
    {
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente ObjCliente = new Cliente();

            ObjCliente.TipoDocumento = cbTipoDocumento.SelectedItem.ToString();
            ObjCliente.Identificacion = txtBoxIdCliente.Text.Trim();
            ObjCliente.Nombres = txtBoxNombresCliente.Text.Trim();
            ObjCliente.Apellidos = txtBoxApellidosCliente.Text.Trim();
            ObjCliente.Correo = txtBoxCorreoCliente.Text.Trim();
            ObjCliente.Celular = txtBoxCelularCliente.Text.Trim();

            if (string.IsNullOrEmpty(ObjCliente.Identificacion) || string.IsNullOrEmpty(ObjCliente.Nombres) ||
                string.IsNullOrEmpty(ObjCliente.Apellidos) || string.IsNullOrEmpty(ObjCliente.Correo) ||
                string.IsNullOrEmpty(ObjCliente.Celular) || string.IsNullOrEmpty(ObjCliente.TipoDocumento))
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }

            if (CN_Cliente.InsertarCliente(ObjCliente))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la inserción");
        }
    }
}
