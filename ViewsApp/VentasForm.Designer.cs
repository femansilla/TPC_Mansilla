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
            this.txtTotLabel = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.lvProducts = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaActual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(920, 507);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 65);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(781, 507);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 65);
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
            this.dgvVentaActual.Location = new System.Drawing.Point(781, 16);
            this.dgvVentaActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVentaActual.MultiSelect = false;
            this.dgvVentaActual.Name = "dgvVentaActual";
            this.dgvVentaActual.ReadOnly = true;
            this.dgvVentaActual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvVentaActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentaActual.Size = new System.Drawing.Size(269, 450);
            this.dgvVentaActual.TabIndex = 5;
            // 
            // txtTotLabel
            // 
            this.txtTotLabel.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotLabel.Location = new System.Drawing.Point(781, 473);
            this.txtTotLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotLabel.Name = "txtTotLabel";
            this.txtTotLabel.Size = new System.Drawing.Size(65, 25);
            this.txtTotLabel.TabIndex = 6;
            this.txtTotLabel.Text = "TOTAL:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(856, 473);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 25);
            this.textBox2.TabIndex = 7;
            // 
            // flProducts
            // 
            this.flProducts.Location = new System.Drawing.Point(17, 17);
            this.flProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flProducts.Name = "flProducts";
            this.flProducts.Size = new System.Drawing.Size(756, 118);
            this.flProducts.TabIndex = 8;
            // 
            // lvProducts
            // 
            this.lvProducts.Location = new System.Drawing.Point(17, 191);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(755, 273);
            this.lvProducts.TabIndex = 9;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.flProducts);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTotLabel);
            this.Controls.Add(this.dgvVentaActual);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtTotLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FlowLayoutPanel flProducts;
        private System.Windows.Forms.ListView lvProducts;
    }
}