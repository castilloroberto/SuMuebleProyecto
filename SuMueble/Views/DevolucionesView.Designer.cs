
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregarDevolucion = new System.Windows.Forms.Button();
            this.txt_buscarCliente = new System.Windows.Forms.TextBox();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvg_devoluciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_devoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 201);
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
            this.btn_agregarDevolucion.Location = new System.Drawing.Point(1365, 701);
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
            this.txt_buscarCliente.Location = new System.Drawing.Point(121, 247);
            this.txt_buscarCliente.Name = "txt_buscarCliente";
            this.txt_buscarCliente.PlaceholderText = "Nombre del Cliente...";
            this.txt_buscarCliente.Size = new System.Drawing.Size(235, 34);
            this.txt_buscarCliente.TabIndex = 3;
            this.txt_buscarCliente.TextChanged += new System.EventHandler(this.txt_buscarCliente_TextChanged_1);
            this.txt_buscarCliente.Leave += new System.EventHandler(this.txt_buscarCliente_Leave);
            // 
            // cb_filtro
            // 
            this.cb_filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_filtro.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Todo",
            "Al Credito",
            "Al Contado"});
            this.cb_filtro.Location = new System.Drawing.Point(1250, 245);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(235, 36);
            this.cb_filtro.TabIndex = 4;
            this.cb_filtro.SelectedIndexChanged += new System.EventHandler(this.cb_filtro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1242, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar por:";
            // 
            // dvg_devoluciones
            // 
            this.dvg_devoluciones.AllowUserToAddRows = false;
            this.dvg_devoluciones.AllowUserToDeleteRows = false;
            this.dvg_devoluciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvg_devoluciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_devoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_devoluciones.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_devoluciones.Location = new System.Drawing.Point(121, 297);
            this.dvg_devoluciones.Name = "dvg_devoluciones";
            this.dvg_devoluciones.ReadOnly = true;
            this.dvg_devoluciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvg_devoluciones.RowHeadersWidth = 51;
            this.dvg_devoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_devoluciones.Size = new System.Drawing.Size(1364, 377);
            this.dvg_devoluciones.TabIndex = 5;
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
        //private System.Windows.Forms.DataGridViewTextBoxColumn CodigoF;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        //private System.Windows.Forms.DataGridView dataGridView1;
    }
}
