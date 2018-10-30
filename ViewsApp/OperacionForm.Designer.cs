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
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelDomicilio = new System.Windows.Forms.Button();
            this.btnAddDomicilio = new System.Windows.Forms.Button();
            this.dgvDomicilios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNac.Location = new System.Drawing.Point(609, 16);
            this.dtFechaNac.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(146, 24);
            this.dtFechaNac.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 21);
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
            this.lblType.Location = new System.Drawing.Point(10, 21);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 20);
            this.lblType.TabIndex = 61;
            this.lblType.Text = "Proveedor";
            this.lblType.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 28);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDelDomicilio
            // 
            this.btnDelDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelDomicilio.Location = new System.Drawing.Point(98, 268);
            this.btnDelDomicilio.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelDomicilio.Name = "btnDelDomicilio";
            this.btnDelDomicilio.Size = new System.Drawing.Size(72, 39);
            this.btnDelDomicilio.TabIndex = 66;
            this.btnDelDomicilio.Text = "Eliminar";
            this.btnDelDomicilio.UseVisualStyleBackColor = true;
            // 
            // btnAddDomicilio
            // 
            this.btnAddDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDomicilio.Location = new System.Drawing.Point(14, 268);
            this.btnAddDomicilio.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddDomicilio.Name = "btnAddDomicilio";
            this.btnAddDomicilio.Size = new System.Drawing.Size(74, 39);
            this.btnAddDomicilio.TabIndex = 65;
            this.btnAddDomicilio.Text = "Agregar";
            this.btnAddDomicilio.UseVisualStyleBackColor = true;
            // 
            // dgvDomicilios
            // 
            this.dgvDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomicilios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDomicilios.Location = new System.Drawing.Point(12, 79);
            this.dgvDomicilios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvDomicilios.MultiSelect = false;
            this.dgvDomicilios.Name = "dgvDomicilios";
            this.dgvDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomicilios.Size = new System.Drawing.Size(743, 178);
            this.dgvDomicilios.TabIndex = 64;
            this.dgvDomicilios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDomicilios_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(674, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 34);
            this.button1.TabIndex = 68;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(585, 312);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 34);
            this.button2.TabIndex = 67;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OperacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDelDomicilio);
            this.Controls.Add(this.btnAddDomicilio);
            this.Controls.Add(this.dgvDomicilios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtFechaNac);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OperacionForm";
            this.Text = "OperacionForm";
            this.Load += new System.EventHandler(this.OperacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelDomicilio;
        private System.Windows.Forms.Button btnAddDomicilio;
        private System.Windows.Forms.DataGridView dgvDomicilios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}