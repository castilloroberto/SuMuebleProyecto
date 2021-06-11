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
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string password = txt_user.Text;
            string user = txt_password.Text;
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
