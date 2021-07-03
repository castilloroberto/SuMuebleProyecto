using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class DevolucionesView : UserControl
    {
        public DevolucionesView()
        {
            InitializeComponent();
            
        }

        private void btn_agregarDevolucion_Click(object sender, EventArgs e)
        {
            Devolucion devolucion = new Devolucion();
            devolucion.ShowDialog();
        }

        private void txt_buscarCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
