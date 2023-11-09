namespace WF_MiniMarket
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miniMarketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniMarketToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.ordenCompraToolStripMenuItem,
            this.detalleCompraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miniMarketToolStripMenuItem
            // 
            this.miniMarketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem});
            this.miniMarketToolStripMenuItem.Name = "miniMarketToolStripMenuItem";
            this.miniMarketToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.miniMarketToolStripMenuItem.Text = "MiniMarket";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarToolStripMenuItem.Text = "Actualizar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCategoriaToolStripMenuItem,
            this.consultarCategoriaToolStripMenuItem});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // registrarCategoriaToolStripMenuItem
            // 
            this.registrarCategoriaToolStripMenuItem.Name = "registrarCategoriaToolStripMenuItem";
            this.registrarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarCategoriaToolStripMenuItem.Text = "Registrar";
            this.registrarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.registrarCategoriaToolStripMenuItem_Click);
            // 
            // consultarCategoriaToolStripMenuItem
            // 
            this.consultarCategoriaToolStripMenuItem.Name = "consultarCategoriaToolStripMenuItem";
            this.consultarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarCategoriaToolStripMenuItem.Text = "Consultar";
            this.consultarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.consultarCategoriaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProveedorToolStripMenuItem2,
            this.consultarProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // registrarProveedorToolStripMenuItem2
            // 
            this.registrarProveedorToolStripMenuItem2.Name = "registrarProveedorToolStripMenuItem2";
            this.registrarProveedorToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.registrarProveedorToolStripMenuItem2.Text = "Registrar";
            this.registrarProveedorToolStripMenuItem2.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem2_Click);
            // 
            // consultarProveedorToolStripMenuItem
            // 
            this.consultarProveedorToolStripMenuItem.Name = "consultarProveedorToolStripMenuItem";
            this.consultarProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarProveedorToolStripMenuItem.Text = "Consultar";
            this.consultarProveedorToolStripMenuItem.Click += new System.EventHandler(this.consultarProveedorToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem3,
            this.actualizarToolStripMenuItem2});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem3
            // 
            this.registrarToolStripMenuItem3.Name = "registrarToolStripMenuItem3";
            this.registrarToolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
            this.registrarToolStripMenuItem3.Text = "Registrar";
            // 
            // actualizarToolStripMenuItem2
            // 
            this.actualizarToolStripMenuItem2.Name = "actualizarToolStripMenuItem2";
            this.actualizarToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem2.Text = "Actualizar";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.actualizarToolStripMenuItem1});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            // 
            // actualizarToolStripMenuItem1
            // 
            this.actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            this.actualizarToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem1.Text = "Actualizar";
            // 
            // ordenCompraToolStripMenuItem
            // 
            this.ordenCompraToolStripMenuItem.Name = "ordenCompraToolStripMenuItem";
            this.ordenCompraToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ordenCompraToolStripMenuItem.Text = "OrdenCompra";
            // 
            // detalleCompraToolStripMenuItem
            // 
            this.detalleCompraToolStripMenuItem.Name = "detalleCompraToolStripMenuItem";
            this.detalleCompraToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.detalleCompraToolStripMenuItem.Text = "DetalleCompra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 482);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miniMarketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ordenCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
    }
}

