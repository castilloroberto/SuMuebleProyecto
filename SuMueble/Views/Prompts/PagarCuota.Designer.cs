
namespace SuMueble.Views
{
    partial class PagarCuota
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cuotas_pendientes = new System.Windows.Forms.TextBox();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNIColaborador = new System.Windows.Forms.TextBox();
            this.txt_monto_pendiente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.l_cliente = new System.Windows.Forms.Label();
            this.dtp_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.l_colabora = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtCuota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuota a Pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(136, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProducto.Location = new System.Drawing.Point(136, 384);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(200, 34);
            this.txtProducto.TabIndex = 3;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.White;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.Black;
            this.btn_volver.Location = new System.Drawing.Point(132, 576);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(200, 37);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(136, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(453, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cuotas Pendientes";
            // 
            // txt_cuotas_pendientes
            // 
            this.txt_cuotas_pendientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cuotas_pendientes.Location = new System.Drawing.Point(457, 389);
            this.txt_cuotas_pendientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_cuotas_pendientes.Name = "txt_cuotas_pendientes";
            this.txt_cuotas_pendientes.ReadOnly = true;
            this.txt_cuotas_pendientes.Size = new System.Drawing.Size(244, 34);
            this.txt_cuotas_pendientes.TabIndex = 8;
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirFactura.FlatAppearance.BorderSize = 0;
            this.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirFactura.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimirFactura.ForeColor = System.Drawing.Color.White;
            this.btnImprimirFactura.Location = new System.Drawing.Point(487, 576);
            this.btnImprimirFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(200, 37);
            this.btnImprimirFactura.TabIndex = 10;
            this.btnImprimirFactura.Text = "Imprimir Recibo";
            this.btnImprimirFactura.UseVisualStyleBackColor = false;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(453, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "DNI Colaborador";
            // 
            // txtDNIColaborador
            // 
            this.txtDNIColaborador.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNIColaborador.Location = new System.Drawing.Point(453, 225);
            this.txtDNIColaborador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDNIColaborador.MaxLength = 13;
            this.txtDNIColaborador.Name = "txtDNIColaborador";
            this.txtDNIColaborador.ReadOnly = true;
            this.txtDNIColaborador.Size = new System.Drawing.Size(200, 34);
            this.txtDNIColaborador.TabIndex = 11;
            // 
            // txt_monto_pendiente
            // 
            this.txt_monto_pendiente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_monto_pendiente.Location = new System.Drawing.Point(453, 498);
            this.txt_monto_pendiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_monto_pendiente.Name = "txt_monto_pendiente";
            this.txt_monto_pendiente.ReadOnly = true;
            this.txt_monto_pendiente.Size = new System.Drawing.Size(244, 34);
            this.txt_monto_pendiente.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(449, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Monto Pendiente";
            // 
            // l_cliente
            // 
            this.l_cliente.AutoSize = true;
            this.l_cliente.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_cliente.Location = new System.Drawing.Point(254, 59);
            this.l_cliente.Name = "l_cliente";
            this.l_cliente.Size = new System.Drawing.Size(172, 50);
            this.l_cliente.TabIndex = 0;
            this.l_cliente.Text = "----------";
            // 
            // dtp_fechaFin
            // 
            this.dtp_fechaFin.Enabled = false;
            this.dtp_fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaFin.Location = new System.Drawing.Point(136, 497);
            this.dtp_fechaFin.MinDate = new System.DateTime(2021, 10, 11, 0, 0, 0, 0);
            this.dtp_fechaFin.Name = "dtp_fechaFin";
            this.dtp_fechaFin.Size = new System.Drawing.Size(250, 27);
            this.dtp_fechaFin.TabIndex = 13;
            // 
            // l_colabora
            // 
            this.l_colabora.AutoSize = true;
            this.l_colabora.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_colabora.Location = new System.Drawing.Point(485, 263);
            this.l_colabora.Name = "l_colabora";
            this.l_colabora.Size = new System.Drawing.Size(134, 23);
            this.l_colabora.TabIndex = 12;
            this.l_colabora.Text = "DNI Colaborador";
            this.l_colabora.Visible = false;
            // 
            // txtCuota
            // 
            this.txtCuota.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCuota.Location = new System.Drawing.Point(136, 224);
            this.txtCuota.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(200, 34);
            this.txtCuota.TabIndex = 0;
            // 
            // PagarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_volver;
            this.ClientSize = new System.Drawing.Size(818, 708);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.dtp_fechaFin);
            this.Controls.Add(this.l_colabora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDNIColaborador);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_monto_pendiente);
            this.Controls.Add(this.txt_cuotas_pendientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_cliente);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PagarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PagarCuota";
            ((System.ComponentModel.ISupportInitialize)(this.txtCuota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cuotas_pendientes;
        private System.Windows.Forms.Button btnImprimirFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNIColaborador;
        private System.Windows.Forms.TextBox txt_monto_pendiente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_cliente;
        private System.Windows.Forms.DateTimePicker dtp_fechaFin;
        private System.Windows.Forms.Label l_colabora;

        private System.Drawing.Printing.PrintDocument printDocument1;

        private System.Windows.Forms.NumericUpDown txtCuota;

    }
}