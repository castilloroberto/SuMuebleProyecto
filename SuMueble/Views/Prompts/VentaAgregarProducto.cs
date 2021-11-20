
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuMueble.Controller;
using SuMueble.Models;
using System.Linq;

namespace SuMueble.Views.Prompts
{
    public partial class VentaAgregarProducto : Form
    {
        ProductoControlador productoControlador = new ProductoControlador();
        List<Productos> productos;
        public VentaAgregarProducto()
        {
            InitializeComponent();
            dgv_productos.AutoGenerateColumns = false;
            dgv_productos.DataSource = productoControlador.GetProductos();
            productos = productoControlador.GetProductos().ToList();
            dgv_productos.DataSource = productos;
        }


        private dynamic GetCell(int cell = 0)
        {
            // ID, Codigo, Producto, Precio, Existencias
            // 0 ,      1,        2,      3,          4
            int row = dgv_productos.CurrentRow.Index;
            return dgv_productos.Rows[row].Cells[cell].Value;
        }
        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // cell 3 = precio
            txt_precio.Value = (decimal)GetCell(3);
        }
        private void ClearProducto()
        {
            
            txt_precio.Value = 0;
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {

            if (txt_precio.Value == 0)
            {
                MessageBox.Show("Selecione el producto", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DetallesVentas dv = new DetallesVentas()
                {
                    ProductoFk = GetCell(0),
                    Cantidad = 1,
                    PrecioVenta = (float)txt_precio.Value,
                    Producto = GetCell(2)
                };

                // propiedad estatica de VentaCreditoView
                VentaCreditoView.listaProducto(dv);
                this.Close();
            }
        }

  

        private void txt_buscarProducto_TextChanged(object sender, EventArgs e)
        {
            string buscar = txt_buscarProducto.Text.ToLower();

            List<Productos> filtrados = productos.Where<Productos>(x => {

                return x.Producto.ToLower().StartsWith(buscar) || x.Codigo.ToLower().StartsWith(buscar);


            }).ToList();

            dgv_productos.DataSource = null;
            dgv_productos.DataSource = filtrados;
        }

        private void txt_buscarProducto_Leave(object sender, EventArgs e)
        {
            txt_buscarProducto.Text = txt_buscarProducto.Text.Trim();
        }
    }
}
