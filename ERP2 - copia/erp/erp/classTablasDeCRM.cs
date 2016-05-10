using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public class classTablasDeCRM
    {

        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public MySqlCommand mcd;
        public MySqlDataAdapter adapter;


        public DataTable selectClientesParaPromocionDeMostrador()
        {
            //SQL STMT
            string sql = "select idCliente, nombreCompania, nombreContacto, "+ 
                "ciudad, pais, telefono, fax, mail from db_erp.t_cliente where t_cliente.ciudad = 'Distrito Federal';";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProductos);
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            return tablaProductos;
        }

        public DataTable selectV_clientesFrecuentes()
        {
            //SQL STMT
            string sql = "SELECT * from db_erp.v_clientesFrecuentes";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProductos);
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            return tablaProductos;
        }

        public DataTable selectV_clientesMayoresCompras()
        {
            //SQL STMT
            string sql = "SELECT * from db_erp.v_clientesMayoresCompras";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProductos);
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            return tablaProductos;
        }
        

        public DataTable selectClientesPorCiudad(string ciudad)
        {
            //SQL STMT
            string sql = "Select idCliente, nombreCompania, nombreContacto, " +
                "ciudad, pais, telefono, fax, mail from db_erp.t_cliente where t_cliente.ciudad = '" + ciudad + "';";
            //MessageBox.Show(sql); 
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProductos);
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            return tablaProductos;
        }

        public DataTable selectV_ciudadesMayoresCompras()
        {
            //SQL STMT
            string sql = "SELECT * from db_erp.v_ciudadesMayoresCompras";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProductos);
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            return tablaProductos;
        }

        public DataTable selectV_clientesPorCiudad()
        {
            //SQL STMT
            string sql = "SELECT * from db_erp.v_clientesPorCiudad";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProductos);
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            return tablaProductos;
        }

        public DataTable selectV_productosMasVendidos()
        {
            //SQL STMT
            string sql = "SELECT * from db_erp.v_productosMasVendidos";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProductos);
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            return tablaProductos;
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
    }
}
