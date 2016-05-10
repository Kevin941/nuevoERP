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
    public partial class formMenuPrincipal : Form
    {
        public formMenuPrincipal()
        {
            InitializeComponent();
        }

        private void botonIniciarErp_Click(object sender, EventArgs e)
        {
            formMenuPrincipalERP ventanaPrincipalERP = new formMenuPrincipalERP();
            ventanaPrincipalERP.Show(); 

        }

        private void botonIniciarCrm_Click(object sender, EventArgs e)
        {
            CRMformMenuPrincipalCRM ventanaCRM = new CRMformMenuPrincipalCRM();
            ventanaCRM.Show();


            //Módulo para mostrar los clientes frecuentes y los productos que obtienen. 
                //Mostrar vista v_clientesFrecuentes
                //Mostrar vista v_clientesMayoresCompras

            //Módulo para enviar promociones para ventas de mostrados según la posición de los clientes 
               ////Mostrar los clientes dentro de D.F para enviarles promociones de mostrador. --> select * from t_cliente where t_cliente.ciudad = 'Distrito Federal'; 

            //Módulo para generar campañas publicitarias según la posición de los clientes. 
                //Mostrar clientes según la región solicitada. --> select * from t_cliente where t_cliente.ciudad = 'combobox';
                 //Mostrar las regiones que consumen más productos --> mostrar vista v_ciudadesMayoresCompras
                //Mostrar un conteo de los clientes en función de las regiones--> |Region|Cantidad Clientes| --> mostrar vista  v_clientesPorCiudad
                
            //Módulo para mostrar una gráfica de los productos más vendidos 
                //Mostrar en una lista los productos más vendidos --> v_productosMasVendidos
                

            //Módulo para mostar los clientes con un periodo más largo sin realizar una compra. 
                //Mostrar cuanto tiempo llevan sin comprar los clientes. 

            //Módulo de administrar clientes 
        }
    }
}
