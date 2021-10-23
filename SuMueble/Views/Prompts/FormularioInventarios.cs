using SuMueble.DataAccess;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace SuMueble
{
    public partial class FormularioInventarios : Form
    {
        private int IDglobal = 0;


        public FormularioInventarios(int ID = 0)
        {
            InitializeComponent();
            using (var db = new SuMuebleDBContext())
            {
                cmb_Categoria.DataSource = db.Categorias.ToList();

            }
            cmb_Categoria.DisplayMember = "Nombre";
            cmb_Categoria.ValueMember = "Id";

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

            Producto p = new Producto();
            using (var db = new SuMuebleDBContext())
            {
                p = db.Productos.Find(ID);
            }
            txt_Existencia.Value = p.Cantidad;
            txt_Nombre.Text = p.Nombre;
            txt_Precio.Value = p.Precio;
            cmb_Categoria.SelectedValue = p.CategoriaId;

        }

      

        private void FormularioInventarios_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hecho_Click(object sender, EventArgs e)
        {

            //VALIDACIONES TEXTBOX VACIOS
            //       cod01
            if (txt_Nombre.Text.Trim() == "")
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
                try
                {
                    Producto p = new Producto()
                    {
                        Cantidad = (int)txt_Existencia.Value,
                        Nombre = txt_Nombre.Text.Trim(),
                        Precio = txt_Precio.Value,
                        CategoriaId = cmb_Categoria.SelectedValue.GetHashCode(),
                        Impuesto = txt_impuesto.Value,
                        Descripcion = txt_description.Text.Trim()
                    };

                    using (var db = new SuMuebleDBContext())
                    {
                        db.Productos.Add(p);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Guardado con exito", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (Exception err)
                {

                    MessageBox.Show($"Error:{err}", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }

        }

      


      

       

        
    }
}
