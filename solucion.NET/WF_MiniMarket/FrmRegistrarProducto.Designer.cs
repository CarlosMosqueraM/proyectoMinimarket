namespace WF_MiniMarket
{
    partial class FrmRegistrarProducto
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
            this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxStock = new System.Windows.Forms.TextBox();
            this.txtBoxPVPProducto = new System.Windows.Forms.TextBox();
            this.txtBoxMarcaProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxIdCategoriaProducto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxIdCategoriaProducto);
            this.groupBox1.Controls.Add(this.cbUnidadMedida);
            this.groupBox1.Controls.Add(this.btnGuardarProducto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBoxDescripcionProducto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxStock);
            this.groupBox1.Controls.Add(this.txtBoxPVPProducto);
            this.groupBox1.Controls.Add(this.txtBoxMarcaProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxNombreProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Producto";
            // 
            // cbUnidadMedida
            // 
            this.cbUnidadMedida.FormattingEnabled = true;
            this.cbUnidadMedida.Items.AddRange(new object[] {
            "UND",
            "GR"});
            this.cbUnidadMedida.Location = new System.Drawing.Point(658, 166);
            this.cbUnidadMedida.Name = "cbUnidadMedida";
            this.cbUnidadMedida.Size = new System.Drawing.Size(121, 28);
            this.cbUnidadMedida.TabIndex = 24;
            this.cbUnidadMedida.Text = "Seleccione..";
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(383, 312);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(80, 32);
            this.btnGuardarProducto.TabIndex = 20;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Descripción:";
            // 
            // txtBoxDescripcionProducto
            // 
            this.txtBoxDescripcionProducto.Location = new System.Drawing.Point(167, 166);
            this.txtBoxDescripcionProducto.Name = "txtBoxDescripcionProducto";
            this.txtBoxDescripcionProducto.Size = new System.Drawing.Size(242, 26);
            this.txtBoxDescripcionProducto.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unidad de medida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "PVP:";
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.Location = new System.Drawing.Point(167, 107);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.Size = new System.Drawing.Size(242, 26);
            this.txtBoxStock.TabIndex = 8;
            // 
            // txtBoxPVPProducto
            // 
            this.txtBoxPVPProducto.Location = new System.Drawing.Point(599, 107);
            this.txtBoxPVPProducto.Name = "txtBoxPVPProducto";
            this.txtBoxPVPProducto.Size = new System.Drawing.Size(242, 26);
            this.txtBoxPVPProducto.TabIndex = 4;
            // 
            // txtBoxMarcaProducto
            // 
            this.txtBoxMarcaProducto.Location = new System.Drawing.Point(599, 53);
            this.txtBoxMarcaProducto.Name = "txtBoxMarcaProducto";
            this.txtBoxMarcaProducto.Size = new System.Drawing.Size(242, 26);
            this.txtBoxMarcaProducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            // 
            // txtBoxNombreProducto
            // 
            this.txtBoxNombreProducto.Location = new System.Drawing.Point(167, 53);
            this.txtBoxNombreProducto.Name = "txtBoxNombreProducto";
            this.txtBoxNombreProducto.Size = new System.Drawing.Size(242, 26);
            this.txtBoxNombreProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Número categoría";
            // 
            // txtBoxIdCategoriaProducto
            // 
            this.txtBoxIdCategoriaProducto.Location = new System.Drawing.Point(167, 221);
            this.txtBoxIdCategoriaProducto.Name = "txtBoxIdCategoriaProducto";
            this.txtBoxIdCategoriaProducto.Size = new System.Drawing.Size(242, 26);
            this.txtBoxIdCategoriaProducto.TabIndex = 25;
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 489);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmRegistrarProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.TextBox txtBoxPVPProducto;
        private System.Windows.Forms.TextBox txtBoxMarcaProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxDescripcionProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.ComboBox cbUnidadMedida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxIdCategoriaProducto;
    }
}