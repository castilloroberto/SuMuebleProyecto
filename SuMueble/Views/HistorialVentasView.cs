using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class HistorialVentasView : UserControl
    {
        bool toogle = true;
        public HistorialVentasView()
        {
            InitializeComponent();
        }

   

        private void HistorialVentasView_Load(object sender, EventArgs e)
        {

        }

        private void btn_verDetalle_Click(object sender, EventArgs e)
        {
            toogle = !toogle;

            VentaCredito ventaCredito = new VentaCredito();
            Ventascontado ventascontado = new Ventascontado();
            if (toogle)
                ventascontado.ShowDialog();
            else
                ventaCredito.ShowDialog();


        }
    }
}
