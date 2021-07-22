
namespace SuMueble.Views
{
    partial class Ventascontado
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
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DNIcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_monto
            // 
            this.txt_monto.BackColor = System.Drawing.SystemColors.Window;
            this.txt_monto.Enabled = false;
            this.txt_monto.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_monto.Location = new System.Drawing.Point(609, 255);
            this.txt_monto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(316, 33);
            this.txt_monto.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(602, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Monto";
            // 
            // txt_DNIcliente
            // 
            this.txt_DNIcliente.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DNIcliente.Enabled = false;
            this.txt_DNIcliente.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DNIcliente.Location = new System.Drawing.Point(610, 135);
            this.txt_DNIcliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DNIcliente.Name = "txt_DNIcliente";
            this.txt_DNIcliente.Size = new System.Drawing.Size(316, 33);
            this.txt_DNIcliente.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(602, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "DNI Cliente";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cliente.Location = new System.Drawing.Point(51, 136);
            this.txt_cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(316, 33);
            this.txt_cliente.TabIndex = 11;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_volver.Location = new System.Drawing.Point(739, 596);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(188, 46);
            this.btn_volver.TabIndex = 9;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente";
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.AllowUserToAddRows = false;
            this.dgv_articulos.AllowUserToDeleteRows = false;
            this.dgv_articulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_articulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_articulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_articulos.Location = new System.Drawing.Point(51, 304);
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.ReadOnly = true;
            this.dgv_articulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_articulos.RowHeadersWidth = 62;
            this.dgv_articulos.RowTemplate.Height = 33;
            this.dgv_articulos.Size = new System.Drawing.Size(874, 239);
            this.dgv_articulos.TabIndex = 16;
            // 
            // Ventascontado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_volver;
            this.ClientSize = new System.Drawing.Size(972, 731);
            this.Controls.Add(this.dgv_articulos);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DNIcliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ventascontado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventascontado";
            this.Load += new System.EventHandler(this.Ventascontado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DNIcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_articulos;
    }
}