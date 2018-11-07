namespace ViewsApp
{
    partial class OperacionForm
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
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbByType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelProducto = new System.Windows.Forms.Button();
            this.btnAddProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.cmbStatusOp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalOperacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(609, 23);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(146, 24);
            this.dtFecha.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Fecha compra";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(625, 1025);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 66);
            this.btnAceptar.TabIndex = 60;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(485, 1025);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 66);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(8, 24);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(77, 18);
            this.lblType.TabIndex = 61;
            this.lblType.Text = "Proveedor";
            // 
            // cmbByType
            // 
            this.cmbByType.FormattingEnabled = true;
            this.cmbByType.Location = new System.Drawing.Point(98, 21);
            this.cmbByType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbByType.Name = "cmbByType";
            this.cmbByType.Size = new System.Drawing.Size(366, 26);
            this.cmbByType.TabIndex = 62;
            this.cmbByType.SelectedIndexChanged += new System.EventHandler(this.cmbByType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Producto/s";
            // 
            // btnDelProducto
            // 
            this.btnDelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProducto.Location = new System.Drawing.Point(98, 309);
            this.btnDelProducto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelProducto.Name = "btnDelProducto";
            this.btnDelProducto.Size = new System.Drawing.Size(71, 32);
            this.btnDelProducto.TabIndex = 66;
            this.btnDelProducto.Text = "Eliminar";
            this.btnDelProducto.UseVisualStyleBackColor = true;
            this.btnDelProducto.Click += new System.EventHandler(this.btnDelProducto_Click);
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducto.Location = new System.Drawing.Point(11, 309);
            this.btnAddProducto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.Size = new System.Drawing.Size(74, 32);
            this.btnAddProducto.TabIndex = 65;
            this.btnAddProducto.Text = "Agregar";
            this.btnAddProducto.UseVisualStyleBackColor = true;
            this.btnAddProducto.Click += new System.EventHandler(this.btnAddProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.Location = new System.Drawing.Point(11, 120);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(743, 178);
            this.dgvProductos.TabIndex = 64;
            // 
            // btnAcept
            // 
            this.btnAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcept.Location = new System.Drawing.Point(673, 352);
            this.btnAcept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(81, 34);
            this.btnAcept.TabIndex = 68;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(584, 352);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(98, 59);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(366, 24);
            this.txtReferencia.TabIndex = 70;
            // 
            // cmbStatusOp
            // 
            this.cmbStatusOp.FormattingEnabled = true;
            this.cmbStatusOp.Location = new System.Drawing.Point(100, 357);
            this.cmbStatusOp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbStatusOp.Name = "cmbStatusOp";
            this.cmbStatusOp.Size = new System.Drawing.Size(366, 26);
            this.cmbStatusOp.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "Estado";
            // 
            // lblTotalOperacion
            // 
            this.lblTotalOperacion.AutoSize = true;
            this.lblTotalOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOperacion.Location = new System.Drawing.Point(579, 311);
            this.lblTotalOperacion.Name = "lblTotalOperacion";
            this.lblTotalOperacion.Size = new System.Drawing.Size(66, 25);
            this.lblTotalOperacion.TabIndex = 75;
            this.lblTotalOperacion.Text = "Total:";
            // 
            // OperacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 397);
            this.Controls.Add(this.lblTotalOperacion);
            this.Controls.Add(this.cmbStatusOp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelProducto);
            this.Controls.Add(this.btnAddProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbByType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OperacionForm";
            this.Text = "OperacionForm";
            this.Load += new System.EventHandler(this.OperacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbByType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelProducto;
        private System.Windows.Forms.Button btnAddProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.ComboBox cmbStatusOp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalOperacion;
    }
}