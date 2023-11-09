namespace WF_MiniMarket
{
    partial class ConsultarCategoria
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
            this.dgvConsultarCategoria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.gbActualizacionCategoria = new System.Windows.Forms.GroupBox();
            this.txtBoxNombreCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCategoria)).BeginInit();
            this.gbActualizacionCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultarCategoria
            // 
            this.dgvConsultarCategoria.AllowUserToAddRows = false;
            this.dgvConsultarCategoria.AllowUserToDeleteRows = false;
            this.dgvConsultarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCategoria.Location = new System.Drawing.Point(30, 49);
            this.dgvConsultarCategoria.Name = "dgvConsultarCategoria";
            this.dgvConsultarCategoria.ReadOnly = true;
            this.dgvConsultarCategoria.Size = new System.Drawing.Size(430, 175);
            this.dgvConsultarCategoria.TabIndex = 0;
            this.dgvConsultarCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarCategoria_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de Categorias";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(510, 113);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(89, 48);
            this.btnAgregarCategoria.TabIndex = 20;
            this.btnAgregarCategoria.Text = "Nueva Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click_1);
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCategoria.Location = new System.Drawing.Point(480, 62);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(89, 32);
            this.btnActualizarCategoria.TabIndex = 21;
            this.btnActualizarCategoria.Text = "Actualizar";
            this.btnActualizarCategoria.UseVisualStyleBackColor = true;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // gbActualizacionCategoria
            // 
            this.gbActualizacionCategoria.Controls.Add(this.btnActualizarCategoria);
            this.gbActualizacionCategoria.Controls.Add(this.txtBoxNombreCategoria);
            this.gbActualizacionCategoria.Controls.Add(this.label2);
            this.gbActualizacionCategoria.Controls.Add(this.txtBoxDescripcionCategoria);
            this.gbActualizacionCategoria.Controls.Add(this.label3);
            this.gbActualizacionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActualizacionCategoria.Location = new System.Drawing.Point(30, 243);
            this.gbActualizacionCategoria.Name = "gbActualizacionCategoria";
            this.gbActualizacionCategoria.Size = new System.Drawing.Size(592, 150);
            this.gbActualizacionCategoria.TabIndex = 22;
            this.gbActualizacionCategoria.TabStop = false;
            this.gbActualizacionCategoria.Text = "Actualización de Categoría";
            this.gbActualizacionCategoria.Visible = false;
            // 
            // txtBoxNombreCategoria
            // 
            this.txtBoxNombreCategoria.Location = new System.Drawing.Point(188, 47);
            this.txtBoxNombreCategoria.Name = "txtBoxNombreCategoria";
            this.txtBoxNombreCategoria.Size = new System.Drawing.Size(242, 26);
            this.txtBoxNombreCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre: ";
            // 
            // txtBoxDescripcionCategoria
            // 
            this.txtBoxDescripcionCategoria.Location = new System.Drawing.Point(188, 93);
            this.txtBoxDescripcionCategoria.Name = "txtBoxDescripcionCategoria";
            this.txtBoxDescripcionCategoria.Size = new System.Drawing.Size(242, 26);
            this.txtBoxDescripcionCategoria.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción: ";
            // 
            // ConsultarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 452);
            this.Controls.Add(this.gbActualizacionCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultarCategoria);
            this.Name = "ConsultarCategoria";
            this.Text = "ConsultarCategoria";
            this.Load += new System.EventHandler(this.ConsultarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCategoria)).EndInit();
            this.gbActualizacionCategoria.ResumeLayout(false);
            this.gbActualizacionCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnActualizarCategoria;
        private System.Windows.Forms.GroupBox gbActualizacionCategoria;
        private System.Windows.Forms.TextBox txtBoxNombreCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDescripcionCategoria;
        private System.Windows.Forms.Label label3;
    }
}