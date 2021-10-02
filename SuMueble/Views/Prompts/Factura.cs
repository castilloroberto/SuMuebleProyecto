using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SuMueble.Views.Prompts
{
    public partial class Factura : Form
    {
        VentaController ventaController = new VentaController();
        int CodigoFactura = 0;
        Bitmap Bitmap;
     
        public Factura(Venta venta = null)
        {
            InitializeComponent();

            if (venta != null)
            {
                dgv_factura.AutoGenerateColumns = false;
                dgv_factura.DataSource = venta.DetallesVenta;
                DataGridHeight();

                total.Text = string.Format("Total: {0:C2}", venta.TotalVenta);

                var descuentos = 0.0;

                foreach (var item in venta.DetallesVenta)
                {
                    descuentos += item.descuento;
                }

                txt_descuentos.Text = string.Format("Descuentos: {0:C2}", descuentos);

                CodigoFactura = ventaController.GetVentaByGuid(venta.ID).CodigoFactura;

                cod_factura.Text = string.Format("Factura Nº : {0}", CodigoFactura);
                nombre_cliente.Text = string.Format("Nombre: {0}", venta.Cliente.Nombre);
                dni_cliente.Text = string.Format("DNI Cliente: {0}", venta.Cliente.DNI);

            }


            fecha.Text = string.Format("Fecha: {0:d}",DateTime.Now.Date);
            hora.Text = string.Format("Hora: {0}", DateTime.Now.ToString("h:mm tt").ToUpper());
            cajero.Text = string.Format("Cajero: {0}",Menu.colaborador.Nombre);


            

        }


        private void DataGridHeight()
        {
            var height = dgv_factura.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgv_factura.Rows)
            {
                height += row.Height;
            }
            dgv_factura.Height = height;
            main_panel.Height = height+55;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Bitmap,0,0);

            e.PageSettings.PaperSize = new PaperSize("custom size", 449, 951);
        }
        private void PrintFactura()
        {
            Graphics graphics = this.CreateGraphics();

            Bitmap = new Bitmap(this.Size.Width,this.Size.Height,graphics);

            Graphics mainGraphic = Graphics.FromImage(Bitmap);

            mainGraphic.CopyFromScreen(this.Location.X, this.Location.Y,0,0,this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
           

           

        }

        private void Factura_Shown(object sender, EventArgs e)
        {
            
  
            

        }

        private void Factura_Activated(object sender, EventArgs e)
        {
            

        }



        private void btn_print_Click(object sender, EventArgs e)
        {
            btn_print.Visible = false;
            PrintFactura();
            this.Close();

        }
    }
}
