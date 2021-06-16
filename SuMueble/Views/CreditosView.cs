using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class CreditosView : UserControl
    {
        public CreditosView()
        {
            InitializeComponent();
        }


        private void btn_pagarcuota_Click(object sender, EventArgs e)
        {
            PagarCuota pagarCuota = new PagarCuota();
            pagarCuota.ShowDialog();
        }
    }
}
