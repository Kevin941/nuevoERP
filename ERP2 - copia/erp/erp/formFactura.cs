using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public partial class formFactura : Form
    {
        public classFacturaVenta factura = new classFacturaVenta(); 
        public formFactura(string idFactura)
        {
            factura.IdVenta = idFactura; 
            InitializeComponent();
        }

        private void formFactura_Load(object sender, EventArgs e)
        {
            
            factura.getFacturaById();
            factura.getProductListFromBill(); 
            this.classFacturaVentaBindingSource.DataSource = factura;
            this.classProductoDeFacturaBindingSource.DataSource = factura.listaDeProductos; 
            ReportDataSource rptDataSource = new ReportDataSource();
            rptDataSource.Name = "SuperFactura";
            rptDataSource.Value = this.classFacturaVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(rptDataSource);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
