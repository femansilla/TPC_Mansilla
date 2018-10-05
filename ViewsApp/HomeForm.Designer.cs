﻿namespace ViewsApp
{
    partial class HomeForm
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
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnGestionProductos = new System.Windows.Forms.Button();
            this.btnGestionClientes = new System.Windows.Forms.Button();
            this.btnControlStock = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGestionProveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Location = new System.Drawing.Point(48, 39);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(201, 44);
            this.btnGestionUsuarios.TabIndex = 0;
            this.btnGestionUsuarios.Text = "Gestion usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.Location = new System.Drawing.Point(48, 92);
            this.btnGestionProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(201, 44);
            this.btnGestionProductos.TabIndex = 1;
            this.btnGestionProductos.Text = "Gestion productos";
            this.btnGestionProductos.UseVisualStyleBackColor = true;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnGestionProductos_Click);
            // 
            // btnGestionClientes
            // 
            this.btnGestionClientes.Location = new System.Drawing.Point(48, 144);
            this.btnGestionClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionClientes.Name = "btnGestionClientes";
            this.btnGestionClientes.Size = new System.Drawing.Size(201, 44);
            this.btnGestionClientes.TabIndex = 2;
            this.btnGestionClientes.Text = "Gestion clientes";
            this.btnGestionClientes.UseVisualStyleBackColor = true;
            this.btnGestionClientes.Click += new System.EventHandler(this.btnGestionClientes_Click);
            // 
            // btnControlStock
            // 
            this.btnControlStock.Location = new System.Drawing.Point(48, 248);
            this.btnControlStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnControlStock.Name = "btnControlStock";
            this.btnControlStock.Size = new System.Drawing.Size(201, 44);
            this.btnControlStock.TabIndex = 3;
            this.btnControlStock.Text = "Control de stock";
            this.btnControlStock.UseVisualStyleBackColor = true;
            this.btnControlStock.Click += new System.EventHandler(this.btnControlStock_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(48, 378);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(201, 44);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(452, 378);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGestionProveedores
            // 
            this.btnGestionProveedores.Location = new System.Drawing.Point(48, 196);
            this.btnGestionProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionProveedores.Name = "btnGestionProveedores";
            this.btnGestionProveedores.Size = new System.Drawing.Size(201, 44);
            this.btnGestionProveedores.TabIndex = 6;
            this.btnGestionProveedores.Text = "Gestion proveedores";
            this.btnGestionProveedores.UseVisualStyleBackColor = true;
            this.btnGestionProveedores.Click += new System.EventHandler(this.btnGestionProveedores_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 452);
            this.Controls.Add(this.btnGestionProveedores);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnControlStock);
            this.Controls.Add(this.btnGestionClientes);
            this.Controls.Add(this.btnGestionProductos);
            this.Controls.Add(this.btnGestionUsuarios);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Location = new System.Drawing.Point(200, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnGestionProductos;
        private System.Windows.Forms.Button btnGestionClientes;
        private System.Windows.Forms.Button btnControlStock;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGestionProveedores;
    }
}