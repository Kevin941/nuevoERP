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
    public partial class CRMERPformClientesProveedores : Form
    {

        public classCliente cliente = new classCliente();
        public classProveedor proveedor = new classProveedor();
        public classEmpleado empleado = new classEmpleado(); 
        public CRMERPformClientesProveedores()
        {
            InitializeComponent();
        }

        private void tabPageAgregarCliente_Click(object sender, EventArgs e)
        {
            
        }
        private void mostrarProveedoresEnGrid(){
            
            DataTable tablaProductos = proveedor.selectAllSuppliers();
            dataGridProveedores.DataSource = tablaProductos;
            autosizeGridProveedores();
        }

        private void mostrarEmpleadosEnGrid()
        {

            DataTable tablaEmpleados = empleado.selectAllEmployees();
            dataGridEmpleados.DataSource = tablaEmpleados;
            autosizeGridEmpleados();
        }

        private void mostrarClientesEnGrid()
        {
            DataTable tablaProductos = cliente.selectAllClients();

            dataGridAgregarCliente.DataSource = tablaProductos;
            autosizeGridClientes();
        }
        private void formClientesProveedores_Load(object sender, EventArgs e)
        {
            mostrarClientesEnGrid();
            mostrarProveedoresEnGrid();
            mostrarEmpleadosEnGrid(); 
            /*   
            //Insertar el proveedor 
            proveedor.nombreProveedor = "Nombre"; 
            proveedor.nombreContacto = "NombreContacto"; 
            proveedor.cargoContacto = "CargoContacto"; 
            proveedor.direccion = "Direccion"; 
            proveedor.ciudad = "Ciudad"; 
            proveedor.mail = "Mail"; 
            proveedor.region = "region"; 
            proveedor.codigoPostal = "Codigo"; 
            proveedor.pais = "Pais"; 
            proveedor.telefono = "telefono";
            proveedor.fax = "fax";
            proveedor.insertSupplier(); 

            //Actualizar el proveedor
            proveedor.idProveedor = 2; 
            proveedor.getSupplierById();
            proveedor.nombreProveedor = "NombreÁctualizado";
            proveedor.updateSupplier();
            proveedor.deleteProveedor(); 
            //Borrar el proveedor
            
            /*
            cliente.idCliente = "1"; 
            
            cliente.telefono = "telefono"; 
            cliente.region = "region"; 
            cliente.pais = "pais"; 
            cliente.nombreContacto="Contacto"; 
            cliente.nombreCompania = "Compañia"; 
            cliente.mail = "Mail"; 
            cliente.fax = "fax"; 
            cliente.direccion = "direccion"; 
            cliente.codigoPostal = "codigoPostal"; 
            cliente.ciudad = "ciudad"; 
            cliente.cargoContacto = "cargoContacto";
            cliente.insertClient(); 
            //cliente.getClientById(); 
            */
            /* Código para agregar todos los clientes. 
            DataTable tablaProductos = cliente.selectAllClients();
            dataGridAgregarCliente.DataSource = tablaProductos;
            autosizeGridClientes();      */
            /*
            cliente.idCliente = "2";
            cliente.mail = "Super Mail";
            cliente.updateClient(); 
            cliente.deleteClient(); 
             * */
                }
        private void autosizeGridClientes()
        {

            dataGridAgregarCliente.AllowUserToOrderColumns = true;
            dataGridAgregarCliente.AllowUserToResizeColumns = true;

            dataGridAgregarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAgregarCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void autosizeGridEmpleados()
        {

            dataGridEmpleados.AllowUserToOrderColumns = true;
            dataGridEmpleados.AllowUserToResizeColumns = true;

            dataGridEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void autosizeGridProveedores()
        {

            dataGridProveedores.AllowUserToOrderColumns = true;
            dataGridProveedores.AllowUserToResizeColumns = true;

            dataGridProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void botonAgregarCliente_Click(object sender, EventArgs e)
        {
            if ((comboBoxNombreDeLaCompañia.Text==null)||(comboBoxNombreDeLaCompañia.Text=="")) 
            {
                MessageBox.Show("Por favor ingresa un nombre para la compañia");
                return;
            }

            if ((comboBoxNombreDelContacto.Text == null) || (comboBoxNombreDelContacto.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el contacto");
                return; 
            }

            if ((comboCargoDelContacto.Text == null) || (comboCargoDelContacto.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el cargo del contacto");
                return;
            }
            if ((textBoxDireccion.Text == null) || (textBoxDireccion.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la direccion");
                return;
            }
            if ((comboBoxCiudad.Text == null) || (comboBoxCiudad.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el Ciudad");
                return;
            }
            if ((comboBoxRegion.Text == null) || (comboBoxRegion.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la region");
                return;
            }
            if ((textBoxCodigoPostal.Text == null) || (textBoxCodigoPostal.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el codigo postal");
                return;
            }
            if ((comboBoxPais.Text == null) || (comboBoxPais.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el pais");
                return;
            }
            if ((textBoxTelefono.Text == null) || (textBoxTelefono.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un telefono");
                return;
            }
            if ((textBoxFax.Text == null) || (textBoxFax.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el Fax");
                return;
            }
            if ((textBoxMail.Text == null) || (textBoxMail.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el mail");
                return;
            }
            cliente.nombreCompania = comboBoxNombreDeLaCompañia.Text;            
            cliente.nombreContacto = comboBoxNombreDelContacto.Text;

            cliente.cargoContacto = comboCargoDelContacto.Text;

            cliente.direccion = textBoxDireccion.Text;

            cliente.ciudad = comboBoxCiudad.Text;

            cliente.region = comboBoxRegion.Text;

            cliente.codigoPostal = textBoxCodigoPostal.Text;

            cliente.pais = comboBoxPais.Text;

            cliente.telefono = textBoxTelefono.Text;

            cliente.fax = textBoxFax.Text;

            cliente.mail = textBoxMail.Text;
            cliente.insertClient();
            mostrarProveedoresEnGrid(); 
        }

        private void dataGridAgregarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dataGridAgregarCliente.Rows[rowIndex];
            //Usuario
            /*
            idCliente
            nombreCompania
            nombreContacto
            cargoContacto
            direccion
            ciudad
            region
            codigoPostal
            pais
            telefono
            fax
            mail*/
            
            cliente.idCliente = dataGridAgregarCliente.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxNombreDeLaCompañia.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxNombreDelContacto.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[2].Value.ToString();
            comboCargoDelContacto.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxDireccion.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxCiudad.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[5].Value.ToString();
            comboBoxRegion.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[6].Value.ToString();
            textBoxCodigoPostal.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[7].Value.ToString();
            comboBoxPais.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[8].Value.ToString();
            textBoxTelefono.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[9].Value.ToString();
            textBoxFax.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[10].Value.ToString();
            textBoxMail.Text = dataGridAgregarCliente.Rows[rowIndex].Cells[11].Value.ToString();
        }

        private void dataGridProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dataGridProveedores.Rows[rowIndex];
            //Usuario
            /*
            idCliente
            nombreCompania
            nombreContacto
            cargoContacto
            direccion
            ciudad
            region
            codigoPostal
            pais
            telefono
            fax
            mail*/

            proveedor.idProveedor = int.Parse(dataGridProveedores.Rows[rowIndex].Cells[0].Value.ToString());
            comboBoxNombreDeCompañiaProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxNombreContactoProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxCargoContactoProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxDireccionProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxCiudadProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxMailProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[6].Value.ToString();
            comboBoxRegionProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[7].Value.ToString();
            textBoxCodigoPostalProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[8].Value.ToString();
            comboBoxPaisProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[9].Value.ToString();
            textBoxTelefonoProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[10].Value.ToString();
            textBoxFaxProveedor.Text = dataGridProveedores.Rows[rowIndex].Cells[11].Value.ToString();
            
            
        }

        private void botonBorrarCliente_Click(object sender, EventArgs e)
        {
            if ((cliente.idCliente == "") || (cliente.idCliente == null))
            {
                MessageBox.Show("Por favor selecciona un cliente"); 
                return;
            }

            
            cliente.deleteClient();
            mostrarClientesEnGrid(); 
        }

        private void botonEditarCliente_Click(object sender, EventArgs e)
        {
            if ((comboBoxNombreDeLaCompañia.Text == null) || (comboBoxNombreDeLaCompañia.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la compañia");
                return;
            }

            if ((comboBoxNombreDelContacto.Text == null) || (comboBoxNombreDelContacto.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el contacto");
                return;
            }

            if ((comboCargoDelContacto.Text == null) || (comboCargoDelContacto.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el cargo del contacto");
                return;
            }
            if ((textBoxDireccion.Text == null) || (textBoxDireccion.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la direccion");
                return;
            }
            if ((comboBoxCiudad.Text == null) || (comboBoxCiudad.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el Ciudad");
                return;
            }
            if ((comboBoxRegion.Text == null) || (comboBoxRegion.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la región");
                return;
            }
            if ((textBoxCodigoPostal.Text == null) || (textBoxCodigoPostal.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el codigo postal");
                return;
            }
            if ((comboBoxPais.Text == null) || (comboBoxPais.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el pais");
                return;
            }
            if ((textBoxTelefono.Text == null) || (textBoxTelefono.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un telefono");
                return;
            }
            if ((textBoxFax.Text == null) || (textBoxFax.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el Fax");
                return;
            }
            if ((textBoxMail.Text == null) || (textBoxMail.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el mail");
                return;
            }
            cliente.nombreCompania = comboBoxNombreDeLaCompañia.Text;
            cliente.nombreContacto = comboBoxNombreDelContacto.Text;

            cliente.cargoContacto = comboCargoDelContacto.Text;

            cliente.direccion = textBoxDireccion.Text;

            cliente.ciudad = comboBoxCiudad.Text;

            cliente.region = comboBoxRegion.Text;

            cliente.codigoPostal = textBoxCodigoPostal.Text;

            cliente.pais = comboBoxPais.Text;

            cliente.telefono = textBoxTelefono.Text;

            cliente.fax = textBoxFax.Text;

            cliente.mail = textBoxMail.Text;
            cliente.updateClient();
            mostrarClientesEnGrid();
        }

        private void tabPageAdministrarProveedores_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAgregarProveedor_Click(object sender, EventArgs e)
        {

            if ((comboBoxNombreDeCompañiaProveedor.Text == null) || (comboBoxNombreDeCompañiaProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la compañia");
                return;
            }

            if ((comboBoxNombreContactoProveedor.Text == null) || (comboBoxNombreContactoProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el contacto");
                return;
            }

            if ((comboBoxCargoContactoProveedor.Text == null) || (comboBoxCargoContactoProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el cargo del contacto");
                return;
            }

            if ((textBoxDireccionProveedor.Text == null) || (textBoxDireccionProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la direccion");
                return;
            }

            if ((comboBoxCiudadProveedor.Text == null) || (comboBoxCiudadProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el Ciudad");
                return;
            }


            if ((comboBoxRegionProveedor.Text == null) || (comboBoxRegionProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el contacto");
                return;
            }


            if ((textBoxCodigoPostalProveedor.Text == null) || (textBoxCodigoPostalProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la region");
                return;
            }


            if ((comboBoxPaisProveedor.Text == null) || (comboBoxPaisProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el pais");
                return;
            }

            if ((textBoxTelefonoProveedor.Text == null) || (textBoxTelefonoProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un telefono");
                return;
            }

            if ((textBoxFaxProveedor.Text == null) || (textBoxFaxProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el Fax");
                return;
            }

            if ((textBoxMailProveedor.Text == null) || (textBoxMailProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el mail");
                return;
            }
            proveedor.nombreProveedor = comboBoxNombreDeCompañiaProveedor.Text;
            proveedor.nombreContacto = comboBoxNombreContactoProveedor.Text;
            proveedor.cargoContacto = comboBoxCargoContactoProveedor.Text;
            proveedor.direccion = textBoxDireccionProveedor.Text;
            proveedor.ciudad = comboBoxCiudadProveedor.Text;
            proveedor.region = comboBoxRegionProveedor.Text;
            proveedor.codigoPostal = textBoxCodigoPostalProveedor.Text;
            proveedor.pais = comboBoxPaisProveedor.Text;
            proveedor.telefono = textBoxTelefonoProveedor.Text;
            proveedor.fax = textBoxFaxProveedor.Text;
            proveedor.mail = textBoxMailProveedor.Text;
            proveedor.insertSupplier();
            mostrarProveedoresEnGrid(); 

        }

        private void buttonEditarProveedor_Click(object sender, EventArgs e)
        {
            if ((comboBoxNombreDeCompañiaProveedor.Text == null) || (comboBoxNombreDeCompañiaProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la compañia");
                return;
            }

            if ((comboBoxNombreContactoProveedor.Text == null) || (comboBoxNombreContactoProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el contacto");
                return;
            }

            if ((comboBoxCargoContactoProveedor.Text == null) || (comboBoxCargoContactoProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el cargo del contacto");
                return;
            }

            if ((textBoxDireccionProveedor.Text == null) || (textBoxDireccionProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la direccion");
                return;
            }

            if ((comboBoxCiudadProveedor.Text == null) || (comboBoxCiudadProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el Ciudad");
                return;
            }


            if ((comboBoxRegionProveedor.Text == null) || (comboBoxRegionProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el contacto");
                return;
            }


            if ((textBoxCodigoPostalProveedor.Text == null) || (textBoxCodigoPostalProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para la region");
                return;
            }


            if ((comboBoxPaisProveedor.Text == null) || (comboBoxPaisProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el pais");
                return;
            }

            if ((textBoxTelefonoProveedor.Text == null) || (textBoxTelefonoProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un telefono");
                return;
            }

            if ((textBoxFaxProveedor.Text == null) || (textBoxFaxProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el Fax");
                return;
            }

            if ((textBoxMailProveedor.Text == null) || (textBoxMailProveedor.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el mail");
                return;
            }

            proveedor.nombreProveedor = comboBoxNombreDeCompañiaProveedor.Text;
            proveedor.nombreContacto = comboBoxNombreContactoProveedor.Text;
            proveedor.cargoContacto = comboBoxCargoContactoProveedor.Text;
            proveedor.direccion = textBoxDireccionProveedor.Text;
            proveedor.ciudad = comboBoxCiudadProveedor.Text;
            proveedor.region = comboBoxRegionProveedor.Text;
            proveedor.codigoPostal = textBoxCodigoPostalProveedor.Text;
            proveedor.pais = comboBoxPaisProveedor.Text;
            proveedor.telefono = textBoxTelefonoProveedor.Text;
            proveedor.fax = textBoxFaxProveedor.Text;
            proveedor.mail = textBoxMailProveedor.Text;
            proveedor.updateSupplier();
            mostrarProveedoresEnGrid(); 
        }

        private void buttonBorrarProveedor_Click(object sender, EventArgs e)
        {

            if ((proveedor.idProveedor == -1) || (proveedor.idProveedor == null))
            {
                MessageBox.Show("Por favor selecciona un cliente");
                return;
            }

            proveedor.deleteProveedor(); 
            mostrarProveedoresEnGrid(); 
            
        }

        private void buttonAgregarEmpleado_Click(object sender, EventArgs e)
        {   
            if ((textBoxNombreEmpleado.Text == null) || (textBoxNombreEmpleado.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el empleado");
                return;
            }
            
            if ((textBoxApellido.Text == null) || (textBoxApellido.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un apellido para el empleado");
                return;
            }
            
            if ((textBoxCargoEmpleado.Text == null) || (textBoxCargoEmpleado.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el cargo del empleado");
                return;
            }
            
            if ((comboBoxSexo.Text == null) || (comboBoxSexo.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un sexo para el empleado");
                return;
            }            
            
            if ((textBoxSalario.Text == null) || (textBoxSalario.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un salario para el empleado");
                return;
            }

            
            if ((dateTimePickerFechaIngreso.Text == null) || (dateTimePickerFechaIngreso.Text == ""))
            {
                MessageBox.Show("Por favor ingresa una fecha de ingreso para el empleado. ");
                return;
            }

            
            if ((textBoxTipoContrato.Text == null) || (textBoxTipoContrato.Text == ""))
            {
                MessageBox.Show("Por favor ingresa el tipo de contrato");
                return;
            }

            //empleado.idEmpleado = -1;
            try
            {
                empleado.nombre = textBoxNombreEmpleado.Text;
                empleado.apellido = textBoxApellido.Text;
                empleado.cargo = textBoxCargoEmpleado.Text;
                empleado.sexo = comboBoxSexo.Text;
                empleado.salario = Convert.ToInt32(textBoxSalario.Text);
                empleado.fechaDeIngreso = dateTimePickerFechaIngreso.Text;
                empleado.tipoDeContrato = textBoxTipoContrato.Text; 
            }
            catch
            {
                MessageBox.Show("Por favor revisa el formato de la entrada de datos. ");
                return; 
            }
            empleado.insertSupplier();
            mostrarEmpleadosEnGrid(); 
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMostrarEmpleados_Click(object sender, EventArgs e)
        {
         
        }

        private void clickCelda(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dataGridEmpleados.Rows[rowIndex];
            //Usuario
            /*
            idCliente
            nombreCompania
            nombreContacto
            cargoContacto
            direccion
            ciudad
            region
            codigoPostal
            pais
            telefono
            fax
            mail*/

            empleado.idEmpleado = Convert.ToInt32(dataGridEmpleados.Rows[rowIndex].Cells[0].Value.ToString());
            textBoxNombreEmpleado.Text = dataGridEmpleados.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxApellido.Text = dataGridEmpleados.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxCargoEmpleado.Text = dataGridEmpleados.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxSexo.Text = dataGridEmpleados.Rows[rowIndex].Cells[4].Value.ToString();
            textBoxSalario.Text = dataGridEmpleados.Rows[rowIndex].Cells[5].Value.ToString();
            dateTimePickerFechaIngreso.Text = dataGridEmpleados.Rows[rowIndex].Cells[6].Value.ToString();
            textBoxTipoContrato.Text = dataGridEmpleados.Rows[rowIndex].Cells[7].Value.ToString();

        }

        private void buttonEditarEmpleado_Click(object sender, EventArgs e)
        {

            if ((textBoxNombreEmpleado.Text == null) || (textBoxNombreEmpleado.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el empleado");
                return;
            }

            if ((textBoxApellido.Text == null) || (textBoxApellido.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un apellido para el empleado");
                return;
            }

            if ((textBoxCargoEmpleado.Text == null) || (textBoxCargoEmpleado.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un nombre para el cargo del empleado");
                return;
            }

            if ((comboBoxSexo.Text == null) || (comboBoxSexo.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un sexo para el empleado");
                return;
            }

            if ((textBoxSalario.Text == null) || (textBoxSalario.Text == ""))
            {
                MessageBox.Show("Por favor ingresa un salario para el empleado");
                return;
            }


            if ((dateTimePickerFechaIngreso.Text == null) || (dateTimePickerFechaIngreso.Text == ""))
            {
                MessageBox.Show("Por favor ingresa una fecha de ingreso para el empleado. ");
                return;
            }


            if ((textBoxTipoContrato.Text == null) || (textBoxTipoContrato.Text == ""))
            {
                MessageBox.Show("Por favor ingresa el tipo de contrato");
                return;
            }

            //empleado.idEmpleado = -1;
            try
            {
                empleado.nombre = textBoxNombreEmpleado.Text;
                empleado.apellido = textBoxApellido.Text;
                empleado.cargo = textBoxCargoEmpleado.Text;
                empleado.sexo = comboBoxSexo.Text;
                empleado.salario = Convert.ToInt32(textBoxSalario.Text);
                empleado.fechaDeIngreso = dateTimePickerFechaIngreso.Text;
                empleado.tipoDeContrato = textBoxTipoContrato.Text;
            }
            catch
            {
                MessageBox.Show("Por favor revisa el formato de la entrada de datos. ");
                return;
            }
            empleado.updateSupplier();
            mostrarEmpleadosEnGrid(); 
        }

        private void buttonEliminarEmpleado_Click(object sender, EventArgs e)
        {

            if ((empleado.idEmpleado == -1))
            {
                MessageBox.Show("Por favor selecciona un empleado");
                return;
            }
            empleado.deleteProveedor();
            mostrarEmpleadosEnGrid(); 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMenuGraficasClientes ventanaMenu = new formMenuGraficasClientes();
            ventanaMenu.Show(); 
        }

       
        
       
    }
}
