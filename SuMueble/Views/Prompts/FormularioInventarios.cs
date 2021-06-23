using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble
{
    public partial class FormularioInventarios : Form
    {

        ProductoControlador productoControlador = new ProductoControlador();
        CategoriaController categoriaController = new CategoriaController();

        
        public FormularioInventarios()
        {
            InitializeComponent();
            cmb_Categoria.DataSource = categoriaController.GetCategorias();
            cmb_Categoria.DisplayMember = "Categoria";
            cmb_Categoria.ValueMember = "ID"; 
        }

        internal static object show()
        {
            throw new NotImplementedException();
        }

        private void FormularioInventarios_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hecho_Click(object sender, EventArgs e)
        {
            Productos p = new Productos() {
                Codigo = txt_Codigo.Text,
                Existencias = int.Parse(txt_Existencia.Text),
                Producto = txt_Nombre.Text,
                PrecioUnitario = float.Parse(txt_Precio.Text),
                IDCategoria = cmb_Categoria.SelectedValue.GetHashCode()
            };

            productoControlador.SaveProductos(p);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
