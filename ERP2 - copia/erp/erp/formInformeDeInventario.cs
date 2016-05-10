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
    public partial class formInformeDeInventario : Form
    {
        public classProducto producto = new classProducto(); 
        
        public formInformeDeInventario()
        {
            InitializeComponent();
        }

        private void mostrarProductos_Load(object sender, EventArgs e)
        {
            //producto.codigoDelProducto = "codigoActualizado"; 
            //producto.descripcion = "producto con cura para el cancer"; 
            //producto.precio = 2000.50f; 
            //producto.existencia = 20; 
            //producto.fechaCaducidad = "fecha";
            //producto.lote = "lote"; 
            //producto.insertProduct(); 
            //producto.updateProduct(); 
            //producto.deleteProduct(); 
            DataTable tablaProductos = producto.selectAllProducts();
            dataGridProductos.DataSource = tablaProductos;
            autosizeGridProductos();
            
            //MessageBox.Show(producto.codigoDelProducto); 
        }

        private void autosizeGridProductos()
        {

            dataGridProductos.AllowUserToOrderColumns = true;
            dataGridProductos.AllowUserToResizeColumns = true;

            dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose(); 
        }



    }
}
