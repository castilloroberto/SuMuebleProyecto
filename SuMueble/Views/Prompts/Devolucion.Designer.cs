
namespace SuMueble.Views
{
    partial class Devolucion
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_hecho = new System.Windows.Forms.Button();
            this.txt_Observacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Motivo = new System.Windows.Forms.TextBox();
            this.txt_CodigoFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_productos = new System.Windows.Forms.ComboBox();
            this.txt_Cantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(46, 510);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(174, 37);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_hecho
            // 
            this.btn_hecho.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_hecho.FlatAppearance.BorderSize = 0;
            this.btn_hecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hecho.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_hecho.ForeColor = System.Drawing.Color.White;
            this.btn_hecho.Location = new System.Drawing.Point(418, 510);
            this.btn_hecho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_hecho.Name = "btn_hecho";
            this.btn_hecho.Size = new System.Drawing.Size(174, 37);
            this.btn_hecho.TabIndex = 25;
            this.btn_hecho.Text = "Hecho";
            this.btn_hecho.UseVisualStyleBackColor = false;
            this.btn_hecho.Click += new System.EventHandler(this.btn_hecho_Click);
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Observacion.Location = new System.Drawing.Point(53, 297);
            this.txt_Observacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Observacion.Multiline = true;
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.PlaceholderText = "Escriba Aqui...";
            this.txt_Observacion.Size = new System.Drawing.Size(233, 87);
            this.txt_Observacion.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(46, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Observaciones:";
            // 
            // txt_Motivo
            // 
            this.txt_Motivo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Motivo.Location = new System.Drawing.Point(55, 192);
            this.txt_Motivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Motivo.MaxLength = 15;
            this.txt_Motivo.Name = "txt_Motivo";
            this.txt_Motivo.PlaceholderText = "Escriba Aqui...";
            this.txt_Motivo.Size = new System.Drawing.Size(231, 34);
            this.txt_Motivo.TabIndex = 31;
            // 
            // txt_CodigoFactura
            // 
            this.txt_CodigoFactura.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CodigoFactura.Location = new System.Drawing.Point(53, 97);
            this.txt_CodigoFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CodigoFactura.MaxLength = 13;
            this.txt_CodigoFactura.Name = "txt_CodigoFactura";
            this.txt_CodigoFactura.PlaceholderText = "Escriba Aqui...";
            this.txt_CodigoFactura.ReadOnly = true;
            this.txt_CodigoFactura.Size = new System.Drawing.Size(231, 34);
            this.txt_CodigoFactura.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Motivo Devolucion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Codigo de Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(358, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(356, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cantidad:";
            // 
            // cb_productos
            // 
            this.cb_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_productos.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_productos.FormattingEnabled = true;
            this.cb_productos.Location = new System.Drawing.Point(361, 95);
            this.cb_productos.Name = "cb_productos";
            this.cb_productos.Size = new System.Drawing.Size(231, 36);
            this.cb_productos.TabIndex = 34;
            this.cb_productos.SelectionChangeCommitted += new System.EventHandler(this.cb_productos_SelectionChangeCommitted);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Cantidad.Location = new System.Drawing.Point(361, 191);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(231, 34);
            this.txt_Cantidad.TabIndex = 35;
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(647, 591);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.cb_productos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Motivo);
            this.Controls.Add(this.txt_CodigoFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Observacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_hecho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_hecho;
        private System.Windows.Forms.TextBox txt_Observacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Motivo;
        private System.Windows.Forms.TextBox txt_CodigoFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_productos;
        private System.Windows.Forms.NumericUpDown txt_Cantidad;
    }
}