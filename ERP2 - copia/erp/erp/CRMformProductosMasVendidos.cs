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
    public partial class CRMformProductosMasVendidos : Form
    {
        classTablasDeCRM tablasParaCRM = new classTablasDeCRM(); 
        public CRMformProductosMasVendidos()
        {
            InitializeComponent();
        }

        private void CRMformProductosMasVendidos_Load(object sender, EventArgs e)
        {
            mostrarTablaEnGrid(tablasParaCRM.selectV_productosMasVendidos(), dataGridViewClientes);
        }

        private void mostrarTablaEnGrid(DataTable tabla, DataGridView grid)
        {
            grid.DataSource = tabla;
            grid.AllowUserToOrderColumns = true;
            grid.AllowUserToResizeColumns = true;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
