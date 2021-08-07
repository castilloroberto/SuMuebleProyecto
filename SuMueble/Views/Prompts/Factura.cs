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
        public Factura(List<DetallesVentas> detalles,float Total_,Guid idventa_)
        {
            InitializeComponent();
            dgv_factura.AutoGenerateColumns = false;
            dgv_factura.DataSource = detalles;
            DataGridHeight();

            //CodigoFactura = ventaController.GetVentaByGuid(idventa_).CodigoFactura;
            //cod_factura.Text = string.Format("Factura Nº : {0}",CodigoFactura);

            fecha.Text = string.Format("Fecha: {0:d}",DateTime.Now.Date);
            hora.Text = string.Format("Hora: {0}", DateTime.Now.ToString("h:mm tt").ToUpper());
            cajero.Text = string.Format("Cajero: {0}",Menu.colaborador.Nombre);
            total.Text = string.Format("Total: {0:C2}", Total_);


            

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

            e.PageSettings.PaperSize = new PaperSize("custom size",200,1000);
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

        private void imprimir_Click(object sender, EventArgs e)
        {
            imprimir.Visible = false;
            camcelar.Visible = false;
            // un avez cargado los datos procedemos a mostrar el dialogo de impresion
            //Task.Factory.StartNew(() => {

            //    System.Threading.Thread.Sleep(500);
            //    PrintFactura();
            //    this.Close();
            //});

            PrintFactura();
            this.Close();

        }
    }
}
