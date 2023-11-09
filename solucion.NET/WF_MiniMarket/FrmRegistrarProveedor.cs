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
    public partial class FrmRegistrarProveedor : Form
    {
        public FrmRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor ObjProveedor = new Proveedor();

            ObjProveedor.Nit = txtBoxNITProveedor.Text.Trim();
            ObjProveedor.RazonSocial = txtBoxRazonSocialProveedor.Text.Trim();
            ObjProveedor.Telefono = txtBoxTelefonoProveedor.Text.Trim();
            ObjProveedor.Correo = txtBoxCorreoProveedor.Text.Trim();
            ObjProveedor.Nomenclatura = txtBoxNomenclaturaProveedor.Text.Trim();
            ObjProveedor.Ciudad = txtBoxCiudadProveedor.Text.Trim();
            ObjProveedor.Departamento = txtBoxDptoProveedor.Text.Trim();

            if (string.IsNullOrEmpty(ObjProveedor.Nit) || string.IsNullOrEmpty(ObjProveedor.RazonSocial) ||
                string.IsNullOrEmpty(ObjProveedor.Telefono) || string.IsNullOrEmpty(ObjProveedor.Correo) ||
                string.IsNullOrEmpty(ObjProveedor.Nomenclatura) || string.IsNullOrEmpty(ObjProveedor.Ciudad) ||
                string.IsNullOrEmpty(ObjProveedor.Departamento)) 
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }

            if (CN_Proveedor.InsertarProveedor(ObjProveedor))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la inserción");
        }

        
    }
}
