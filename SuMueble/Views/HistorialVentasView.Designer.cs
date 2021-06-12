
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Cliente = new System.Windows.Forms.ColumnHeader();
            this.nombre = new System.Windows.Forms.ColumnHeader();
            this.producto = new System.Windows.Forms.ColumnHeader();
            this.cantida = new System.Windows.Forms.ColumnHeader();
            this.fecha = new System.Windows.Forms.ColumnHeader();
            this.monto = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(386, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Buscar...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(379, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bucar Clientes";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cliente,
            this.nombre,
            this.producto,
            this.cantida,
            this.fecha,
            this.monto});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(386, 152);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(895, 373);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Cliente
            // 
            this.Cliente.Text = "ClienteID";
            this.Cliente.Width = 120;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.Width = 180;
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.producto.Width = 120;
            // 
            // cantida
            // 
            this.cantida.Text = "Cantidad";
            this.cantida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantida.Width = 120;
            // 
            // fecha
            // 
            this.fecha.Text = "Fecha";
            this.fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fecha.Width = 120;
            // 
            // monto
            // 
            this.monto.Text = "Monto";
            this.monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monto.Width = 120;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;

           
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(386, 554);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver Detalles";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // HistorialVentasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HistorialVentasView";
            this.Size = new System.Drawing.Size(1634, 669);
            this.Load += new System.EventHandler(this.HistorialVentasView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Cliente;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader producto;
        private System.Windows.Forms.ColumnHeader cantida;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader monto;
        private System.Windows.Forms.Button button1;
    }
}
