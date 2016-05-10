namespace erp
{
    partial class CRMformAnalisisGeografico
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonMostrarTabla = new System.Windows.Forms.Button();
            this.botonCiudadesConMayorConsumo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(953, 363);
            this.dataGridViewClientes.TabIndex = 1;
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Coahuila",
            "Colima",
            "Distrito Federal",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.comboBoxCiudad.Location = new System.Drawing.Point(63, 381);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(291, 21);
            this.comboBoxCiudad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ciudad";
            // 
            // botonMostrarTabla
            // 
            this.botonMostrarTabla.Location = new System.Drawing.Point(360, 381);
            this.botonMostrarTabla.Name = "botonMostrarTabla";
            this.botonMostrarTabla.Size = new System.Drawing.Size(141, 23);
            this.botonMostrarTabla.TabIndex = 4;
            this.botonMostrarTabla.Text = "Mostrar Tabla";
            this.botonMostrarTabla.UseVisualStyleBackColor = true;
            this.botonMostrarTabla.Click += new System.EventHandler(this.botonMostrarTabla_Click);
            // 
            // botonCiudadesConMayorConsumo
            // 
            this.botonCiudadesConMayorConsumo.Location = new System.Drawing.Point(519, 381);
            this.botonCiudadesConMayorConsumo.Name = "botonCiudadesConMayorConsumo";
            this.botonCiudadesConMayorConsumo.Size = new System.Drawing.Size(157, 23);
            this.botonCiudadesConMayorConsumo.TabIndex = 5;
            this.botonCiudadesConMayorConsumo.Text = "Ciudades con mayor consumo";
            this.botonCiudadesConMayorConsumo.UseVisualStyleBackColor = true;
            this.botonCiudadesConMayorConsumo.Click += new System.EventHandler(this.botonCiudadesConMayorConsumo_Click);
            // 
            // CRMformAnalisisGeografico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 416);
            this.Controls.Add(this.botonCiudadesConMayorConsumo);
            this.Controls.Add(this.botonMostrarTabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCiudad);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "CRMformAnalisisGeografico";
            this.Text = "formAnalisisGeografico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonMostrarTabla;
        private System.Windows.Forms.Button botonCiudadesConMayorConsumo;
    }
}