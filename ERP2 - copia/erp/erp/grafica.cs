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

namespace erp
{
    public partial class grafica : Form
    {
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public MySqlCommand mcd;
        public MySqlDataAdapter adapter;

        public string tipoGrafica = "";
        public grafica(string tipoGrafica)
        {
            this.tipoGrafica = tipoGrafica; 
            InitializeComponent();
        }
        public grafica()
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
            chartEjemplo.Series["miSerie"].IsVisibleInLegend = false;
            show_v_empleadossexo(); 

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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartEjemplo.ChartAreas["ChartArea1"].Position.Width = 100;
            chartEjemplo.ChartAreas["ChartArea1"].Position.Height = 90;
            chartEjemplo.ChartAreas["ChartArea1"].Position.Y=4;
            chartEjemplo.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.Interval = 1;
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
            
            chartEjemplo.ChartAreas["ChartArea1"].AxisY.IsMarginVisible = false;
            chartEjemplo.Series["miSerie"].Points.AddXY("A", 4);
            chartEjemplo.Series["miSerie"].Points.AddXY("B", 5);
            chartEjemplo.Series["miSerie"].Points.AddXY("C", 6);
            chartEjemplo.Series["miSerie"].Points.AddXY("D", 12);
 
        }
    }
}
