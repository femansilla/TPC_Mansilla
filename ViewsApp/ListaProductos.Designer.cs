namespace ViewsApp
{
    partial class ListaProductos
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
            this.lisProduct = new System.Windows.Forms.ListView();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lisProduct
            // 
            this.lisProduct.Location = new System.Drawing.Point(12, 12);
            this.lisProduct.Name = "lisProduct";
            this.lisProduct.Size = new System.Drawing.Size(731, 366);
            this.lisProduct.TabIndex = 2;
            this.lisProduct.UseCompatibleStateImageBehavior = false;
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(175, 397);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProducto.TabIndex = 6;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Location = new System.Drawing.Point(94, 397);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarProducto.TabIndex = 5;
            this.btnBorrarProducto.Text = "Borrar";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(13, 397);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 432);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnBorrarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lisProduct);
            this.Name = "ListaProductos";
            this.Text = "ListaProductos";
            this.Load += new System.EventHandler(this.ListaProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lisProduct;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}