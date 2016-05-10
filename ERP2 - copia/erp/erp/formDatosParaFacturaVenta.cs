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
    public partial class formDatosParaFacturaVenta : Form
    {
        public classFacturaVenta facturaDeVenta = new classFacturaVenta();
        public classCliente clienteParaFacturacion = new classCliente(); 
        public formDatosParaFacturaVenta(classFacturaVenta facturaDeVenta)
        {
            float subtotal = 0; 
            this.facturaDeVenta.IdVenta = facturaDeVenta.IdVenta;
            this.facturaDeVenta.FechaEntrega = facturaDeVenta.FechaEntrega;
            this.facturaDeVenta.FechaEnvio = facturaDeVenta.FechaEnvio;
            this.facturaDeVenta.FechaPago = facturaDeVenta.FechaPago;
            this.facturaDeVenta.FechaPedido = facturaDeVenta.FechaPedido;
            this.facturaDeVenta.FormaDeEnvio = facturaDeVenta.FormaDeEnvio; 
            this.facturaDeVenta.EmpresaMSM = "MSM Salud S.A. de C.V.";
            this.facturaDeVenta.DireccionMSM = "Insurgentes sur #512"; 
            this.facturaDeVenta.TelefonoMSM = "55 1385 0736"; 
            foreach (classProductoDeFactura producto in facturaDeVenta.listaDeProductos)
            {
                subtotal += Convert.ToSingle(producto.Precio) * Convert.ToSingle(producto.Cantidad); 
                this.facturaDeVenta.listaDeProductos.Add(producto); 
            }

            this.facturaDeVenta.Subtotal = subtotal.ToString();
            this.facturaDeVenta.Iva = (subtotal * 0.16).ToString();
            this.facturaDeVenta.Monto = (subtotal * 1.16).ToString(); 

            InitializeComponent();
        }

        private void botonAgregarNuevoCliente_Click(object sender, EventArgs e)
        {
            CRMERPformClientesProveedores ventanaAdministrarClientes = new CRMERPformClientesProveedores();
            ventanaAdministrarClientes.Show(); 
        }

        private void formDatosParaFactura_Load(object sender, EventArgs e)
        {
            groupBoxDatosReceptor.Enabled = false; 
        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxIdCliente.Text == "")
            {
                MessageBox.Show("Ingresa una clave de cliente para buscar"); 
                return; 
            }

            clienteParaFacturacion.idCliente = textBoxIdCliente.Text;
            if (clienteParaFacturacion.existe())
            {
                clienteParaFacturacion.getClientById();
            }
            else
            {
                MessageBox.Show("Clave de cliente inexistente. Ingresa otra clave de búsqueda"); 
                return; 
            }
            
            textBoxCliente.Text = clienteParaFacturacion.nombreCompania;
            facturaDeVenta.Destinatario =clienteParaFacturacion.nombreCompania;
            textBoxDireccion.Text = clienteParaFacturacion.direccion;
            facturaDeVenta.DireccionDestinatario = clienteParaFacturacion.direccion;
            textBoxCiudad.Text = clienteParaFacturacion.ciudad;
            facturaDeVenta.CiudadDestinatario = clienteParaFacturacion.ciudad; 
            textBoxRegion.Text = clienteParaFacturacion.region;
            facturaDeVenta.RegionDestinatario = clienteParaFacturacion.region; 
            textBoxCodigoPostal.Text = clienteParaFacturacion.codigoPostal;
            facturaDeVenta.CodigoPostalDestinatario = clienteParaFacturacion.codigoPostal; 
            textBoxPais.Text = clienteParaFacturacion.pais;
            facturaDeVenta.PaisDestinatario = clienteParaFacturacion.pais; 
            textBoxTelefono.Text = clienteParaFacturacion.telefono;
            facturaDeVenta.TelefonoDestinatario = clienteParaFacturacion.telefono; 
            textBoxFax.Text = clienteParaFacturacion.fax; 
            facturaDeVenta.FaxDestinatario = clienteParaFacturacion.fax; 
            textBoxMail.Text = clienteParaFacturacion.mail; 
            facturaDeVenta.MailDeContacto = clienteParaFacturacion.mail; 
        }

        private void botonRealizarFactura_Click(object sender, EventArgs e)
        {
            if ((clienteParaFacturacion.idCliente == "") || (clienteParaFacturacion.idCliente == null))
            {
                MessageBox.Show("Por favor busca un cliente para poder continuar");
                return; 
            }
            classProducto productoParaActualizarExistencias = new classProducto();
            foreach (classProductoDeFactura producto in facturaDeVenta.listaDeProductos)
            {
                productoParaActualizarExistencias.idProducto = Convert.ToInt16(producto.IdProducto);
                productoParaActualizarExistencias.getProductById(); 
                productoParaActualizarExistencias.existencia = productoParaActualizarExistencias.existencia - Convert.ToInt16(producto.Cantidad);
                producto.calcularTotal(); 
                producto.Insert();
                productoParaActualizarExistencias.updateProduct(); 
            }
            facturaDeVenta.IdCliente = clienteParaFacturacion.idCliente; 
            facturaDeVenta.insertFactura();
            MessageBox.Show("Factura Creada. Pulse aceptar para visualizar las facturas realizadas");
            this.Close(); 
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxDatosReceptor_Enter(object sender, EventArgs e)
        {

        }
    }
}
