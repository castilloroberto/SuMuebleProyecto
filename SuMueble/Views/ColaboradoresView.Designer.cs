namespace SuMueble.Views
{
    partial class ColaboradoresView
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
            this.btn_terminarContrato = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dgv_colaboradores = new System.Windows.Forms.DataGridView();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_terminarContrato
            // 
            this.btn_terminarContrato.BackColor = System.Drawing.Color.Crimson;
            this.btn_terminarContrato.FlatAppearance.BorderSize = 0;
            this.btn_terminarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terminarContrato.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_terminarContrato.ForeColor = System.Drawing.Color.White;
            this.btn_terminarContrato.Location = new System.Drawing.Point(1146, 703);
            this.btn_terminarContrato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_terminarContrato.Name = "btn_terminarContrato";
            this.btn_terminarContrato.Size = new System.Drawing.Size(176, 37);
            this.btn_terminarContrato.TabIndex = 6;
            this.btn_terminarContrato.Text = "Terminar Contrato";
            this.btn_terminarContrato.UseVisualStyleBackColor = false;
            this.btn_terminarContrato.Click += new System.EventHandler(this.btn_terminarContrato_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Location = new System.Drawing.Point(279, 703);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_nuevo.MinimumSize = new System.Drawing.Size(0, 37);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(110, 37);
            this.btn_nuevo.TabIndex = 5;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Location = new System.Drawing.Point(121, 703);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_actualizar.MinimumSize = new System.Drawing.Size(0, 37);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(134, 37);
            this.btn_actualizar.TabIndex = 4;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // dgv_colaboradores
            // 
            this.dgv_colaboradores.AllowUserToAddRows = false;
            this.dgv_colaboradores.AllowUserToDeleteRows = false;
            this.dgv_colaboradores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_colaboradores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_colaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_colaboradores.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_colaboradores.Location = new System.Drawing.Point(121, 297);
            this.dgv_colaboradores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_colaboradores.Name = "dgv_colaboradores";
            this.dgv_colaboradores.ReadOnly = true;
            this.dgv_colaboradores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_colaboradores.RowHeadersWidth = 51;
            this.dgv_colaboradores.RowTemplate.Height = 25;
            this.dgv_colaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_colaboradores.Size = new System.Drawing.Size(1201, 377);
            this.dgv_colaboradores.TabIndex = 3;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_busqueda.Location = new System.Drawing.Point(121, 234);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_busqueda.MaximumSize = new System.Drawing.Size(400, 37);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.PlaceholderText = "Escriba aqui...";
            this.txt_busqueda.Size = new System.Drawing.Size(234, 34);
            this.txt_busqueda.TabIndex = 1;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Colaborador:";
            // 
            // ColaboradoresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_colaboradores);
            this.Controls.Add(this.btn_terminarContrato);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_busqueda);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ColaboradoresView";
            this.Size = new System.Drawing.Size(1517, 760);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colaboradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_colaboradores;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_terminarContrato;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_actualizar;
    }
}
