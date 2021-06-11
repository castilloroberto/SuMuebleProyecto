using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class ColaboradoresView : UserControl
    {
        public ColaboradoresView()
        {
            InitializeComponent();
        }

        

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            AgregarEditarColaboradores addEditColaborador = new AgregarEditarColaboradores();

            addEditColaborador.ShowDialog();
            //actailizar data grid despues de agregar 
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            AgregarEditarColaboradores addEditColaborador = new AgregarEditarColaboradores();

            addEditColaborador.ShowDialog();
            //actailizar data grid despues de agregar 
        }
    }
}
