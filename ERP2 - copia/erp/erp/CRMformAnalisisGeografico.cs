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
    public partial class CRMformAnalisisGeografico : Form
    {
        classTablasDeCRM tablasParaCRM = new classTablasDeCRM(); 
        public CRMformAnalisisGeografico()
        {
            InitializeComponent();
        }

        private void botonMostrarTabla_Click(object sender, EventArgs e)
        {
            if ((comboBoxCiudad.Text == "") || (comboBoxCiudad.Text == null))
            {
                MessageBox.Show("Por favor selecciona una ciudad");
                return; 
            }
            mostrarTablaEnGrid(tablasParaCRM.selectClientesPorCiudad(comboBoxCiudad.Text), dataGridViewClientes);

        }

        private void mostrarTablaEnGrid(DataTable tabla, DataGridView grid)
        {
            grid.DataSource = tabla;
            grid.AllowUserToOrderColumns = true;
            grid.AllowUserToResizeColumns = true;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void botonCiudadesConMayorConsumo_Click(object sender, EventArgs e)
        {
             mostrarTablaEnGrid(tablasParaCRM.selectV_ciudadesMayoresCompras(), dataGridViewClientes);
            
        }
    }
}
