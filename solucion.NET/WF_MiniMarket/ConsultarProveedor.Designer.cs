namespace WF_MiniMarket
{
    partial class ConsultarProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvConsultarProveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnActualizarProveedor = new System.Windows.Forms.Button();
            this.gbActualizacionProveedor = new System.Windows.Forms.GroupBox();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDptoProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxCiudadProveedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNomenclaturaProveedor = new System.Windows.Forms.TextBox();
            this.txtBoxCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtBoxTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtBoxRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNITProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProveedor)).BeginInit();
            this.gbActualizacionProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultarProveedor
            // 
            this.dgvConsultarProveedor.AllowUserToAddRows = false;
            this.dgvConsultarProveedor.AllowUserToDeleteRows = false;
            this.dgvConsultarProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarProveedor.Location = new System.Drawing.Point(30, 49);
            this.dgvConsultarProveedor.Name = "dgvConsultarProveedor";
            this.dgvConsultarProveedor.ReadOnly = true;
            this.dgvConsultarProveedor.Size = new System.Drawing.Size(844, 159);
            this.dgvConsultarProveedor.TabIndex = 0;
            this.dgvConsultarProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarProveedor_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de Proveedores";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(896, 100);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(96, 52);
            this.btnAgregarProveedor.TabIndex = 20;
            this.btnAgregarProveedor.Text = "Nuevo Proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnActualizarProveedor
            // 
            this.btnActualizarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProveedor.Location = new System.Drawing.Point(866, 80);
            this.btnActualizarProveedor.Name = "btnActualizarProveedor";
            this.btnActualizarProveedor.Size = new System.Drawing.Size(89, 32);
            this.btnActualizarProveedor.TabIndex = 21;
            this.btnActualizarProveedor.Text = "Actualizar";
            this.btnActualizarProveedor.UseVisualStyleBackColor = true;
            this.btnActualizarProveedor.Click += new System.EventHandler(this.btnActualizarProveedor_Click);
            // 
            // gbActualizacionProveedor
            // 
            this.gbActualizacionProveedor.Controls.Add(this.btnGuardarProveedor);
            this.gbActualizacionProveedor.Controls.Add(this.btnActualizarProveedor);
            this.gbActualizacionProveedor.Controls.Add(this.label6);
            this.gbActualizacionProveedor.Controls.Add(this.txtBoxDptoProveedor);
            this.gbActualizacionProveedor.Controls.Add(this.label5);
            this.gbActualizacionProveedor.Controls.Add(this.txtBoxCiudadProveedor);
            this.gbActualizacionProveedor.Controls.Add(this.label9);
            this.gbActualizacionProveedor.Controls.Add(this.label8);
            this.gbActualizacionProveedor.Controls.Add(this.label4);
            this.gbActualizacionProveedor.Controls.Add(this.label3);
            this.gbActualizacionProveedor.Controls.Add(this.txtBoxNomenclaturaProveedor);
            this.gbActualizacionProveedor.Controls.Add(this.txtBoxCorreoProveedor);
            this.gbActualizacionProveedor.Controls.Add(this.txtBoxTelefonoProveedor);
            this.gbActualizacionProveedor.Controls.Add(this.txtBoxRazonSocialProveedor);
            this.gbActualizacionProveedor.Controls.Add(this.label2);
            this.gbActualizacionProveedor.Controls.Add(this.txtBoxNITProveedor);
            this.gbActualizacionProveedor.Controls.Add(this.label7);
            this.gbActualizacionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActualizacionProveedor.Location = new System.Drawing.Point(30, 220);
            this.gbActualizacionProveedor.Name = "gbActualizacionProveedor";
            this.gbActualizacionProveedor.Size = new System.Drawing.Size(971, 200);
            this.gbActualizacionProveedor.TabIndex = 22;
            this.gbActualizacionProveedor.TabStop = false;
            this.gbActualizacionProveedor.Text = "Actualización de Proveedor";
            this.gbActualizacionProveedor.Visible = false;
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Location = new System.Drawing.Point(390, 314);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(80, 32);
            this.btnGuardarProveedor.TabIndex = 20;
            this.btnGuardarProveedor.Text = "Guardar";
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Departamento";
            // 
            // txtBoxDptoProveedor
            // 
            this.txtBoxDptoProveedor.Location = new System.Drawing.Point(142, 159);
            this.txtBoxDptoProveedor.Name = "txtBoxDptoProveedor";
            this.txtBoxDptoProveedor.Size = new System.Drawing.Size(189, 26);
            this.txtBoxDptoProveedor.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ciudad";
            // 
            // txtBoxCiudadProveedor
            // 
            this.txtBoxCiudadProveedor.Location = new System.Drawing.Point(547, 120);
            this.txtBoxCiudadProveedor.Name = "txtBoxCiudadProveedor";
            this.txtBoxCiudadProveedor.Size = new System.Drawing.Size(234, 26);
            this.txtBoxCiudadProveedor.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nomenclatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(409, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Teléfono";
            // 
            // txtBoxNomenclaturaProveedor
            // 
            this.txtBoxNomenclaturaProveedor.Location = new System.Drawing.Point(142, 117);
            this.txtBoxNomenclaturaProveedor.Name = "txtBoxNomenclaturaProveedor";
            this.txtBoxNomenclaturaProveedor.Size = new System.Drawing.Size(189, 26);
            this.txtBoxNomenclaturaProveedor.TabIndex = 8;
            // 
            // txtBoxCorreoProveedor
            // 
            this.txtBoxCorreoProveedor.Location = new System.Drawing.Point(547, 77);
            this.txtBoxCorreoProveedor.Name = "txtBoxCorreoProveedor";
            this.txtBoxCorreoProveedor.Size = new System.Drawing.Size(234, 26);
            this.txtBoxCorreoProveedor.TabIndex = 5;
            // 
            // txtBoxTelefonoProveedor
            // 
            this.txtBoxTelefonoProveedor.Location = new System.Drawing.Point(142, 74);
            this.txtBoxTelefonoProveedor.Name = "txtBoxTelefonoProveedor";
            this.txtBoxTelefonoProveedor.Size = new System.Drawing.Size(189, 26);
            this.txtBoxTelefonoProveedor.TabIndex = 4;
            // 
            // txtBoxRazonSocialProveedor
            // 
            this.txtBoxRazonSocialProveedor.Location = new System.Drawing.Point(547, 32);
            this.txtBoxRazonSocialProveedor.Name = "txtBoxRazonSocialProveedor";
            this.txtBoxRazonSocialProveedor.Size = new System.Drawing.Size(234, 26);
            this.txtBoxRazonSocialProveedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon Social";
            // 
            // txtBoxNITProveedor
            // 
            this.txtBoxNITProveedor.Enabled = false;
            this.txtBoxNITProveedor.Location = new System.Drawing.Point(142, 32);
            this.txtBoxNITProveedor.Name = "txtBoxNITProveedor";
            this.txtBoxNITProveedor.Size = new System.Drawing.Size(189, 26);
            this.txtBoxNITProveedor.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "NIT";
            // 
            // ConsultarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 509);
            this.Controls.Add(this.gbActualizacionProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultarProveedor);
            this.Name = "ConsultarProveedor";
            this.Text = "ConsultarProveedor";
            this.Load += new System.EventHandler(this.ConsultarProveedor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProveedor)).EndInit();
            this.gbActualizacionProveedor.ResumeLayout(false);
            this.gbActualizacionProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnActualizarProveedor;
        private System.Windows.Forms.GroupBox gbActualizacionProveedor;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDptoProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxCiudadProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNomenclaturaProveedor;
        private System.Windows.Forms.TextBox txtBoxCorreoProveedor;
        private System.Windows.Forms.TextBox txtBoxTelefonoProveedor;
        private System.Windows.Forms.TextBox txtBoxRazonSocialProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNITProveedor;
        private System.Windows.Forms.Label label7;
    }
}