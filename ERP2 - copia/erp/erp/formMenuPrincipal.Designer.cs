namespace erp
{
    partial class formMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonIniciarCrm = new System.Windows.Forms.Button();
            this.botonIniciarErp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 411);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // botonIniciarCrm
            // 
            this.botonIniciarCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.botonIniciarCrm.Location = new System.Drawing.Point(445, 344);
            this.botonIniciarCrm.Name = "botonIniciarCrm";
            this.botonIniciarCrm.Size = new System.Drawing.Size(268, 42);
            this.botonIniciarCrm.TabIndex = 1;
            this.botonIniciarCrm.Text = "Iniciar CRM";
            this.botonIniciarCrm.UseVisualStyleBackColor = true;
            this.botonIniciarCrm.Click += new System.EventHandler(this.botonIniciarCrm_Click);
            // 
            // botonIniciarErp
            // 
            this.botonIniciarErp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.botonIniciarErp.Location = new System.Drawing.Point(130, 344);
            this.botonIniciarErp.Name = "botonIniciarErp";
            this.botonIniciarErp.Size = new System.Drawing.Size(268, 42);
            this.botonIniciarErp.TabIndex = 1;
            this.botonIniciarErp.Text = "Iniciar ERP";
            this.botonIniciarErp.UseVisualStyleBackColor = true;
            this.botonIniciarErp.Click += new System.EventHandler(this.botonIniciarErp_Click);
            // 
            // formMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.botonIniciarErp);
            this.Controls.Add(this.botonIniciarCrm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formMenuPrincipal";
            this.Text = "formMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonIniciarCrm;
        private System.Windows.Forms.Button botonIniciarErp;
    }
}