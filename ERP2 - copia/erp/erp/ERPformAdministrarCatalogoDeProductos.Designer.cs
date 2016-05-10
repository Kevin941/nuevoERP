namespace erp
{
    partial class ERPformAdministrarCatalogoDeProductos
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
            this.dataGridProductosDeCatalogo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodigoDelProducto = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxExistencia = new System.Windows.Forms.TextBox();
            this.textBoxLote = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.dateTimeFechaDeCaducidad = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductosDeCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProductosDeCatalogo
            // 
            this.dataGridProductosDeCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductosDeCatalogo.Location = new System.Drawing.Point(12, 22);
            this.dataGridProductosDeCatalogo.Name = "dataGridProductosDeCatalogo";
            this.dataGridProductosDeCatalogo.Size = new System.Drawing.Size(747, 200);
            this.dataGridProductosDeCatalogo.TabIndex = 0;
            this.dataGridProductosDeCatalogo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductosDeCatalogo_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Existencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de caducidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lote";
            // 
            // textBoxCodigoDelProducto
            // 
            this.textBoxCodigoDelProducto.Location = new System.Drawing.Point(91, 228);
            this.textBoxCodigoDelProducto.Name = "textBoxCodigoDelProducto";
            this.textBoxCodigoDelProducto.Size = new System.Drawing.Size(165, 20);
            this.textBoxCodigoDelProducto.TabIndex = 8;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(91, 254);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(165, 20);
            this.textBoxDescripcion.TabIndex = 9;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(336, 231);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(165, 20);
            this.textBoxPrecio.TabIndex = 10;
            // 
            // textBoxExistencia
            // 
            this.textBoxExistencia.Location = new System.Drawing.Point(336, 257);
            this.textBoxExistencia.Name = "textBoxExistencia";
            this.textBoxExistencia.Size = new System.Drawing.Size(165, 20);
            this.textBoxExistencia.TabIndex = 11;
            // 
            // textBoxLote
            // 
            this.textBoxLote.Location = new System.Drawing.Point(618, 254);
            this.textBoxLote.Name = "textBoxLote";
            this.textBoxLote.Size = new System.Drawing.Size(141, 20);
            this.textBoxLote.TabIndex = 13;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(25, 288);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(231, 23);
            this.botonAgregar.TabIndex = 14;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(270, 288);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(231, 23);
            this.botonEliminar.TabIndex = 15;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(510, 288);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(249, 23);
            this.botonEditar.TabIndex = 16;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // dateTimeFechaDeCaducidad
            // 
            this.dateTimeFechaDeCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDeCaducidad.Location = new System.Drawing.Point(618, 228);
            this.dateTimeFechaDeCaducidad.Name = "dateTimeFechaDeCaducidad";
            this.dateTimeFechaDeCaducidad.Size = new System.Drawing.Size(141, 20);
            this.dateTimeFechaDeCaducidad.TabIndex = 17;
            // 
            // formAdministrarCatalogoDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 323);
            this.Controls.Add(this.dateTimeFechaDeCaducidad);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.textBoxLote);
            this.Controls.Add(this.textBoxExistencia);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxCodigoDelProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProductosDeCatalogo);
            this.Name = "formAdministrarCatalogoDeProductos";
            this.Text = "formAgregarProductoAlCatalogo";
            this.Load += new System.EventHandler(this.formAgregarProductoAlCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductosDeCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProductosDeCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodigoDelProducto;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxExistencia;
        private System.Windows.Forms.TextBox textBoxLote;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeCaducidad;
    }
}