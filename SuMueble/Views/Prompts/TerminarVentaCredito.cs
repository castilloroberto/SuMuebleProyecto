using SuMueble.DataAccess;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views.Prompts
{
    public partial class TerminarVentaCredito : Form
    {
        private string msg = "Venta Terminada Exitosamente\nLa factura se imprimira en seguida\nPrimer Monto a pagar: {0:C2}";
        public TerminarVentaCredito()
        {
            InitializeComponent();
            dtp_fechaFin.MinDate = DateTime.Now.AddDays(7);
            
        }

        private void btn_terminarVenta_Click(object sender, EventArgs e)
        {
            // propiedad estatica VentaCreditoView
            VentaCreditoView._venta.Cuotas = (int)txt_cuotas.Value;
            VentaCreditoView._venta.FechaVencimiento = dtp_fechaFin.Value;
            VentaCreditoView._venta.Prima = txt_prima.Value;

            try
            {
                int ok = 0;
                using (var db = new SuMuebleDBContext())
                {
                    db.Ventas.Add(VentaCreditoView._venta);
                    ok = db.SaveChanges();
                }
                if (ok > 0 ) 
                {
                    MessageBox.Show(string.Format(msg,(float)txt_prima.Value), "Imprimer Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    var recibo = new Recibo(VentaCreditoView._venta,(float)txt_prima.Value);
                    recibo.ShowDialog();
                }
                else
                    MessageBox.Show($"No se ha podido guardado los datos", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            catch (DbEntityValidationException err)
            {

                VentaCreditoView.showValidationError(err);


            }
            this.Close();
        }
    }
}
