using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        Bitmap Bitmap;


        public Recibo(Venta venta=null,float pago=0)
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
        private void PrintFactura()
        {
            Graphics graphics = this.CreateGraphics();

            Bitmap = new Bitmap(this.Size.Width, this.Size.Height, graphics);

            Graphics mainGraphic = Graphics.FromImage(Bitmap);

            mainGraphic.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }
        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Bitmap, 0, 0);

            e.PageSettings.PaperSize = new PaperSize("custom size", 449, 951);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            btn_print.Visible = false;
            PrintFactura();
            this.Close();
        }
    }
}
