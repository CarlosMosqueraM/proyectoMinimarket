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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void miniMarketToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmRegistrarMiniMarketcs objFrm = new FrmRegistrarMiniMarketcs();

        //    objFrm.MdiParent = this;
        //    objFrm.Show();
        //    objFrm.WindowState = FormWindowState.Maximized;
        //}


        //CATEGORIA

        private void registrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria objFrm = new FrmRegistrarCategoria();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }

        private void consultarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCategoria objFrm = new ConsultarCategoria();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }


        //CLIENTE

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente objFrm = new FrmRegistrarCliente();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCliente objFrm = new ConsultarCliente();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }


        //PRODUCTO
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto objFrm = new FrmRegistrarProducto();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }


        //PROVEEDOR

        private void registrarProveedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRegistrarProveedor objFrm = new FrmRegistrarProveedor();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarMiniMarketcs objFrm = new FrmRegistrarMiniMarketcs();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }

        private void consultarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProveedor objFrm = new ConsultarProveedor();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }

        
    }
}
