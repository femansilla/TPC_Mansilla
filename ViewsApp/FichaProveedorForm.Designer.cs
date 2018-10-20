namespace ViewsApp
{
    partial class FichaProveedorForm
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
            this.btnDelDomicilio = new System.Windows.Forms.Button();
            this.btnAddDomicilio = new System.Windows.Forms.Button();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.dgvDomicilios = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPerfilType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerCatalogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelDomicilio
            // 
            this.btnDelDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelDomicilio.Location = new System.Drawing.Point(113, 334);
            this.btnDelDomicilio.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelDomicilio.Name = "btnDelDomicilio";
            this.btnDelDomicilio.Size = new System.Drawing.Size(80, 34);
            this.btnDelDomicilio.TabIndex = 43;
            this.btnDelDomicilio.Text = "Eliminar";
            this.btnDelDomicilio.UseVisualStyleBackColor = true;
            this.btnDelDomicilio.Click += new System.EventHandler(this.btnDelDomicilio_Click);
            // 
            // btnAddDomicilio
            // 
            this.btnAddDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDomicilio.Location = new System.Drawing.Point(21, 334);
            this.btnAddDomicilio.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddDomicilio.Name = "btnAddDomicilio";
            this.btnAddDomicilio.Size = new System.Drawing.Size(82, 34);
            this.btnAddDomicilio.TabIndex = 42;
            this.btnAddDomicilio.Text = "Agregar";
            this.btnAddDomicilio.UseVisualStyleBackColor = true;
            this.btnAddDomicilio.Click += new System.EventHandler(this.btnAddDomicilio_Click);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(17, 193);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(70, 18);
            this.lblDomicilio.TabIndex = 41;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // dgvDomicilios
            // 
            this.dgvDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomicilios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDomicilios.Location = new System.Drawing.Point(19, 216);
            this.dgvDomicilios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvDomicilios.MultiSelect = false;
            this.dgvDomicilios.Name = "dgvDomicilios";
            this.dgvDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomicilios.Size = new System.Drawing.Size(521, 107);
            this.dgvDomicilios.TabIndex = 40;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(449, 442);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 48);
            this.btnAceptar.TabIndex = 39;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(347, 442);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 48);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaNac.Location = new System.Drawing.Point(160, 90);
            this.dtFechaNac.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(378, 24);
            this.dtFechaNac.TabIndex = 37;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUIT.Location = new System.Drawing.Point(163, 160);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(378, 24);
            this.txtCUIT.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Cuit/Cuil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Sexo";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(359, 126);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(92, 22);
            this.rdFemale.TabIndex = 33;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Femenino";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(161, 126);
            this.rdMale.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(94, 22);
            this.rdMale.TabIndex = 32;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Masculino";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tipo";
            // 
            // cmbPerfilType
            // 
            this.cmbPerfilType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfilType.FormattingEnabled = true;
            this.cmbPerfilType.Location = new System.Drawing.Point(163, 393);
            this.cmbPerfilType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbPerfilType.Name = "cmbPerfilType";
            this.cmbPerfilType.Size = new System.Drawing.Size(378, 26);
            this.cmbPerfilType.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha nacimiento";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(161, 50);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(378, 24);
            this.txtApellido.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(160, 14);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(378, 24);
            this.txtNombre.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre";
            // 
            // btnVerCatalogo
            // 
            this.btnVerCatalogo.Location = new System.Drawing.Point(397, 334);
            this.btnVerCatalogo.Name = "btnVerCatalogo";
            this.btnVerCatalogo.Size = new System.Drawing.Size(141, 34);
            this.btnVerCatalogo.TabIndex = 44;
            this.btnVerCatalogo.Text = "Catalogo";
            this.btnVerCatalogo.UseVisualStyleBackColor = true;
            this.btnVerCatalogo.Click += new System.EventHandler(this.btnVerCatalogo_Click);
            // 
            // FichaProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 502);
            this.Controls.Add(this.btnVerCatalogo);
            this.Controls.Add(this.btnDelDomicilio);
            this.Controls.Add(this.btnAddDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.dgvDomicilios);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtFechaNac);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPerfilType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FichaProveedorForm";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.FichaProveedorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelDomicilio;
        private System.Windows.Forms.Button btnAddDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.DataGridView dgvDomicilios;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPerfilType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerCatalogo;
    }
}