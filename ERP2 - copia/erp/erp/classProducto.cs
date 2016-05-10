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
    public class classProducto
    {
        public int idProducto;
        public string codigoDelProducto;
        public string descripcion;
        public string precio;
        public int existencia;
        public string fechaCaducidad;
        public string lote;
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public MySqlCommand mcd;
        public MySqlDataAdapter adapter;

        public classProducto()
        {
             idProducto= -1;
        codigoDelProducto = "";
        descripcion = "";
        precio = "";
        existencia = -1;
        fechaCaducidad= "";
        lote = "";
        }
        public void openCon()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }

        public bool existe()
        {
            string sql = "SELECT * FROM db_erp.t_producto where idProducto=" + idProducto + ";";
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
        public void getProductById()
        {
            string sql = "SELECT * FROM db_erp.t_producto where idProducto=" + idProducto + ";";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);

                adapter.Fill(tablaProductos);
                codigoDelProducto = tablaProductos.Rows[0]["codigoDelProducto"].ToString(); 
                descripcion = tablaProductos.Rows[0]["descripcion"].ToString(); 
                precio = tablaProductos.Rows[0]["precio"].ToString(); 
                existencia = Convert.ToInt16(tablaProductos.Rows[0]["existencia"].ToString()); 
                fechaCaducidad = tablaProductos.Rows[0]["fechaCaducidad"].ToString(); 
                lote = tablaProductos.Rows[0]["lote"].ToString(); 
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            
        }
        public void closeCon()
        {
            if (mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }         
        }


        public void insertProduct()
        {
            string q = "insert into db_erp.t_producto (codigoDelProducto, descripcion, precio, existencia, fechaCaducidad, lote) " +
            "values('" + codigoDelProducto + "','" + descripcion + "'," + precio + "," + existencia + ",'" + fechaCaducidad +
            "','" + lote + "');";
            //MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
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

        public void updateProduct()
        {
            string q = "update db_erp.t_producto set codigoDelProducto='" + codigoDelProducto + "', descripcion='" + descripcion + "', precio=" + precio + ", existencia=" +
                existencia + ", fechaCaducidad='" + fechaCaducidad + "', lote='" + lote + "' WHERE idProducto=" + idProducto + ";";

            //MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
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

        public DataTable selectAllProducts()
        {
            

            //SQL STMT
            string sql = "SELECT idProducto, codigoDelProducto, descripcion, precio, existencia, fechaCaducidad, lote FROM db_erp.t_producto "
        + "where borrado = false;"; 
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
        public void deleteProduct()
        {

            if (MessageBox.Show("¿Realmente quieres eliminar el Produto? ", "Cuidado",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
               == DialogResult.No)
            {
                return;
            }
            string q = "update db_erp.t_producto set borrado=true where idProducto = " + idProducto+";";

            //MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
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
