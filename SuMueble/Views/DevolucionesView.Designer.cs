
namespace SuMueble.Views
{
    partial class DevolucionesView
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregarDevolucion = new System.Windows.Forms.Button();
            this.txt_buscarCliente = new System.Windows.Forms.TextBox();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvg_devoluciones = new System.Windows.Forms.DataGridView();
            this.CodigoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_devoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Cliente:";
            // 
            // btn_agregarDevolucion
            // 
            this.btn_agregarDevolucion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarDevolucion.FlatAppearance.BorderSize = 0;
            this.btn_agregarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarDevolucion.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarDevolucion.ForeColor = System.Drawing.Color.White;
            this.btn_agregarDevolucion.Location = new System.Drawing.Point(1285, 695);
            this.btn_agregarDevolucion.Name = "btn_agregarDevolucion";
            this.btn_agregarDevolucion.Size = new System.Drawing.Size(120, 37);
            this.btn_agregarDevolucion.TabIndex = 1;
            this.btn_agregarDevolucion.Text = "Agregar";
            this.btn_agregarDevolucion.UseVisualStyleBackColor = false;
            this.btn_agregarDevolucion.Click += new System.EventHandler(this.btn_agregarDevolucion_Click);
            // 
            // txt_buscarCliente
            // 
            this.txt_buscarCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscarCliente.Location = new System.Drawing.Point(122, 246);
            this.txt_buscarCliente.Name = "txt_buscarCliente";
            this.txt_buscarCliente.PlaceholderText = "DNI del Cliente o Nombre...";
            this.txt_buscarCliente.Size = new System.Drawing.Size(234, 34);
            this.txt_buscarCliente.TabIndex = 3;
            // 
            // cb_filtro
            // 
            this.cb_filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_filtro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Location = new System.Drawing.Point(1171, 246);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(234, 36);
            this.cb_filtro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1163, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar por:";
            // 
            // dvg_devoluciones
            // 
            this.dvg_devoluciones.AllowUserToAddRows = false;
            this.dvg_devoluciones.AllowUserToDeleteRows = false;
            this.dvg_devoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_devoluciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvg_devoluciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_devoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_devoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoF,
            this.Column5,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column1});
            this.dvg_devoluciones.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_devoluciones.Location = new System.Drawing.Point(122, 298);
            this.dvg_devoluciones.Name = "dvg_devoluciones";
            this.dvg_devoluciones.ReadOnly = true;
            this.dvg_devoluciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvg_devoluciones.RowHeadersWidth = 51;
            this.dvg_devoluciones.Size = new System.Drawing.Size(1283, 377);
            this.dvg_devoluciones.TabIndex = 5;
            // 
            // CodigoF
            // 
            this.CodigoF.DataPropertyName = "CodigoFactura";
            this.CodigoF.HeaderText = "Codigo Factura";
            this.CodigoF.MinimumWidth = 8;
            this.CodigoF.Name = "CodigoF";
            this.CodigoF.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TipoVenta";
            this.Column5.HeaderText = "Tipo venta";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TotalVenta";
            this.Column8.HeaderText = "Total";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NombreCliente";
            this.Column2.HeaderText = "Nombre Cliente";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FechaInicio";
            this.Column3.HeaderText = "Fecha Inicio";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FechaFin";
            this.Column4.HeaderText = "Fecha Fin";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Prima";
            this.Column6.HeaderText = "Prima";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Cuotas";
            this.Column7.HeaderText = "Cuotas";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Colaborador";
            this.Column1.HeaderText = "Colaborador";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // DevolucionesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvg_devoluciones);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.txt_buscarCliente);
            this.Controls.Add(this.btn_agregarDevolucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DevolucionesView";
            this.Size = new System.Drawing.Size(1517, 760);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_devoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregarDevolucion;
        private System.Windows.Forms.TextBox txt_buscarCliente;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvg_devoluciones;
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
