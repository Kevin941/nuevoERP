using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public partial class ERPformAdministrarCatalogoDeProductos : Form
    {
        classProducto producto = new classProducto(); 
        public ERPformAdministrarCatalogoDeProductos()
        {
            InitializeComponent();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if ((textBoxCodigoDelProducto.Text == null) || (textBoxCodigoDelProducto.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un codigo para el producto");
                return; 
            }

            if ((textBoxDescripcion.Text == null) || (textBoxDescripcion.Text == ""))
            {
                MessageBox.Show("Por favor ingresa una descripción");
                return;
            }

            if ((textBoxPrecio.Text == null) || (textBoxPrecio.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un Precio");
                return;
            }

            if ((textBoxExistencia.Text == null) || (textBoxExistencia.Text == ""))
            {
                MessageBox.Show("Por favor ingresa una cantidad para la existencia");
                return;
            }
            
            if ((dateTimeFechaDeCaducidad.Text == null) || (dateTimeFechaDeCaducidad.Text == ""))
            {
                MessageBox.Show("Por favor ingresa una fecha de caducidad");
                return;
            }

            if ((textBoxLote.Text == null) || (textBoxLote.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un lote");
                return;
            }


            //Validacion para los datos que deben ser números 

            try
            {
                int entero = Convert.ToInt16(textBoxExistencia.Text); 
            }
            catch (Exception ex) {
                MessageBox.Show("Por favor ingresa un numero entero para la existencia");
                return; 
                }

            try
            {
                float numeroDecimal = Convert.ToSingle(textBoxPrecio.Text); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingresa un número entero o decimal para el precio");
                return;
            }
            producto.codigoDelProducto = textBoxCodigoDelProducto.Text;
            producto.descripcion = textBoxDescripcion.Text;
            producto.precio = textBoxPrecio.Text;
            producto.existencia = Convert.ToInt16(textBoxExistencia.Text); 
            producto.fechaCaducidad = dateTimeFechaDeCaducidad.Text;
            producto.lote = textBoxLote.Text;
            producto.insertProduct();
            mostrarProductosEnGrid(); 
        }

        private void formAgregarProductoAlCatalogo_Load(object sender, EventArgs e)
        {
            mostrarProductosEnGrid(); 
        }

        private void mostrarProductosEnGrid()
        {
            DataTable tablaProductos = producto.selectAllProducts();
            dataGridProductosDeCatalogo.DataSource = tablaProductos;
            autosizeGridProductosDeCatalogo();            
        }

        private void autosizeGridProductosDeCatalogo()
        {
            dataGridProductosDeCatalogo.AllowUserToOrderColumns = true;
            dataGridProductosDeCatalogo.AllowUserToResizeColumns = true;

            dataGridProductosDeCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProductosDeCatalogo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {

            if ((producto.idProducto <0 ))
            {
                MessageBox.Show("Por favor selecciona producto");
                return;
            }

            producto.deleteProduct();
            mostrarProductosEnGrid(); 
        }

        private void dataGridProductosDeCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;
            /*
            DataGridViewRow row = dataGridAgregarCliente.Rows[rowIndex];
            /*
            idProducto
            codigoDelProducto
            descripcion
            precio
            existencia
            fechaCaducidad
            lote
             * */
            try
            {
                producto.idProducto = Convert.ToInt16(dataGridProductosDeCatalogo.Rows[rowIndex].Cells[0].Value.ToString());

                textBoxCodigoDelProducto.Text = dataGridProductosDeCatalogo.Rows[rowIndex].Cells[1].Value.ToString();
                textBoxDescripcion.Text = dataGridProductosDeCatalogo.Rows[rowIndex].Cells[2].Value.ToString();
                float flotante = Convert.ToSingle(dataGridProductosDeCatalogo.Rows[rowIndex].Cells[3].Value);
                textBoxPrecio.Text = Convert.ToSingle(dataGridProductosDeCatalogo.Rows[rowIndex].Cells[3].Value.ToString()).ToString(CultureInfo.InvariantCulture); 
                textBoxExistencia.Text = dataGridProductosDeCatalogo.Rows[rowIndex].Cells[4].Value.ToString();
                dateTimeFechaDeCaducidad.Text = dataGridProductosDeCatalogo.Rows[rowIndex].Cells[5].Value.ToString();
                textBoxLote.Text = dataGridProductosDeCatalogo.Rows[rowIndex].Cells[6].Value.ToString();
            }
            catch
            {
                return; 
            }
            
            
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if ((textBoxCodigoDelProducto.Text == null) || (textBoxCodigoDelProducto.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un codigo para el producto");
                return;
            }

            if ((textBoxDescripcion.Text == null) || (textBoxDescripcion.Text == ""))
            {
                MessageBox.Show("Por favor ingresa una descripción");
                return;
            }

            if ((textBoxPrecio.Text == null) || (textBoxPrecio.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un Precio");
                return;
            }

            if ((textBoxExistencia.Text == null) || (textBoxExistencia.Text == ""))
            {
                MessageBox.Show("Por favor ingresa una cantidad para la existencia");
                return;
            }

            if ((dateTimeFechaDeCaducidad.Text == null) || (dateTimeFechaDeCaducidad.Text == ""))
            {
                MessageBox.Show("Por favor ingresa una fecha de caducidad");
                return;
            }

            if ((textBoxLote.Text == null) || (textBoxLote.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un lote");
                return;
            }


            //Validacion para los datos que deben ser números 

            try
            {
                int entero = Convert.ToInt16(textBoxExistencia.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingresa un numero entero para la existencia");
                return;
            }

            try
            {
                float numeroDecimal = Convert.ToSingle(textBoxPrecio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingresa un número entero o decimal para el precio");
                return;
            }
            producto.codigoDelProducto = textBoxCodigoDelProducto.Text;
            producto.descripcion = textBoxDescripcion.Text;
            producto.precio = textBoxPrecio.Text;
            producto.existencia = Convert.ToInt16(textBoxExistencia.Text);
            producto.fechaCaducidad = dateTimeFechaDeCaducidad.Text;
            producto.lote = textBoxLote.Text;
            producto.updateProduct();
            mostrarProductosEnGrid(); 
        }




    }
}
