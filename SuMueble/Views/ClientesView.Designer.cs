
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
            this.label3 = new System.Windows.Forms.Label();
            this.total_clientes = new System.Windows.Forms.Label();
            this.btn_ver_todos = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_monto_minimo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(93, 259);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.RowHeadersWidth = 51;
            this.dgv_clientes.RowTemplate.Height = 29;
            this.dgv_clientes.Size = new System.Drawing.Size(1287, 479);
            this.dgv_clientes.TabIndex = 0;
            // 
            // txt_buscar_nombre
            // 
            this.txt_buscar_nombre.Location = new System.Drawing.Point(93, 211);
            this.txt_buscar_nombre.Name = "txt_buscar_nombre";
            this.txt_buscar_nombre.PlaceholderText = "Buscar por nombre";
            this.txt_buscar_nombre.Size = new System.Drawing.Size(201, 27);
            this.txt_buscar_nombre.TabIndex = 1;
            this.txt_buscar_nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_nombre_KeyUp);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(337, 211);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PlaceholderText = "Ej: ciudad o colonia";
            this.txt_direccion.Size = new System.Drawing.Size(201, 27);
            this.txt_direccion.TabIndex = 1;
            this.txt_direccion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_direccion_KeyUp);
            // 
            // n_monto_minimo
            // 
            this.n_monto_minimo.Location = new System.Drawing.Point(1230, 176);
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
            this.label1.Location = new System.Drawing.Point(1209, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monto minimo invertido";
            // 
            // btn_monto_minimo
            // 
            this.btn_monto_minimo.Location = new System.Drawing.Point(1169, 209);
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
            this.label2.Location = new System.Drawing.Point(585, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes antes de:";
            // 
            // dtp_cliente_desde
            // 
            this.dtp_cliente_desde.Location = new System.Drawing.Point(585, 211);
            this.dtp_cliente_desde.Name = "dtp_cliente_desde";
            this.dtp_cliente_desde.Size = new System.Drawing.Size(250, 27);
            this.dtp_cliente_desde.TabIndex = 5;
            this.dtp_cliente_desde.CloseUp += new System.EventHandler(this.dtp_cliente_desde_CloseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(570, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 57);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar Clientes";
            // 
            // total_clientes
            // 
            this.total_clientes.AutoSize = true;
            this.total_clientes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_clientes.Location = new System.Drawing.Point(1089, 741);
            this.total_clientes.Name = "total_clientes";
            this.total_clientes.Size = new System.Drawing.Size(226, 46);
            this.total_clientes.TabIndex = 6;
            this.total_clientes.Text = "Total Clientes:";
            // 
            // btn_ver_todos
            // 
            this.btn_ver_todos.Location = new System.Drawing.Point(93, 744);
            this.btn_ver_todos.Name = "btn_ver_todos";
            this.btn_ver_todos.Size = new System.Drawing.Size(211, 29);
            this.btn_ver_todos.TabIndex = 4;
            this.btn_ver_todos.Text = "Ver todos";
            this.btn_ver_todos.UseVisualStyleBackColor = true;
            this.btn_ver_todos.Click += new System.EventHandler(this.btn_ver_todos_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ayuda.Location = new System.Drawing.Point(1393, 25);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(94, 29);
            this.btn_ayuda.TabIndex = 49;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // ClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.total_clientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_cliente_desde);
            this.Controls.Add(this.btn_ver_todos);
            this.Controls.Add(this.btn_monto_minimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_monto_minimo);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_buscar_nombre);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "ClientesView";
            this.Size = new System.Drawing.Size(1517, 810);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_clientes;
        private System.Windows.Forms.Button btn_ver_todos;
        private System.Windows.Forms.Button btn_ayuda;
    }
}
