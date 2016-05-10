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
    public class classProveedor
    {
        public int idProveedor = -1;
        public string nombreProveedor;
        public string nombreContacto;
        public string cargoContacto;
        public string direccion;
        public string ciudad;
        public string mail; 
        public string region;
        public string codigoPostal;
        public string pais;
        public string telefono;
        public string fax; 
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public MySqlCommand mcd;
        public MySqlDataAdapter adapter;

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
        public DataTable selectAllSuppliers()
        {


            //SQL STMT
            string sql = "SELECT * FROM db_erp.t_proveedor";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores= new DataTable();
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
            return tablaProveedores;
        }

        public bool existe()
        {
            string sql = "SELECT * FROM db_erp.t_proveedor where idProveedor=" + idProveedor + ";";
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
        public void getSupplierById()
        {
            string sql = "SELECT * FROM db_erp.t_proveedor where idProveedor=" + idProveedor + ";";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);


                adapter.Fill(tablaProveedores);

                nombreProveedor = tablaProveedores.Rows[0]["nombreProveedor"].ToString();
                nombreContacto = tablaProveedores.Rows[0]["nombreContacto"].ToString();
                cargoContacto = tablaProveedores.Rows[0]["cargoContacto"].ToString();
                direccion = tablaProveedores.Rows[0]["direccion"].ToString();
                ciudad = tablaProveedores.Rows[0]["ciudad"].ToString();
                mail = tablaProveedores.Rows[0]["mail"].ToString();
                region = tablaProveedores.Rows[0]["region"].ToString();
                fax = tablaProveedores.Rows[0]["fax"].ToString();                
                codigoPostal = tablaProveedores.Rows[0]["codigoPostal"].ToString();
                pais = tablaProveedores.Rows[0]["pais"].ToString();
                telefono = tablaProveedores.Rows[0]["telefono"].ToString();
                fax = tablaProveedores.Rows[0]["fax"].ToString();
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }


        }

        public void insertSupplier()
        {

            string q = "insert into db_erp.t_proveedor (nombreProveedor, nombreContacto, cargoContacto, direccion, ciudad, mail, region, codigoPostal, pais, telefono, fax) " +
            "values('" + nombreProveedor + "','" + nombreContacto + "','" + cargoContacto + "','" + direccion + "','" + ciudad + "','" + mail + "','" + region + "','" + codigoPostal +
            "','" + pais + "','" + telefono + "','" + fax + "');";


            //MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                 //   MessageBox.Show("Query Executed");
                }
                else
                {
                   // MessageBox.Show("Query Not Executed");
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

        public void updateSupplier()
        {
            string q = "update db_erp.t_proveedor set nombreProveedor='" + nombreProveedor + "', nombreContacto='" + nombreContacto + "', cargoContacto='" + cargoContacto +
                "', direccion='" + direccion + "', ciudad='" + ciudad + "', mail='" + mail + "', region='" + region + "', codigoPostal='" + codigoPostal + 
                "', pais='" + pais + "', telefono='" + telefono + "', fax='" + fax +
                "' WHERE idProveedor=" + idProveedor + ";";

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

        
        public void deleteProveedor()
        {
            string q = "delete FROM db_erp.t_proveedor WHERE idProveedor=" + idProveedor + ";";

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
        
    }

}