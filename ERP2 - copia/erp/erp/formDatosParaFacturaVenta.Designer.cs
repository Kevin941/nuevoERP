﻿namespace erp
{
    partial class formDatosParaFacturaVenta
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
            this.botonBuscarCliente = new System.Windows.Forms.Button();
            this.botonAgregarNuevoCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.groupBoxDatosReceptor = new System.Windows.Forms.GroupBox();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botonRealizarFactura = new System.Windows.Forms.Button();
            this.groupBoxDatosReceptor.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonBuscarCliente
            // 
            this.botonBuscarCliente.Location = new System.Drawing.Point(12, 286);
            this.botonBuscarCliente.Name = "botonBuscarCliente";
            this.botonBuscarCliente.Size = new System.Drawing.Size(122, 23);
            this.botonBuscarCliente.TabIndex = 0;
            this.botonBuscarCliente.Text = "Buscar Cliente";
            this.botonBuscarCliente.UseVisualStyleBackColor = true;
            this.botonBuscarCliente.Click += new System.EventHandler(this.botonBuscarCliente_Click);
            // 
            // botonAgregarNuevoCliente
            // 
            this.botonAgregarNuevoCliente.Location = new System.Drawing.Point(12, 317);
            this.botonAgregarNuevoCliente.Name = "botonAgregarNuevoCliente";
            this.botonAgregarNuevoCliente.Size = new System.Drawing.Size(301, 23);
            this.botonAgregarNuevoCliente.TabIndex = 1;
            this.botonAgregarNuevoCliente.Text = "Agregar un nuevo cliente";
            this.botonAgregarNuevoCliente.UseVisualStyleBackColor = true;
            this.botonAgregarNuevoCliente.Click += new System.EventHandler(this.botonAgregarNuevoCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Region";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Codigo Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pais ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mail";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(115, 22);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(186, 20);
            this.textBoxCliente.TabIndex = 3;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.textBoxDireccion.Location = new System.Drawing.Point(115, 48);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(186, 20);
            this.textBoxDireccion.TabIndex = 3;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(115, 72);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(186, 20);
            this.textBoxCiudad.TabIndex = 3;
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(115, 98);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(186, 20);
            this.textBoxRegion.TabIndex = 3;
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(115, 124);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(186, 20);
            this.textBoxCodigoPostal.TabIndex = 3;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(115, 150);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(186, 20);
            this.textBoxPais.TabIndex = 3;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(115, 176);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(186, 20);
            this.textBoxTelefono.TabIndex = 3;
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(115, 202);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(186, 20);
            this.textBoxFax.TabIndex = 3;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(115, 228);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(186, 20);
            this.textBoxMail.TabIndex = 3;
            // 
            // groupBoxDatosReceptor
            // 
            this.groupBoxDatosReceptor.Controls.Add(this.label1);
            this.groupBoxDatosReceptor.Controls.Add(this.textBoxMail);
            this.groupBoxDatosReceptor.Controls.Add(this.label2);
            this.groupBoxDatosReceptor.Controls.Add(this.textBoxFax);
            this.groupBoxDatosReceptor.Controls.Add(this.label3);
            this.groupBoxDatosReceptor.Controls.Add(this.textBoxTelefono);
            this.groupBoxDatosReceptor.Controls.Add(this.label4);
            this.groupBoxDatosReceptor.Controls.Add(this.textBoxPais);
            this.groupBoxDatosReceptor.Controls.Add(this.label5);
            this.groupBoxDatosReceptor.Controls.Add(this.textBoxCodigoPostal);
            this.groupBoxDatosReceptor.Controls.Add(this.label6);
            this.groupBoxDatosReceptor.Controls.Add(this.textBoxRegion);
            this.groupBoxDatosReceptor.Controls.Add(this.label7);
            this.groupBoxDatosReceptor.Controls.Add(this.textBoxCiudad);
            this.groupBoxDatosReceptor.Controls.Add(this.label8);
            this.groupBoxDatosReceptor.Controls.Add(this.textBoxDireccion);
            this.groupBoxDatosReceptor.Controls.Add(this.label9);
            this.groupBoxDatosReceptor.Controls.Add(this.textBoxCliente);
            this.groupBoxDatosReceptor.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatosReceptor.Name = "groupBoxDatosReceptor";
            this.groupBoxDatosReceptor.Size = new System.Drawing.Size(337, 263);
            this.groupBoxDatosReceptor.TabIndex = 4;
            this.groupBoxDatosReceptor.TabStop = false;
            this.groupBoxDatosReceptor.Text = "Datos del receptor";
            this.groupBoxDatosReceptor.Enter += new System.EventHandler(this.groupBoxDatosReceptor_Enter);
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(213, 284);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCliente.TabIndex = 5;
            this.textBoxIdCliente.TextChanged += new System.EventHandler(this.textBoxIdCliente_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Id Cliente";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // botonRealizarFactura
            // 
            this.botonRealizarFactura.Location = new System.Drawing.Point(12, 346);
            this.botonRealizarFactura.Name = "botonRealizarFactura";
            this.botonRealizarFactura.Size = new System.Drawing.Size(301, 23);
            this.botonRealizarFactura.TabIndex = 7;
            this.botonRealizarFactura.Text = "Realizar factura";
            this.botonRealizarFactura.UseVisualStyleBackColor = true;
            this.botonRealizarFactura.Click += new System.EventHandler(this.botonRealizarFactura_Click);
            // 
            // formDatosParaFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 380);
            this.Controls.Add(this.botonRealizarFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxIdCliente);
            this.Controls.Add(this.groupBoxDatosReceptor);
            this.Controls.Add(this.botonAgregarNuevoCliente);
            this.Controls.Add(this.botonBuscarCliente);
            this.Name = "formDatosParaFacturaVenta";
            this.Text = "formDatosParaFactura";
            this.Load += new System.EventHandler(this.formDatosParaFactura_Load);
            this.groupBoxDatosReceptor.ResumeLayout(false);
            this.groupBoxDatosReceptor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBuscarCliente;
        private System.Windows.Forms.Button botonAgregarNuevoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.GroupBox groupBoxDatosReceptor;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonRealizarFactura;
    }
}