
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_BuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_verDetalle = new System.Windows.Forms.Button();
            this.dvg_ventas = new System.Windows.Forms.DataGridView();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_BuscarCliente
            // 
            this.txt_BuscarCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_BuscarCliente.Location = new System.Drawing.Point(128, 236);
            this.txt_BuscarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_BuscarCliente.Name = "txt_BuscarCliente";
            this.txt_BuscarCliente.PlaceholderText = "Nombre del Cliente...";
            this.txt_BuscarCliente.Size = new System.Drawing.Size(234, 34);
            this.txt_BuscarCliente.TabIndex = 0;
            this.txt_BuscarCliente.TextChanged += new System.EventHandler(this.txt_BuscarCliente_TextChanged);
            this.txt_BuscarCliente.Leave += new System.EventHandler(this.txt_BuscarCliente_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
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
            this.btn_verDetalle.Location = new System.Drawing.Point(1351, 704);
            this.btn_verDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_verDetalle.Name = "btn_verDetalle";
            this.btn_verDetalle.Size = new System.Drawing.Size(134, 37);
            this.btn_verDetalle.TabIndex = 3;
            this.btn_verDetalle.Text = "Ver Detalles";
            this.btn_verDetalle.UseVisualStyleBackColor = false;
            this.btn_verDetalle.Visible = false;
            this.btn_verDetalle.Click += new System.EventHandler(this.btn_verDetalle_Click);
            // 
            // dvg_ventas
            // 
            this.dvg_ventas.AllowUserToAddRows = false;
            this.dvg_ventas.AllowUserToDeleteRows = false;
            this.dvg_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_ventas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvg_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_ventas.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_ventas.Location = new System.Drawing.Point(121, 297);
            this.dvg_ventas.Name = "dvg_ventas";
            this.dvg_ventas.ReadOnly = true;
            this.dvg_ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvg_ventas.RowHeadersWidth = 51;
            this.dvg_ventas.Size = new System.Drawing.Size(1364, 377);
            this.dvg_ventas.TabIndex = 4;
            // 
            // cb_filtro
            // 
            this.cb_filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_filtro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Simple",
            "Detalles"});
            this.cb_filtro.Location = new System.Drawing.Point(1250, 236);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(235, 36);
            this.cb_filtro.TabIndex = 6;
            this.cb_filtro.SelectionChangeCommitted += new System.EventHandler(this.cb_filtro_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1242, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar por:";
            // 
            // HistorialVentasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvg_ventas);
            this.Controls.Add(this.btn_verDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BuscarCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HistorialVentasView";
            this.Size = new System.Drawing.Size(1517, 760);
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
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn CodigoF;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
