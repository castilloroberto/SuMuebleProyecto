
namespace SuMueble.Views
{
    partial class AgregarEditarColaboradores
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
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_rtn = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_puesto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_contratoIniciado = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_contratoFinalizado = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.btn_hecho = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btnNuevoPuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "RTN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dni.Location = new System.Drawing.Point(118, 34);
            this.txt_dni.MaxLength = 13;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.PlaceholderText = "Numero de Identidad";
            this.txt_dni.Size = new System.Drawing.Size(124, 23);
            this.txt_dni.TabIndex = 4;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // txt_rtn
            // 
            this.txt_rtn.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_rtn.Location = new System.Drawing.Point(309, 34);
            this.txt_rtn.MaxLength = 15;
            this.txt_rtn.Name = "txt_rtn";
            this.txt_rtn.PlaceholderText = "Escriba Aqui...";
            this.txt_rtn.Size = new System.Drawing.Size(146, 23);
            this.txt_rtn.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.Location = new System.Drawing.Point(118, 78);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Nombre Completo...";
            this.txt_nombre.Size = new System.Drawing.Size(337, 23);
            this.txt_nombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clave:";
            // 
            // txt_clave
            // 
            this.txt_clave.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_clave.Location = new System.Drawing.Point(118, 165);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.PlaceholderText = "Para entrar al Sistema...";
            this.txt_clave.Size = new System.Drawing.Size(124, 23);
            this.txt_clave.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(261, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puesto:";
            // 
            // cb_puesto
            // 
            this.cb_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_puesto.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_puesto.FormattingEnabled = true;
            this.cb_puesto.Location = new System.Drawing.Point(325, 166);
            this.cb_puesto.Name = "cb_puesto";
            this.cb_puesto.Size = new System.Drawing.Size(130, 23);
            this.cb_puesto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Nacimiento:";
            // 
            // dtp_contratoIniciado
            // 
            this.dtp_contratoIniciado.Enabled = false;
            this.dtp_contratoIniciado.Location = new System.Drawing.Point(158, 323);
            this.dtp_contratoIniciado.Name = "dtp_contratoIniciado";
            this.dtp_contratoIniciado.Size = new System.Drawing.Size(298, 23);
            this.dtp_contratoIniciado.TabIndex = 12;
            this.dtp_contratoIniciado.ValueChanged += new System.EventHandler(this.dtp_contratoIniciado_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Contrato:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(176, 124);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(279, 23);
            this.dtp_fechaNacimiento.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(39, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha Finalizacion Contrato:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtp_contratoFinalizado
            // 
            this.dtp_contratoFinalizado.Enabled = false;
            this.dtp_contratoFinalizado.Location = new System.Drawing.Point(239, 359);
            this.dtp_contratoFinalizado.Name = "dtp_contratoFinalizado";
            this.dtp_contratoFinalizado.Size = new System.Drawing.Size(216, 23);
            this.dtp_contratoFinalizado.TabIndex = 16;
            this.dtp_contratoFinalizado.ValueChanged += new System.EventHandler(this.dtp_contratoFinalizado_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(39, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Correo:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_correo.Location = new System.Drawing.Point(118, 252);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PlaceholderText = "Escriba un Correo Valido...";
            this.txt_correo.Size = new System.Drawing.Size(337, 23);
            this.txt_correo.TabIndex = 18;
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(39, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefono:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_telefono.Location = new System.Drawing.Point(118, 288);
            this.txt_telefono.MaxLength = 8;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PlaceholderText = "Ejemplo: 88137603";
            this.txt_telefono.Size = new System.Drawing.Size(124, 23);
            this.txt_telefono.TabIndex = 20;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(39, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Direccion Exacta:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_direccion.Location = new System.Drawing.Point(167, 395);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PlaceholderText = "Ciudad, Colonia y Referencias";
            this.txt_direccion.Size = new System.Drawing.Size(288, 48);
            this.txt_direccion.TabIndex = 22;
            // 
            // btn_hecho
            // 
            this.btn_hecho.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_hecho.FlatAppearance.BorderSize = 0;
            this.btn_hecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hecho.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_hecho.ForeColor = System.Drawing.Color.White;
            this.btn_hecho.Location = new System.Drawing.Point(361, 463);
            this.btn_hecho.Name = "btn_hecho";
            this.btn_hecho.Size = new System.Drawing.Size(94, 22);
            this.btn_hecho.TabIndex = 23;
            this.btn_hecho.Text = "Hecho";
            this.btn_hecho.UseVisualStyleBackColor = false;
            this.btn_hecho.Click += new System.EventHandler(this.btn_hecho_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(39, 463);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 22);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPuesto
            // 
            this.btnNuevoPuesto.BackColor = System.Drawing.Color.White;
            this.btnNuevoPuesto.FlatAppearance.BorderSize = 0;
            this.btnNuevoPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPuesto.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoPuesto.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoPuesto.Location = new System.Drawing.Point(325, 195);
            this.btnNuevoPuesto.Name = "btnNuevoPuesto";
            this.btnNuevoPuesto.Size = new System.Drawing.Size(130, 22);
            this.btnNuevoPuesto.TabIndex = 24;
            this.btnNuevoPuesto.Text = "Nuevo";
            this.btnNuevoPuesto.UseVisualStyleBackColor = false;
            this.btnNuevoPuesto.Click += new System.EventHandler(this.btnNuevoPuesto_Click);
            // 
            // AgregarEditarColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(495, 497);
            this.Controls.Add(this.btnNuevoPuesto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_hecho);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_contratoFinalizado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_fechaNacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_contratoIniciado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_puesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_rtn);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarEditarColaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarEditarColaboradores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_rtn;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_puesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_contratoIniciado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_contratoFinalizado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Button btn_hecho;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btnNuevoPuesto;
    }
}