namespace WF_MiniMarket
{
    partial class FrmRegistrarDetalleCompra
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
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.txtBoxCodigoDetalleCompra = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCantidadProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBoxSubtotal);
            this.groupBox1.Controls.Add(this.txtBoxCodigoDetalleCompra);
            this.groupBox1.Controls.Add(this.txtBoxPrecioUnitario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxCantidadProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 444);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Detalle de Compra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Subtotal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Código:";
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Location = new System.Drawing.Point(181, 212);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.Size = new System.Drawing.Size(242, 26);
            this.txtBoxSubtotal.TabIndex = 8;
            // 
            // txtBoxCodigoDetalleCompra
            // 
            this.txtBoxCodigoDetalleCompra.Location = new System.Drawing.Point(181, 55);
            this.txtBoxCodigoDetalleCompra.Name = "txtBoxCodigoDetalleCompra";
            this.txtBoxCodigoDetalleCompra.Size = new System.Drawing.Size(242, 26);
            this.txtBoxCodigoDetalleCompra.TabIndex = 7;
            // 
            // txtBoxPrecioUnitario
            // 
            this.txtBoxPrecioUnitario.Location = new System.Drawing.Point(181, 108);
            this.txtBoxPrecioUnitario.Name = "txtBoxPrecioUnitario";
            this.txtBoxPrecioUnitario.Size = new System.Drawing.Size(242, 26);
            this.txtBoxPrecioUnitario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio unitario:";
            // 
            // txtBoxCantidadProducto
            // 
            this.txtBoxCantidadProducto.Location = new System.Drawing.Point(181, 162);
            this.txtBoxCantidadProducto.Name = "txtBoxCantidadProducto";
            this.txtBoxCantidadProducto.Size = new System.Drawing.Size(242, 26);
            this.txtBoxCantidadProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad producto:";
            // 
            // FrmRegistrarDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 500);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarDetalleCompra";
            this.Text = "FrmRegistrarDetalleCompra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.TextBox txtBoxCodigoDetalleCompra;
        private System.Windows.Forms.TextBox txtBoxPrecioUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCantidadProducto;
        private System.Windows.Forms.Label label1;
    }
}