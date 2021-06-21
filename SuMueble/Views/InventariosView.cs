using SuMueble;
using SuMueble.Controller;
using System.Windows.Forms;

namespace Ventana_de_Inventarios
{
    public partial class InventariosView : UserControl
    {
        CategoriaController categoriaController = new CategoriaController();
        public InventariosView()
        {
            InitializeComponent();
            CargarDatos();
            cb_categorias.ValueMember = "ID";
            cb_categorias.DisplayMember = "Categoria";

        }

        private void CargarDatos()
        {
            cb_categorias.DataSource = categoriaController.GetCategorias();

        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            FormularioInventarios formInventarios = new FormularioInventarios();
            formInventarios.ShowDialog();
        }

        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
            FormularioInventarios formInventarios = new FormularioInventarios();
            formInventarios.ShowDialog();
        }
    }
}
