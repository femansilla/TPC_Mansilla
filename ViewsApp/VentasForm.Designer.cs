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
            this.btnAgregarPrdADgv = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbProductTypeFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelFilterType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaActual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1152, 516);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 33);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1064, 516);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 33);
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
            this.dgvVentaActual.Location = new System.Drawing.Point(803, 13);
            this.dgvVentaActual.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentaActual.MultiSelect = false;
            this.dgvVentaActual.Name = "dgvVentaActual";
            this.dgvVentaActual.ReadOnly = true;
            this.dgvVentaActual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvVentaActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentaActual.Size = new System.Drawing.Size(434, 450);
            this.dgvVentaActual.TabIndex = 5;
            this.dgvVentaActual.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentaActual_CellDoubleClick);
            // 
            // lblTotalOperacion
            // 
            this.lblTotalOperacion.AutoSize = true;
            this.lblTotalOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOperacion.Location = new System.Drawing.Point(811, 469);
            this.lblTotalOperacion.Name = "lblTotalOperacion";
            this.lblTotalOperacion.Size = new System.Drawing.Size(66, 25);
            this.lblTotalOperacion.TabIndex = 76;
            this.lblTotalOperacion.Text = "Total:";
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(12, 13);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(784, 450);
            this.Products.TabIndex = 77;
            // 
            // btnAgregarPrdADgv
            // 
            this.btnAgregarPrdADgv.Location = new System.Drawing.Point(713, 467);
            this.btnAgregarPrdADgv.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPrdADgv.Name = "btnAgregarPrdADgv";
            this.btnAgregarPrdADgv.Size = new System.Drawing.Size(85, 33);
            this.btnAgregarPrdADgv.TabIndex = 78;
            this.btnAgregarPrdADgv.Text = "Agregar";
            this.btnAgregarPrdADgv.UseVisualStyleBackColor = true;
            this.btnAgregarPrdADgv.Click += new System.EventHandler(this.btnAgregarPrdADgv_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(606, 472);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 25);
            this.txtCantidad.TabIndex = 79;
            this.txtCantidad.Text = "Cantidad...";
            this.txtCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCantidad_MouseClick);
            // 
            // cmbProductTypeFilter
            // 
            this.cmbProductTypeFilter.FormattingEnabled = true;
            this.cmbProductTypeFilter.Location = new System.Drawing.Point(53, 472);
            this.cmbProductTypeFilter.Name = "cmbProductTypeFilter";
            this.cmbProductTypeFilter.Size = new System.Drawing.Size(183, 25);
            this.cmbProductTypeFilter.TabIndex = 80;
            this.cmbProductTypeFilter.SelectedValueChanged += new System.EventHandler(this.cmbProductTypeFilter_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "Tipo";
            // 
            // btnDelFilterType
            // 
            this.btnDelFilterType.Location = new System.Drawing.Point(243, 467);
            this.btnDelFilterType.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelFilterType.Name = "btnDelFilterType";
            this.btnDelFilterType.Size = new System.Drawing.Size(102, 33);
            this.btnDelFilterType.TabIndex = 82;
            this.btnDelFilterType.Text = "Borrar filttro";
            this.btnDelFilterType.UseVisualStyleBackColor = true;
            this.btnDelFilterType.Click += new System.EventHandler(this.btnDelFilterType_Click);
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 562);
            this.Controls.Add(this.btnDelFilterType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProductTypeFilter);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregarPrdADgv);
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
        private System.Windows.Forms.Button btnAgregarPrdADgv;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbProductTypeFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelFilterType;
    }
}