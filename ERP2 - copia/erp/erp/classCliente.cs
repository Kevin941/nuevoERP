using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace erp
{
    public class classCliente
    {
        public string telefono;
        public string region;
        public string pais;
        public string nombreContacto;
        public string nombreCompania;
        public string mail;
        public string idCliente;
        public string fax;
        public string direccion;
        public string codigoPostal;
        public string ciudad;
        public string cargoContacto;
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public MySqlCommand mcd;
        public MySqlDataAdapter adapter;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
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
        public DataTable selectAllClients()
        {


            //SQL STMT
            string sql = "select idCliente, nombreCompania, nombreContacto, " +
                "cargoContacto, direccion, ciudad, region, codigoPostal, pais, telefono, fax, mail from db_erp.t_cliente where t_cliente.borrado = false";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaClientes = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaClientes);
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            return tablaClientes;
        }
        public bool existe()
        {
            string sql = "SELECT * FROM db_erp.t_cliente where idCliente=" + idCliente + " and borrado=false;";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();
                adapter = new MySqlDataAdapter(mcd);
                adapter.Fill(tablaProductos);
                closeCon();
                if (tablaProductos.Rows.Count > 0)
                    return true;
                else
                    return false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeCon();
                return false;
            }
        }
        public void getClientById()
        {
            string sql = "SELECT * FROM db_erp.t_cliente where idCliente=" + idCliente + ";";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaClientes = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);


                adapter.Fill(tablaClientes);

                telefono = tablaClientes.Rows[0]["telefono"].ToString();
                region = tablaClientes.Rows[0]["region"].ToString();
                pais = tablaClientes.Rows[0]["pais"].ToString();
                nombreContacto = tablaClientes.Rows[0]["nombreContacto"].ToString();
                nombreCompania = tablaClientes.Rows[0]["nombreCompania"].ToString();
                mail = tablaClientes.Rows[0]["mail"].ToString();
                fax = tablaClientes.Rows[0]["fax"].ToString();
                direccion = tablaClientes.Rows[0]["direccion"].ToString();
                codigoPostal = tablaClientes.Rows[0]["codigoPostal"].ToString();
                ciudad = tablaClientes.Rows[0]["ciudad"].ToString();
                cargoContacto = tablaClientes.Rows[0]["cargoContacto"].ToString();


                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }


        }

        public void insertClient()
        {
            string q = "insert into db_erp.t_cliente (telefono, region, pais, nombreContacto, nombreCompania, mail, fax, direccion, codigoPostal, " +
            "ciudad, cargoContacto) " +
            "values('" + telefono + "','" + region + "','" + pais + "','" + nombreContacto + "','" + nombreCompania + "','" + mail + "','" + fax + "','" + direccion +
            "','" + codigoPostal + "','" + ciudad + "','" + cargoContacto + "');";

            Console.WriteLine(q);
            MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Query Executed");
                }
                else
                {
                    //MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        public void updateClient()
        {
            string q = "update db_erp.t_cliente set telefono='" + telefono + "', region='" + region + "', pais='" + pais + "', nombreContacto='" +
                nombreContacto + "', nombreCompania='" + nombreCompania + "', mail='" + mail + "', fax='" + fax +
                "', direccion='" + direccion + "', codigoPostal='" + codigoPostal + "', ciudad='" + ciudad
                + "', cargoContacto='" + cargoContacto +
                "' WHERE idCliente=" + idCliente + ";";

            //MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Query Executed");
                }
                else
                {
                    //MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        public void deleteClient()
        {

            if (MessageBox.Show("¿Realmente quieres eliminar el cliente?", "Cuidado",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.No)
            {
                return;
            }

            string q = "update db_erp.t_cliente set borrado=" + "true" +
                " WHERE idCliente=" + idCliente + ";";

            MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Query Executed");
                }
                else
                {
                    //MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }



    }

}

