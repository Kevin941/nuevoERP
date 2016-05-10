namespace erp
{
    partial class formCompraDeProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFormaDeEnvio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFechaDePedido = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaDePago = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaDeEntrega = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaDeEnvio = new System.Windows.Forms.DateTimePicker();
            this.botonRealizarFactura = new System.Windows.Forms.Button();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosDelProducto = new System.Windows.Forms.GroupBox();
            this.dateTimeFechaDeCaducidad = new System.Windows.Forms.DateTimePicker();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxLote = new System.Windows.Forms.TextBox();
            this.textBoxExistencia = new System.Windows.Forms.TextBox();
            this.botonAgregarProductoAFactura = new System.Windows.Forms.Button();
            this.textBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.textBoxCodigoDelProducto = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionDelProducto = new System.Windows.Forms.TextBox();
            this.labelCodigoDelProducto = new System.Windows.Forms.Label();
            this.botonBuscarProducto = new System.Windows.Forms.Button();
            this.textBoxClaveDeProducto = new System.Windows.Forms.TextBox();
            this.labelClaveDelProducto = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrecioUnitario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelFechaDeCaducidad = new System.Windows.Forms.Label();
            this.labelExistencia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.groupBoxDatosDelProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFormaDeEnvio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimeFechaDePedido);
            this.groupBox1.Controls.Add(this.dateTimeFechaDePago);
            this.groupBox1.Controls.Add(this.dateTimeFechaDeEntrega);
            this.groupBox1.Controls.Add(this.dateTimeFechaDeEnvio);
            this.groupBox1.Controls.Add(this.botonRealizarFactura);
            this.groupBox1.Location = new System.Drawing.Point(479, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 170);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Envío";
            // 
            // comboBoxFormaDeEnvio
            // 
            this.comboBoxFormaDeEnvio.FormattingEnabled = true;
            this.comboBoxFormaDeEnvio.Items.AddRange(new object[] {
            "A domicilio",
            "En mostrador"});
            this.comboBoxFormaDeEnvio.Location = new System.Drawing.Point(153, 79);
            this.comboBoxFormaDeEnvio.Name = "comboBoxFormaDeEnvio";
            this.comboBoxFormaDeEnvio.Size = new System.Drawing.Size(195, 21);
            this.comboBoxFormaDeEnvio.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Forma de Envío";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de envío";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha de entrega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha de pedido";
            // 
            // dateTimeFechaDePedido
            // 
            this.dateTimeFechaDePedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDePedido.Location = new System.Drawing.Point(153, 28);
            this.dateTimeFechaDePedido.Name = "dateTimeFechaDePedido";
            this.dateTimeFechaDePedido.Size = new System.Drawing.Size(195, 20);
            this.dateTimeFechaDePedido.TabIndex = 12;
            // 
            // dateTimeFechaDePago
            // 
            this.dateTimeFechaDePago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDePago.Location = new System.Drawing.Point(451, 53);
            this.dateTimeFechaDePago.Name = "dateTimeFechaDePago";
            this.dateTimeFechaDePago.Size = new System.Drawing.Size(195, 20);
            this.dateTimeFechaDePago.TabIndex = 12;
            // 
            // dateTimeFechaDeEntrega
            // 
            this.dateTimeFechaDeEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDeEntrega.Location = new System.Drawing.Point(153, 54);
            this.dateTimeFechaDeEntrega.Name = "dateTimeFechaDeEntrega";
            this.dateTimeFechaDeEntrega.Size = new System.Drawing.Size(195, 20);
            this.dateTimeFechaDeEntrega.TabIndex = 12;
            // 
            // dateTimeFechaDeEnvio
            // 
            this.dateTimeFechaDeEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDeEnvio.Location = new System.Drawing.Point(451, 27);
            this.dateTimeFechaDeEnvio.Name = "dateTimeFechaDeEnvio";
            this.dateTimeFechaDeEnvio.Size = new System.Drawing.Size(195, 20);
            this.dateTimeFechaDeEnvio.TabIndex = 12;
            // 
            // botonRealizarFactura
            // 
            this.botonRealizarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.botonRealizarFactura.Location = new System.Drawing.Point(31, 120);
            this.botonRealizarFactura.Name = "botonRealizarFactura";
            this.botonRealizarFactura.Size = new System.Drawing.Size(615, 35);
            this.botonRealizarFactura.TabIndex = 6;
            this.botonRealizarFactura.Text = "Continuar";
            this.botonRealizarFactura.UseVisualStyleBackColor = true;
            this.botonRealizarFactura.Click += new System.EventHandler(this.botonRealizarFactura_Click);
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(479, 21);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.Size = new System.Drawing.Size(660, 216);
            this.dataGridProductos.TabIndex = 9;
            // 
            // groupBoxDatosDelProducto
            // 
            this.groupBoxDatosDelProducto.Controls.Add(this.dateTimeFechaDeCaducidad);
            this.groupBoxDatosDelProducto.Controls.Add(this.textBoxCantidad);
            this.groupBoxDatosDelProducto.Controls.Add(this.textBoxLote);
            this.groupBoxDatosDelProducto.Controls.Add(this.textBoxExistencia);
            this.groupBoxDatosDelProducto.Controls.Add(this.botonAgregarProductoAFactura);
            this.groupBoxDatosDelProducto.Controls.Add(this.textBoxPrecioUnitario);
            this.groupBoxDatosDelProducto.Controls.Add(this.textBoxCodigoDelProducto);
            this.groupBoxDatosDelProducto.Controls.Add(this.textBoxDescripcionDelProducto);
            this.groupBoxDatosDelProducto.Controls.Add(this.labelCodigoDelProducto);
            this.groupBoxDatosDelProducto.Controls.Add(this.botonBuscarProducto);
            this.groupBoxDatosDelProducto.Controls.Add(this.textBoxClaveDeProducto);
            this.groupBoxDatosDelProducto.Controls.Add(this.labelClaveDelProducto);
            this.groupBoxDatosDelProducto.Controls.Add(this.labelDescripcion);
            this.groupBoxDatosDelProducto.Controls.Add(this.labelPrecioUnitario);
            this.groupBoxDatosDelProducto.Controls.Add(this.label1);
            this.groupBoxDatosDelProducto.Controls.Add(this.labelOutput);
            this.groupBoxDatosDelProducto.Controls.Add(this.labelFechaDeCaducidad);
            this.groupBoxDatosDelProducto.Controls.Add(this.labelExistencia);
            this.groupBoxDatosDelProducto.Location = new System.Drawing.Point(15, 10);
            this.groupBoxDatosDelProducto.Name = "groupBoxDatosDelProducto";
            this.groupBoxDatosDelProducto.Size = new System.Drawing.Size(407, 403);
            this.groupBoxDatosDelProducto.TabIndex = 8;
            this.groupBoxDatosDelProducto.TabStop = false;
            this.groupBoxDatosDelProducto.Text = "Datos del producto";
            // 
            // dateTimeFechaDeCaducidad
            // 
            this.dateTimeFechaDeCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDeCaducidad.Location = new System.Drawing.Point(137, 159);
            this.dateTimeFechaDeCaducidad.Name = "dateTimeFechaDeCaducidad";
            this.dateTimeFechaDeCaducidad.Size = new System.Drawing.Size(195, 20);
            this.dateTimeFechaDeCaducidad.TabIndex = 12;
            this.dateTimeFechaDeCaducidad.Value = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(137, 211);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(195, 20);
            this.textBoxCantidad.TabIndex = 11;
            // 
            // textBoxLote
            // 
            this.textBoxLote.Location = new System.Drawing.Point(137, 185);
            this.textBoxLote.Name = "textBoxLote";
            this.textBoxLote.Size = new System.Drawing.Size(195, 20);
            this.textBoxLote.TabIndex = 11;
            // 
            // textBoxExistencia
            // 
            this.textBoxExistencia.Location = new System.Drawing.Point(137, 134);
            this.textBoxExistencia.Name = "textBoxExistencia";
            this.textBoxExistencia.Size = new System.Drawing.Size(195, 20);
            this.textBoxExistencia.TabIndex = 11;
            // 
            // botonAgregarProductoAFactura
            // 
            this.botonAgregarProductoAFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.botonAgregarProductoAFactura.Location = new System.Drawing.Point(9, 353);
            this.botonAgregarProductoAFactura.Name = "botonAgregarProductoAFactura";
            this.botonAgregarProductoAFactura.Size = new System.Drawing.Size(392, 44);
            this.botonAgregarProductoAFactura.TabIndex = 9;
            this.botonAgregarProductoAFactura.Text = "Agregar producto al pedido";
            this.botonAgregarProductoAFactura.UseVisualStyleBackColor = true;
            this.botonAgregarProductoAFactura.Click += new System.EventHandler(this.botonAgregarProductoAFactura_Click);
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(137, 108);
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(195, 20);
            this.textBoxPrecioUnitario.TabIndex = 10;
            // 
            // textBoxCodigoDelProducto
            // 
            this.textBoxCodigoDelProducto.Location = new System.Drawing.Point(137, 82);
            this.textBoxCodigoDelProducto.Name = "textBoxCodigoDelProducto";
            this.textBoxCodigoDelProducto.Size = new System.Drawing.Size(195, 20);
            this.textBoxCodigoDelProducto.TabIndex = 10;
            // 
            // textBoxDescripcionDelProducto
            // 
            this.textBoxDescripcionDelProducto.Location = new System.Drawing.Point(137, 56);
            this.textBoxDescripcionDelProducto.Name = "textBoxDescripcionDelProducto";
            this.textBoxDescripcionDelProducto.Size = new System.Drawing.Size(195, 20);
            this.textBoxDescripcionDelProducto.TabIndex = 10;
            // 
            // labelCodigoDelProducto
            // 
            this.labelCodigoDelProducto.AutoSize = true;
            this.labelCodigoDelProducto.Location = new System.Drawing.Point(6, 89);
            this.labelCodigoDelProducto.Name = "labelCodigoDelProducto";
            this.labelCodigoDelProducto.Size = new System.Drawing.Size(102, 13);
            this.labelCodigoDelProducto.TabIndex = 6;
            this.labelCodigoDelProducto.Text = "Código del producto";
            // 
            // botonBuscarProducto
            // 
            this.botonBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.botonBuscarProducto.Location = new System.Drawing.Point(9, 303);
            this.botonBuscarProducto.Name = "botonBuscarProducto";
            this.botonBuscarProducto.Size = new System.Drawing.Size(392, 44);
            this.botonBuscarProducto.TabIndex = 5;
            this.botonBuscarProducto.Text = "Buscar Producto";
            this.botonBuscarProducto.UseVisualStyleBackColor = true;
            this.botonBuscarProducto.Click += new System.EventHandler(this.botonBuscarProducto_Click);
            // 
            // textBoxClaveDeProducto
            // 
            this.textBoxClaveDeProducto.Location = new System.Drawing.Point(137, 30);
            this.textBoxClaveDeProducto.Name = "textBoxClaveDeProducto";
            this.textBoxClaveDeProducto.Size = new System.Drawing.Size(195, 20);
            this.textBoxClaveDeProducto.TabIndex = 0;
            // 
            // labelClaveDelProducto
            // 
            this.labelClaveDelProducto.AutoSize = true;
            this.labelClaveDelProducto.Location = new System.Drawing.Point(6, 37);
            this.labelClaveDelProducto.Name = "labelClaveDelProducto";
            this.labelClaveDelProducto.Size = new System.Drawing.Size(96, 13);
            this.labelClaveDelProducto.TabIndex = 1;
            this.labelClaveDelProducto.Text = "Clave del producto";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(6, 63);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(125, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripción del producto";
            this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPrecioUnitario
            // 
            this.labelPrecioUnitario.AutoSize = true;
            this.labelPrecioUnitario.Location = new System.Drawing.Point(6, 115);
            this.labelPrecioUnitario.Name = "labelPrecioUnitario";
            this.labelPrecioUnitario.Size = new System.Drawing.Size(74, 13);
            this.labelPrecioUnitario.TabIndex = 2;
            this.labelPrecioUnitario.Text = "Precio unitario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad a pedir";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(6, 192);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(28, 13);
            this.labelOutput.TabIndex = 2;
            this.labelOutput.Text = "Lote";
            // 
            // labelFechaDeCaducidad
            // 
            this.labelFechaDeCaducidad.AutoSize = true;
            this.labelFechaDeCaducidad.Location = new System.Drawing.Point(6, 167);
            this.labelFechaDeCaducidad.Name = "labelFechaDeCaducidad";
            this.labelFechaDeCaducidad.Size = new System.Drawing.Size(106, 13);
            this.labelFechaDeCaducidad.TabIndex = 2;
            this.labelFechaDeCaducidad.Text = "Fecha de Caducidad";
            // 
            // labelExistencia
            // 
            this.labelExistencia.AutoSize = true;
            this.labelExistencia.Location = new System.Drawing.Point(6, 141);
            this.labelExistencia.Name = "labelExistencia";
            this.labelExistencia.Size = new System.Drawing.Size(55, 13);
            this.labelExistencia.TabIndex = 2;
            this.labelExistencia.Text = "Existencia";
            // 
            // formCompraDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.groupBoxDatosDelProducto);
            this.Name = "formCompraDeProductos";
            this.Text = "formCompraDeProductos";
            this.Load += new System.EventHandler(this.formCompraDeProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.groupBoxDatosDelProducto.ResumeLayout(false);
            this.groupBoxDatosDelProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFormaDeEnvio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDePedido;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDePago;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeEntrega;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeEnvio;
        private System.Windows.Forms.Button botonRealizarFactura;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.GroupBox groupBoxDatosDelProducto;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeCaducidad;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxLote;
        private System.Windows.Forms.TextBox textBoxExistencia;
        private System.Windows.Forms.Button botonAgregarProductoAFactura;
        private System.Windows.Forms.TextBox textBoxPrecioUnitario;
        private System.Windows.Forms.TextBox textBoxCodigoDelProducto;
        private System.Windows.Forms.TextBox textBoxDescripcionDelProducto;
        private System.Windows.Forms.Label labelCodigoDelProducto;
        private System.Windows.Forms.Button botonBuscarProducto;
        private System.Windows.Forms.TextBox textBoxClaveDeProducto;
        private System.Windows.Forms.Label labelClaveDelProducto;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrecioUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelFechaDeCaducidad;
        private System.Windows.Forms.Label labelExistencia;
    }
}