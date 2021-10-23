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
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            cb_categorias.DataSource = categoriaController.GetCategorias();
            productos = pc.GetProductos().ToList();
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

            List<Productos> filtrados = productos.Where<Productos>(x => {

                return x.Producto.ToLower().StartsWith(buscar) || x.Codigo.ToLower().StartsWith(buscar) ;


            }).ToList();

            dgv_Productos.DataSource = null;
            dgv_Productos.DataSource = filtrados;
        }

        private void cb_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            string categoriaString = cb_categorias.SelectedValue.ToString();
           
           
            
            if (categoriaString != "SuMueble.Models.Categorias") {
                
                int idCategoria = 0;
                idCategoria = Convert.ToInt32(categoriaString);

                if (idCategoria != 1)
                {
                    List<Productos> filtrados = productos.Where<Productos>(x =>
                    {

                        return x.IDCategoria == idCategoria;

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
