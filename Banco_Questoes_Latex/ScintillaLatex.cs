using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using System.IO;

namespace Banco_Questoes_Latex
{
    public partial class ScintillaLatex : UserControl
    {
        public ScintillaLatex()
        {
            InitializeComponent();
            this.Orientacao = Orientation.Vertical;
            Format_Scintila_Latex();
            Autocomplete_Scintilla_Latex();
        }

        private string _autocomplete = "";

        public Orientation Orientacao
        {
            get
            {
                return splitContainerPreview.Orientation;
            }

            set
            {
                splitContainerPreview.Orientation = value;
                if (value == Orientation.Horizontal)
                {
                    splitContainerPreview.SplitterDistance = this.Height / 2;
                }
                else
                {
                    splitContainerPreview.SplitterDistance = this.Width / 2;
                }
            }
        }

        public int Intervalo_Atualizacao_Picturebox
        {
            get
            {
                return atualizaPictureBox.Interval;
            }

            set
            {
                atualizaPictureBox.Interval = value;
            }
        }

        private bool _Atualizaar_Picturebox = true;

        public bool Atualizaar_Picturebox
        {
            get
            {
                return _Atualizaar_Picturebox;
            }

            set
            {
                _Atualizaar_Picturebox = value;
            }
        }

        public bool Barra_Scintilla_Visivel
        {
            get
            {
                return toolStripScintilla.Visible;
            }

            set
            {
                toolStripScintilla.Visible = value;
            }
        }

        public bool Barra_Preview_Visivel
        {
            get
            {
                return toolStripPreview.Visible;
            }

            set
            {
                toolStripPreview.Visible = value;
            }
        }


        override public string  Text
        {
            get
            {
                return ScintillaEditor.Text;
            }

            set
            {
                ScintillaEditor.Text = value;
            }
        }

        private void Format_Scintila_Latex()
        {
            ScintillaEditor.Lexer = ScintillaNET.Lexer.Latex;

            ScintillaEditor.Styles[Style.Latex.Default].Font = "Consolas";

            ScintillaEditor.Styles[Style.Latex.Math].ForeColor = Color.Red;
            ScintillaEditor.Styles[Style.Latex.Math].Bold = true;

            ScintillaEditor.Styles[Style.Latex.Math2].ForeColor = Color.Red;
            ScintillaEditor.Styles[Style.Latex.Math2].Bold = true;

            ScintillaEditor.Styles[Style.Latex.Tag].ForeColor = Color.Red;
            ScintillaEditor.Styles[Style.Latex.Tag].Bold = true;

            ScintillaEditor.Styles[Style.Latex.Tag2].ForeColor = Color.Red;
            ScintillaEditor.Styles[Style.Latex.Tag2].Bold = true;

            ScintillaEditor.Styles[Style.Latex.ShortCommand].ForeColor = Color.Red;
            ScintillaEditor.Styles[Style.Latex.ShortCommand].Bold = true;

            ScintillaEditor.Styles[Style.Latex.Command].ForeColor = Color.Blue;
            ScintillaEditor.Styles[Style.Latex.Command].Bold = true;

            ScintillaEditor.Styles[Style.Latex.Comment].ForeColor = Color.Green;
            ScintillaEditor.Styles[Style.Latex.Comment].Bold = true;

        }

        private void Autocomplete_Scintilla_Latex()
        {
            if (_autocomplete == "")
            {
                _autocomplete = File.ReadAllText(Properties.Settings.Default.Config_Reservade_Words).Replace("\r\n"," ");
            }
        }

        private void ScintillaEditor_CharAdded(object sender, CharAddedEventArgs e)
        {
            // Find the word start
            var currentPos = this.ScintillaEditor.CurrentPosition;
            var wordStartPos = this.ScintillaEditor.WordStartPosition(currentPos, true);

            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0)
            {
                if (!this.ScintillaEditor.AutoCActive)
                    this.ScintillaEditor.AutoCShow(lenEntered, _autocomplete);
                if (!atualizaPictureBox.Enabled)
                {
                    atualizaPictureBox.Stop();
                    atualizaPictureBox.Start();
                }
            }
        }

        private void atualizaPictureBox_Tick(object sender, EventArgs e)
        {
            atualizaPictureBox.Stop();
            Atualiza_Imagem();
        }

        private async void Atualiza_Imagem()
        {
            //await Task.Run(() => //This code runs on a new thread, control is returned to the caller on the UI thread.
            //{
                Latex L = new Latex();
                Image I = null;
                string txtLATEX = this.Text;
                int largura_considerada = this.toolStripContainerPreview.ContentPanel.Width - 30;
                await Task.Run(async () => {
                    await L.Image_From_LATEX_async(txtLATEX, null, largura_considerada, false);
                    I = L.Ultima_Imagem;
                });
                this.imagemLatex.Width = I.Width;
                this.imagemLatex.Height = I.Height;
                this.imagemLatex.Image = I;
                atualizaPictureBox.Stop();
            //});
            
        }

        private void ScintillaEditor_BeforeInsert(object sender, BeforeModificationEventArgs e)
        {
            if (!atualizaPictureBox.Enabled)
            {
                atualizaPictureBox.Stop();
                atualizaPictureBox.Start();
            }
        }
    }
}
