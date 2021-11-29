
namespace SuMueble.Views
{
    partial class Reportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_reporte = new System.Windows.Forms.DataGridView();
            this.cb_reporte = new System.Windows.Forms.ComboBox();
            this.btn_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes";
            // 
            // dgv_reporte
            // 
            this.dgv_reporte.AllowUserToAddRows = false;
            this.dgv_reporte.AllowUserToDeleteRows = false;
            this.dgv_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporte.Location = new System.Drawing.Point(180, 251);
            this.dgv_reporte.Name = "dgv_reporte";
            this.dgv_reporte.ReadOnly = true;
            this.dgv_reporte.RowHeadersWidth = 51;
            this.dgv_reporte.RowTemplate.Height = 29;
            this.dgv_reporte.Size = new System.Drawing.Size(1192, 427);
            this.dgv_reporte.TabIndex = 1;
            // 
            // cb_reporte
            // 
            this.cb_reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_reporte.FormattingEnabled = true;
            this.cb_reporte.Items.AddRange(new object[] {
            "Colaboradores",
            "Clientes",
            "Inventario",
            "Devoluciones",
            "Ventas"});
            this.cb_reporte.Location = new System.Drawing.Point(1221, 203);
            this.cb_reporte.Name = "cb_reporte";
            this.cb_reporte.Size = new System.Drawing.Size(151, 28);
            this.cb_reporte.TabIndex = 2;
            this.cb_reporte.SelectionChangeCommitted += new System.EventHandler(this.cb_reporte_SelectionChangeCommitted);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(1221, 705);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(151, 29);
            this.btn_exportar.TabIndex = 3;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.cb_reporte);
            this.Controls.Add(this.dgv_reporte);
            this.Controls.Add(this.label1);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(1523, 917);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_reporte;
        private System.Windows.Forms.ComboBox cb_reporte;
        private System.Windows.Forms.Button btn_exportar;
    }
}
