using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views.Prompts
{
    public partial class AgregarReferencia : Form
    {
        public AgregarReferencia()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Referencias referencias = new Referencias()
            {
             CodigoRecibo = txtCodigoFactura.Text, 
             Direccion = txtDireccion.Text,
             DNIReferencia = txtDNIReferencia.Text,
             Nombre = txt_nombreCliente.Text,
             Tel = txt_telefono.Text
            };
            VentaCreditoView.listaReferencias.Add(referencias);
            this.Close();
        }
    }
}
