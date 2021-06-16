
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregarDevolucion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_buscarCliente = new System.Windows.Forms.TextBox();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(462, 89);
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
            this.btn_agregarDevolucion.Location = new System.Drawing.Point(1261, 588);
            this.btn_agregarDevolucion.Name = "btn_agregarDevolucion";
            this.btn_agregarDevolucion.Size = new System.Drawing.Size(120, 37);
            this.btn_agregarDevolucion.TabIndex = 1;
            this.btn_agregarDevolucion.Text = "Agregar";
            this.btn_agregarDevolucion.UseVisualStyleBackColor = false;
            this.btn_agregarDevolucion.Click += new System.EventHandler(this.btn_agregarDevolucion_Click);
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
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(912, 377);
            this.dataGridView1.TabIndex = 2;
            // 
            // txt_buscarCliente
            // 
            this.txt_buscarCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscarCliente.Location = new System.Drawing.Point(469, 133);
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
            this.cb_filtro.Location = new System.Drawing.Point(1148, 131);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(234, 36);
            this.cb_filtro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1140, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar por:";
            // 
            // DevolucionesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.txt_buscarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agregarDevolucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DevolucionesView";
            this.Size = new System.Drawing.Size(1810, 760);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregarDevolucion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_buscarCliente;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.Label label2;
    }
}
