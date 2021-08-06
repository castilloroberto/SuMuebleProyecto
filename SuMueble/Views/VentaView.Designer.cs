
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_terminarVenta = new System.Windows.Forms.Button();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.txt_clienteTelefono = new System.Windows.Forms.TextBox();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_cantidadProducto = new System.Windows.Forms.TextBox();
            this.txt_buscarProducto = new System.Windows.Forms.TextBox();
            this.txt_dniCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dniColaborador = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelClienteNuevo = new System.Windows.Forms.Label();
            this.dniColaboradorLabelError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_monto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_productosVenta = new System.Windows.Forms.ListBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_quitarItem = new System.Windows.Forms.Button();
            this.btn_verFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_terminarVenta
            // 
            this.btn_terminarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(208)))), ((int)(((byte)(88)))));
            this.btn_terminarVenta.FlatAppearance.BorderSize = 0;
            this.btn_terminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terminarVenta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_terminarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_terminarVenta.Location = new System.Drawing.Point(1318, 790);
            this.btn_terminarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_terminarVenta.Name = "btn_terminarVenta";
            this.btn_terminarVenta.Size = new System.Drawing.Size(191, 38);
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
            this.btn_agregarProducto.Location = new System.Drawing.Point(742, 790);
            this.btn_agregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(191, 38);
            this.btn_agregarProducto.TabIndex = 30;
            this.btn_agregarProducto.Text = "Agregar a la Venta";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // txt_clienteTelefono
            // 
            this.txt_clienteTelefono.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_clienteTelefono.Location = new System.Drawing.Point(710, 230);
            this.txt_clienteTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_clienteTelefono.MaxLength = 8;
            this.txt_clienteTelefono.Name = "txt_clienteTelefono";
            this.txt_clienteTelefono.PlaceholderText = "Escriba Aqui...";
            this.txt_clienteTelefono.Size = new System.Drawing.Size(223, 34);
            this.txt_clienteTelefono.TabIndex = 28;
            this.txt_clienteTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clienteTelefono_KeyPress);
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombreCliente.Location = new System.Drawing.Point(338, 230);
            this.txt_nombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombreCliente.MaxLength = 255;
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.PlaceholderText = "Nombre y Apellidos...";
            this.txt_nombreCliente.Size = new System.Drawing.Size(325, 34);
            this.txt_nombreCliente.TabIndex = 27;
            this.txt_nombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreCliente_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_precio.Location = new System.Drawing.Point(77, 794);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.PlaceholderText = "Precio Sugerido...";
            this.txt_precio.Size = new System.Drawing.Size(223, 34);
            this.txt_precio.TabIndex = 26;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_cantidadProducto
            // 
            this.txt_cantidadProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cantidadProducto.Location = new System.Drawing.Point(357, 794);
            this.txt_cantidadProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidadProducto.MaxLength = 100;
            this.txt_cantidadProducto.Name = "txt_cantidadProducto";
            this.txt_cantidadProducto.PlaceholderText = "Cantidad...";
            this.txt_cantidadProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_cantidadProducto.TabIndex = 25;
            this.txt_cantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidadProducto_KeyPress);
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscarProducto.Location = new System.Drawing.Point(75, 334);
            this.txt_buscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.PlaceholderText = "Nombre o Codigo de Producto...";
            this.txt_buscarProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_buscarProducto.TabIndex = 24;
            this.txt_buscarProducto.TextChanged += new System.EventHandler(this.txt_buscarProducto_TextChanged);
            // 
            // txt_dniCliente
            // 
            this.txt_dniCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniCliente.Location = new System.Drawing.Point(75, 230);
            this.txt_dniCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dniCliente.MaxLength = 13;
            this.txt_dniCliente.Name = "txt_dniCliente";
            this.txt_dniCliente.PlaceholderText = "Numero de Identidad...";
            this.txt_dniCliente.Size = new System.Drawing.Size(223, 34);
            this.txt_dniCliente.TabIndex = 22;
            this.txt_dniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dniCliente_KeyPress);
            this.txt_dniCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dniCliente_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(74, 762);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Precio Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(707, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Telefono Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(354, 762);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(335, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(73, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buscar Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "DNI Cliente";
            // 
            // txt_dniColaborador
            // 
            this.txt_dniColaborador.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniColaborador.Location = new System.Drawing.Point(1286, 230);
            this.txt_dniColaborador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dniColaborador.MaxLength = 13;
            this.txt_dniColaborador.Name = "txt_dniColaborador";
            this.txt_dniColaborador.PlaceholderText = "Numero de Identidad...";
            this.txt_dniColaborador.Size = new System.Drawing.Size(223, 34);
            this.txt_dniColaborador.TabIndex = 23;
            this.txt_dniColaborador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dniColaborador_KeyPress);
            this.txt_dniColaborador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dniColaborador_KeyUp);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.labelTelefono.Location = new System.Drawing.Point(710, 266);
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
            this.labelNombre.Location = new System.Drawing.Point(338, 266);
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
            this.labelClienteNuevo.Location = new System.Drawing.Point(75, 266);
            this.labelClienteNuevo.Name = "labelClienteNuevo";
            this.labelClienteNuevo.Size = new System.Drawing.Size(98, 20);
            this.labelClienteNuevo.TabIndex = 12;
            this.labelClienteNuevo.Text = "Cliente Nuevo";
            this.labelClienteNuevo.Visible = false;
            // 
            // dniColaboradorLabelError
            // 
            this.dniColaboradorLabelError.AutoSize = true;
            this.dniColaboradorLabelError.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dniColaboradorLabelError.ForeColor = System.Drawing.Color.Crimson;
            this.dniColaboradorLabelError.Location = new System.Drawing.Point(1286, 266);
            this.dniColaboradorLabelError.Name = "dniColaboradorLabelError";
            this.dniColaboradorLabelError.Size = new System.Drawing.Size(129, 20);
            this.dniColaboradorLabelError.TabIndex = 11;
            this.dniColaboradorLabelError.Text = "Escribio mal su DNI";
            this.dniColaboradorLabelError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1278, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNI Colaborador";
            // 
            // l_monto
            // 
            this.l_monto.AutoSize = true;
            this.l_monto.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_monto.Location = new System.Drawing.Point(1344, 334);
            this.l_monto.Name = "l_monto";
            this.l_monto.Size = new System.Drawing.Size(165, 32);
            this.l_monto.TabIndex = 9;
            this.l_monto.Text = "Lps. 000,000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(997, 334);
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
            this.lb_productosVenta.Location = new System.Drawing.Point(997, 390);
            this.lb_productosVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.producto,
            this.precio,
            this.existencias});
            this.dgv_productos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_productos.Location = new System.Drawing.Point(75, 390);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 29;
            this.dgv_productos.Size = new System.Drawing.Size(857, 366);
            this.dgv_productos.TabIndex = 6;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "Producto";
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "PrecioUnitario";
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // existencias
            // 
            this.existencias.DataPropertyName = "Existencias";
            this.existencias.HeaderText = "Existencias";
            this.existencias.MinimumWidth = 6;
            this.existencias.Name = "existencias";
            this.existencias.ReadOnly = true;
            // 
            // btn_quitarItem
            // 
            this.btn_quitarItem.BackColor = System.Drawing.Color.Crimson;
            this.btn_quitarItem.FlatAppearance.BorderSize = 0;
            this.btn_quitarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitarItem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_quitarItem.ForeColor = System.Drawing.Color.White;
            this.btn_quitarItem.Location = new System.Drawing.Point(997, 790);
            this.btn_quitarItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_quitarItem.Name = "btn_quitarItem";
            this.btn_quitarItem.Size = new System.Drawing.Size(129, 38);
            this.btn_quitarItem.TabIndex = 30;
            this.btn_quitarItem.Text = "Quitar Item";
            this.btn_quitarItem.UseVisualStyleBackColor = false;
            this.btn_quitarItem.Click += new System.EventHandler(this.btn_quitarItem_Click);
            // 
            // btn_verFactura
            // 
            this.btn_verFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(208)))), ((int)(((byte)(88)))));
            this.btn_verFactura.FlatAppearance.BorderSize = 0;
            this.btn_verFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verFactura.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verFactura.ForeColor = System.Drawing.Color.White;
            this.btn_verFactura.Location = new System.Drawing.Point(1318, 844);
            this.btn_verFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_verFactura.Name = "btn_verFactura";
            this.btn_verFactura.Size = new System.Drawing.Size(191, 38);
            this.btn_verFactura.TabIndex = 31;
            this.btn_verFactura.Text = "Ver factura";
            this.btn_verFactura.UseVisualStyleBackColor = false;
            this.btn_verFactura.Click += new System.EventHandler(this.btn_verFactura_Click);
            // 
            // VentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_verFactura);
            this.Controls.Add(this.btn_terminarVenta);
            this.Controls.Add(this.btn_quitarItem);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.txt_clienteTelefono);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantidadProducto);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.txt_dniCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dniColaborador);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelClienteNuevo);
            this.Controls.Add(this.dniColaboradorLabelError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_productosVenta);
            this.Controls.Add(this.dgv_productos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentaView";
            this.Size = new System.Drawing.Size(1523, 918);
            this.Load += new System.EventHandler(this.VentaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_terminarVenta;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.TextBox txt_clienteTelefono;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_cantidadProducto;
        private System.Windows.Forms.TextBox txt_buscarProducto;
        private System.Windows.Forms.TextBox txt_dniCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dniColaborador;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelClienteNuevo;
        private System.Windows.Forms.Label dniColaboradorLabelError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_productosVenta;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencias;
        private System.Windows.Forms.Button btn_quitarItem;
        private System.Windows.Forms.Button btn_verFactura;
    }
}
