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
    public partial class formMenuPrincipalERP : Form
    {
        public formMenuPrincipalERP()
        {
            InitializeComponent();
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRMERPformClientesProveedores ventanaAdministrarClientes = new CRMERPformClientesProveedores();
            ventanaAdministrarClientes.Show(); 

        }

        private void informeDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVentaDeProductos ventanaVentaProductos = new formVentaDeProductos();
            ventanaVentaProductos.Show(); 

        }

        private void informeDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInformeDeInventario ventanaInformeDeInventario = new formInformeDeInventario();
            ventanaInformeDeInventario.Show(); 
        }

        private void administrarCatálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ERPformAdministrarCatalogoDeProductos ventanaAdministrarCatalogo = new ERPformAdministrarCatalogoDeProductos();
            ventanaAdministrarCatalogo.Show(); 
        }

        private void realizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVisualizarFacturas ventanaFacturas = new formVisualizarFacturas();
            ventanaFacturas.Show(); 
        }

        private void informeDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCompraDeProductos ventanaComprarProductos = new formCompraDeProductos();
            ventanaComprarProductos.Show(); 
        }

        private void administrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRMERPformClientesProveedores ventanaAdministrarEmpleados= new CRMERPformClientesProveedores();
            ventanaAdministrarEmpleados.Show(); 
        }

        private void análisisGráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAnalisisGrafico ventanaAnalisisGrafico = new formAnalisisGrafico();
            ventanaAnalisisGrafico.Show(); 
        }
    }
}
