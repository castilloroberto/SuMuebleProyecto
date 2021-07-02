using SuMueble.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class Login : Form
    {
        ColaboradorControlador colaboradorControlador = new ColaboradorControlador();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
           string user = txt_user.Text;
            string password = txt_password.Text;
            bool res = colaboradorControlador.Login(user, password);
           
            if (res)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Codigo o Clave de Usuario Invalido", "Contrasena Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_user.Text = "";   
            txt_password.Text = "";
            txt_user.Focus();

        }
    }
}
