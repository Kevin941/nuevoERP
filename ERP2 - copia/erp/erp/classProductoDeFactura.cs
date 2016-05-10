using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public class classProductoDeFactura
    {
        private string idVenta;
        private string idProducto;
        private string cantidad;
        private string codigoDelProducto;
        private string descripcion;
        private string precio;
        private string total; 

        public string IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        
        public string IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string CodigoDelProducto
        {
            get { return codigoDelProducto; }
            set { codigoDelProducto = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public string Total
        {
            get { return total; }
            set { total = value; }
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public classProductoDeFactura()
        {
            server = "localhost";
            database = "db_erp";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

       

        private void Initialize()
        {

        }
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert()
        {
            string query = "INSERT INTO db_erp.t_detalleVenta (idVenta, idProducto, total, cantidad) " +
                "VALUES(" +
                "'" + idVenta + "'" + ", " +
                "'" + idProducto + "'" + ", " +
                "'" + total + "'" + ", " +
                "'" + cantidad + "'" + ")";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE db_erp.t_detalleventa SET " + 
                "cantidad=" + "'" + cantidad + "'" +
                "total=" + "'" + total + "'" +
                "WHERE idVenta='" + idVenta + "' and idProducto='" + idProducto + "';";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM db_erp.t_detalleventa WHERE idVenta='"+ idVenta+ "' and idProducto='"+idProducto+"';";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void calcularTotal()
        {
            this.total = (Convert.ToSingle(this.precio) * Convert.ToInt16(this.cantidad)).ToString(); 
        }
    }
}

