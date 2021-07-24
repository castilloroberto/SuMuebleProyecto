
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ventasCredito = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btn_pagarcuota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventasCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ventasCredito
            // 
            this.dgv_ventasCredito.AllowUserToAddRows = false;
            this.dgv_ventasCredito.AllowUserToDeleteRows = false;
            this.dgv_ventasCredito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ventasCredito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ventasCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ventasCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ventasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventasCredito.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ventasCredito.Location = new System.Drawing.Point(234, 416);
            this.dgv_ventasCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_ventasCredito.Name = "dgv_ventasCredito";
            this.dgv_ventasCredito.ReadOnly = true;
            this.dgv_ventasCredito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ventasCredito.RowHeadersWidth = 51;
            this.dgv_ventasCredito.RowTemplate.Height = 25;
            this.dgv_ventasCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ventasCredito.Size = new System.Drawing.Size(1319, 471);
            this.dgv_ventasCredito.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(234, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Venta";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbuscar.Location = new System.Drawing.Point(234, 344);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PlaceholderText = "Codigo de Factura...";
            this.txtbuscar.Size = new System.Drawing.Size(292, 39);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_pagarcuota
            // 
            this.btn_pagarcuota.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_pagarcuota.FlatAppearance.BorderSize = 0;
            this.btn_pagarcuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagarcuota.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pagarcuota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pagarcuota.Location = new System.Drawing.Point(1351, 897);
            this.btn_pagarcuota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pagarcuota.Name = "btn_pagarcuota";
            this.btn_pagarcuota.Size = new System.Drawing.Size(202, 46);
            this.btn_pagarcuota.TabIndex = 3;
            this.btn_pagarcuota.Text = "Pagar Cuota";
            this.btn_pagarcuota.UseVisualStyleBackColor = false;
            this.btn_pagarcuota.Click += new System.EventHandler(this.btn_pagarcuota_Click);
            // 
            // CreditosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_pagarcuota);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ventasCredito);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreditosView";
            this.Size = new System.Drawing.Size(1715, 950);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventasCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ventasCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btn_pagarcuota;
    }
}
