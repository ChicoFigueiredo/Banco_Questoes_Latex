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
using System.Xml;


namespace Componentes_do_Chico
{
    public partial class ScintillaLatex : UserControl
    {
        public ScintillaLatex()
        {
            InitializeComponent();
            this.Orientacao = Orientation.Vertical;
            Format_Scintila_Latex();
            Autocomplete_Scintilla_Latex();
            Carregar_Menu_Formatacao();
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


        override public string Text
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

            ScintillaEditor.ClearCmdKey(Keys.Control | Keys.F);
        }

        private void Autocomplete_Scintilla_Latex()
        {
            if (_autocomplete == "")
            {
                string arquivo_palavras_reservadas = Properties.Settings.Default.Config_Reservade_Words;
                if (!File.Exists(arquivo_palavras_reservadas))
                {
                    arquivo_palavras_reservadas = Path.Combine(AppContext.BaseDirectory, Properties.Settings.Default.Config_Reservade_Words);
                    if (!File.Exists(arquivo_palavras_reservadas))
                    {
                        arquivo_palavras_reservadas = Path.Combine(Environment.CurrentDirectory, Properties.Settings.Default.Config_Reservade_Words);
                        if (!File.Exists(arquivo_palavras_reservadas))
                        {
                            arquivo_palavras_reservadas = Path.Combine(System.IO.Directory.GetCurrentDirectory(), Properties.Settings.Default.Config_Reservade_Words);
                        }
                    }
                }
                if (File.Exists(arquivo_palavras_reservadas))
                {
                    _autocomplete = File.ReadAllText(arquivo_palavras_reservadas).Replace("\r\n", " ");
                }

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


        private async void Atualiza_Imagem()
        {
            //await Task.Run(() => //This code runs on a new thread, control is returned to the caller on the UI thread.
            //{
            Latex L = new Latex();
            Image I = null;
            string txtLATEX = this.Text;
            int largura_considerada = this.toolStripContainerPreview.ContentPanel.Width - 30;
            await Task.Run(async () =>
            {
                await L.Image_From_LATEX_async(txtLATEX, null, largura_considerada, false);
                I = L.Ultima_Imagem;
            });
            try
            {
                this.imagemLatex.Width = I.Width;
                this.imagemLatex.Height = I.Height;
                this.imagemLatex.Image = I;
            } catch(Exception ex)
            {

            }
        }

        private void ScintillaEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Control)
            {
                e.Handled = true;
                mnuFormatador.ShowDropDown();
            }
        }

        private void ScintillaEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 32)
            {
                // Prevent control characters from getting inserted into the text buffer
                e.Handled = true;
                return;
            }
        }

        private void Inserir_Item_Texto_do_Menu(object sender, EventArgs e)
        {
            ToolStripMenuItem m = (ToolStripMenuItem)sender;
            string[] item = m.Tag.ToString().Replace("\\\\n","\n").Split(';');
            string texto_a_inserir = item[0];
            int posicoes_a_recuar = item.Count() > 1 ? int.Parse(item[1]) : 0;
            ScintillaEditor.AddText(texto_a_inserir);
            ScintillaEditor.CurrentPosition += posicoes_a_recuar;
            ScintillaEditor.SelectionEnd = ScintillaEditor.CurrentPosition;
        }

        private void ScintillaEditor_DelayedTextChanged(object sender, EventArgs e)
        {
            Atualiza_Imagem();
        }

        private void Carregar_Menu_Formatacao()
        {
            //ToolStripMenuItem m = new ToolStripMenuItem("&Formatação");
            LoadDynamicMenu(mnuFormatador);
        }


        private string m_xmlPath = "config\\menuFormatacao.xml";
        [ToolboxItem("Extended"), Category("Extended"), Description("The path to the Menu XML configuration file.")]
        public string XmlPath { get { return m_xmlPath; } set { m_xmlPath = value; } }

        public void LoadDynamicMenu(ToolStripDropDownButton MenuRaiz)
        {
            string xmlPath;

            if (System.IO.Path.IsPathRooted(XmlPath))
                xmlPath = XmlPath;
            else
                xmlPath = Path.Combine(Application.StartupPath, XmlPath);

            if (System.IO.File.Exists(xmlPath))
            {

                XmlDocument document = new XmlDocument();
                document.Load(xmlPath);

                XmlElement element = document.DocumentElement;

                foreach (XmlNode node in document.FirstChild.ChildNodes)
                {
                    ToolStripMenuItem menuItem = new ToolStripMenuItem();

                    menuItem.Name = node.Attributes["Name"].Value;
                    menuItem.Text = node.Attributes["Text"].Value;

                    MenuRaiz.DropDownItems.Add(menuItem);
                    GenerateMenusFromXML(node, (ToolStripMenuItem)MenuRaiz.DropDownItems[MenuRaiz.DropDownItems.Count - 1]);
                }
            }
        }

        private void GenerateMenusFromXML(XmlNode rootNode, ToolStripMenuItem menuItem)
        {
            ToolStripItem item = null;
            ToolStripSeparator separator = null;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                if (node.Attributes["Text"].Value == "-")
                {
                    separator = new ToolStripSeparator();

                    menuItem.DropDownItems.Add(separator);
                }
                else
                {
                    item = new ToolStripMenuItem();
                    item.Name = node.Attributes["Name"].Value;
                    item.Text = node.Attributes["Text"].Value;
                    item.Tag = node.Attributes["Tag"] == null ? "" : node.Attributes["Tag"].Value ?? "";

                    menuItem.DropDownItems.Add(item);

                    if (node.Attributes["FormLocation"] != null)
                        item.Tag = node.Attributes["FormLocation"].Value;

                    // add an event handler to the menu item added
                    if (node.Attributes["Click"] != null)
                    {
                        FindEventsByName(item, this, true, "Click", node.Attributes["Click"].Value);
                    }

                    GenerateMenusFromXML(node, (ToolStripMenuItem)menuItem.DropDownItems[menuItem.DropDownItems.Count - 1]);
                }
            }
        }

        private void FindEventsByName(object sender, object receiver, bool bind, string handlerPrefix, string handlerSuffix)
        {
            System.Reflection.EventInfo[] SenderEvent = sender.GetType().GetEvents();
            Type ReceiverType = receiver.GetType();
            System.Reflection.MethodInfo method;

            foreach (System.Reflection.EventInfo e in SenderEvent)
            {
                if (e.Name == handlerPrefix)
                {
                    method = ReceiverType.GetMethod(string.Format("{0}", handlerPrefix), System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

                    try
                    {
                        System.Delegate d = System.Delegate.CreateDelegate(e.EventHandlerType, receiver, handlerSuffix); //method.Name

                        if (bind)
                            e.AddEventHandler(sender, d);
                        else
                            e.RemoveEventHandler(sender, d);

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}
