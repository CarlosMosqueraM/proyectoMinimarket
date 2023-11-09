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
    public partial class ConsultarCategoria : Form
    {
        

        public ConsultarCategoria()
        {
            InitializeComponent();
            
        }

        private void btnAgregarCategoria_Click_1(object sender, EventArgs e)
        {
            FrmRegistrarCategoria frmRegistrarCategoria = new FrmRegistrarCategoria();

            frmRegistrarCategoria.MdiParent = this.MdiParent; // Se asigna el mismo formulario de registro.
            frmRegistrarCategoria.Show();
        }


        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            Categoria ObjCategoria = new Categoria();

            ObjCategoria.Nombre = txtBoxNombreCategoria.Text.Trim();
            ObjCategoria.Descripcion = txtBoxDescripcionCategoria.Text.Trim();


            if (CN_Categoria.ActualizarCategoria(ObjCategoria))
            {
                MessageBox.Show("Actualización exitosa");
            }
            else
                MessageBox.Show("Fallo en la actualización");
        }

        private void ConsultarCategoria_Load(object sender, EventArgs e)
        {
            DataTable tablaDatos = new DataTable();

            DataGridViewButtonColumn dgvEditarCategoria = new DataGridViewButtonColumn();
            dgvEditarCategoria.Name = "Actualizar";
            dgvEditarCategoria.Text = "Actualizar";

            tablaDatos = CN_Categoria.ConsultarCategoria();
            dgvConsultarCategoria.DataSource = tablaDatos;
            dgvConsultarCategoria.Columns[0].Visible = false;
            dgvConsultarCategoria.Columns.Add(dgvEditarCategoria);
        }

        private void dgvConsultarCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarCategoria.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                gbActualizacionCategoria.Visible = true;

                txtBoxNombreCategoria.Text = dgvConsultarCategoria.CurrentRow.Cells[2].Value.ToString();
                txtBoxDescripcionCategoria.Text = dgvConsultarCategoria.CurrentRow.Cells[3].Value.ToString();

            }
        }
    }
}
