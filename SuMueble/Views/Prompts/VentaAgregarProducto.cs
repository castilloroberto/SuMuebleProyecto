using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuMueble.Controller;
using SuMueble.Models;

namespace SuMueble.Views.Prompts
{
    public partial class VentaAgregarProducto : Form
    {
        ProductoControlador productoControlador = new ProductoControlador();
        public VentaAgregarProducto()
        {
            InitializeComponent();
            dgv_productos.AutoGenerateColumns = false;
            dgv_productos.DataSource = productoControlador.GetProductos();
        }


        private string GetCell(int cell = 0)
        {
            // ID, Codigo, Producto, Precio, Existencias
            // 0 ,      1,        2,      3,          4
            return dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells[cell].Value.ToString();
        }
        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // cell 3 = precio
            txt_precio.Text = GetCell(3);
        }
        private void ClearProducto()
        {
            txt_cantidadProducto.Text = string.Empty;
            txt_precio.Text = string.Empty;
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


            VentaCreditoView.listaProducto(dv);
            this.Close();
        }
    }
}
