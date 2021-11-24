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

        
       
        Ventas Venta = new Ventas();


        public PagarCuota(int idVenta)
        {
            InitializeComponent();

            Venta = Venta.Get(idVenta);
            txtDNIColaborador.Text = Menu.colaborador.DNI;
        }


        private void cargarDatos(DataRow venta)
        {
       
            

        }


        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if (Validardatos())
            {
                Pagos p = new Pagos()
                {
                    IDColaborador = txtDNIColaborador.Text,
                    Monto = (float)txtCuota.Value,
                    
                };

                 
                
                if (p.Insert(p) > 0)
                {
                    MessageBox.Show("Pago completado con exito\nEl recibo se imprimira en seguida", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                    var recibo = new Recibo(Venta, (float)txtCuota.Value);
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
