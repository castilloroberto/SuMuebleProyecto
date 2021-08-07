using SuMueble.Controller;
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
    public partial class TerminarVentaCredito : Form
    {
        //controladores
        VentaController vcontroller = new VentaController();
        private string msg = "Venta Terminada Exitosamente\nLa factura se imprimira en seguida\nPrimer Monto a pagar: {0:C2}";
        public TerminarVentaCredito()
        {
            InitializeComponent();
            
        }

        private void btn_terminarVenta_Click(object sender, EventArgs e)
        {
            // propiedad estatica VentaCreditoView
            VentaCreditoView._venta.Cuotas = (int)txt_cuotas.Value;
            VentaCreditoView._venta.FechaFin = dtp_fechaFin.Value;
            VentaCreditoView._venta.Prima = (float)txt_prima.Value;

            bool ok = vcontroller.SaveVenta(VentaCreditoView._venta);
            if (ok) 
            {
                MessageBox.Show(string.Format(msg,(float)txt_prima.Value), "Imprimer factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show($"Ha habido un error\nIntente de nuevo", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            this.Close();
        }
    }
}
