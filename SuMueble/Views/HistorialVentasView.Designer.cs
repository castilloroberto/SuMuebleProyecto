
namespace SuMueble.Views
{
    partial class HistorialVentasView
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
            this.txt_BuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_verDetalle = new System.Windows.Forms.Button();
            this.dvg_ventas = new System.Windows.Forms.DataGridView();
            this.CodigoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_BuscarCliente
            // 
            this.txt_BuscarCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_BuscarCliente.Location = new System.Drawing.Point(234, 332);
            this.txt_BuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BuscarCliente.Name = "txt_BuscarCliente";
            this.txt_BuscarCliente.PlaceholderText = "Nombre del Cliente...";
            this.txt_BuscarCliente.Size = new System.Drawing.Size(292, 39);
            this.txt_BuscarCliente.TabIndex = 0;
            this.txt_BuscarCliente.TextChanged += new System.EventHandler(this.txt_BuscarCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(225, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Cliente:";
            // 
            // btn_verDetalle
            // 
            this.btn_verDetalle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_verDetalle.FlatAppearance.BorderSize = 0;
            this.btn_verDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verDetalle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verDetalle.ForeColor = System.Drawing.Color.White;
            this.btn_verDetalle.Location = new System.Drawing.Point(1385, 896);
            this.btn_verDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_verDetalle.Name = "btn_verDetalle";
            this.btn_verDetalle.Size = new System.Drawing.Size(168, 46);
            this.btn_verDetalle.TabIndex = 3;
            this.btn_verDetalle.Text = "Ver Detalles";
            this.btn_verDetalle.UseVisualStyleBackColor = false;
            this.btn_verDetalle.Click += new System.EventHandler(this.btn_verDetalle_Click);
            // 
            // dvg_ventas
            // 
            this.dvg_ventas.AllowUserToAddRows = false;
            this.dvg_ventas.AllowUserToDeleteRows = false;
            this.dvg_ventas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvg_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoF,
            this.Column5,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column1});
            this.dvg_ventas.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_ventas.Location = new System.Drawing.Point(234, 416);
            this.dvg_ventas.Margin = new System.Windows.Forms.Padding(4);
            this.dvg_ventas.Name = "dvg_ventas";
            this.dvg_ventas.ReadOnly = true;
            this.dvg_ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvg_ventas.RowHeadersWidth = 51;
            this.dvg_ventas.Size = new System.Drawing.Size(1319, 471);
            this.dvg_ventas.TabIndex = 4;
            // 
            // CodigoF
            // 
            this.CodigoF.DataPropertyName = "CodigoFactura";
            this.CodigoF.HeaderText = "CodigoFactura";
            this.CodigoF.MinimumWidth = 8;
            this.CodigoF.Name = "CodigoF";
            this.CodigoF.ReadOnly = true;
            this.CodigoF.Width = 141;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TipoVenta";
            this.Column5.HeaderText = "TipoVenta";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 141;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TotalVenta";
            this.Column8.HeaderText = "Total";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 141;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NombreCliente";
            this.Column2.HeaderText = "NombreCliente";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 141;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FechaInicio";
            this.Column3.HeaderText = "FechaInicio";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FechaFin";
            this.Column4.HeaderText = "FechaFin";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 141;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Prima";
            this.Column6.HeaderText = "Prima";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 141;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Cuotas";
            this.Column7.HeaderText = "Cuotas";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 141;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Colaborador";
            this.Column1.HeaderText = "Colaborador";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 141;
            // 
            // HistorialVentasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvg_ventas);
            this.Controls.Add(this.btn_verDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BuscarCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HistorialVentasView";
            this.Size = new System.Drawing.Size(1715, 950);
            this.Load += new System.EventHandler(this.HistorialVentasView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_verDetalle;
        private System.Windows.Forms.DataGridView dvg_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
