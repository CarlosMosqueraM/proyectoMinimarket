namespace WF_MiniMarket
{
    partial class ConsultarCliente
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
            this.dgvConsultarCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.gbActualizacionCliente = new System.Windows.Forms.GroupBox();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxCelularCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxCorreoCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxApellidosCliente = new System.Windows.Forms.TextBox();
            this.txtBoxNombresCliente = new System.Windows.Forms.TextBox();
            this.txtBoxIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliente)).BeginInit();
            this.gbActualizacionCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultarCliente
            // 
            this.dgvConsultarCliente.AllowUserToAddRows = false;
            this.dgvConsultarCliente.AllowUserToDeleteRows = false;
            this.dgvConsultarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCliente.Location = new System.Drawing.Point(30, 49);
            this.dgvConsultarCliente.Name = "dgvConsultarCliente";
            this.dgvConsultarCliente.ReadOnly = true;
            this.dgvConsultarCliente.Size = new System.Drawing.Size(781, 142);
            this.dgvConsultarCliente.TabIndex = 0;
            this.dgvConsultarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarCliente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de Clientes";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(844, 99);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(80, 49);
            this.btnAgregarCliente.TabIndex = 20;
            this.btnAgregarCliente.Text = "Nuevo Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click_1);
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.Location = new System.Drawing.Point(815, 86);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(89, 32);
            this.btnActualizarCliente.TabIndex = 21;
            this.btnActualizarCliente.Text = "Actualizar";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // gbActualizacionCliente
            // 
            this.gbActualizacionCliente.Controls.Add(this.cbTipoDocumento);
            this.gbActualizacionCliente.Controls.Add(this.btnActualizarCliente);
            this.gbActualizacionCliente.Controls.Add(this.label11);
            this.gbActualizacionCliente.Controls.Add(this.txtBoxCelularCliente);
            this.gbActualizacionCliente.Controls.Add(this.label10);
            this.gbActualizacionCliente.Controls.Add(this.txtBoxCorreoCliente);
            this.gbActualizacionCliente.Controls.Add(this.label9);
            this.gbActualizacionCliente.Controls.Add(this.label8);
            this.gbActualizacionCliente.Controls.Add(this.label3);
            this.gbActualizacionCliente.Controls.Add(this.txtBoxApellidosCliente);
            this.gbActualizacionCliente.Controls.Add(this.txtBoxNombresCliente);
            this.gbActualizacionCliente.Controls.Add(this.txtBoxIdCliente);
            this.gbActualizacionCliente.Controls.Add(this.label2);
            this.gbActualizacionCliente.Controls.Add(this.label4);
            this.gbActualizacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActualizacionCliente.Location = new System.Drawing.Point(21, 212);
            this.gbActualizacionCliente.Name = "gbActualizacionCliente";
            this.gbActualizacionCliente.Size = new System.Drawing.Size(918, 192);
            this.gbActualizacionCliente.TabIndex = 22;
            this.gbActualizacionCliente.TabStop = false;
            this.gbActualizacionCliente.Text = "Actualización de Cliente";
            this.gbActualizacionCliente.Visible = false;
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PAS",
            "PEP",
            "PPT",
            "CE",
            "Otro"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(170, 48);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(121, 28);
            this.cbTipoDocumento.TabIndex = 23;
            this.cbTipoDocumento.Text = "Seleccione..";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Celular";
            // 
            // txtBoxCelularCliente
            // 
            this.txtBoxCelularCliente.Location = new System.Drawing.Point(567, 134);
            this.txtBoxCelularCliente.Name = "txtBoxCelularCliente";
            this.txtBoxCelularCliente.Size = new System.Drawing.Size(211, 26);
            this.txtBoxCelularCliente.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Correo";
            // 
            // txtBoxCorreoCliente
            // 
            this.txtBoxCorreoCliente.Location = new System.Drawing.Point(127, 137);
            this.txtBoxCorreoCliente.Name = "txtBoxCorreoCliente";
            this.txtBoxCorreoCliente.Size = new System.Drawing.Size(211, 26);
            this.txtBoxCorreoCliente.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombres";
            // 
            // txtBoxApellidosCliente
            // 
            this.txtBoxApellidosCliente.Location = new System.Drawing.Point(567, 92);
            this.txtBoxApellidosCliente.Name = "txtBoxApellidosCliente";
            this.txtBoxApellidosCliente.Size = new System.Drawing.Size(211, 26);
            this.txtBoxApellidosCliente.TabIndex = 8;
            // 
            // txtBoxNombresCliente
            // 
            this.txtBoxNombresCliente.Location = new System.Drawing.Point(127, 92);
            this.txtBoxNombresCliente.Name = "txtBoxNombresCliente";
            this.txtBoxNombresCliente.Size = new System.Drawing.Size(211, 26);
            this.txtBoxNombresCliente.TabIndex = 4;
            // 
            // txtBoxIdCliente
            // 
            this.txtBoxIdCliente.Location = new System.Drawing.Point(567, 51);
            this.txtBoxIdCliente.Name = "txtBoxIdCliente";
            this.txtBoxIdCliente.Size = new System.Drawing.Size(211, 26);
            this.txtBoxIdCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo documento";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 509);
            this.Controls.Add(this.gbActualizacionCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultarCliente);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliente)).EndInit();
            this.gbActualizacionCliente.ResumeLayout(false);
            this.gbActualizacionCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.GroupBox gbActualizacionCliente;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxCelularCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxCorreoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxApellidosCliente;
        private System.Windows.Forms.TextBox txtBoxNombresCliente;
        private System.Windows.Forms.TextBox txtBoxIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}