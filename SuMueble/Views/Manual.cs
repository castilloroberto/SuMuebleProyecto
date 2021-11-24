using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class Manual : Form
    {
        public Manual(string seccion = "ventascontado")
        {
            InitializeComponent();
            string url = "https://robert-virtual.github.io/web-manual/#"+seccion;
            webView.Source = new Uri(url);
        }
    }
}
