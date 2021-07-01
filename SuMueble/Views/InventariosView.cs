using SuMueble;
using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Ventana_de_Inventarios
{
    public partial class InventariosView : UserControl
    {
        CategoriaController categoriaController = new CategoriaController();
        ProductoControlador pc = new ProductoControlador();
        List<Productos> productos;
        public InventariosView()
        {
            InitializeComponent();
            dgv_Productos.AutoGenerateColumns = false;
            CargarDatos();
            cb_categorias.ValueMember = "ID";
            cb_categorias.DisplayMember = "Categoria";

        }

        private void CargarDatos()
        {
            cb_categorias.DataSource = categoriaController.GetCategorias();
            productos = pc.GetProductos().ToList();
            dgv_Productos.DataSource = productos;

        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            int ID = int.Parse(GetCell(0));
            
            FormularioInventarios formInventarios = new FormularioInventarios(ID);
            formInventarios.ShowDialog();
            CargarDatos();
        }

        private string GetCell(int ID)
        {
            return dgv_Productos.Rows[dgv_Productos.CurrentRow.Index].Cells[ID].Value.ToString();
        }

        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
            FormularioInventarios formInventarios = new FormularioInventarios();
            formInventarios.ShowDialog();
            CargarDatos();
        }

        private void InventariosView_Load(object sender, System.EventArgs e)
        {

        }

        private void txt_buscar_metodo(object sender, EventArgs e)
        {
            string buscar = txt_buscar.Text;

            List<Productos> filtrados = productos.Where<Productos>(x => {

                return x.Producto.ToLower().StartsWith(buscar) || x.Codigo.ToLower().StartsWith(buscar) ;


            }).ToList();

            dgv_Productos.DataSource = null;
            dgv_Productos.DataSource = filtrados;
        }
    }
}
