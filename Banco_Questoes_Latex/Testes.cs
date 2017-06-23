using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Questoes_Latex
{
    public partial class Testes : Form
    {
        public Testes()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            scntillaLatex1.ScintillaEditor.Text = "Caralho!!!";
            scntillaLatex1.Orientacao = Orientation.Horizontal;
            scntillaLatex1.Barra_Preview_Visivel = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Latex L = new Latex();
            //L.Execute_Command("cmd.exe", "", "", "" , System.Diagnostics.ProcessWindowStyle.Normal,false);
            if (scntillaLatex1.Text.Trim() == "") { scntillaLatex1.Text = "$ 6\\frac{1}{9} - 2\\frac{3}{38} + 5\\frac{1}{76} - \\frac{1}{2} $ ";  }
            Image I = L.Image_From_LATEX(scntillaLatex1.Text, null, scntillaLatex1.toolStripContainerPreview.ContentPanel.Width-30, false);
            scntillaLatex1.imagemLatex.Width = I.Width;
            scntillaLatex1.imagemLatex.Height = I.Height;
            scntillaLatex1.imagemLatex.Image = I;
        }
    }
}
