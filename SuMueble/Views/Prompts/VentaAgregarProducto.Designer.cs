
namespace SuMueble.Views.Prompts
{
    partial class VentaAgregarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_buscarProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.txt_descuento = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_agregarProducto.Location = new System.Drawing.Point(701, 602);
            this.btn_agregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(191, 38);
            this.btn_agregarProducto.TabIndex = 36;
            this.btn_agregarProducto.Text = "Agregar a la Venta";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(664, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 33;
            this.label9.Text = "Precio Producto";
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscarProducto.Location = new System.Drawing.Point(37, 62);
            this.txt_buscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.PlaceholderText = "Nombre o Codigo de Producto...";
            this.txt_buscarProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_buscarProducto.TabIndex = 38;
            this.txt_buscarProducto.TextChanged += new System.EventHandler(this.txt_buscarProducto_TextChanged);
            this.txt_buscarProducto.Leave += new System.EventHandler(this.txt_buscarProducto_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 37;
            this.label7.Text = "Buscar Producto";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(37, 602);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(191, 38);
            this.btn_cancelar.TabIndex = 36;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_productos.Location = new System.Drawing.Point(34, 106);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 29;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(857, 404);
            this.dgv_productos.TabIndex = 39;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // txt_descuento
            // 
            this.txt_descuento.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_descuento.Location = new System.Drawing.Point(338, 543);
            this.txt_descuento.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(223, 34);
            this.txt_descuento.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(567, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(334, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "Descuento";
            // 
            // txt_precio
            // 
            this.txt_precio.DecimalPlaces = 2;
            this.txt_precio.Enabled = false;
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_precio.Location = new System.Drawing.Point(668, 543);
            this.txt_precio.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(223, 34);
            this.txt_precio.TabIndex = 44;
            this.txt_precio.ThousandsSeparator = true;
            // 
            // VentaAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(933, 682);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentaAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VentaAgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_buscarProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dgv_productos;
        //private System.Windows.Forms.DataGridViewTextBoxColumn id;
        //private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        //private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        //private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        //private System.Windows.Forms.DataGridViewTextBoxColumn existencias;
        private System.Windows.Forms.NumericUpDown txt_descuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_precio;
    }
}