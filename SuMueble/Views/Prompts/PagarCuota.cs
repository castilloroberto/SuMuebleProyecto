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

        ColaboradorControlador ColaboradorControlador = new ColaboradorControlador();
        VentaController ventaController = new VentaController();
        DetalleVentaController detalleControllador = new DetalleVentaController();
        PagoControlador PagoControlador = new PagoControlador();
        Guid IDVenta;
        private string codFactura;
        DataTable DetalleVenta;



        public PagarCuota(string cod_factura)
        {
            InitializeComponent();

            var venta = ventaController.GetVenta(cod_factura);
            DetalleVenta = detalleControllador.GetDetalleVenta(int.Parse(cod_factura));
            codFactura = cod_factura;
            cargarDatos(venta);
        }


        private void cargarDatos(DataRow venta)
        {
            IDVenta = venta.Field<Guid>("ID");
       
            txt_cuotas_pendientes.Text = venta.Field<int>("Cuotas").ToString();

            

            dtp_fechaFin.Value = venta.Field<DateTime>("FechaFin");


            var venta_ = ventaController.GetVentaID(codFactura);
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
                Pagos p = new Pagos()
                {
                    IDVenta= IDVenta,
                    IDColaborador = txtDNIColaborador.Text,
                    Monto = float.Parse(txtCuota.Text),
                };

                 
                
                if (PagoControlador.InsertPagos(p) == true)
                {
                    MessageBox.Show("Pago completado con exito\nEl recibo se imprimira en seguida", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += imprimir;
                    printDocument1.Print();
                    
                }
                else
                {
                    MessageBox.Show("El pago no se pudo completar\nVerifique los datos e intente de nuevo", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    

                }
            }

            
        }
         
        private void imprimir(object sender, PrintPageEventArgs e)
        {
            var recibo = new Recibo();
            recibo.ShowDialog();
        }



        #region Validaciones
        private bool Validardatos()
        {
            bool ok;
            bool ok1 = txtCuota.Text != "";
            bool ok2= txtDNIColaborador.Text != "";
           
            ok = ok1 && ok2;
            if (ok==false)
            {
                MessageBox.Show("Ingrese los datos que se le solicitan", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }


        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca valores numericos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtDNIColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca valores numericos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
        #endregion

        private void txtDNIColaborador_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDNIColaborador_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDNIColaborador.Text.Length == 13)
            {

                l_colabora.Visible = true;
                var cola = ColaboradorControlador.GetColaborador(txtDNIColaborador.Text);
                if (cola != null)
                {
                    l_colabora.ForeColor = Color.DodgerBlue;
                    l_colabora.Text = cola.Nombre;

                }
                else
                {
                    l_colabora.ForeColor = Color.Red;
                    l_colabora.Text = "Tiene un error en su DNI";
                }
            }
            else
            {
                l_colabora.Visible = false;

            }
        }
    }
}
