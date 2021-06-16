using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class Venta : UserControl
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarcliente_Click(object sender, EventArgs e)
        {
           
;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            

        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
        }

        private void btngenerarcodigofactura_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            Random alea = new Random();
            n1 = alea.Next();
            txtcodigofactura.Text = n1.ToString();
        }
    }
}
