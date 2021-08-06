using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views.Prompts
{
    public partial class Factura : Form
    {
        public Factura(List<DetallesVentas> detalles)
        {
            InitializeComponent();
            dgv_factura.AutoGenerateColumns = false;
            dgv_factura.DataSource = detalles;
            DataGridHeight();

            fecha.Text = string.Format("Fecha: {0:d}",DateTime.Now.Date);
            hora.Text = string.Format("Hora: {0}", DateTime.Now.ToString("h:mm tt").ToUpper());
            cajero.Text = string.Format("Cajero: {0}",Menu.colaborador.Nombre);

        }


        private void DataGridHeight()
        {
            var height = dgv_factura.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgv_factura.Rows)
            {
                height += row.Height;
            }
            dgv_factura.Height = height;
            main_panel.Height = height+55;
        }
    }
}
