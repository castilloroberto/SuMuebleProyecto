
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
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_dniCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rtnCliente = new System.Windows.Forms.TextBox();
            this.lb_referencias = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregarReferencia = new System.Windows.Forms.Button();
            this.lb_productosVenta = new System.Windows.Forms.ListBox();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.l_monto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_terminarVenta = new System.Windows.Forms.Button();
            this.labelClienteNuevo = new System.Windows.Forms.Label();
            this.l_NombreCliente = new System.Windows.Forms.Label();
            this.l_TelefonoCliente = new System.Windows.Forms.Label();
            this.l_RTNCliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dirCliente = new System.Windows.Forms.TextBox();
            this.l_dir = new System.Windows.Forms.Label();
            this.btn_quitarItem = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefonoCliente.Location = new System.Drawing.Point(802, 231);
            this.txtTelefonoCliente.MaxLength = 8;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.PlaceholderText = "Escriba Aqui...";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(223, 34);
            this.txtTelefonoCliente.TabIndex = 34;
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCliente_KeyPress);
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombreCliente.Location = new System.Drawing.Point(428, 231);
            this.txt_nombreCliente.MaxLength = 200;
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.PlaceholderText = "Nombre y Apellidos...";
            this.txt_nombreCliente.Size = new System.Drawing.Size(325, 34);
            this.txt_nombreCliente.TabIndex = 33;
            this.txt_nombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreCliente_KeyPress);
            this.txt_nombreCliente.Leave += new System.EventHandler(this.txt_nombreCliente_Leave);
            // 
            // txt_dniCliente
            // 
            this.txt_dniCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniCliente.Location = new System.Drawing.Point(166, 231);
            this.txt_dniCliente.MaxLength = 13;
            this.txt_dniCliente.Name = "txt_dniCliente";
            this.txt_dniCliente.PlaceholderText = "Numero de Identidad...";
            this.txt_dniCliente.Size = new System.Drawing.Size(223, 34);
            this.txt_dniCliente.TabIndex = 32;
            this.txt_dniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dniCliente_KeyPress);
            this.txt_dniCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dniCliente_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(802, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Teléfono Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(425, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(160, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "DNI Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(166, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "RTN Cliente";
            // 
            // txt_rtnCliente
            // 
            this.txt_rtnCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_rtnCliente.Location = new System.Drawing.Point(166, 345);
            this.txt_rtnCliente.MaxLength = 14;
            this.txt_rtnCliente.Name = "txt_rtnCliente";
            this.txt_rtnCliente.PlaceholderText = "Registro Tributario Nacional...";
            this.txt_rtnCliente.Size = new System.Drawing.Size(223, 34);
            this.txt_rtnCliente.TabIndex = 32;
            this.txt_rtnCliente.Leave += new System.EventHandler(this.txt_rtnCliente_Leave);
            // 
            // lb_referencias
            // 
            this.lb_referencias.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_referencias.FormattingEnabled = true;
            this.lb_referencias.ItemHeight = 28;
            this.lb_referencias.Location = new System.Drawing.Point(166, 465);
            this.lb_referencias.Name = "lb_referencias";
            this.lb_referencias.Size = new System.Drawing.Size(513, 312);
            this.lb_referencias.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 32);
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
            this.btn_agregarReferencia.Location = new System.Drawing.Point(165, 822);
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
            this.lb_productosVenta.Location = new System.Drawing.Point(913, 465);
            this.lb_productosVenta.Name = "lb_productosVenta";
            this.lb_productosVenta.Size = new System.Drawing.Size(513, 312);
            this.lb_productosVenta.TabIndex = 37;
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_agregarProducto.Location = new System.Drawing.Point(913, 826);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(191, 37);
            this.btn_agregarProducto.TabIndex = 36;
            this.btn_agregarProducto.Text = "Agregar Productos";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // l_monto
            // 
            this.l_monto.AutoSize = true;
            this.l_monto.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_monto.Location = new System.Drawing.Point(1262, 417);
            this.l_monto.Name = "l_monto";
            this.l_monto.Size = new System.Drawing.Size(165, 32);
            this.l_monto.TabIndex = 42;
            this.l_monto.Text = "Lps. 000,000.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(913, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 32);
            this.label7.TabIndex = 41;
            this.label7.Text = "Resumen Venta";
            // 
            // btn_terminarVenta
            // 
            this.btn_terminarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(208)))), ((int)(((byte)(88)))));
            this.btn_terminarVenta.FlatAppearance.BorderSize = 0;
            this.btn_terminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terminarVenta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_terminarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_terminarVenta.Location = new System.Drawing.Point(1235, 826);
            this.btn_terminarVenta.Name = "btn_terminarVenta";
            this.btn_terminarVenta.Size = new System.Drawing.Size(191, 37);
            this.btn_terminarVenta.TabIndex = 36;
            this.btn_terminarVenta.Text = "Terminar Venta";
            this.btn_terminarVenta.UseVisualStyleBackColor = false;
            this.btn_terminarVenta.Click += new System.EventHandler(this.btn_terminarVenta_Click);
            // 
            // labelClienteNuevo
            // 
            this.labelClienteNuevo.AutoSize = true;
            this.labelClienteNuevo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClienteNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.labelClienteNuevo.Location = new System.Drawing.Point(166, 273);
            this.labelClienteNuevo.Name = "labelClienteNuevo";
            this.labelClienteNuevo.Size = new System.Drawing.Size(98, 20);
            this.labelClienteNuevo.TabIndex = 43;
            this.labelClienteNuevo.Text = "Cliente Nuevo";
            this.labelClienteNuevo.Visible = false;
            // 
            // l_NombreCliente
            // 
            this.l_NombreCliente.AutoSize = true;
            this.l_NombreCliente.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_NombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.l_NombreCliente.Location = new System.Drawing.Point(428, 273);
            this.l_NombreCliente.Name = "l_NombreCliente";
            this.l_NombreCliente.Size = new System.Drawing.Size(66, 20);
            this.l_NombreCliente.TabIndex = 44;
            this.l_NombreCliente.Text = "Ingresar...";
            this.l_NombreCliente.Visible = false;
            // 
            // l_TelefonoCliente
            // 
            this.l_TelefonoCliente.AutoSize = true;
            this.l_TelefonoCliente.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_TelefonoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.l_TelefonoCliente.Location = new System.Drawing.Point(802, 272);
            this.l_TelefonoCliente.Name = "l_TelefonoCliente";
            this.l_TelefonoCliente.Size = new System.Drawing.Size(66, 20);
            this.l_TelefonoCliente.TabIndex = 45;
            this.l_TelefonoCliente.Text = "Ingresar...";
            this.l_TelefonoCliente.Visible = false;
            // 
            // l_RTNCliente
            // 
            this.l_RTNCliente.AutoSize = true;
            this.l_RTNCliente.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_RTNCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.l_RTNCliente.Location = new System.Drawing.Point(166, 386);
            this.l_RTNCliente.Name = "l_RTNCliente";
            this.l_RTNCliente.Size = new System.Drawing.Size(66, 20);
            this.l_RTNCliente.TabIndex = 46;
            this.l_RTNCliente.Text = "Ingresar...";
            this.l_RTNCliente.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(425, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "Dirección";
            // 
            // txt_dirCliente
            // 
            this.txt_dirCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dirCliente.Location = new System.Drawing.Point(428, 346);
            this.txt_dirCliente.MaxLength = 255;
            this.txt_dirCliente.Multiline = true;
            this.txt_dirCliente.Name = "txt_dirCliente";
            this.txt_dirCliente.PlaceholderText = "Ciudad, colonia, referencias...";
            this.txt_dirCliente.Size = new System.Drawing.Size(325, 33);
            this.txt_dirCliente.TabIndex = 33;
            this.txt_dirCliente.Leave += new System.EventHandler(this.txt_dirCliente_Leave);
            // 
            // l_dir
            // 
            this.l_dir.AutoSize = true;
            this.l_dir.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_dir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.l_dir.Location = new System.Drawing.Point(428, 386);
            this.l_dir.Name = "l_dir";
            this.l_dir.Size = new System.Drawing.Size(66, 20);
            this.l_dir.TabIndex = 45;
            this.l_dir.Text = "Ingresar...";
            this.l_dir.Visible = false;
            // 
            // btn_quitarItem
            // 
            this.btn_quitarItem.BackColor = System.Drawing.Color.Crimson;
            this.btn_quitarItem.FlatAppearance.BorderSize = 0;
            this.btn_quitarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitarItem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_quitarItem.ForeColor = System.Drawing.Color.White;
            this.btn_quitarItem.Location = new System.Drawing.Point(550, 821);
            this.btn_quitarItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_quitarItem.Name = "btn_quitarItem";
            this.btn_quitarItem.Size = new System.Drawing.Size(129, 38);
            this.btn_quitarItem.TabIndex = 47;
            this.btn_quitarItem.Text = "Quitar Ítem";
            this.btn_quitarItem.UseVisualStyleBackColor = false;
            this.btn_quitarItem.Click += new System.EventHandler(this.btn_quitarItem_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ayuda.Location = new System.Drawing.Point(1313, 35);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(94, 29);
            this.btn_ayuda.TabIndex = 48;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // VentaCreditoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_quitarItem);
            this.Controls.Add(this.l_RTNCliente);
            this.Controls.Add(this.l_dir);
            this.Controls.Add(this.l_TelefonoCliente);
            this.Controls.Add(this.l_NombreCliente);
            this.Controls.Add(this.labelClienteNuevo);
            this.Controls.Add(this.l_monto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_productosVenta);
            this.Controls.Add(this.btn_terminarVenta);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.btn_agregarReferencia);
            this.Controls.Add(this.lb_referencias);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.txt_dirCliente);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.txt_rtnCliente);
            this.Controls.Add(this.txt_dniCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "VentaCreditoView";
            this.Size = new System.Drawing.Size(1439, 957);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_dniCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rtnCliente;
        private System.Windows.Forms.ListBox lb_referencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregarReferencia;
        private System.Windows.Forms.ListBox lb_productosVenta;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.Label l_monto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_terminarVenta;
        private System.Windows.Forms.Label labelClienteNuevo;
        private System.Windows.Forms.Label l_NombreCliente;
        private System.Windows.Forms.Label l_TelefonoCliente;
        private System.Windows.Forms.Label l_RTNCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dirCliente;
        private System.Windows.Forms.Label l_dir;
        private System.Windows.Forms.Button btn_quitarItem;
        private System.Windows.Forms.Button btn_ayuda;
    }
}
