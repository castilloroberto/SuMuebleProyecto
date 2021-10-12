
namespace SuMueble.Views
{
    partial class VentaView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_terminarVenta = new System.Windows.Forms.Button();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.txt_clienteTelefono = new System.Windows.Forms.TextBox();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_buscarProducto = new System.Windows.Forms.TextBox();
            this.txt_dniCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelClienteNuevo = new System.Windows.Forms.Label();
            this.l_monto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_productosVenta = new System.Windows.Forms.ListBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.btn_quitarItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.NumericUpDown();
            this.txt_cantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.txt_precio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidadProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_terminarVenta
            // 
            this.btn_terminarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(208)))), ((int)(((byte)(88)))));
            this.btn_terminarVenta.FlatAppearance.BorderSize = 0;
            this.btn_terminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terminarVenta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_terminarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_terminarVenta.Location = new System.Drawing.Point(1318, 789);
            this.btn_terminarVenta.Name = "btn_terminarVenta";
            this.btn_terminarVenta.Size = new System.Drawing.Size(191, 37);
            this.btn_terminarVenta.TabIndex = 31;
            this.btn_terminarVenta.Text = "Terminar Venta";
            this.btn_terminarVenta.UseVisualStyleBackColor = false;
            this.btn_terminarVenta.Click += new System.EventHandler(this.btn_terminarVenta_Click);
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_agregarProducto.Location = new System.Drawing.Point(742, 789);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(191, 51);
            this.btn_agregarProducto.TabIndex = 30;
            this.btn_agregarProducto.Text = "Agregar a la Venta";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // txt_clienteTelefono
            // 
            this.txt_clienteTelefono.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_clienteTelefono.Location = new System.Drawing.Point(710, 229);
            this.txt_clienteTelefono.MaxLength = 8;
            this.txt_clienteTelefono.Name = "txt_clienteTelefono";
            this.txt_clienteTelefono.PlaceholderText = "Escriba Aquí...";
            this.txt_clienteTelefono.Size = new System.Drawing.Size(223, 34);
            this.txt_clienteTelefono.TabIndex = 28;
            this.txt_clienteTelefono.TextChanged += new System.EventHandler(this.txt_clienteTelefono_TextChanged);
            this.txt_clienteTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_clienteTelefono_KeyDown);
            this.txt_clienteTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clienteTelefono_KeyPress);
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombreCliente.Location = new System.Drawing.Point(338, 229);
            this.txt_nombreCliente.MaxLength = 200;
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.PlaceholderText = "Nombre y Apellidos...";
            this.txt_nombreCliente.Size = new System.Drawing.Size(325, 34);
            this.txt_nombreCliente.TabIndex = 27;
            this.txt_nombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreCliente_KeyPress);
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscarProducto.Location = new System.Drawing.Point(75, 333);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.PlaceholderText = "Nombre o Codigo de Producto...";
            this.txt_buscarProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_buscarProducto.TabIndex = 24;
            this.txt_buscarProducto.TextChanged += new System.EventHandler(this.txt_buscarProducto_TextChanged);
            // 
            // txt_dniCliente
            // 
            this.txt_dniCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniCliente.Location = new System.Drawing.Point(75, 229);
            this.txt_dniCliente.MaxLength = 13;
            this.txt_dniCliente.Name = "txt_dniCliente";
            this.txt_dniCliente.PlaceholderText = "Numero de Identidad...";
            this.txt_dniCliente.Size = new System.Drawing.Size(223, 34);
            this.txt_dniCliente.TabIndex = 22;
            this.txt_dniCliente.TextChanged += new System.EventHandler(this.txt_dniCliente_TextChanged);
            this.txt_dniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dniCliente_KeyPress);
            this.txt_dniCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dniCliente_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(74, 763);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Precio Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(707, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Teléfono Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(354, 763);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(335, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(73, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buscar Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "DNI Cliente";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.labelTelefono.Location = new System.Drawing.Point(710, 267);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(66, 20);
            this.labelTelefono.TabIndex = 14;
            this.labelTelefono.Text = "Ingresar...";
            this.labelTelefono.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.labelNombre.Location = new System.Drawing.Point(338, 267);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 20);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Ingresar...";
            this.labelNombre.Visible = false;
            // 
            // labelClienteNuevo
            // 
            this.labelClienteNuevo.AutoSize = true;
            this.labelClienteNuevo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClienteNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.labelClienteNuevo.Location = new System.Drawing.Point(75, 267);
            this.labelClienteNuevo.Name = "labelClienteNuevo";
            this.labelClienteNuevo.Size = new System.Drawing.Size(98, 20);
            this.labelClienteNuevo.TabIndex = 12;
            this.labelClienteNuevo.Text = "Cliente Nuevo";
            this.labelClienteNuevo.Visible = false;
            // 
            // l_monto
            // 
            this.l_monto.AutoSize = true;
            this.l_monto.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_monto.Location = new System.Drawing.Point(1344, 333);
            this.l_monto.Name = "l_monto";
            this.l_monto.Size = new System.Drawing.Size(165, 32);
            this.l_monto.TabIndex = 9;
            this.l_monto.Text = "Lps. 000,000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(997, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resumen Venta";
            // 
            // lb_productosVenta
            // 
            this.lb_productosVenta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_productosVenta.FormattingEnabled = true;
            this.lb_productosVenta.ItemHeight = 28;
            this.lb_productosVenta.Location = new System.Drawing.Point(997, 389);
            this.lb_productosVenta.Name = "lb_productosVenta";
            this.lb_productosVenta.Size = new System.Drawing.Size(513, 312);
            this.lb_productosVenta.TabIndex = 7;
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_productos.Location = new System.Drawing.Point(75, 389);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 29;
            this.dgv_productos.Size = new System.Drawing.Size(857, 365);
            this.dgv_productos.TabIndex = 6;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // btn_quitarItem
            // 
            this.btn_quitarItem.BackColor = System.Drawing.Color.Crimson;
            this.btn_quitarItem.FlatAppearance.BorderSize = 0;
            this.btn_quitarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitarItem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_quitarItem.ForeColor = System.Drawing.Color.White;
            this.btn_quitarItem.Location = new System.Drawing.Point(997, 789);
            this.btn_quitarItem.Name = "btn_quitarItem";
            this.btn_quitarItem.Size = new System.Drawing.Size(129, 37);
            this.btn_quitarItem.TabIndex = 30;
            this.btn_quitarItem.Text = "Quitar Item";
            this.btn_quitarItem.UseVisualStyleBackColor = false;
            this.btn_quitarItem.Click += new System.EventHandler(this.btn_quitarItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(77, 844);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descuento";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_descuento.Location = new System.Drawing.Point(77, 875);
            this.txt_descuento.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(223, 34);
            this.txt_descuento.TabIndex = 32;
            this.txt_descuento.ValueChanged += new System.EventHandler(this.txt_descuento_ValueChanged);
            this.txt_descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descuento_KeyPress);
            // 
            // txt_cantidadProducto
            // 
            this.txt_cantidadProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cantidadProducto.Location = new System.Drawing.Point(354, 793);
            this.txt_cantidadProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_cantidadProducto.Name = "txt_cantidadProducto";
            this.txt_cantidadProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_cantidadProducto.TabIndex = 33;
            this.txt_cantidadProducto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_precio
            // 
            this.txt_precio.DecimalPlaces = 2;
            this.txt_precio.Enabled = false;
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_precio.Location = new System.Drawing.Point(77, 789);
            this.txt_precio.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(223, 34);
            this.txt_precio.TabIndex = 33;
            this.txt_precio.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(306, 875);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "%";
            // 
            // VentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantidadProducto);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.btn_terminarVenta);
            this.Controls.Add(this.btn_quitarItem);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.txt_clienteTelefono);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.txt_dniCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelClienteNuevo);
            this.Controls.Add(this.l_monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_productosVenta);
            this.Controls.Add(this.dgv_productos);
            this.Name = "VentaView";
            this.Size = new System.Drawing.Size(1523, 917);
            this.Load += new System.EventHandler(this.VentaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidadProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_terminarVenta;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.TextBox txt_clienteTelefono;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_buscarProducto;
        private System.Windows.Forms.TextBox txt_dniCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelClienteNuevo;
        private System.Windows.Forms.Label l_monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_productosVenta;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button btn_quitarItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_descuento;
        private System.Windows.Forms.NumericUpDown txt_cantidadProducto;
        private System.Windows.Forms.NumericUpDown txt_precio;
        private System.Windows.Forms.Label label3;
    }
}
