using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views.Prompts
{
    public class Input
    {
        public static string Show(string texto, string titulo)
        {
            Form Prompt = new Form()
            {
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = titulo,
                StartPosition = FormStartPosition.CenterParent
            };
            Label textlabel = new Label() {Left=50, Top=20, Text=texto, Width=400};
            TextBox textbox = new TextBox() {Left = 50, Top = 50, Width=400, Height=37 };
            Button btn = new Button() {Text="OK", Left=350, Width=100, Height=37, Top=100, DialogResult=DialogResult.OK};
            btn.Click += (sender, e) => { Prompt.Close();};
            Prompt.Controls.Add(textbox);
            Prompt.Controls.Add(btn);
            Prompt.Controls.Add(textlabel);
            Prompt.AcceptButton = btn;
            return  textbox.Text;

        }
    }
}
