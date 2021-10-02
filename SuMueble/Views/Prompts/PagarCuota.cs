using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using SuMueble.Views.Prompts;
using System.Drawing.Printing;

namespace SuMueble.Views
{
    public partial class PagarCuota : Form
    {

        VentaController ventaController = new VentaController();
        DetalleVentaController detalleControllador = new DetalleVentaController();
        PagoControlador PagoControlador = new PagoControlador();
        Guid IDVenta;
        private string codFactura;
        DataTable DetalleVenta;
        Venta venta_;


        public PagarCuota(string cod_factura)
        {
            InitializeComponent();

            var venta = ventaController.GetVenta(cod_factura);
            DetalleVenta = detalleControllador.GetDetalleVenta(int.Parse(cod_factura));
            codFactura = cod_factura;
            cargarDatos(venta);
            txtDNIColaborador.Text = Menu.colaborador.DNI;
        }


        private void cargarDatos(DataRow venta)
        {
            IDVenta = venta.Field<Guid>("ID");
       
            txt_cuotas_pendientes.Text = venta.Field<int>("Cuotas").ToString();

            

            dtp_fechaFin.Value = venta.Field<DateTime>("FechaFin");


            venta_ = ventaController.GetVentaID(codFactura);
            l_cliente.Text = venta_.NombreCliente;

            txtProducto.Text = DetalleVenta.Rows[0].Field<string>("Producto");
            var creditopendiente = PagoControlador.GetCreditoPendiente(int.Parse(codFactura));

            if (creditopendiente.Rows.Count > 0)
            {
                txt_monto_pendiente.Text = creditopendiente.Rows[0].Field<double>("Pendiente").ToString();

            }
            else
            {
                txt_monto_pendiente.Text = DetalleVenta.Rows[0].Field<double>("SubTotal").ToString();
            }

            

        }


        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if (Validardatos())
            {
                Pago p = new Pago()
                {
                    IDVenta= IDVenta,
                    IDColaborador = txtDNIColaborador.Text,
                    Monto = (float)txtCuota.Value,
                    
                };

                 
                
                if (PagoControlador.InsertPagos(p) == true)
                {
                    MessageBox.Show("Pago completado con exito\nEl recibo se imprimira en seguida", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                    var recibo = new Recibo(venta_, (float)txtCuota.Value);
                    recibo.ShowDialog();
                    //printDocument1 = new PrintDocument();
                    //PrinterSettings ps = new PrinterSettings();
                    //printDocument1.PrinterSettings = ps;
                    //printDocument1.PrintPage += imprimir;
                    //printDocument1.Print();

                }
                else
                {
                    MessageBox.Show("El pago no se pudo completar\nVerifique los datos e intente de nuevo", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    

                }
            }

            
        }
         
        //private void imprimir(object sender, PrintPageEventArgs e)
        //{
            
        //}



        #region Validaciones
        private bool Validardatos()
        {
            bool ok = txtCuota.Value != 0;
            if (!ok)
            {
                MessageBox.Show("Ingrese los datos que se le solicitan", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }


        #endregion

      

       
    }
}
