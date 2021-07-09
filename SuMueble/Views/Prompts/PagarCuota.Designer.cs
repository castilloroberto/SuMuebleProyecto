
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
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNIColaborador = new System.Windows.Forms.TextBox();
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
            // txtCuota
            // 
            this.txtCuota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCuota.Location = new System.Drawing.Point(132, 225);
            this.txtCuota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(200, 34);
            this.txtCuota.TabIndex = 1;
            this.txtCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuota_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProducto.Location = new System.Drawing.Point(132, 348);
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
            this.label4.Location = new System.Drawing.Point(132, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "ProductoID";
            // 
            // txtProductoID
            // 
            this.txtProductoID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductoID.Location = new System.Drawing.Point(132, 462);
            this.txtProductoID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.ReadOnly = true;
            this.txtProductoID.Size = new System.Drawing.Size(200, 34);
            this.txtProductoID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(449, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pendiente Despues del Pago";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(453, 353);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(244, 34);
            this.textBox4.TabIndex = 8;
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
            this.btnImprimirFactura.Text = "Imprimir Factura";
            this.btnImprimirFactura.UseVisualStyleBackColor = false;
            this.btnImprimirFactura.Click += new System.EventHandler(this.button1_Click);
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
            this.txtDNIColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNIColaborador.Location = new System.Drawing.Point(453, 225);
            this.txtDNIColaborador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDNIColaborador.MaxLength = 13;
            this.txtDNIColaborador.Name = "txtDNIColaborador";
            this.txtDNIColaborador.Size = new System.Drawing.Size(200, 34);
            this.txtDNIColaborador.TabIndex = 11;
            this.txtDNIColaborador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNIColaborador_KeyPress);
            // 
            // PagarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_volver;
            this.ClientSize = new System.Drawing.Size(818, 708);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDNIColaborador);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductoID);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PagarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PagarCuota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnImprimirFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNIColaborador;
    }
}