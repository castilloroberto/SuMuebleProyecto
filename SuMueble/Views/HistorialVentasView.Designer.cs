
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_verDetalle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(469, 133);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "DNI del Cliente o Nombre...";
            this.textBox1.Size = new System.Drawing.Size(234, 34);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(462, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Cliente:";
            // 
            // btn_verDetalle
            // 
            this.btn_verDetalle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_verDetalle.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btn_verDetalle.FlatAppearance.BorderSize = 0;
            this.btn_verDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btn_verDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_verDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verDetalle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verDetalle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_verDetalle.Location = new System.Drawing.Point(467, 590);
            this.btn_verDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_verDetalle.Name = "btn_verDetalle";
            this.btn_verDetalle.Size = new System.Drawing.Size(134, 37);
            this.btn_verDetalle.TabIndex = 3;
            this.btn_verDetalle.Text = "Ver Detalles";
            this.btn_verDetalle.UseVisualStyleBackColor = false;
            this.btn_verDetalle.Click += new System.EventHandler(this.btn_verDetalle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(469, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(912, 377);
            this.dataGridView1.TabIndex = 4;
            // 
            // HistorialVentasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_verDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HistorialVentasView";
            this.Size = new System.Drawing.Size(1810, 760);
            this.Load += new System.EventHandler(this.HistorialVentasView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_verDetalle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
