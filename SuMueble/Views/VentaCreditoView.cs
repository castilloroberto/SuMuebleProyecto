using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using SuMueble.Views.Prompts;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class VentaCreditoView : UserControl
    {
        public VentaCreditoView()
        {
            InitializeComponent();
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            VentaAgregarProducto ventaAgregarProducto = new VentaAgregarProducto();
            ventaAgregarProducto.ShowDialog();
        }

        private void btn_agregarReferencia_Click(object sender, EventArgs e)
        {
            AgregarReferencia agregarReferencia = new AgregarReferencia();
            agregarReferencia.ShowDialog();
        }
    }
}
