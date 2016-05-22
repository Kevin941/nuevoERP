namespace erp
{
    partial class formMenuPrincipalERP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuPrincipalERP));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCatálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.análisisGráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem,
            this.operaciónToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.análisisGráficoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(750, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeDeInventarioToolStripMenuItem,
            this.informeDeVentasToolStripMenuItem,
            this.informeDeComprasToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.informesToolStripMenuItem.Text = "Productos";
            // 
            // informeDeInventarioToolStripMenuItem
            // 
            this.informeDeInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCatalogoToolStripMenuItem,
            this.administrarCatálogoToolStripMenuItem});
            this.informeDeInventarioToolStripMenuItem.Name = "informeDeInventarioToolStripMenuItem";
            this.informeDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.informeDeInventarioToolStripMenuItem.Text = "Catálogo de productos";
            this.informeDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.informeDeInventarioToolStripMenuItem_Click);
            // 
            // verCatalogoToolStripMenuItem
            // 
            this.verCatalogoToolStripMenuItem.Name = "verCatalogoToolStripMenuItem";
            this.verCatalogoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.verCatalogoToolStripMenuItem.Text = "Ver Catálogo";
            this.verCatalogoToolStripMenuItem.Click += new System.EventHandler(this.verCatalogoToolStripMenuItem_Click);
            // 
            // administrarCatálogoToolStripMenuItem
            // 
            this.administrarCatálogoToolStripMenuItem.Name = "administrarCatálogoToolStripMenuItem";
            this.administrarCatálogoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.administrarCatálogoToolStripMenuItem.Text = "Administrar catálogo";
            this.administrarCatálogoToolStripMenuItem.Click += new System.EventHandler(this.administrarCatálogoToolStripMenuItem_Click);
            // 
            // informeDeVentasToolStripMenuItem
            // 
            this.informeDeVentasToolStripMenuItem.Name = "informeDeVentasToolStripMenuItem";
            this.informeDeVentasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.informeDeVentasToolStripMenuItem.Text = "Vender Productos";
            this.informeDeVentasToolStripMenuItem.Click += new System.EventHandler(this.informeDeVentasToolStripMenuItem_Click);
            // 
            // informeDeComprasToolStripMenuItem
            // 
            this.informeDeComprasToolStripMenuItem.Name = "informeDeComprasToolStripMenuItem";
            this.informeDeComprasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.informeDeComprasToolStripMenuItem.Text = "Comprar Productos";
            this.informeDeComprasToolStripMenuItem.Click += new System.EventHandler(this.informeDeComprasToolStripMenuItem_Click);
            // 
            // operaciónToolStripMenuItem
            // 
            this.operaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarCompraToolStripMenuItem});
            this.operaciónToolStripMenuItem.Name = "operaciónToolStripMenuItem";
            this.operaciónToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.operaciónToolStripMenuItem.Text = "Facturas";
            // 
            // realizarCompraToolStripMenuItem
            // 
            this.realizarCompraToolStripMenuItem.Name = "realizarCompraToolStripMenuItem";
            this.realizarCompraToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.realizarCompraToolStripMenuItem.Text = "Visualizar Facturas";
            this.realizarCompraToolStripMenuItem.Click += new System.EventHandler(this.realizarCompraToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // administrarClientesToolStripMenuItem
            // 
            this.administrarClientesToolStripMenuItem.Name = "administrarClientesToolStripMenuItem";
            this.administrarClientesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.administrarClientesToolStripMenuItem.Text = "Administrar clientes";
            this.administrarClientesToolStripMenuItem.Click += new System.EventHandler(this.administrarClientesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarEmpleadosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // administrarEmpleadosToolStripMenuItem
            // 
            this.administrarEmpleadosToolStripMenuItem.Name = "administrarEmpleadosToolStripMenuItem";
            this.administrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.administrarEmpleadosToolStripMenuItem.Text = "Administrar empleados";
            this.administrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.administrarEmpleadosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // análisisGráficoToolStripMenuItem
            // 
            this.análisisGráficoToolStripMenuItem.Name = "análisisGráficoToolStripMenuItem";
            this.análisisGráficoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.análisisGráficoToolStripMenuItem.Text = "Análisis Gráfico";
            this.análisisGráficoToolStripMenuItem.Click += new System.EventHandler(this.análisisGráficoToolStripMenuItem_Click);
            // 
            // formMenuPrincipalERP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 449);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formMenuPrincipalERP";
            this.Text = "menuPrincipal";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarCompraToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCatalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCatálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem análisisGráficoToolStripMenuItem;
    }
}