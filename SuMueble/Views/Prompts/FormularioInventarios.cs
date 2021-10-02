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
                txt_Existencia.Enabled = false;
                txt_Precio.Enabled = false;
            }
            IDglobal = ID;
        }

        private void cargarDatos(int ID)
        {

            Producto p = productoControlador.GetProducto(ID);
            txt_Codigo.Text = p.Codigo;
            txt_Existencia.Value = p.Existencias;
            txt_Nombre.Text = p.Producto.ToString();
            txt_Precio.Value = (decimal)p.PrecioUnitario;
            cmb_Categoria.SelectedValue = p.IDCategoria;
            txt_Codigo.ReadOnly = true;

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
            else if (txt_Precio.Value == 0)
            {
                MessageBox.Show("Precio articulo esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Precio.Focus();
            }
            else if (cmb_Categoria.Text == "Todos")
            {
                MessageBox.Show("No se ha seleccionado ninguna categoria", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_Categoria.Focus();
            }
            else if (txt_Existencia.Value == 0)
            {
                MessageBox.Show("Existencia articulo esta vacio", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Producto p = new Producto()
                {
                    ID = IDglobal,
                    Codigo = txt_Codigo.Text,
                    Existencias = (int)txt_Existencia.Value,
                    Producto = txt_Nombre.Text,
                    PrecioUnitario = (float)txt_Precio.Value,
                    IDCategoria = cmb_Categoria.SelectedValue.GetHashCode(),
                    ISV = (float)txt_impuesto.Value
                };
                productoControlador.SaveProductos(p);
                MessageBox.Show("Guardado con exito", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

      


      

       

        
    }
}
