
namespace SuMueble.Views.Prompts
{
    partial class TerminarVentaCredito
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
            this.dtp_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_terminarVenta = new System.Windows.Forms.Button();
            this.txt_cuotas = new System.Windows.Forms.NumericUpDown();
            this.txt_prima = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prima)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_fechaFin
            // 
            this.dtp_fechaFin.CalendarFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_fechaFin.Location = new System.Drawing.Point(375, 108);
            this.dtp_fechaFin.Name = "dtp_fechaFin";
            this.dtp_fechaFin.Size = new System.Drawing.Size(250, 27);
            this.dtp_fechaFin.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(370, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 32);
            this.label7.TabIndex = 42;
            this.label7.Text = "Fecha Vencimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(61, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 28);
            this.label8.TabIndex = 43;
            this.label8.Text = "Prima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Numero de Cuotas";
            // 
            // btn_terminarVenta
            // 
            this.btn_terminarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(208)))), ((int)(((byte)(88)))));
            this.btn_terminarVenta.FlatAppearance.BorderSize = 0;
            this.btn_terminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terminarVenta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_terminarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_terminarVenta.Location = new System.Drawing.Point(375, 220);
            this.btn_terminarVenta.Name = "btn_terminarVenta";
            this.btn_terminarVenta.Size = new System.Drawing.Size(250, 37);
            this.btn_terminarVenta.TabIndex = 47;
            this.btn_terminarVenta.Text = "Terminar Venta";
            this.btn_terminarVenta.UseVisualStyleBackColor = false;
            this.btn_terminarVenta.Click += new System.EventHandler(this.btn_terminarVenta_Click);
            // 
            // txt_cuotas
            // 
            this.txt_cuotas.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cuotas.Location = new System.Drawing.Point(64, 108);
            this.txt_cuotas.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txt_cuotas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_cuotas.Name = "txt_cuotas";
            this.txt_cuotas.Size = new System.Drawing.Size(208, 34);
            this.txt_cuotas.TabIndex = 48;
            this.txt_cuotas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txt_prima
            // 
            this.txt_prima.DecimalPlaces = 2;
            this.txt_prima.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_prima.Location = new System.Drawing.Point(64, 223);
            this.txt_prima.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_prima.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_prima.Name = "txt_prima";
            this.txt_prima.Size = new System.Drawing.Size(208, 34);
            this.txt_prima.TabIndex = 48;
            this.txt_prima.ThousandsSeparator = true;
            this.txt_prima.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // TerminarVentaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 365);
            this.Controls.Add(this.txt_prima);
            this.Controls.Add(this.txt_cuotas);
            this.Controls.Add(this.btn_terminarVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_fechaFin);
            this.Name = "TerminarVentaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TerminarVentaCredito";
            ((System.ComponentModel.ISupportInitialize)(this.txt_cuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_fechaFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_terminarVenta;
        private System.Windows.Forms.NumericUpDown txt_cuotas;
        private System.Windows.Forms.NumericUpDown txt_prima;
    }
}