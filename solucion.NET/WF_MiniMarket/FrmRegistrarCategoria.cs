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
    public partial class FrmRegistrarCategoria : Form
    {
        public FrmRegistrarCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            Categoria ObjCategoria = new Categoria();

            ObjCategoria.Nombre = txtBoxNombreCategoria.Text.Trim();
            ObjCategoria.Descripcion = txtBoxDescripcionCategoria.Text.Trim();

            if (string.IsNullOrEmpty(ObjCategoria.Nombre) || string.IsNullOrEmpty(ObjCategoria.Descripcion))
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }


            if (CN_Categoria.InsertarCategoria(ObjCategoria))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la inserción");
        }
    }
}
