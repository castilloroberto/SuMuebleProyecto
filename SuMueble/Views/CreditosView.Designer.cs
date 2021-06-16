
namespace SuMueble.Views
{
    partial class CreditosView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_pagarcuota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(798, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(404, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(410, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "DNI o Nombre de Cliente...";
            this.textBox1.Size = new System.Drawing.Size(205, 29);
            this.textBox1.TabIndex = 2;
            // 
            // btn_pagarcuota
            // 
            this.btn_pagarcuota.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_pagarcuota.FlatAppearance.BorderSize = 0;
            this.btn_pagarcuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagarcuota.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pagarcuota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pagarcuota.Location = new System.Drawing.Point(410, 439);
            this.btn_pagarcuota.Name = "btn_pagarcuota";
            this.btn_pagarcuota.Size = new System.Drawing.Size(142, 28);
            this.btn_pagarcuota.TabIndex = 3;
            this.btn_pagarcuota.Text = "Pagar Cuota";
            this.btn_pagarcuota.UseVisualStyleBackColor = false;
            this.btn_pagarcuota.Click += new System.EventHandler(this.btn_pagarcuota_Click);
            // 
            // CreditosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_pagarcuota);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreditosView";
            this.Size = new System.Drawing.Size(1584, 570);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_pagarcuota;
    }
}
