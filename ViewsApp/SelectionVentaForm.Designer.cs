namespace ViewsApp
{
    partial class SelectionVentaForm
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
            this.dgvAllClients = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnVentaMostrador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllClients
            // 
            this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClients.Location = new System.Drawing.Point(11, 48);
            this.dgvAllClients.Name = "dgvAllClients";
            this.dgvAllClients.Size = new System.Drawing.Size(255, 416);
            this.dgvAllClients.TabIndex = 27;
            this.dgvAllClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllClients_CellDoubleClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnVolver.Location = new System.Drawing.Point(274, 101);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 46);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 25);
            this.txtSearch.TabIndex = 23;
            // 
            // btnVentaMostrador
            // 
            this.btnVentaMostrador.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnVentaMostrador.Location = new System.Drawing.Point(274, 43);
            this.btnVentaMostrador.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnVentaMostrador.Name = "btnVentaMostrador";
            this.btnVentaMostrador.Size = new System.Drawing.Size(91, 46);
            this.btnVentaMostrador.TabIndex = 28;
            this.btnVentaMostrador.Text = "Mostrador";
            this.btnVentaMostrador.UseVisualStyleBackColor = true;
            this.btnVentaMostrador.Click += new System.EventHandler(this.btnVentaMostrador_Click);
            // 
            // SelectionVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 473);
            this.Controls.Add(this.btnVentaMostrador);
            this.Controls.Add(this.dgvAllClients);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SelectionVentaForm";
            this.Text = "SelectionVentaForm";
            this.Load += new System.EventHandler(this.SelectionVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllClients;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnVentaMostrador;
    }
}