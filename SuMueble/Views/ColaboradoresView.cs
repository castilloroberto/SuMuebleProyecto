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
            AgregarEditarColaboradores addEditColaborador = new AgregarEditarColaboradores();

            addEditColaborador.ShowDialog();
            //actailizar data grid despues de agregar 
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
    }
}
