namespace WF_MiniMarket
{
    partial class FrmRegistrarCategoria
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
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.txtBoxNombreCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarCategoria);
            this.groupBox1.Controls.Add(this.txtBoxNombreCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxDescripcionCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Categoría";
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Location = new System.Drawing.Point(268, 190);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(80, 32);
            this.btnGuardarCategoria.TabIndex = 19;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // txtBoxNombreCategoria
            // 
            this.txtBoxNombreCategoria.Location = new System.Drawing.Point(189, 66);
            this.txtBoxNombreCategoria.Name = "txtBoxNombreCategoria";
            this.txtBoxNombreCategoria.Size = new System.Drawing.Size(242, 26);
            this.txtBoxNombreCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre: ";
            // 
            // txtBoxDescripcionCategoria
            // 
            this.txtBoxDescripcionCategoria.Location = new System.Drawing.Point(189, 120);
            this.txtBoxDescripcionCategoria.Name = "txtBoxDescripcionCategoria";
            this.txtBoxDescripcionCategoria.Size = new System.Drawing.Size(242, 26);
            this.txtBoxDescripcionCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción: ";
            // 
            // FrmRegistrarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 372);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarCategoria";
            this.Text = "FrmRegistrarCategoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxNombreCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDescripcionCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarCategoria;
    }
}