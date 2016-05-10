namespace erp
{
    partial class formVisualizarFacturas
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
            this.tabControlFacturasDeVenta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridFacturas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridFacturasDeCompra = new System.Windows.Forms.DataGridView();
            this.tabControlFacturasDeVenta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturasDeCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlFacturasDeVenta
            // 
            this.tabControlFacturasDeVenta.Controls.Add(this.tabPage1);
            this.tabControlFacturasDeVenta.Controls.Add(this.tabPage2);
            this.tabControlFacturasDeVenta.Location = new System.Drawing.Point(12, 12);
            this.tabControlFacturasDeVenta.Name = "tabControlFacturasDeVenta";
            this.tabControlFacturasDeVenta.SelectedIndex = 0;
            this.tabControlFacturasDeVenta.Size = new System.Drawing.Size(978, 421);
            this.tabControlFacturasDeVenta.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridFacturas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Facturas de Venta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridFacturas
            // 
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Location = new System.Drawing.Point(6, 6);
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.Size = new System.Drawing.Size(958, 383);
            this.dataGridFacturas.TabIndex = 1;
            this.dataGridFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFacturas_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridFacturasDeCompra);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Facturas de Compra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridFacturasDeCompra
            // 
            this.dataGridFacturasDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturasDeCompra.Location = new System.Drawing.Point(6, 6);
            this.dataGridFacturasDeCompra.Name = "dataGridFacturasDeCompra";
            this.dataGridFacturasDeCompra.Size = new System.Drawing.Size(958, 383);
            this.dataGridFacturasDeCompra.TabIndex = 0;
            // 
            // formVisualizarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 445);
            this.Controls.Add(this.tabControlFacturasDeVenta);
            this.Name = "formVisualizarFacturas";
            this.Text = "formVisualizarFacturas";
            this.Load += new System.EventHandler(this.formVisualizarFacturas_Load);
            this.tabControlFacturasDeVenta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturasDeCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFacturasDeVenta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridFacturas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridFacturasDeCompra;

    }
}