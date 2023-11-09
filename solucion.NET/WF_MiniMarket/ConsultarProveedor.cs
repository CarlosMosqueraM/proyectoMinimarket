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
    public partial class ConsultarProveedor : Form
    {
        

        public ConsultarProveedor()
        {
            InitializeComponent();
            
        }

        

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            
            FrmRegistrarProveedor frmRegistrarProveedor = new FrmRegistrarProveedor();

            frmRegistrarProveedor.MdiParent = this.MdiParent; // Se asigna el mismo formulario de registro.
            frmRegistrarProveedor.Show();
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor ObjProveedor = new Proveedor();

            ObjProveedor.Nit = txtBoxNITProveedor.Text.Trim();
            ObjProveedor.RazonSocial = txtBoxRazonSocialProveedor.Text.Trim();
            ObjProveedor.Telefono = txtBoxTelefonoProveedor.Text.Trim();
            ObjProveedor.Correo = txtBoxCorreoProveedor.Text.Trim();
            ObjProveedor.Nomenclatura = txtBoxNomenclaturaProveedor.Text.Trim();
            ObjProveedor.Ciudad = txtBoxCiudadProveedor.Text.Trim();
            ObjProveedor.Departamento = txtBoxDptoProveedor.Text.Trim();


            if (CN_Proveedor.ActualizarProveedor(ObjProveedor))
            {
                MessageBox.Show("Actualización exitosa");
                gbActualizacionProveedor.Visible = false;
            }
            else
                MessageBox.Show("Fallo en la actualización");
        }

        private void ConsultarProveedor_Load_1(object sender, EventArgs e)
        {
            DataTable tablaDatos = new DataTable();

            DataGridViewButtonColumn dgvEditarProveedor = new DataGridViewButtonColumn();
            dgvEditarProveedor.Name = "Actualizar";
            dgvEditarProveedor.Text = "Actualizar";

            tablaDatos = CN_Proveedor.ConsultarProveedor();
            dgvConsultarProveedor.DataSource = tablaDatos;
            dgvConsultarProveedor.Columns[0].Visible = false;
            dgvConsultarProveedor.Columns.Add(dgvEditarProveedor);
            


        }

        private void dgvConsultarProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarProveedor.Columns[e.ColumnIndex].Name =="Actualizar")
            {
                if (dgvConsultarProveedor.CurrentRow != null)
                {
                    gbActualizacionProveedor.Visible = true;
                string idProveedorStr = dgvConsultarProveedor.CurrentRow.Cells["idProveedor"].Value.ToString();
                Proveedor ObjProveedor = new Proveedor();


               
                ObjProveedor.idProveedor = int.Parse(idProveedorStr);

                txtBoxNITProveedor.Text = dgvConsultarProveedor.CurrentRow.Cells[2].Value.ToString();
                txtBoxRazonSocialProveedor.Text = dgvConsultarProveedor.CurrentRow.Cells[3].Value.ToString();
                txtBoxTelefonoProveedor.Text = dgvConsultarProveedor.CurrentRow.Cells[4].Value.ToString();
                txtBoxCorreoProveedor.Text = dgvConsultarProveedor.CurrentRow.Cells[5].Value.ToString();
                txtBoxNomenclaturaProveedor.Text = dgvConsultarProveedor.CurrentRow.Cells[6].Value.ToString();
                txtBoxCiudadProveedor.Text = dgvConsultarProveedor.CurrentRow.Cells[7].Value.ToString();
                txtBoxDptoProveedor.Text = dgvConsultarProveedor.CurrentRow.Cells[8].Value.ToString();
                }
            }
        }

        
    }
}
