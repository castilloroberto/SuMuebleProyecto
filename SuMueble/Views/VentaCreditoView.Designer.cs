
namespace SuMueble.Views
{
    partial class VentaCreditoView
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
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_dniCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_referencias = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregarReferencia = new System.Windows.Forms.Button();
            this.lb_productosVenta = new System.Windows.Forms.ListBox();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.txt_dniColaborador = new System.Windows.Forms.TextBox();
            this.dniColaboradorLabelError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_monto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_telefono.Location = new System.Drawing.Point(616, 161);
            this.txt_telefono.MaxLength = 8;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PlaceholderText = "Escriba Aqui...";
            this.txt_telefono.Size = new System.Drawing.Size(223, 34);
            this.txt_telefono.TabIndex = 34;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombreCliente.Location = new System.Drawing.Point(613, 77);
            this.txt_nombreCliente.MaxLength = 255;
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.PlaceholderText = "Nombre y Apellidos...";
            this.txt_nombreCliente.Size = new System.Drawing.Size(325, 34);
            this.txt_nombreCliente.TabIndex = 33;
            // 
            // txt_dniCliente
            // 
            this.txt_dniCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniCliente.Location = new System.Drawing.Point(351, 77);
            this.txt_dniCliente.MaxLength = 13;
            this.txt_dniCliente.Name = "txt_dniCliente";
            this.txt_dniCliente.PlaceholderText = "Numero de Identidad...";
            this.txt_dniCliente.Size = new System.Drawing.Size(223, 34);
            this.txt_dniCliente.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(613, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Telefono Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(610, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(345, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "DNI Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(345, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "RTN Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(351, 161);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Registro Tributario Nacional...";
            this.textBox1.Size = new System.Drawing.Size(223, 34);
            this.textBox1.TabIndex = 32;
            // 
            // lb_referencias
            // 
            this.lb_referencias.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_referencias.FormattingEnabled = true;
            this.lb_referencias.ItemHeight = 28;
            this.lb_referencias.Location = new System.Drawing.Point(351, 290);
            this.lb_referencias.Name = "lb_referencias";
            this.lb_referencias.Size = new System.Drawing.Size(513, 340);
            this.lb_referencias.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(347, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Referencias del Cliente";
            // 
            // btn_agregarReferencia
            // 
            this.btn_agregarReferencia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarReferencia.FlatAppearance.BorderSize = 0;
            this.btn_agregarReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarReferencia.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarReferencia.ForeColor = System.Drawing.Color.White;
            this.btn_agregarReferencia.Location = new System.Drawing.Point(351, 652);
            this.btn_agregarReferencia.Name = "btn_agregarReferencia";
            this.btn_agregarReferencia.Size = new System.Drawing.Size(191, 37);
            this.btn_agregarReferencia.TabIndex = 36;
            this.btn_agregarReferencia.Text = "Agregar Referencia";
            this.btn_agregarReferencia.UseVisualStyleBackColor = false;
            this.btn_agregarReferencia.Click += new System.EventHandler(this.btn_agregarReferencia_Click);
            // 
            // lb_productosVenta
            // 
            this.lb_productosVenta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_productosVenta.FormattingEnabled = true;
            this.lb_productosVenta.ItemHeight = 28;
            this.lb_productosVenta.Location = new System.Drawing.Point(1176, 290);
            this.lb_productosVenta.Name = "lb_productosVenta";
            this.lb_productosVenta.Size = new System.Drawing.Size(513, 340);
            this.lb_productosVenta.TabIndex = 37;
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_agregarProducto.Location = new System.Drawing.Point(1176, 652);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(191, 37);
            this.btn_agregarProducto.TabIndex = 36;
            this.btn_agregarProducto.Text = "Agregar Productos";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // txt_dniColaborador
            // 
            this.txt_dniColaborador.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniColaborador.Location = new System.Drawing.Point(1466, 77);
            this.txt_dniColaborador.Name = "txt_dniColaborador";
            this.txt_dniColaborador.PlaceholderText = "Numero de Identidad...";
            this.txt_dniColaborador.Size = new System.Drawing.Size(223, 34);
            this.txt_dniColaborador.TabIndex = 40;
            // 
            // dniColaboradorLabelError
            // 
            this.dniColaboradorLabelError.AutoSize = true;
            this.dniColaboradorLabelError.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dniColaboradorLabelError.ForeColor = System.Drawing.Color.Crimson;
            this.dniColaboradorLabelError.Location = new System.Drawing.Point(1466, 114);
            this.dniColaboradorLabelError.Name = "dniColaboradorLabelError";
            this.dniColaboradorLabelError.Size = new System.Drawing.Size(129, 20);
            this.dniColaboradorLabelError.TabIndex = 39;
            this.dniColaboradorLabelError.Text = "Escribio mal su DNI";
            this.dniColaboradorLabelError.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1458, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "DNI Colaborador";
            // 
            // l_monto
            // 
            this.l_monto.AutoSize = true;
            this.l_monto.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_monto.Location = new System.Drawing.Point(1524, 243);
            this.l_monto.Name = "l_monto";
            this.l_monto.Size = new System.Drawing.Size(165, 32);
            this.l_monto.TabIndex = 42;
            this.l_monto.Text = "Lps. 000,000.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1176, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 32);
            this.label7.TabIndex = 41;
            this.label7.Text = "Resumen Venta";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(208)))), ((int)(((byte)(88)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1498, 652);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 37);
            this.button2.TabIndex = 36;
            this.button2.Text = "Terminar Venta";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // VentaCreditoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l_monto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_dniColaborador);
            this.Controls.Add(this.dniColaboradorLabelError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_productosVenta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.btn_agregarReferencia);
            this.Controls.Add(this.lb_referencias);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_dniCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "VentaCreditoView";
            this.Size = new System.Drawing.Size(1810, 760);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_dniCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lb_referencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregarReferencia;
        private System.Windows.Forms.ListBox lb_productosVenta;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.TextBox txt_dniColaborador;
        private System.Windows.Forms.Label dniColaboradorLabelError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_monto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}
