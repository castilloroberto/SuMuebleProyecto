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

namespace SuMueble.Views
{
    public partial class PagarCuota : Form
    {


        VentaController ventaController = new VentaController();
        DetalleVentaController detalleControllador = new DetalleVentaController();
        PagoControlador PagoControlador = new PagoControlador();
        Guid IDVenta;
        public PagarCuota(string cod_factura)
        {
            InitializeComponent();

            var venta = ventaController.GetVenta(cod_factura);

            cargarDatos(venta);
        }


        private void cargarDatos(DataRow venta)
        {
            IDVenta = venta.Field<Guid>("ID");
            txt_cuotas_pendientes.Text = venta.Field<string>("Cuotas");
            dtp_fechaFin.Value = venta.Field<DateTime>("FechaFin");

            var detalle = detalleControllador.GetDetalleVenta(IDVenta);

            float precioveta = detalle.Field<float>("PrecioVenta");
            
            var pagos = PagoControlador.

        }


        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if (Validardatos())
            {
                Pagos p = new Pagos()
                {
                    IDVenta = Guid.Empty,
                    IDColaborador = txtDNIColaborador.Text,
                    Monto = int.Parse(txtCuota.Text),
                };

                bool ok = PagoControlador.InsertPagos(p);
                
                if (ok)
                {
                    MessageBox.Show("Pago completado con exito\nLa factura se imprimira en seguida", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El pago no se pudo completar\nVerifique los datos e intente de nuevo", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    

                }
            }
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

    }
}
