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
    public partial class FrmRegistrarProducto : Form
    {
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto ObjProducto = new Producto();

            ObjProducto.Nombre = txtBoxNombreProducto.Text.Trim();
            ObjProducto.Marca = txtBoxMarcaProducto.Text.Trim();
            if (int.TryParse(txtBoxStock.Text.Trim(), out int stock))
            {
                ObjProducto.Stock = stock;
            }
            if (int.TryParse(txtBoxPVPProducto.Text.Trim(), out int pvp))
            {
                ObjProducto.PVP = pvp;
            }
            ObjProducto.Descripcion = txtBoxDescripcionProducto.Text.Trim();
            ObjProducto.UnidadMedida = cbUnidadMedida.SelectedItem.ToString();
            if (int.TryParse(txtBoxIdCategoriaProducto.Text.Trim(), out int idCategoria))
            {
                ObjProducto.idCategoria = idCategoria;
            }


            if (CN_Producto.InsertarProducto(ObjProducto))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la inserción");
        }
    }
}
