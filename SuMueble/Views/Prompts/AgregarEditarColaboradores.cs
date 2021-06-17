using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class AgregarEditarColaboradores : Form
    {
        public AgregarEditarColaboradores()
        {
            InitializeComponent();
        }

        private void btn_hecho_Click(object sender, EventArgs e)
        {
            // enviar el insert 
            this.Close();
            
        }
    }
}
