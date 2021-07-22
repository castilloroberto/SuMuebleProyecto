using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{

    public partial class Devolucion : Form
    {
        DevolucionControlador devolucionControlador = new DevolucionControlador();
        public Devolucion()
        {
            InitializeComponent();
        }

        private void btn_hecho_Click(object sender, EventArgs e)
        {
            Devoluciones devolucion = new Devoluciones()
            {
                CodigoFactura = int.Parse (txt_CodigoFactura.Text),
                Cantidad = int.Parse(txt_Cantidad.Text),
                IDProducto = int.Parse(txt_CodigoProducto.Text),
                Motivo= txt_Motivo.Text,
                Observaciones= txt_Observacion.Text

            };
            bool res=devolucionControlador.InsertarDevolucion(devolucion);
            if (res == true)
                MessageBox.Show("Devolucion Guardada Corrrecta Mente","Devoluciones",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("La Devolucion NO se Guardo Corrrecta Mente", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }

        internal static object Where<T>(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
