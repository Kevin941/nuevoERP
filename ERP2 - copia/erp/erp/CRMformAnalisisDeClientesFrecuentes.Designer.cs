namespace erp
{
    partial class CRMformAnalisisDeClientesFrecuentes
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
            this.buttonBotonMayoresCompras = new System.Windows.Forms.Button();
            this.botonClientesFrecuentes = new System.Windows.Forms.Button();
            this.labelDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(953, 279);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // buttonBotonMayoresCompras
            // 
            this.buttonBotonMayoresCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonBotonMayoresCompras.Location = new System.Drawing.Point(12, 321);
            this.buttonBotonMayoresCompras.Name = "buttonBotonMayoresCompras";
            this.buttonBotonMayoresCompras.Size = new System.Drawing.Size(469, 38);
            this.buttonBotonMayoresCompras.TabIndex = 1;
            this.buttonBotonMayoresCompras.Text = "Clientes con mayores compras";
            this.buttonBotonMayoresCompras.UseVisualStyleBackColor = true;
            this.buttonBotonMayoresCompras.Click += new System.EventHandler(this.buttonBotonMayoresCompras_Click);
            // 
            // botonClientesFrecuentes
            // 
            this.botonClientesFrecuentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botonClientesFrecuentes.Location = new System.Drawing.Point(496, 321);
            this.botonClientesFrecuentes.Name = "botonClientesFrecuentes";
            this.botonClientesFrecuentes.Size = new System.Drawing.Size(469, 38);
            this.botonClientesFrecuentes.TabIndex = 1;
            this.botonClientesFrecuentes.Text = "Clientes Frecuentes";
            this.botonClientesFrecuentes.UseVisualStyleBackColor = true;
            this.botonClientesFrecuentes.Click += new System.EventHandler(this.botonClientesFrecuentes_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(12, 20);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(0, 13);
            this.labelDescripcion.TabIndex = 2;
            // 
            // formAnalisisDeClientesFrecuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 371);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.botonClientesFrecuentes);
            this.Controls.Add(this.buttonBotonMayoresCompras);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "formAnalisisDeClientesFrecuentes";
            this.Text = "formAnalisisDeClientesFrecuentes";
            this.Load += new System.EventHandler(this.formAnalisisDeClientesFrecuentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button buttonBotonMayoresCompras;
        private System.Windows.Forms.Button botonClientesFrecuentes;
        private System.Windows.Forms.Label labelDescripcion;
    }
}