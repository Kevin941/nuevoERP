namespace erp
{
    partial class grafica
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
            this.chartEjemplo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartEjemplo)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEjemplo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEjemplo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEjemplo.Legends.Add(legend1);
            this.chartEjemplo.Location = new System.Drawing.Point(51, 91);
            this.chartEjemplo.Name = "chartEjemplo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "miSerie";
            this.chartEjemplo.Series.Add(series1);
            this.chartEjemplo.Size = new System.Drawing.Size(300, 300);
            this.chartEjemplo.TabIndex = 0;
            this.chartEjemplo.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartEjemplo);
            this.Name = "grafica";
            this.Text = "grafica";
            this.Load += new System.EventHandler(this.grafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEjemplo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEjemplo;
        private System.Windows.Forms.Button button1;
    }
}