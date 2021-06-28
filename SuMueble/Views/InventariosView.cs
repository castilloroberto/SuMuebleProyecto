using SuMueble;
using SuMueble.Controller;
using System;
using System.Windows.Forms;

namespace Ventana_de_Inventarios
{
    public partial class InventariosView : UserControl
    {
        CategoriaController categoriaController = new CategoriaController();
        ProductoControlador pc = new ProductoControlador();
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
            dgv_Productos.DataSource = pc.GetProductos();

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
    }
}
