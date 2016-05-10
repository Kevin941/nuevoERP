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
    public class classFacturaCompra
    {
        //Campos llenados con los datos de MSM. Se llenan en el constructor de "formDatosParaFacturaVenta"
        private string empresaMSM;
        private string direccionMSM;
        private string telefonoMSM;

        //Este valor se llena en el formulario formDatosParaFacturaVenta
        private string idCompra; //Es lo mismo que id de factura

        //El id Cliente se llena desde el formulario formDatosParaFacturaVenta
        private string idCliente;

        //Campos llenados manualmente en el formulario de FormVentaDeProductos 
        private string fechaPedido;
        private string fechaEntrega;
        private string fechaEnvio;
        private string fechaPago;
        private string formaDeEnvio;


        //Campos llenados por medio del Formulario de formDatosParaFactura (Se llena el formulario con un Query a la tabla de clientes) 
        private string destinatario;
        private string direccionDestinatario;
        private string ciudadDestinatario;
        private string regionDestinatario;
        private string codigoPostalDestinatario;
        private string paisDestinatario;
        private string telefonoDestinatario;
        private string faxDestinatario;
        private string mailDeContacto;

        //Estos 3 valores se calculan con el resultado de la lista de productos. 
        //Se calculan en el momento de invocar el formulario formDatosParaFactura
        private string subtotal;
        private string iva;
        private string monto; //Es lo mismo que total 




        public string Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        public string Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        private classProductoDeFacturaCompra productoTemporal;
        public List<classProductoDeFacturaCompra> listaDeProductos = new List<classProductoDeFacturaCompra>();
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public MySqlCommand mcd;
        public MySqlDataAdapter adapter;

        public string EmpresaMSM
        {

            get { return empresaMSM; }
            set { empresaMSM = value; }
        }

        public string DireccionMSM
        {
            get { return direccionMSM; }
            set { direccionMSM = value; }
        }
        public string TelefonoMSM
        {
            get { return telefonoMSM; }
            set { telefonoMSM = value; }
        }
        public string IdCompra { get { return idCompra; } set { idCompra = value; } } //Es lo mismo que id de factura
        public string IdCliente { get { return idCliente; } set { idCliente = value; } }
        public string FechaPedido { get { return fechaPedido; } set { fechaPedido = value; } }
        public string FechaEntrega { get { return fechaEntrega; } set { fechaEntrega = value; } }
        public string FechaEnvio { get { return fechaEnvio; } set { fechaEnvio = value; } }
        public string FechaPago { get { return fechaPago; } set { fechaPago = value; } }
        public string FormaDeEnvio { get { return formaDeEnvio; } set { formaDeEnvio = value; } }
        public string Monto { get { return monto; } set { monto = value; } }
        public string Destinatario { get { return destinatario; } set { destinatario = value; } }
        public string DireccionDestinatario { get { return direccionDestinatario; } set { direccionDestinatario = value; } }
        public string CiudadDestinatario { get { return ciudadDestinatario; } set { ciudadDestinatario = value; } }
        public string RegionDestinatario { get { return regionDestinatario; } set { regionDestinatario = value; } }
        public string CodigoPostalDestinatario { get { return codigoPostalDestinatario; } set { codigoPostalDestinatario = value; } }
        public string PaisDestinatario { get { return paisDestinatario; } set { paisDestinatario = value; } }
        public string TelefonoDestinatario { get { return telefonoDestinatario; } set { telefonoDestinatario = value; } }
        public string FaxDestinatario { get { return faxDestinatario; } set { faxDestinatario = value; } }
        public string MailDeContacto { get { return mailDeContacto; } set { mailDeContacto = value; } }

        public void openCon()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }

        public void getFacturaById()
        {

            string sql = "SELECT * FROM db_erp.t_compras where idCompra=" + idCompra + ";";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //MessageBox.Show(sql); 
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();
                adapter = new MySqlDataAdapter(mcd);
                adapter.Fill(tablaProductos);
                idCompra = tablaProductos.Rows[0]["idCompra"].ToString();
                idCliente = tablaProductos.Rows[0]["idCliente"].ToString();
                fechaPedido = tablaProductos.Rows[0]["fechaPedido"].ToString();
                fechaEntrega = tablaProductos.Rows[0]["fechaEntrega"].ToString();
                fechaEnvio = tablaProductos.Rows[0]["fechaEnvio"].ToString();
                fechaPago = tablaProductos.Rows[0]["fechaPago"].ToString();
                formaDeEnvio = tablaProductos.Rows[0]["formaDeEnvio"].ToString();
                monto = tablaProductos.Rows[0]["monto"].ToString();
                destinatario = tablaProductos.Rows[0]["destinatario"].ToString();
                direccionDestinatario = tablaProductos.Rows[0]["direccionDestinatario"].ToString();
                ciudadDestinatario = tablaProductos.Rows[0]["ciudadDestinatario"].ToString();
                regionDestinatario = tablaProductos.Rows[0]["regionDestinatario"].ToString();
                codigoPostalDestinatario = tablaProductos.Rows[0]["codigoPostalDestinatario"].ToString();
                paisDestinatario = tablaProductos.Rows[0]["paisDestinatario"].ToString();
                telefonoDestinatario = tablaProductos.Rows[0]["telefonoDestinatario"].ToString();
                faxDestinatario = tablaProductos.Rows[0]["faxDestinatario"].ToString();
                mailDeContacto = tablaProductos.Rows[0]["mailDeContacto"].ToString();
                subtotal = tablaProductos.Rows[0]["subtotal"].ToString();
                iva = tablaProductos.Rows[0]["iva"].ToString();
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


        public void insertFactura()
        {
            string q = "insert into db_erp.t_compras (idCliente, "
            + "fechaPedido, fechaEntrega, fechaEnvio, fechaPago,"
            + "formaDeEnvio, destinatario, direccionDestinatario,"
            + "ciudadDestinatario, regionDestinatario, codigoPostalDestinatario, paisDestinatario, "
            + "telefonoDestinatario, faxDestinatario, mailDeContacto, subtotal, iva, monto) " +
            "values('" + idCliente + "','" + fechaPedido + "','" + fechaEntrega + "','" + fechaEnvio + "','" + fechaPago +
            "','" + formaDeEnvio + "','" + destinatario + "','" + direccionDestinatario +
            "','" + ciudadDestinatario + "','" + regionDestinatario + "','" + codigoPostalDestinatario + "','" + paisDestinatario +
            "','" + telefonoDestinatario + "','" + faxDestinatario + "','" + mailDeContacto + "','" + subtotal + "','" + iva + "','" + monto + "');";
            //MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Query Executed");
                    idCompra = getLastId().ToString();
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



        public void updateFactura()
        {
            string q = "update db_erp.t_compras set " +
                "idCliente='" + idCliente +
                "', fechaPedido='" + fechaPedido +
                "', fechaEntrega='" + fechaEntrega +
                "', fechaEnvio='" + fechaEnvio +
                "', fechaPago='" + fechaPago +
                "', formaDeEnvio='" + formaDeEnvio +
                "', destinatario='" + destinatario +
                "', direccionDestinatario='" + direccionDestinatario +
                "', ciudadDestinatario='" + ciudadDestinatario +
                "', regionDestinatario='" + regionDestinatario +
                "', codigoPostalDestinatario='" + codigoPostalDestinatario +
                "', paisDestinatario='" + paisDestinatario +
                "', telefonoDestinatario='" + telefonoDestinatario +
                "', faxDestinatario='" + faxDestinatario +
                "', mailDeContacto='" + mailDeContacto +
                "', subtotal='" + subtotal +
                "', iva='" + iva +
                "', monto='" + monto +
                "' WHERE idCompra=" + idCompra + ";";
            MessageBox.Show(q);
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

        public DataTable selectAllFacturas()
        {


            //SQL STMT
            string sql = "SELECT * FROM db_erp.t_compras";
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

        public DataTable selectAllFacturasParaGrid()
        {


            //SQL STMT
            string sql = "select idCompra ,fechaPedido , destinatario , monto from db_erp.t_compras;";
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

        public int getLastId()
        {
            int lastID = -1;
            string sql = "SELECT MAX( idCompra ) FROM db_erp.t_compras;";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //MessageBox.Show(sql); 
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();
                adapter = new MySqlDataAdapter(mcd);
                adapter.Fill(tablaProductos);
                if (tablaProductos.Rows[0][0].ToString() == "")
                    return 0;
                lastID = int.Parse(tablaProductos.Rows[0][0].ToString());
                closeCon();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }
            return lastID;
        }


        public void deleteFactura()
        {
            string q = "delete FROM db_erp.t_compras WHERE idCompra=" + idCompra + "; " +
                "DELETE FROM db_erp.t_detalleventa WHERE idCompra='" + idCompra + "';";
            Console.WriteLine(q);
            MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() != 0)
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

        public void getProductListFromBill()
        {
            string query = "SELECT " +
                "db_erp.t_detalleVenta.cantidad, " +
                "db_erp.t_detalleVenta.total, " +
                "db_erp.t_producto.codigoDelProducto," +
                "db_erp.t_producto.descripcion, " +
                "db_erp.t_producto.precio " +
                "FROM " +
                "db_erp.t_detalleVenta, " +
                "db_erp.t_producto" +
                " where " +
                "t_detalleVenta.idCompra=" + idCompra +
             " and t_detalleVenta.idProducto = t_producto.idProducto;";
            //MessageBox.Show(query); 

            try
            {
                //Open connection
                openCon();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, mcon);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();



                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    productoTemporal = null;
                    productoTemporal = new classProductoDeFacturaCompra();
                    productoTemporal.Cantidad = dataReader["cantidad"].ToString();
                    productoTemporal.CodigoDelProducto = dataReader["codigoDelProducto"].ToString();
                    productoTemporal.Descripcion = dataReader["descripcion"].ToString();
                    productoTemporal.Precio = dataReader["precio"].ToString();
                    productoTemporal.Total = dataReader["total"].ToString();
                    listaDeProductos.Add(productoTemporal);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection

                closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            //return list to be displayed



        }


    }
}
