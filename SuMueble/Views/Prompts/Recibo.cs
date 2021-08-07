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
    public partial class Recibo : Form
    {
        VentaController vcontroller = new VentaController();
        ClienteControlador clienteControlador = new ClienteControlador();
        ColaboradorControlador colaboradorControlador = new ColaboradorControlador();
        PagoControlador pagoControlador = new PagoControlador();

        public Recibo(Ventas venta=null,float pago=0)
        {
            InitializeComponent();

            total.Text = pago.ToString();
            if (venta != null)
            {
                if (venta.Cliente != null)
                {
                    cliente.Text = string.Format("Cliente: {0}", venta.Cliente.Nombre);

                }
                if (venta.NombreCliente != null)
                {
                    cliente.Text = string.Format("Cliente: {0}", venta.NombreCliente);

                }
                cuotaRestantes.Text = venta.Cuotas.ToString();
                
            }
            fecha.Text = string.Format("{0:d}", DateTime.Now.Date);
            hora.Text = string.Format("{0}", DateTime.Now.ToString("h:mm tt").ToUpper());
            cajero.Text = string.Format("{0}", Menu.colaborador.Nombre);

            //pagado.Text = string.Format("{0:C2}", _Total);
            //Total_.Text = string.Format("Total: {0:C2}", Total_);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
