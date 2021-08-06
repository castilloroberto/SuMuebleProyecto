
namespace SuMueble.Views.Prompts
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.header_panel = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Label();
            this.cajero = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.cod_factura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botton_panel = new System.Windows.Forms.Panel();
            this.camcelar = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.dgv_factura = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.header_panel.SuspendLayout();
            this.botton_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factura)).BeginInit();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.hora);
            this.header_panel.Controls.Add(this.cajero);
            this.header_panel.Controls.Add(this.fecha);
            this.header_panel.Controls.Add(this.cod_factura);
            this.header_panel.Controls.Add(this.label4);
            this.header_panel.Controls.Add(this.label3);
            this.header_panel.Controls.Add(this.label2);
            this.header_panel.Controls.Add(this.label1);
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(449, 384);
            this.header_panel.TabIndex = 2;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hora.Location = new System.Drawing.Point(278, 286);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(51, 23);
            this.hora.TabIndex = 1;
            this.hora.Text = "Hora:";
            this.hora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cajero
            // 
            this.cajero.AutoSize = true;
            this.cajero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cajero.Location = new System.Drawing.Point(37, 342);
            this.cajero.Name = "cajero";
            this.cajero.Size = new System.Drawing.Size(63, 23);
            this.cajero.TabIndex = 2;
            this.cajero.Text = "Cajero:";
            this.cajero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fecha.Location = new System.Drawing.Point(37, 286);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(58, 23);
            this.fecha.TabIndex = 3;
            this.fecha.Text = "Fecha:";
            this.fecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cod_factura
            // 
            this.cod_factura.AutoSize = true;
            this.cod_factura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cod_factura.Location = new System.Drawing.Point(149, 236);
            this.cod_factura.Name = "cod_factura";
            this.cod_factura.Size = new System.Drawing.Size(113, 23);
            this.cod_factura.TabIndex = 4;
            this.cod_factura.Text = "Factura Nº : 0";
            this.cod_factura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(149, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tel: 9777-1860";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(122, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "sumueble@gmail.com";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 69);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danlí, El Paraíso, Col. Las Brisas,\r\nfrente al parque del amor, \r\ncontiguo al Ins" +
    "tituto Departamental de Oriente.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Su Mueble";
            // 
            // botton_panel
            // 
            this.botton_panel.Controls.Add(this.camcelar);
            this.botton_panel.Controls.Add(this.imprimir);
            this.botton_panel.Controls.Add(this.total);
            this.botton_panel.Location = new System.Drawing.Point(0, 738);
            this.botton_panel.Name = "botton_panel";
            this.botton_panel.Size = new System.Drawing.Size(449, 127);
            this.botton_panel.TabIndex = 3;
            // 
            // camcelar
            // 
            this.camcelar.Location = new System.Drawing.Point(12, 86);
            this.camcelar.Name = "camcelar";
            this.camcelar.Size = new System.Drawing.Size(94, 29);
            this.camcelar.TabIndex = 2;
            this.camcelar.Text = "Cancelar";
            this.camcelar.UseVisualStyleBackColor = true;
            // 
            // imprimir
            // 
            this.imprimir.Location = new System.Drawing.Point(317, 86);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(94, 29);
            this.imprimir.TabIndex = 2;
            this.imprimir.Text = "imprimir";
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total.Location = new System.Drawing.Point(250, 16);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(50, 23);
            this.total.TabIndex = 1;
            this.total.Text = "Total:";
            this.total.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.dgv_factura);
            this.main_panel.Controls.Add(this.label6);
            this.main_panel.Location = new System.Drawing.Point(0, 384);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(449, 317);
            this.main_panel.TabIndex = 4;
            // 
            // dgv_factura
            // 
            this.dgv_factura.AllowUserToAddRows = false;
            this.dgv_factura.AllowUserToDeleteRows = false;
            this.dgv_factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_factura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_factura.BackgroundColor = System.Drawing.Color.White;
            this.dgv_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_factura.GridColor = System.Drawing.Color.White;
            this.dgv_factura.Location = new System.Drawing.Point(37, 58);
            this.dgv_factura.Name = "dgv_factura";
            this.dgv_factura.ReadOnly = true;
            this.dgv_factura.RowHeadersWidth = 51;
            this.dgv_factura.RowTemplate.Height = 29;
            this.dgv_factura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_factura.Size = new System.Drawing.Size(374, 239);
            this.dgv_factura.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Cantidad";
            this.Column1.HeaderText = "Cant.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Producto";
            this.Column2.HeaderText = "Descripcion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PrecioVenta";
            this.Column3.HeaderText = "Valor";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(122, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Datos del Cliente";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.camcelar;
            this.ClientSize = new System.Drawing.Size(449, 865);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.botton_panel);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Activated += new System.EventHandler(this.Factura_Activated);
            this.Load += new System.EventHandler(this.Factura_Load);
            this.Shown += new System.EventHandler(this.Factura_Shown);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.botton_panel.ResumeLayout(false);
            this.botton_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label cajero;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label cod_factura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel botton_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.DataGridView dgv_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Button camcelar;
    }
}