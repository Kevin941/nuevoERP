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
    public class classEmpleado
    {
        public int idEmpleado = -1;
        public string nombre = "";
        public string apellido = "";
        public string cargo = "";
        public string sexo = "";
        public int salario = 0;
        public string fechaDeIngreso= "";        
        public string tipoDeContrato = "";
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
        public DataTable selectAllEmployees()
        {
            //SQL STMT
            string sql = "SELECT * FROM db_erp.t_empleados";
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
            return tablaProveedores;
        }

        public bool existe()
        {
            string sql = "SELECT * FROM db_erp.t_empleados where idEmpleado=" + idEmpleado + ";";
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
            string sql = "SELECT * FROM db_erp.t_empleados where idEmpleado=" + idEmpleado + ";";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProveedores = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);


                adapter.Fill(tablaProveedores);

                nombre = tablaProveedores.Rows[0]["nombre"].ToString();
                apellido = tablaProveedores.Rows[0]["apellido"].ToString();
                cargo = tablaProveedores.Rows[0]["cargo"].ToString();
                sexo = tablaProveedores.Rows[0]["sexo"].ToString();
                salario = Convert.ToInt16(tablaProveedores.Rows[0]["salario"].ToString());
                fechaDeIngreso = tablaProveedores.Rows[0]["fechaDeIngreso"].ToString();
                tipoDeContrato = tablaProveedores.Rows[0]["tipoDeContrato"].ToString();                
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

            string q = "insert into db_erp.t_empleados (nombre, apellido, cargo, sexo, salario, fechaDeIngreso, tipoDeContrato) " +
            "values('" + nombre + "','" + apellido + "','" + cargo + "','" + sexo + "','" + salario + "','" + fechaDeIngreso + "','" + tipoDeContrato + "');";

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
            string q = "update db_erp.t_empleados set nombre='" + nombre + "', apellido='" + apellido + "', cargo='" + cargo +
                "', sexo='" + sexo + "', salario='" + salario + "', fechaDeIngreso='" + fechaDeIngreso + "', tipoDeContrato='" + tipoDeContrato +
                "' WHERE idEmpleado=" + idEmpleado + ";";
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
            string q = "delete FROM db_erp.t_empleados WHERE idEmpleado=" + idEmpleado + ";";

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