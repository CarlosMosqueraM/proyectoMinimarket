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
    public partial class ConsultarCliente : Form
    {
        

        public ConsultarCliente()
        {
            InitializeComponent();
            
        }

        


        private void btnAgregarCliente_Click_1(object sender, EventArgs e)
        {
            FrmRegistrarCliente frmRegistrarCliente = new FrmRegistrarCliente();

            frmRegistrarCliente.MdiParent = this.MdiParent; // Se asigna el mismo formulario de registro.
            frmRegistrarCliente.Show();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            Cliente ObjCliente = new Cliente();

            ObjCliente.TipoDocumento = cbTipoDocumento.SelectedItem.ToString().Trim();
            ObjCliente.Identificacion = txtBoxIdCliente.Text.Trim();
            ObjCliente.Nombres = txtBoxNombresCliente.Text.Trim();
            ObjCliente.Apellidos = txtBoxApellidosCliente.Text.Trim();
            ObjCliente.Correo = txtBoxCorreoCliente.Text.Trim();
            ObjCliente.Celular = txtBoxCelularCliente.Text.Trim();


            if (CN_Cliente.ActualizarCliente(ObjCliente))
            {
                MessageBox.Show("Actualización exitosa");
                gbActualizacionCliente.Visible = false;
            }
            else
                MessageBox.Show("Fallo en la actualización");
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            DataTable tablaDatos = new DataTable();

            DataGridViewButtonColumn dgvEditarCliente = new DataGridViewButtonColumn();
            dgvEditarCliente.Name = "Actualizar";
            dgvEditarCliente.Text = "Actualizar";

            tablaDatos = CN_Cliente.ConsultarCliente();
            dgvConsultarCliente.DataSource = tablaDatos;
            dgvConsultarCliente.Columns[0].Visible = false;
            dgvConsultarCliente.Columns.Add(dgvEditarCliente);
        }

        private void dgvConsultarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarCliente.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                if (dgvConsultarCliente.CurrentRow != null)
                {
                    gbActualizacionCliente.Visible = true;
                    string idClienteStr = dgvConsultarCliente.CurrentRow.Cells[1].Value.ToString();
                    Cliente ObjCliente = new Cliente();
                    // Convierte la cadena a un entero usando int.Parse y asigna el valor a ObjProveedor.idProveedor
                    ObjCliente.idCliente = int.Parse(idClienteStr);

                    string tipoDocu = dgvConsultarCliente.CurrentRow.Cells[2].Value.ToString();

                    // Establece el valor seleccionado en el ComboBox
                    cbTipoDocumento.SelectedItem = tipoDocu;
                    //cbTipoDocumento.SelectedItem = dgvConsultarCliente.CurrentRow.Cells[2].Value.ToString();
                    txtBoxIdCliente.Text = dgvConsultarCliente.CurrentRow.Cells[3].Value.ToString();
                    txtBoxNombresCliente.Text = dgvConsultarCliente.CurrentRow.Cells[4].Value.ToString();
                    txtBoxApellidosCliente.Text = dgvConsultarCliente.CurrentRow.Cells[5].Value.ToString();
                    txtBoxCorreoCliente.Text = dgvConsultarCliente.CurrentRow.Cells[6].Value.ToString();
                    txtBoxCelularCliente.Text = dgvConsultarCliente.CurrentRow.Cells[7].Value.ToString();
                }
            }
        }
    }
}
