namespace erp
{
    partial class formAnalisisGrafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartEjemplo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.comboBoxGraficaAmostrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartEjemplo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEjemplo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEjemplo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEjemplo.Legends.Add(legend1);
            this.chartEjemplo.Location = new System.Drawing.Point(368, 41);
            this.chartEjemplo.Name = "chartEjemplo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "miSerie";
            this.chartEjemplo.Series.Add(series1);
            this.chartEjemplo.Size = new System.Drawing.Size(936, 538);
            this.chartEjemplo.TabIndex = 0;
            this.chartEjemplo.Text = "chart1";
            // 
            // dataGridViewQuery
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewQuery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuery.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewQuery.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuery.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewQuery.RowHeadersVisible = false;
            this.dataGridViewQuery.Size = new System.Drawing.Size(350, 538);
            this.dataGridViewQuery.TabIndex = 2;
            // 
            // comboBoxGraficaAmostrar
            // 
            this.comboBoxGraficaAmostrar.FormattingEnabled = true;
            this.comboBoxGraficaAmostrar.Items.AddRange(new object[] {
            "Empleados por sexo",
            "Empleados por cargo",
            "Productos en existencia",
            "Productos mas vendidos",
            "Ciudades con más compras",
            "Ciudades con mayores compras",
            "Clientes por ciudad",
            "Clientes por puesto (cargo)",
            "Clientes con mayores compras",
            "Clientes mas frecuentes"});
            this.comboBoxGraficaAmostrar.Location = new System.Drawing.Point(12, 12);
            this.comboBoxGraficaAmostrar.Name = "comboBoxGraficaAmostrar";
            this.comboBoxGraficaAmostrar.Size = new System.Drawing.Size(388, 21);
            this.comboBoxGraficaAmostrar.TabIndex = 3;
            this.comboBoxGraficaAmostrar.SelectedIndexChanged += new System.EventHandler(this.comboBoxGraficaAmostrar_SelectedIndexChanged);
            // 
            // formAnalisisGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1056, 506);
            this.Controls.Add(this.comboBoxGraficaAmostrar);
            this.Controls.Add(this.dataGridViewQuery);
            this.Controls.Add(this.chartEjemplo);
            this.Name = "formAnalisisGrafico";
            this.Text = "Modulo de análisis gráfico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.grafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEjemplo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEjemplo;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.ComboBox comboBoxGraficaAmostrar;
    }
}