using SuMueble.Controller;
using SuMueble.Models;
using SuMueble.Views.Prompts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class AgregarEditarColaboradores : Form
    {
        ColaboradorControlador cControlador = new ColaboradorControlador();
        PuestoControlador pControlador = new PuestoControlador();
        public AgregarEditarColaboradores()
        {
            InitializeComponent();
            CargarPuestos();
        }

        private void btn_hecho_Click(object sender, EventArgs e)
        {
            // enviar el insert 
            Colaboradores colaborador = new Colaboradores()
            {
             Clave = txt_clave.Text, 
             Contratado = dtp_contratoIniciado.Value,
             Direccion = txt_direccion.Text,
             DNI = txt_dni.Text,
             Email = txt_correo.Text,
             FechaNacimiento = dtp_fechaNacimiento.Value,
             Nombre = txt_nombre.Text,
             RTN = txt_rtn.Text,
             Tel = txt_telefono.Text,
             FinContrato = dtp_contratoFinalizado.Value,
             IDPuesto = cb_puesto.SelectedValue.GetHashCode()
            };
            cControlador.SaveColaborador(colaborador);
            this.Close();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtp_contratoIniciado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtp_contratoFinalizado_ValueChanged(object sender, EventArgs e)
        {

        }
        private void CargarPuestos()
        {
            cb_puesto.DataSource = pControlador.GetPuestos();
            cb_puesto.DisplayMember = "Puesto";
            cb_puesto.ValueMember = "ID";
        }

        private void btnNuevoPuesto_Click(object sender, EventArgs e)
        {
            string Puesto = Input.Show("Ingrese Un Nuevo Puesto", "Nuevo Puesto");
            if (Puesto != "")
                pControlador.InsertarPuestos(Puesto);
            CargarPuestos();
        }
    }
}
