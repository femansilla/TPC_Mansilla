namespace ViewsApp
{
    partial class VentasForm
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvVentaActual = new System.Windows.Forms.DataGridView();
            this.lblTotalOperacion = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaActual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(970, 505);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 45);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(882, 505);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 45);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvVentaActual
            // 
            this.dgvVentaActual.AllowUserToAddRows = false;
            this.dgvVentaActual.AllowUserToDeleteRows = false;
            this.dgvVentaActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentaActual.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVentaActual.Location = new System.Drawing.Point(785, 13);
            this.dgvVentaActual.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentaActual.MultiSelect = false;
            this.dgvVentaActual.Name = "dgvVentaActual";
            this.dgvVentaActual.ReadOnly = true;
            this.dgvVentaActual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvVentaActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentaActual.Size = new System.Drawing.Size(269, 450);
            this.dgvVentaActual.TabIndex = 5;
            // 
            // lblTotalOperacion
            // 
            this.lblTotalOperacion.AutoSize = true;
            this.lblTotalOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOperacion.Location = new System.Drawing.Point(776, 470);
            this.lblTotalOperacion.Name = "lblTotalOperacion";
            this.lblTotalOperacion.Size = new System.Drawing.Size(66, 25);
            this.lblTotalOperacion.TabIndex = 76;
            this.lblTotalOperacion.Text = "Total:";
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(12, 13);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(751, 450);
            this.Products.TabIndex = 77;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.lblTotalOperacion);
            this.Controls.Add(this.dgvVentaActual);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentasForm";
            this.Text = "VentasForm";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvVentaActual;
        private System.Windows.Forms.Label lblTotalOperacion;
        private System.Windows.Forms.FlowLayoutPanel Products;
    }
}