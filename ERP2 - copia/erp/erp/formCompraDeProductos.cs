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
    public partial class formCompraDeProductos : Form
    {

        classFacturaCompra facturaDeCompra = new classFacturaCompra();
        classProductoDeFacturaCompra productoDeFactura = new classProductoDeFacturaCompra();
        classProducto productoDeBusqueda = new classProducto();

        public formCompraDeProductos()
        {
            InitializeComponent();
        }

        private void botonBuscarProducto_Click(object sender, EventArgs e)
        {
            if ((textBoxClaveDeProducto.Text == "") || (textBoxClaveDeProducto.Text == null))
            {
                MessageBox.Show("Introduce una clave de producto");
                return;
            }


            productoDeBusqueda.idProducto = Convert.ToInt16(textBoxClaveDeProducto.Text);
            if (!productoDeBusqueda.existe())
            {
                MessageBox.Show("Producto inexistente");
                return;
            }
            productoDeBusqueda.getProductById();

            textBoxCodigoDelProducto.Text = productoDeBusqueda.codigoDelProducto;
            textBoxDescripcionDelProducto.Text = productoDeBusqueda.descripcion;
            textBoxPrecioUnitario.Text = productoDeBusqueda.precio.ToString();
            textBoxExistencia.Text = productoDeBusqueda.existencia.ToString();
            DateTime fecha = DateTime.Parse(productoDeBusqueda.fechaCaducidad.ToString());
            dateTimeFechaDeCaducidad.Value = Convert.ToDateTime(fecha, System.Globalization.CultureInfo.CurrentCulture);
            textBoxLote.Text = productoDeBusqueda.lote;
        }

        private void botonRealizarFactura_Click(object sender, EventArgs e)
        {
            //facturaDeCompra.IdVenta = (facturaDeCompra.getLastId() + 1).ToString(); 
            if (facturaDeCompra.listaDeProductos.Count < 1)
            {
                MessageBox.Show("Debe de agregar al menos un producto para continuar");
                return;
            }
            if ((comboBoxFormaDeEnvio.Text == "") || (comboBoxFormaDeEnvio.Text == null))
            {
                MessageBox.Show("Por favor ingresa una forma de envío");
                return;
            }

            facturaDeCompra.FormaDeEnvio = comboBoxFormaDeEnvio.Text;
            facturaDeCompra.FechaEntrega = dateTimeFechaDeEntrega.Text;
            facturaDeCompra.FechaEnvio = dateTimeFechaDeEnvio.Text;
            facturaDeCompra.FechaPago = dateTimeFechaDePago.Text;
            facturaDeCompra.FechaPedido = dateTimeFechaDePedido.Text;
            formDatosParaFacturaCompra ventanaCapturarDatosDeFactura = new formDatosParaFacturaCompra(facturaDeCompra);
            ventanaCapturarDatosDeFactura.Show();
            this.Hide();
            this.Dispose();
        }

        private void botonAgregarProductoAFactura_Click(object sender, EventArgs e)
        {
            if (textBoxCodigoDelProducto.Text == "")
            {
                MessageBox.Show("Por favor realiza una búsqueda antes de agregar el producto");
                return;

            }
            if ((textBoxCantidad.Text == "") || (textBoxCantidad.Text == null))
            {
                MessageBox.Show("Por favor ingresa una cantidad");
                return;
            }
            try
            {
                int entero = Convert.ToInt16(textBoxCantidad.Text);
            }
            catch
            {
                MessageBox.Show("Ingresa un número entero para la cantidad");
                return;
            }

            if (productoDeBusqueda.existencia < Convert.ToInt16(textBoxCantidad.Text))
            {
                MessageBox.Show("No hay productos suficientes para realizar esa venta.");
                return;
            }

            //Se prepara el producto para agregarlo a la lista de productos de la factura
            productoDeFactura = new classProductoDeFacturaCompra();
            productoDeFactura.IdProducto = productoDeBusqueda.idProducto.ToString();
            productoDeFactura.IdCompra = (facturaDeCompra.getLastId() + 1).ToString();
            productoDeFactura.Precio = productoDeBusqueda.precio.ToString();
            productoDeFactura.Cantidad = textBoxCantidad.Text;
            productoDeFactura.CodigoDelProducto = productoDeBusqueda.codigoDelProducto;
            productoDeFactura.Descripcion = productoDeBusqueda.descripcion;
            productoDeFactura.calcularTotal();

            //Se introduce el producto a la factura
            facturaDeCompra.listaDeProductos.Add(productoDeFactura);

            //Se limpia el formulario 
            limpiarFormulario();
            mostrarProductosEnGrid();
        }

        private void mostrarProductosEnGrid()
        {
            BindingSource source = new BindingSource();
            source.DataSource = facturaDeCompra.listaDeProductos;
            source.ResetBindings(false);
            dataGridProductos.DataSource = source;
            autosizeGrid();

        }

        private void autosizeGrid()
        {

            dataGridProductos.AllowUserToOrderColumns = true;
            dataGridProductos.AllowUserToResizeColumns = true;

            dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void limpiarFormulario()
        {
            textBoxClaveDeProducto.Text = "";
            textBoxLote.Text = "";
            textBoxCodigoDelProducto.Text = "";
            textBoxDescripcionDelProducto.Text = "";
            textBoxPrecioUnitario.Text = "";
            dateTimeFechaDeCaducidad.Text = "";
            textBoxExistencia.Text = "";
            textBoxLote.Text = "";
        }

        private void formCompraDeProductos_Load(object sender, EventArgs e)
        {
            textBoxCodigoDelProducto.Enabled = false;
            textBoxDescripcionDelProducto.Enabled = false;
            textBoxPrecioUnitario.Enabled = false;
            dateTimeFechaDeCaducidad.Enabled = false;
            textBoxExistencia.Enabled = false;
            textBoxLote.Enabled = false;
            mostrarProductosEnGrid(); 
        }
    }
}
