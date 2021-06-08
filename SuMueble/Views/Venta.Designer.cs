
namespace SuMueble.Views
{
    partial class Venta
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.btnbuscarinventario = new System.Windows.Forms.Button();
            this.lblISV = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtcodigofactura = new System.Windows.Forms.TextBox();
            this.btnBuscarcliente = new System.Windows.Forms.Button();
            this.lblnombrecliente = new System.Windows.Forms.Label();
            this.lblcodigofactura = new System.Windows.Forms.Label();
            this.lblfechaventa = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(111, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(929, 625);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ventas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(893, 188);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblDescuento);
            this.groupBox1.Controls.Add(this.btnbuscarinventario);
            this.groupBox1.Controls.Add(this.lblISV);
            this.groupBox1.Controls.Add(this.lblsubtotal);
            this.groupBox1.Controls.Add(this.txtarticulo);
            this.groupBox1.Controls.Add(this.lblprecio);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.lblcantidad);
            this.groupBox1.Controls.Add(this.lblArticulo);
            this.groupBox1.Location = new System.Drawing.Point(18, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(725, 95);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(94, 29);
            this.btnguardar.TabIndex = 12;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(449, 120);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(125, 27);
            this.txttotal.TabIndex = 11;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(607, 118);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(94, 29);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(607, 75);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(707, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 9;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(355, 123);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(42, 20);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "Total";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(449, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(622, 37);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(79, 20);
            this.lblDescuento.TabIndex = 6;
            this.lblDescuento.Text = "Descuento";
            // 
            // btnbuscarinventario
            // 
            this.btnbuscarinventario.Location = new System.Drawing.Point(239, 33);
            this.btnbuscarinventario.Name = "btnbuscarinventario";
            this.btnbuscarinventario.Size = new System.Drawing.Size(81, 29);
            this.btnbuscarinventario.TabIndex = 6;
            this.btnbuscarinventario.Text = "Buscar";
            this.btnbuscarinventario.UseVisualStyleBackColor = true;
            // 
            // lblISV
            // 
            this.lblISV.AutoSize = true;
            this.lblISV.Location = new System.Drawing.Point(355, 82);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(30, 20);
            this.lblISV.TabIndex = 5;
            this.lblISV.Text = "ISV";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(16, 123);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(71, 20);
            this.lblsubtotal.TabIndex = 4;
            this.lblsubtotal.Text = "Sub Total";
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(103, 34);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(125, 27);
            this.txtarticulo.TabIndex = 4;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(355, 37);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(90, 20);
            this.lblprecio.TabIndex = 4;
            this.lblprecio.Text = "Precio venta";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(103, 75);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(125, 27);
            this.txtcantidad.TabIndex = 4;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(16, 78);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(69, 20);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(16, 37);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(61, 20);
            this.lblArticulo.TabIndex = 1;
            this.lblArticulo.Text = "Articulo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnlimpiar);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtcodigofactura);
            this.groupBox2.Controls.Add(this.btnBuscarcliente);
            this.groupBox2.Controls.Add(this.lblnombrecliente);
            this.groupBox2.Controls.Add(this.lblcodigofactura);
            this.groupBox2.Controls.Add(this.lblfechaventa);
            this.groupBox2.Controls.Add(this.lblDNI);
            this.groupBox2.Controls.Add(this.txtnombrecliente);
            this.groupBox2.Controls.Add(this.txtDNI);
            this.groupBox2.Location = new System.Drawing.Point(19, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 155);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(622, 89);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(449, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 27);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtcodigofactura
            // 
            this.txtcodigofactura.Location = new System.Drawing.Point(449, 90);
            this.txtcodigofactura.Name = "txtcodigofactura";
            this.txtcodigofactura.Size = new System.Drawing.Size(125, 27);
            this.txtcodigofactura.TabIndex = 8;
            // 
            // btnBuscarcliente
            // 
            this.btnBuscarcliente.Location = new System.Drawing.Point(239, 42);
            this.btnBuscarcliente.Name = "btnBuscarcliente";
            this.btnBuscarcliente.Size = new System.Drawing.Size(81, 29);
            this.btnBuscarcliente.TabIndex = 7;
            this.btnBuscarcliente.Text = "Buscar";
            this.btnBuscarcliente.UseVisualStyleBackColor = true;
            // 
            // lblnombrecliente
            // 
            this.lblnombrecliente.AutoSize = true;
            this.lblnombrecliente.Location = new System.Drawing.Point(24, 93);
            this.lblnombrecliente.Name = "lblnombrecliente";
            this.lblnombrecliente.Size = new System.Drawing.Size(73, 20);
            this.lblnombrecliente.TabIndex = 6;
            this.lblnombrecliente.Text = "N. Cliente";
            // 
            // lblcodigofactura
            // 
            this.lblcodigofactura.AutoSize = true;
            this.lblcodigofactura.Location = new System.Drawing.Point(355, 93);
            this.lblcodigofactura.Name = "lblcodigofactura";
            this.lblcodigofactura.Size = new System.Drawing.Size(72, 20);
            this.lblcodigofactura.TabIndex = 5;
            this.lblcodigofactura.Text = "C. Factura";
            // 
            // lblfechaventa
            // 
            this.lblfechaventa.AutoSize = true;
            this.lblfechaventa.Location = new System.Drawing.Point(355, 44);
            this.lblfechaventa.Name = "lblfechaventa";
            this.lblfechaventa.Size = new System.Drawing.Size(88, 20);
            this.lblfechaventa.TabIndex = 3;
            this.lblfechaventa.Text = "Fecha Venta";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(24, 46);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 20);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(97, 90);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(125, 27);
            this.txtnombrecliente.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(97, 41);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(125, 27);
            this.txtDNI.TabIndex = 0;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "Venta";
            this.Size = new System.Drawing.Size(1171, 803);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Button btnbuscarinventario;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtcodigofactura;
        private System.Windows.Forms.Button btnBuscarcliente;
        private System.Windows.Forms.Label lblnombrecliente;
        private System.Windows.Forms.Label lblcodigofactura;
        private System.Windows.Forms.Label lblfechaventa;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtDNI;
    }
}
