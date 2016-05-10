namespace erp
{
    partial class formFactura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classFacturaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classProductoDeFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.classClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classFacturaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classProductoDeFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classFacturaVentaBindingSource
            // 
            this.classFacturaVentaBindingSource.DataSource = typeof(erp.classFacturaVenta);
            // 
            // classProductoDeFacturaBindingSource
            // 
            this.classProductoDeFacturaBindingSource.DataSource = typeof(erp.classProductoDeFactura);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDatosDeFactura";
            reportDataSource1.Value = this.classFacturaVentaBindingSource;
            reportDataSource2.Name = "DataSetProductosDeFactura";
            reportDataSource2.Value = this.classProductoDeFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "erp.reportFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(987, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // classClienteBindingSource
            // 
            this.classClienteBindingSource.DataSource = typeof(erp.classCliente);
            // 
            // formFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 416);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formFactura";
            this.Text = "formFactura";
            this.Load += new System.EventHandler(this.formFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classFacturaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classProductoDeFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource classClienteBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource classFacturaVentaBindingSource;
        private System.Windows.Forms.BindingSource classProductoDeFacturaBindingSource;
    }
}