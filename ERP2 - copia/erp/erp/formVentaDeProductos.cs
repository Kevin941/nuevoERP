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
    public partial class formVentaDeProductos : Form
    {
        classFacturaVenta facturaDeVenta = new classFacturaVenta();
        classProductoDeFactura productoDeFactura = new classProductoDeFactura();
        classProducto productoDeBusqueda = new classProducto(); 
         
        public formVentaDeProductos()
        {
            InitializeComponent();
        }

        private void formVentaDeProductos_Load(object sender, EventArgs e)
        {
            textBoxCodigoDelProducto.Enabled = false;  
            textBoxDescripcionDelProducto.Enabled = false;
            textBoxPrecioUnitario.Enabled = false;
            dateTimeFechaDeCaducidad.Enabled = false;  
            textBoxExistencia.Enabled = false;  
            textBoxLote.Enabled = false;
            mostrarProductosEnGrid(); 
        }

        private void botonBuscarProducto_Click(object sender, EventArgs e)
        {
            if ((textBoxClaveDeProducto.Text=="") || (textBoxClaveDeProducto.Text==null))
            {
                MessageBox.Show("Introduce una clave de producto"); 
                return; 
            }


            productoDeBusqueda.idProducto = Convert.ToInt16(textBoxClaveDeProducto.Text);
            if(!productoDeBusqueda.existe())
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
            //facturaDeVenta.IdVenta = (facturaDeVenta.getLastId() + 1).ToString(); 
            if (facturaDeVenta.listaDeProductos.Count < 1)
            {
                MessageBox.Show("Debe de agregar al menos un producto para continuar");
                return; 
            }
            if((comboBoxFormaDeEnvio.Text == "")||(comboBoxFormaDeEnvio.Text == null))
            {
                MessageBox.Show("Por favor ingresa una forma de envío"); 
                return; 
            }

            facturaDeVenta.FormaDeEnvio = comboBoxFormaDeEnvio.Text; 
            facturaDeVenta.FechaEntrega = dateTimeFechaDeEntrega.Text;
            facturaDeVenta.FechaEnvio = dateTimeFechaDeEnvio.Text;
            facturaDeVenta.FechaPago = dateTimeFechaDePago.Text;
            facturaDeVenta.FechaPedido = dateTimeFechaDePedido.Text; 
            formDatosParaFacturaVenta ventanaCapturarDatosDeFactura = new formDatosParaFacturaVenta(facturaDeVenta);
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
            if((textBoxCantidad.Text=="") || (textBoxCantidad.Text == null )){
                MessageBox.Show("Por favor ingresa una cantidad");
                return; 
            }
            try {
                int entero = Convert.ToInt16(textBoxCantidad.Text); 
            }
            catch{
                MessageBox.Show("Ingresa un número entero para la cantidad"); 
                return; 
            }

            if (productoDeBusqueda.existencia < Convert.ToInt16(textBoxCantidad.Text))
            {
                MessageBox.Show("No hay productos suficientes para realizar esa venta.");
                return;
            }

            //Se prepara el producto para agregarlo a la lista de productos de la factura
            productoDeFactura = new classProductoDeFactura();
            productoDeFactura.IdProducto = productoDeBusqueda.idProducto.ToString();
            productoDeFactura.IdVenta = (facturaDeVenta.getLastId() + 1).ToString();
            productoDeFactura.Precio = productoDeBusqueda.precio.ToString();
            productoDeFactura.Cantidad = textBoxCantidad.Text;
            productoDeFactura.CodigoDelProducto = productoDeBusqueda.codigoDelProducto;
            productoDeFactura.Descripcion = productoDeBusqueda.descripcion;
            productoDeFactura.calcularTotal(); 
            
            //Se introduce el producto a la factura
            facturaDeVenta.listaDeProductos.Add(productoDeFactura); 

            //Se limpia el formulario 
            limpiarFormulario();
            mostrarProductosEnGrid(); 
        }

        private void mostrarProductosEnGrid()
        {
            BindingSource source = new BindingSource();
            source.DataSource = facturaDeVenta.listaDeProductos;
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
            textBoxExistencia.Text ="";
            textBoxLote.Text = "";
        }

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return; 
        }

        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
