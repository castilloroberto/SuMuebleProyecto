using SuMueble;
using System.Windows.Forms;

namespace Ventana_de_Inventarios
{
    public partial class Inventarios : UserControl
    {
        public Inventarios()
        {
            InitializeComponent();
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
