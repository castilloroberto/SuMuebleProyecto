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
using SuMueble.DataAccess;

namespace SuMueble.Views
{
    public partial class PagarCuota : Form
    {

        private int codFactura;
        DetalleVenta DetalleVenta;
        Venta venta_;


        public PagarCuota(int cod_factura)
        {
            InitializeComponent();

            codFactura = cod_factura;
            cargarDatos();
            txtDNIColaborador.Text = Menu.colaborador.DNI;
        }


        private void cargarDatos()
        {
       

            




            

            

        }


        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if (Validardatos())
            {
                Pago p = new Pago()
                {
                    CodigoFactura= codFactura,
                    ColaboradorDNI = txtDNIColaborador.Text,
                    Monto = txtCuota.Value,
                    
                };

                int res = 0;
                using (var db = new SuMuebleDBContext())
                {
                    db.Pagos.Add(p);
                    res = db.SaveChanges();
                }
                if (res > 0)
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
