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
    public partial class formVisualizarFacturas : Form
    {
        public classFacturaVenta facturaDeVenta = new classFacturaVenta();
        public classFacturaCompra facturaDeCompra = new classFacturaCompra();

        public formVisualizarFacturas()
        {
            InitializeComponent();
        }

        private void formVisualizarFacturas_Load(object sender, EventArgs e)
        {
            mostrarFacturasEnGrid();
            mostrarFacturasDeCompraEnGrid();
        }

        private void mostrarFacturasEnGrid()
        {
            DataTable tablaFacturas = facturaDeVenta.selectAllFacturasParaGrid();
            dataGridFacturas.DataSource = tablaFacturas;
            autosizeGridFacturas();
        }

        private void mostrarFacturasDeCompraEnGrid()
        {
            DataTable tablaFacturas = facturaDeCompra.selectAllFacturasParaGrid();

            dataGridFacturasDeCompra.DataSource = tablaFacturas;
            autosizeGridFacturasDeCompra();
        }

        private void autosizeGridFacturas()
        {

            dataGridFacturas.AllowUserToOrderColumns = true;
            dataGridFacturas.AllowUserToResizeColumns = true;

            dataGridFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFacturas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void autosizeGridFacturasDeCompra()
        {

            dataGridFacturasDeCompra.AllowUserToOrderColumns = true;
            dataGridFacturasDeCompra.AllowUserToResizeColumns = true;

            dataGridFacturasDeCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFacturasDeCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }


        private void dataGridFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dataGridFacturas.Rows[rowIndex];
            //Usuario
            /*
            idCliente
            nombreCompania
            nombreContacto
            cargoContacto
            direccion
            ciudad
            region
            codigoPostal
            pais
            telefono
            fax
            mail*/

            facturaDeVenta.IdVenta = dataGridFacturas.Rows[rowIndex].Cells[0].Value.ToString();
            formFactura ventanaFactura = new formFactura(facturaDeVenta.IdVenta);
            ventanaFactura.Show();

        }

       
    }
}
