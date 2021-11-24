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
        private int IdProducto = 0;
        Categorias Categorias = new Categorias();

        public FormularioInventarios(int idProducto = 0)
        {
            InitializeComponent();
            cmb_Categoria.DataSource = Categorias.GetAll();
            cmb_Categoria.DisplayMember = "Categoria";
            cmb_Categoria.ValueMember = "IdCategoria";

            if (idProducto != 0)
            {
                cargarDatos(idProducto);
                txt_Existencia.Enabled = false;
                txt_Precio.Enabled = false;
            }
            IdProducto = idProducto;
        }

        private void cargarDatos(int idProducto)
        {

            Producto p = new Producto();
            p = p.Get(idProducto);
            txt_Codigo.Text = p.Codigo;
            txt_Existencia.Value = p.Existencias;
            txt_Nombre.Text = p.NombreProducto.ToString();
            txt_Precio.Value = (decimal)p.PrecioUnitario;
            cmb_Categoria.SelectedValue = p.CategoriaFk;
            txt_Codigo.ReadOnly = true;

        }

      

        private void FormularioInventarios_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hecho_Click(object sender, EventArgs e)
        {

            //VALIDACIONES TEXTBOX VACIOS
            //       cod01
            var prodCod = txt_Codigo.Text.Trim();
            if ( prodCod == "" || prodCod.Contains(" ") )
            {
                MessageBox.Show("Codigo articulo es invalido", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Codigo.Focus();
            }
            else if (txt_Nombre.Text.Trim() == "")
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
                    IdProducto = IdProducto,
                    Codigo = txt_Codigo.Text.Trim(),
                    Existencias = (int)txt_Existencia.Value,
                    NombreProducto = txt_Nombre.Text.Trim(),
                    PrecioUnitario = txt_Precio.Value,
                    CategoriaFk = cmb_Categoria.SelectedValue.GetHashCode(),
                    ISV = txt_impuesto.Value,
                    EstadoFk = cb_prod_estado.SelectedIndex+1
                };
                p.Save(p);
                MessageBox.Show("Guardado con exito", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

      


      

       

        
    }
}
