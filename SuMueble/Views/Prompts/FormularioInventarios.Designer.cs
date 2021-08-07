
namespace SuMueble
{
    partial class FormularioInventarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Hecho = new System.Windows.Forms.Button();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_impuesto = new System.Windows.Forms.NumericUpDown();
            this.txt_Precio = new System.Windows.Forms.NumericUpDown();
            this.txt_Existencia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_impuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Existencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(382, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(382, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría";
            // 
            // btn_Hecho
            // 
            this.btn_Hecho.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Hecho.FlatAppearance.BorderSize = 0;
            this.btn_Hecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hecho.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Hecho.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Hecho.Location = new System.Drawing.Point(501, 421);
            this.btn_Hecho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Hecho.Name = "btn_Hecho";
            this.btn_Hecho.Size = new System.Drawing.Size(150, 37);
            this.btn_Hecho.TabIndex = 6;
            this.btn_Hecho.Text = "Hecho";
            this.btn_Hecho.UseVisualStyleBackColor = false;
            this.btn_Hecho.Click += new System.EventHandler(this.btn_Hecho_Click);
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(57, 340);
            this.cmb_Categoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(269, 36);
            this.cmb_Categoria.TabIndex = 5;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Codigo.Location = new System.Drawing.Point(57, 89);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(269, 34);
            this.txt_Codigo.TabIndex = 1;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nombre.Location = new System.Drawing.Point(382, 89);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(269, 34);
            this.txt_Nombre.TabIndex = 2;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(57, 421);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(150, 37);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(382, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Impuesto";
            // 
            // txt_impuesto
            // 
            this.txt_impuesto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_impuesto.Location = new System.Drawing.Point(382, 340);
            this.txt_impuesto.Name = "txt_impuesto";
            this.txt_impuesto.Size = new System.Drawing.Size(269, 34);
            this.txt_impuesto.TabIndex = 8;
            // 
            // txt_Precio
            // 
            this.txt_Precio.DecimalPlaces = 2;
            this.txt_Precio.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Precio.Location = new System.Drawing.Point(57, 214);
            this.txt_Precio.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(269, 34);
            this.txt_Precio.TabIndex = 8;
            this.txt_Precio.ThousandsSeparator = true;
            // 
            // txt_Existencia
            // 
            this.txt_Existencia.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Existencia.Location = new System.Drawing.Point(382, 214);
            this.txt_Existencia.Name = "txt_Existencia";
            this.txt_Existencia.Size = new System.Drawing.Size(269, 34);
            this.txt_Existencia.TabIndex = 8;
            // 
            // FormularioInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(708, 524);
            this.Controls.Add(this.txt_Existencia);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_impuesto);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.btn_Hecho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormularioInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.FormularioInventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_impuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Existencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Hecho;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_impuesto;
        private System.Windows.Forms.NumericUpDown txt_Precio;
        private System.Windows.Forms.NumericUpDown txt_Existencia;
    }
}