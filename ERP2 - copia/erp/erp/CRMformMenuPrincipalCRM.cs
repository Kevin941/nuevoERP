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
    public partial class CRMformMenuPrincipalCRM : Form
    {
        public CRMformMenuPrincipalCRM()
        {
            InitializeComponent();
        }

        private void administrarClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CRMERPformClientesProveedores ventanaClientesProveedores = new CRMERPformClientesProveedores();
            ventanaClientesProveedores.Show(); 
        }

        private void clientesFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRMformAnalisisDeClientesFrecuentes ventanaAnalisisDeClientesFrecuentes = new CRMformAnalisisDeClientesFrecuentes();
            ventanaAnalisisDeClientesFrecuentes.Show(); 
        }

        private void promocionesDeMostradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRMformPromocionesDeMostrador ventanaPromocionesDeMostrador = new CRMformPromocionesDeMostrador();
            ventanaPromocionesDeMostrador.Show(); 

        }

        private void análisisGeográficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRMformAnalisisGeografico ventanaAnalisisGeografico = new CRMformAnalisisGeografico();
            ventanaAnalisisGeografico.Show(); 
        }

        private void productosMásVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRMformProductosMasVendidos ventanaProductosMasVendidos = new CRMformProductosMasVendidos();
            ventanaProductosMasVendidos.Show(); 
        }

        private void análisisGráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAnalisisGrafico ventanaAnalisisGrafico = new formAnalisisGrafico();
            ventanaAnalisisGrafico.Show(); 
        }
    }
}
