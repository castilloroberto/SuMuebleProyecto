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
        private int IDglobal = 0;
        ProductoControlador productoControlador = new ProductoControlador();
        CategoriaController categoriaController = new CategoriaController();

        
        public FormularioInventarios(int ID = 0)
        {
            InitializeComponent();
            cmb_Categoria.DataSource = categoriaController.GetCategorias();
            cmb_Categoria.DisplayMember = "Categoria";
            cmb_Categoria.ValueMember = "ID";
            if (ID != 0) {
                cargarDatos(ID);
            }
            IDglobal = ID;
        }

        private void cargarDatos(int ID)
        {
            
            Productos p = productoControlador.GetProducto(ID);
            txt_Codigo.Text = p.Codigo;
            txt_Existencia.Text = p.Existencias.ToString();
            txt_Nombre.Text = p.Producto.ToString();
            txt_Precio.Text = p.PrecioUnitario.ToString();
            cmb_Categoria.SelectedValue = p.IDCategoria;
            txt_Codigo.ReadOnly = true;

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
                ID = IDglobal,
                Codigo = txt_Codigo.Text,
                Existencias = int.Parse(txt_Existencia.Text),
                Producto = txt_Nombre.Text,
                PrecioUnitario = float.Parse(txt_Precio.Text),
                IDCategoria = cmb_Categoria.SelectedValue.GetHashCode()



            };

            productoControlador.SaveProductos(p);
            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
