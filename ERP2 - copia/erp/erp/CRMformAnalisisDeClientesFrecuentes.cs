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
    public partial class CRMformAnalisisDeClientesFrecuentes : Form
    {
        classTablasDeCRM tablasParaCRM = new classTablasDeCRM(); 
        public CRMformAnalisisDeClientesFrecuentes()
        {
            InitializeComponent();
        }

        private void formAnalisisDeClientesFrecuentes_Load(object sender, EventArgs e)
        {

        }

        private void buttonBotonMayoresCompras_Click(object sender, EventArgs e)
        {
            labelDescripcion.Text = "A continuación se muestra una que reporta a los clientes que han consumido más con MSM";
            mostrarTablaEnGrid(tablasParaCRM.selectV_clientesMayoresCompras(), dataGridViewClientes); 
            
        }

        private void mostrarTablaEnGrid(DataTable tabla, DataGridView grid)
        {
            grid.DataSource = tabla;
            grid.AllowUserToOrderColumns = true;
            grid.AllowUserToResizeColumns = true;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void botonClientesFrecuentes_Click(object sender, EventArgs e)
        {
            labelDescripcion.Text = "A continuación se muestra un reporte de los clientes con mayor cantidad de compras";
            mostrarTablaEnGrid(tablasParaCRM.selectV_clientesFrecuentes(), dataGridViewClientes);
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
