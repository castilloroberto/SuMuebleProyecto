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
            if (ID != 0)
            {
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

            //VALIDACIONES TEXTBOX VACIOS

            if (txt_Codigo.Text == "")
            {
                MessageBox.Show("Codigo articulo esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Codigo.Focus();
            }
            else if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Nombre articulo esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre.Focus();
            }
            else if (txt_Precio.Text == "")
            {
                MessageBox.Show("Precio articulo esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Precio.Focus();
                txt_Precio.Focus();
            }
            else if (cmb_Categoria.Text == "Todos")
            {
                MessageBox.Show("No se ha seleccionado ninguna categoria", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Existencia.Focus();
            }
            else if (txt_Existencia.Text == "")
            {
                MessageBox.Show("Existencia articulo esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Productos p = new Productos()
                {
                    ID = IDglobal,
                    Codigo = txt_Codigo.Text,
                    Existencias = int.Parse(txt_Existencia.Text),
                    Producto = txt_Nombre.Text,
                    PrecioUnitario = float.Parse(txt_Precio.Text),
                    IDCategoria = cmb_Categoria.SelectedValue.GetHashCode()
                };
                productoControlador.SaveProductos(p);
                MessageBox.Show("Guardado con exito", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void txt_Precio_TextChanged(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca valores numericos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txt_Existencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca valores numericos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
