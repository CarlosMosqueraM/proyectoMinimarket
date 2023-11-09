namespace WF_MiniMarket
{
    partial class FrmRegistrarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxCelularCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxCorreoCliente = new System.Windows.Forms.TextBox();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxApellidosCliente = new System.Windows.Forms.TextBox();
            this.txtBoxNombresCliente = new System.Windows.Forms.TextBox();
            this.txtBoxIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoDocumento);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBoxCelularCliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBoxCorreoCliente);
            this.groupBox1.Controls.Add(this.btnGuardarCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxApellidosCliente);
            this.groupBox1.Controls.Add(this.txtBoxNombresCliente);
            this.groupBox1.Controls.Add(this.txtBoxIdCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Cliente";
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
            this.cbTipoDocumento.Location = new System.Drawing.Point(203, 56);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(121, 28);
            this.cbTipoDocumento.TabIndex = 23;
            this.cbTipoDocumento.Text = "Seleccione..";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Celular";
            // 
            // txtBoxCelularCliente
            // 
            this.txtBoxCelularCliente.Location = new System.Drawing.Point(626, 174);
            this.txtBoxCelularCliente.Name = "txtBoxCelularCliente";
            this.txtBoxCelularCliente.Size = new System.Drawing.Size(254, 26);
            this.txtBoxCelularCliente.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Correo";
            // 
            // txtBoxCorreoCliente
            // 
            this.txtBoxCorreoCliente.Location = new System.Drawing.Point(146, 174);
            this.txtBoxCorreoCliente.Name = "txtBoxCorreoCliente";
            this.txtBoxCorreoCliente.Size = new System.Drawing.Size(254, 26);
            this.txtBoxCorreoCliente.TabIndex = 19;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(409, 246);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(80, 32);
            this.btnGuardarCliente.TabIndex = 18;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombres";
            // 
            // txtBoxApellidosCliente
            // 
            this.txtBoxApellidosCliente.Location = new System.Drawing.Point(626, 121);
            this.txtBoxApellidosCliente.Name = "txtBoxApellidosCliente";
            this.txtBoxApellidosCliente.Size = new System.Drawing.Size(254, 26);
            this.txtBoxApellidosCliente.TabIndex = 8;
            // 
            // txtBoxNombresCliente
            // 
            this.txtBoxNombresCliente.Location = new System.Drawing.Point(146, 118);
            this.txtBoxNombresCliente.Name = "txtBoxNombresCliente";
            this.txtBoxNombresCliente.Size = new System.Drawing.Size(254, 26);
            this.txtBoxNombresCliente.TabIndex = 4;
            // 
            // txtBoxIdCliente
            // 
            this.txtBoxIdCliente.Location = new System.Drawing.Point(626, 64);
            this.txtBoxIdCliente.Name = "txtBoxIdCliente";
            this.txtBoxIdCliente.Size = new System.Drawing.Size(254, 26);
            this.txtBoxIdCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo documento";
            // 
            // FrmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 518);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarCliente";
            this.Text = "FrmRegistrarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxCelularCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxCorreoCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxApellidosCliente;
        private System.Windows.Forms.TextBox txtBoxNombresCliente;
        private System.Windows.Forms.TextBox txtBoxIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}