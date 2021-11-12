
namespace SuMueble.Views
{
    partial class ClientesView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.txt_buscar_nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(95, 205);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.RowHeadersWidth = 51;
            this.dgv_clientes.RowTemplate.Height = 29;
            this.dgv_clientes.Size = new System.Drawing.Size(1287, 479);
            this.dgv_clientes.TabIndex = 0;
            // 
            // txt_buscar_nombre
            // 
            this.txt_buscar_nombre.Location = new System.Drawing.Point(95, 157);
            this.txt_buscar_nombre.Name = "txt_buscar_nombre";
            this.txt_buscar_nombre.PlaceholderText = "Buscar por nombre";
            this.txt_buscar_nombre.Size = new System.Drawing.Size(201, 27);
            this.txt_buscar_nombre.TabIndex = 1;
            this.txt_buscar_nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_nombre_KeyUp);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(339, 157);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PlaceholderText = "Ej: ciudad o colonia";
            this.txt_direccion.Size = new System.Drawing.Size(201, 27);
            this.txt_direccion.TabIndex = 1;
            this.txt_direccion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_nombre_KeyUp);
            // 
            // ClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_buscar_nombre);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "ClientesView";
            this.Size = new System.Drawing.Size(1517, 760);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txt_buscar_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
    }
}
