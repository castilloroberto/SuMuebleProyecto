using SuMueble;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using SuMueble.DataAccess;

namespace Ventana_de_Inventarios
{
    public partial class InventariosView : UserControl
    {
       
        List<Producto> productos;
        public InventariosView()
        {
            InitializeComponent();
            CargarDatos();
            cb_categorias.ValueMember = "Id";
            cb_categorias.DisplayMember = "Nombre";
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            using (var db = new SuMuebleDBContext())
            {
                cb_categorias.DataSource = db.Categorias.ToList();
                productos = db.Productos.ToList();

            }
            dgv_Productos.DataSource = productos;

        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {

            if (dgv_Productos.SelectedRows.Count > 0)
            {
                int ID = int.Parse(GetCell(0));
                FormularioInventarios formInventarios = new FormularioInventarios(ID);
                formInventarios.ShowDialog();
                CargarDatos();
            }
            else {
                MessageBox.Show("No hay ningún producto seleccionado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
            txt_buscar.Text = "";
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
            string buscar = txt_buscar.Text.ToLower();

            List<Producto> filtrados = productos.Where<Producto>(x => {

                return x.Nombre.ToLower().StartsWith(buscar) || x.Id.ToString().StartsWith(buscar) ;


            }).ToList();

            dgv_Productos.DataSource = null;
            dgv_Productos.DataSource = filtrados;
        }

        private void cb_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            string categoriaString = cb_categorias.SelectedValue.ToString();
           
           
            
            if (categoriaString != "SuMueble.Models.Categorias") {
                
                int idCategoria = 0;
                int.TryParse(categoriaString,out idCategoria);

                if (idCategoria > 1 )
                {
                    List<Producto> filtrados = productos.Where(x =>
                    {

                        return x.CategoriaId == idCategoria;

                    }).ToList();

                    dgv_Productos.DataSource = null;
                    dgv_Productos.DataSource = filtrados;
                } else {
                    dgv_Productos.DataSource = null;
                    dgv_Productos.DataSource = productos;
                }

                
           
            }


        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            txt_buscar.Text = txt_buscar.Text.Trim();
        }
    }
}
