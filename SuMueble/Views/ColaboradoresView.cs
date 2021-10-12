using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuMueble.Controller;
using SuMueble.Models;
using SuMueble;
using System.Linq;

namespace SuMueble.Views
{
    public partial class ColaboradoresView : UserControl
    {
        ColaboradorControlador cControlador = new ColaboradorControlador();
        List<Colaboradores> colaboradores;

        public ColaboradoresView()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            dgv_colaboradores.DataSource = null;
            colaboradores = cControlador.Colaboradores().ToList();
            dgv_colaboradores.DataSource = colaboradores;
        }

        

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            AgregarEditarColaboradores addEditColaborador = new AgregarEditarColaboradores();

            addEditColaborador.ShowDialog();
            CargarDatos();
            //actailizar data grid despues de agregar 
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string colabodador = GetCell(0);
            var addEditColaborador = new AgregarEditarColaboradores(colabodador);

            addEditColaborador.ShowDialog();
            //actailizar data grid despues de agregar
            CargarDatos();
        }
        public dynamic GetCell(int cell)
        {
            int idx = dgv_colaboradores.CurrentRow.Index;
            return dgv_colaboradores.Rows[idx].Cells[cell].Value;

        }
        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            string buscar =txt_busqueda.Text.ToLower();

            List<Colaboradores> filtrados = colaboradores.Where<Colaboradores>(x => {

                return x.Nombre.ToLower().StartsWith(buscar) || x.DNI.ToLower().StartsWith(buscar);


            }).ToList();

            dgv_colaboradores.DataSource = null;
            dgv_colaboradores.DataSource = filtrados;
        }

        private void btn_terminarContrato_Click(object sender, EventArgs e)
        {

            if (dgv_colaboradores.SelectedRows.Count > 0)
            {
                DialogResult boton = MessageBox.Show("¿Desea terminar el contrato seleccionado?", "Mensaje del sistena", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (boton == DialogResult.OK)
                {
                    cControlador.desactivarColaborador(GetCell(0));
                    CargarDatos();
               
                }
               
            }
            else 
            {
                MessageBox.Show("No hay ningún colaborador seleccionado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            txt_busqueda.Text = "";
            txt_busqueda.Focus();

        }

        private void txt_busqueda_Leave(object sender, EventArgs e)
        {
            txt_busqueda.Text = txt_busqueda.Text.Trim();
        }
    }
}
