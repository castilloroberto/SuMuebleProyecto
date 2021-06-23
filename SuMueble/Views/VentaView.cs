using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using SuMueble.Controller;
using System.Windows.Forms;
using SuMueble.Models;

namespace SuMueble.Views
{
    public partial class VentaView : UserControl
    {
        ProductoControlador productoControlador = new ProductoControlador();
        private List<DetallesVentas> detallesVenta = new List<DetallesVentas>();
        private float Total = 0;
        public VentaView()
        {
            InitializeComponent();
            
        
            dgv_productos.AutoGenerateColumns = false;
            dgv_productos.DataSource = productoControlador.GetProductos();
        }


        private void btn_terminarVenta_Click(object sender, EventArgs e)
        {

        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // cell 3 = precio
            txt_precio.Text = GetCell(3);
        }

        

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            DetallesVentas dv = new DetallesVentas()
            {
                IDProducto = int.Parse(GetCell(0)),
                Cantidad = int.Parse(txt_cantidadProducto.Text),
                PrecioVenta = int.Parse(txt_precio.Text),
                Producto = GetCell(2)
            };
           
            CargarListVew(dv);
            ClearProducto();
           

        }
        private void CargarListVew(DetallesVentas dv)
        {
            Total += dv.SubTotal;
            l_monto.Text = string.Format("{0:C2}", Total);
            detallesVenta.Add(dv);
            lb_productosVenta.DataSource = null;
            lb_productosVenta.DataSource = detallesVenta;
            lb_productosVenta.DisplayMember = "Info";

        }
        private string GetCell(int cell = 0)
        {
            // ID, Codigo, Producto, Precio, Existencias
            // 0 ,      1,        2,      3,          4
            return dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells[cell].Value.ToString();
        }

        private void ClearProducto()
        {
            txt_cantidadProducto.Text = string.Empty;
            txt_precio.Text = string.Empty;
        }
    }
}
