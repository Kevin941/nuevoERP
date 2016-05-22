using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace erp
{
    public partial class formAnalisisGrafico : Form
    {
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public MySqlCommand mcd;
        public MySqlDataAdapter adapter;

        public string tipoGrafica = "";
        public formAnalisisGrafico(string tipoGrafica)
        {
            this.tipoGrafica = tipoGrafica; 
            InitializeComponent();
        }
        public formAnalisisGrafico()
        {
         
            InitializeComponent();
        }
        public void closeCon()
        {
            if (mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }
        }

        public void openCon()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }
        private void grafica_Load(object sender, EventArgs e)
        {
            //Quitamos el letrero de "miSerie"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;

            /*this.WindowState = FormWindowState.Maximized;
            MinimumSize = this.Size;
            MaximumSize = this.Size;
            dataGridViewQuery.Width = this.Width - 35;
            chartEjemplo.Width = this.Width - 35;*/

            //____________________________________________________________________________________________________________________________________________
            //____________________________________________________________________________________________________________________________________________
            //____________________________________________________________________________________________________________________________________________
            //____________________________________________________________________________________________________________________________________________

            chartEjemplo.Series["miSerie"].Points.Clear();
            comboBoxGraficaAmostrar.SelectedIndex = 6; 
            
            

            
            

        }

        private void v_clientesfrecuentes()
        {
            //SQL STMT
            string sql = "SELECT nombreCompania as 'Compania', comprasRealizadas as 'Compras realizadas' FROM db_erp.v_clientesfrecuentes";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;

            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));

            }

            //Colocamos los titulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);

            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 100;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
        }

        private void v_clientesmayorescompras()
        {
            //SQL STMT
            string sql = "SELECT nombreCompania as 'Compania', montoTotal as 'Monto total' FROM db_erp.v_clientesmayorescompras";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;

            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));

            }

            //Colocamos los titulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);

            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 100;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
        }

        private void v_clientescargo()
        {
            //SQL STMT
            string sql = "SELECT cargoContacto as 'Puesto del contacto', cantidad as 'Cantidad de puestos   ' FROM db_erp.v_clientescargo";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;

            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));

            }

            //Colocamos los titulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);

            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 100;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
        }

        private void v_clientesciudad()
        {
            //SQL STMT
            string sql = "SELECT ciudad as 'Ciudad', cantidad as 'Cantidad de clientes' FROM db_erp.v_clientesciudad";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;

            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));

            }

            //Colocamos los titulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);

            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 100;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
        }

        private void v_ciudadesmayorescomprasEnPesos()
        {
            //SQL STMT
            string sql = "SELECT ciudad as 'Ciudad', montoTotal as 'Compras en $$' FROM db_erp.v_ciudadesmayorescompras";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;

            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));

            }

            //Colocamos los titulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);

            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 100;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
        }

        private void v_ciudadesmayorescomprasCantidad()
        {
            //SQL STMT
            string sql = "SELECT ciudad as 'Ciudad', Compras_por_ciudad as 'Cantidad de compras' FROM db_erp.v_ciudadesmayorescompras";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;

            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));

            }

            //Colocamos los titulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);

            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 1;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
        }

        private void autoSizeDataGrid(DataGridView dataGridView1)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoResizeColumns();            
            dataGridView1.AutoResizeRows(); 
        }

        public void show_v_empleadossexo()
        {
            //SQL STMT
            string sql = "SELECT * FROM db_erp.v_empleadossexo";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;
            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));
                
            }

            //Colocamos los títulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 5;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void v_productosEnExistencia()
        {
            //SQL STMT
            string sql = "select codigoDelProducto as 'Codigo de producto', existencia as 'Existencia' from db_erp.t_producto; ";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;
            

            

            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));

            }

            //Colocamos los títulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();            
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            
            

            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 100;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
        }

        private void v_productosmasvendidos()
        {
            //SQL STMT
            string sql = "SELECT codigoDelProducto as 'Codigo del producto', cantidadVendidos as 'Cantidad vendidos' FROM db_erp.v_productosmasvendidos";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;

            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));

            }

            //Colocamos los titulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);

            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 5;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
        }

        private void v_empleadoscargo()
        {
            //SQL STMT
            string sql = "SELECT * FROM db_erp.v_empleadoscargo";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProveedores);
                closeCon();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                closeCon();
            }

            dataGridViewQuery.DataSource = tablaProveedores;
            autoSizeDataGrid(dataGridViewQuery);

            for (int x = 0; x < tablaProveedores.Rows.Count; x++)
            {
                //MessageBox.Show(); 
                chartEjemplo.Series["miSerie"].Points.AddXY(tablaProveedores.Rows[x][0].ToString(), Convert.ToInt32(tablaProveedores.Rows[x][1].ToString()));

            }

            //Colocamos los títulos de las gráficas
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Title = tablaProveedores.Columns[0].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Title = tablaProveedores.Columns[1].ToString();
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 22.5F, System.Drawing.FontStyle.Bold);

            //Las distancias entre campo y campo 
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Las distancias entre unidad y unidad
            //chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 5;

            //Quitamos el letrero de "miSeria"
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
        }

        private void comboBoxGraficaAmostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartEjemplo.Series["miSerie"].Points.Clear();
            string seleccionado = comboBoxGraficaAmostrar.Text;

            switch (seleccionado)
            {
                case "Empleados por sexo": 
                    show_v_empleadossexo();
                    break; 
                case "Empleados por cargo": 
                    v_empleadoscargo();            
                    break; 
                case "Productos en existencia": 
                    v_productosEnExistencia();
                    break; 
                case "Productos mas vendidos":
                    v_productosmasvendidos();            
                    break; 
                case "Ciudades con más compras": 
                    v_ciudadesmayorescomprasCantidad();            
                    break; 
                case "Ciudades con mayores compras": 
                    v_ciudadesmayorescomprasEnPesos();           
                    break; 
                case "Clientes por ciudad":
                    v_clientesciudad();            
                    break; 
                case "Clientes por puesto (cargo)": 
                    v_clientescargo();            
                    break; 
                case "Clientes con mayores compras": 
                    v_clientesmayorescompras();            
                    break; 

                case "Clientes mas frecuentes":
                    v_clientesfrecuentes(); 
                    break;
            }

        }
    }
}
