
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
            this.n_monto_minimo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_monto_minimo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_cliente_desde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_monto_minimo)).BeginInit();
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
            this.txt_direccion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_direccion_KeyUp);
            // 
            // n_monto_minimo
            // 
            this.n_monto_minimo.Location = new System.Drawing.Point(1232, 122);
            this.n_monto_minimo.Maximum = new decimal(new int[] {
            1500000,
            0,
            0,
            0});
            this.n_monto_minimo.Name = "n_monto_minimo";
            this.n_monto_minimo.Size = new System.Drawing.Size(150, 27);
            this.n_monto_minimo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1211, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monto minimo invertido";
            // 
            // btn_monto_minimo
            // 
            this.btn_monto_minimo.Location = new System.Drawing.Point(1171, 155);
            this.btn_monto_minimo.Name = "btn_monto_minimo";
            this.btn_monto_minimo.Size = new System.Drawing.Size(211, 29);
            this.btn_monto_minimo.TabIndex = 4;
            this.btn_monto_minimo.Text = "Buscar por monto minimo";
            this.btn_monto_minimo.UseVisualStyleBackColor = true;
            this.btn_monto_minimo.Click += new System.EventHandler(this.btn_monto_minimo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes antes de:";
            // 
            // dtp_cliente_desde
            // 
            this.dtp_cliente_desde.Location = new System.Drawing.Point(587, 157);
            this.dtp_cliente_desde.Name = "dtp_cliente_desde";
            this.dtp_cliente_desde.Size = new System.Drawing.Size(250, 27);
            this.dtp_cliente_desde.TabIndex = 5;
            this.dtp_cliente_desde.CloseUp += new System.EventHandler(this.dtp_cliente_desde_CloseUp);
            // 
            // ClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtp_cliente_desde);
            this.Controls.Add(this.btn_monto_minimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_monto_minimo);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_buscar_nombre);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "ClientesView";
            this.Size = new System.Drawing.Size(1517, 760);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_monto_minimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txt_buscar_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.NumericUpDown n_monto_minimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_monto_minimo;
        private System.Windows.Forms.DateTimePicker dtp_cliente_desde;
        private System.Windows.Forms.Label label2;
    }
}
