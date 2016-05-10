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
    public partial class formDatosParaFacturaCompra : Form
    {

        public classFacturaCompra facturaDeCompra = new classFacturaCompra();
        public classProveedor proveedorParaFacturacion = new classProveedor(); 
        public formDatosParaFacturaCompra(classFacturaCompra facturaDeCompra)
        {
            float subtotal = 0; 
            this.facturaDeCompra.IdCompra = facturaDeCompra.IdCompra;
            this.facturaDeCompra.FechaEntrega = facturaDeCompra.FechaEntrega;
            this.facturaDeCompra.FechaEnvio = facturaDeCompra.FechaEnvio;
            this.facturaDeCompra.FechaPago = facturaDeCompra.FechaPago;
            this.facturaDeCompra.FechaPedido = facturaDeCompra.FechaPedido;
            this.facturaDeCompra.FormaDeEnvio = facturaDeCompra.FormaDeEnvio; 
            this.facturaDeCompra.EmpresaMSM = "MSM Salud S.A. de C.V.";
            this.facturaDeCompra.DireccionMSM = "Insurgentes sur #512"; 
            this.facturaDeCompra.TelefonoMSM = "55 1385 0736"; 
            foreach (classProductoDeFacturaCompra producto in facturaDeCompra.listaDeProductos)
            {
                subtotal += Convert.ToSingle(producto.Precio) * Convert.ToSingle(producto.Cantidad); 
                this.facturaDeCompra.listaDeProductos.Add(producto); 
            }

            this.facturaDeCompra.Subtotal = subtotal.ToString();
            this.facturaDeCompra.Iva = (subtotal * 0.16).ToString();
            this.facturaDeCompra.Monto = (subtotal * 1.16).ToString(); 

            InitializeComponent();
        }

        private void botonAgregarNuevoCliente_Click(object sender, EventArgs e)
        {
            CRMERPformClientesProveedores ventanaAdministrarProvedores = new CRMERPformClientesProveedores();
            ventanaAdministrarProvedores.Show(); 
        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxIdCliente.Text == "")
            {
                MessageBox.Show("Ingresa una clave de cliente para buscar");
                return;
            }

            proveedorParaFacturacion.idProveedor = Convert.ToInt16(textBoxIdCliente.Text);
            if (proveedorParaFacturacion.existe())
            {
                proveedorParaFacturacion.getSupplierById();
            }
            else
            {
                MessageBox.Show("Clave de cliente inexistente. Ingresa otra clave de búsqueda");
                return;
            }

            textBoxCliente.Text = proveedorParaFacturacion.nombreProveedor;
            facturaDeCompra.Destinatario = proveedorParaFacturacion.nombreProveedor;
            textBoxDireccion.Text = proveedorParaFacturacion.direccion;
            facturaDeCompra.DireccionDestinatario = proveedorParaFacturacion.direccion;
            textBoxCiudad.Text = proveedorParaFacturacion.ciudad;
            facturaDeCompra.CiudadDestinatario = proveedorParaFacturacion.ciudad;
            textBoxRegion.Text = proveedorParaFacturacion.region;
            facturaDeCompra.RegionDestinatario = proveedorParaFacturacion.region;
            textBoxCodigoPostal.Text = proveedorParaFacturacion.codigoPostal;
            facturaDeCompra.CodigoPostalDestinatario = proveedorParaFacturacion.codigoPostal;
            textBoxPais.Text = proveedorParaFacturacion.pais;
            facturaDeCompra.PaisDestinatario = proveedorParaFacturacion.pais;
            textBoxTelefono.Text = proveedorParaFacturacion.telefono;
            facturaDeCompra.TelefonoDestinatario = proveedorParaFacturacion.telefono;
            textBoxFax.Text = proveedorParaFacturacion.fax;
            facturaDeCompra.FaxDestinatario = proveedorParaFacturacion.fax;
            textBoxMail.Text = proveedorParaFacturacion.mail;
            facturaDeCompra.MailDeContacto = proveedorParaFacturacion.mail; 
        }

        private void botonRealizarFactura_Click(object sender, EventArgs e)
        {

            if ((proveedorParaFacturacion.idProveedor == -1) || (proveedorParaFacturacion.idProveedor == null))
            {
                MessageBox.Show("Por favor busca un proveedor para poder continuar");
                return;
            }
            classProducto productoParaActualizarExistencias = new classProducto();
            foreach (classProductoDeFacturaCompra producto in facturaDeCompra.listaDeProductos)
            {
                productoParaActualizarExistencias.idProducto = Convert.ToInt16(producto.IdProducto);
                productoParaActualizarExistencias.getProductById();
                productoParaActualizarExistencias.existencia = productoParaActualizarExistencias.existencia + Convert.ToInt16(producto.Cantidad);
                producto.calcularTotal();
                producto.Insert();
                productoParaActualizarExistencias.updateProduct();
            }

            facturaDeCompra.insertFactura();
            MessageBox.Show("Factura Creada. Pulse aceptar para visualizar las facturas realizadas");
            this.Close(); 
        }

        private void formDatosParaFacturaCompra_Load(object sender, EventArgs e)
        {
            groupBoxDatosReceptor.Enabled = false; 
        }
    }
}
