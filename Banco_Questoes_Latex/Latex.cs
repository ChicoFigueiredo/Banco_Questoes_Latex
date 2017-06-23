using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;
using System.Drawing.Imaging;

namespace Banco_Questoes_Latex
{
    class Latex
    {
        private string caminho_latex = Properties.Settings.Default.MikTex_Bin_Folder;
        private string caminho_Temp = Properties.Settings.Default.Temp_Folder;

        private string _Header_Padrao_LATEX = Properties.Settings.Default.Header_Padrao_LATEX;
        private string Header_Padrao_LATEX { get {
                return _Header_Padrao_LATEX.Replace("#PW#", Paper_Width.ToString());
        } }

        private string _Footer_Padrao_LATEX = Properties.Settings.Default.Footer_Padrao_LATEX;
        private string Footer_Padrao_LATEX { get {
                return _Footer_Padrao_LATEX;
        } }

        private Encoding ISO_8859_1 = System.Text.Encoding.GetEncoding("iso-8859-1");

        private decimal _paperWidth = 13;
        public decimal Paper_Width { get { return _paperWidth; } set { _paperWidth = value; } }

        public struct Item_Lista_Figuras {
            public string hash;
            public string tipo;
            public Image Image;
        }

        public Image Ultima_Imagem { get; set; }

        public async Task Image_From_LATEX_async(string LATEX, List<Item_Lista_Figuras> Imagens, int Largura = 150, bool addComment = false)
        {
            Ultima_Imagem = Image_From_LATEX(LATEX, Imagens, Largura, addComment);
        }

        public Image Image_From_LATEX(string LATEX, List<Item_Lista_Figuras> Imagens, int Largura = 150, bool addComment = false )
        {
            string Diretorio_Atual = caminho_Temp;
            try { Diretorio_Atual = Directory.CreateDirectory(Diretorio_Atual).FullName; } catch (Exception ex) { };
            string Nome_Principal = Md5Hash(LATEX);
            string Arq_Latex_Nome = (Diretorio_Atual.Reverse().ToArray()[0] != '\\' ? Diretorio_Atual + "\\" : Diretorio_Atual) + Nome_Principal + ".tex";
            string Arq_PNG_Nome = (Diretorio_Atual.Reverse().ToArray()[0] != '\\' ? Diretorio_Atual + "\\" : Diretorio_Atual) + Nome_Principal + "-" + Largura + ".png";
            try { File.Delete(Arq_Latex_Nome); } catch (Exception ex) { };
            try { File.Delete(Arq_PNG_Nome); } catch (Exception ex) { };
            StreamWriter Arq_Latex = new StreamWriter(Arq_Latex_Nome, false, ISO_8859_1);
            string latex_saida = Header_Padrao_LATEX + "\n" + LATEX + "\n" + Footer_Padrao_LATEX;
            Arq_Latex.Write(latex_saida);
            Arq_Latex.Close();
            if (Imagens != null)
            {
                foreach(Item_Lista_Figuras it in Imagens)
                {
                    it.Image.Save(Diretorio_Atual + it.hash + ".png", ImageFormat.Png);
                }
            }
            if (Generate_PNG_From_LATEX(Arq_Latex_Nome, ref Arq_PNG_Nome, Diretorio_Atual, Largura))
            {
                Image img = Image.FromFile(Arq_PNG_Nome);
                if (addComment)
                {
                    img = Add_Comment_To_Image(img, LATEX,ImageFormat.Png);
                }
                return img;
            }
            else
            {
                return null;
            }

        }

        public bool Generate_PNG_From_LATEX(string Arq_Latex, ref string Arq_PNG, string Diretorio = "", int Largura = 150)
        {
            int Largura_PNG = Largura * 600 / 2869;
            Arq_PNG = (((Arq_PNG ?? "") == "") ? Arq_Latex + ".png" : Arq_PNG);
            if (File.Exists(Arq_Latex))
            {
                Execute_Command("latex.exe", "--src-specials -interaction=nonstopmode \"" + Arq_Latex + "\"",Diretorio);
                string Arq_DVI = Arq_Latex.Replace(".tex", ".dvi");
                Execute_Command("dvipng.exe", "\"" + Arq_DVI + "\" -D " + Largura_PNG + " -o \"" + Arq_PNG + "\"", Diretorio);
                if (File.Exists(Arq_PNG))
                {
                    return (new FileInfo(Arq_PNG)).Length > 0;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }



        public bool Execute_Command(string Command, string Arguments = "", string Diretorio = "", string EnviromentPath = "", ProcessWindowStyle Condicao_Janela = ProcessWindowStyle.Hidden, bool Nao_Criar_Nova_Janela = true)
        {
            try{ Directory.CreateDirectory(Diretorio == "" ? caminho_Temp : Diretorio); } catch (Exception ex){};
            string enviromentPath = System.Environment.GetEnvironmentVariable("PATH") != "" ? (EnviromentPath != "" ? ";" + EnviromentPath : (caminho_latex != "" ? ";" + caminho_latex : "")) : "";
            var paths = enviromentPath.Split(';');
            string exePath = paths.Select(x => Path.Combine(x, Command))
                               .Where(x => File.Exists(x))
                               .FirstOrDefault();

            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = exePath,
                Arguments = Arguments,
                WorkingDirectory = Diretorio == "" ? caminho_Temp : Diretorio,
                CreateNoWindow = Nao_Criar_Nova_Janela,
                WindowStyle = Condicao_Janela,
                UseShellExecute = false
            };
            startInfo.EnvironmentVariables["Path"] += startInfo.EnvironmentVariables["Path"] != "" ? (EnviromentPath != "" ? ";" + EnviromentPath : (caminho_latex != "" ? ";" + caminho_latex : "")) : "";

            Process cmd = new Process();

            cmd.StartInfo = startInfo;

            cmd.Start();
            cmd.WaitForExit();
            cmd.Close();
            return true;
        }

        public string Md5Hash(string input)
        {
            MD5 md5Hash_ = MD5.Create();
            byte[] data = md5Hash_.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for(int i=0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public Image Add_Comment_To_Image(Image Img, string Comment, ImageFormat formato)
        {
            formato = formato ?? ImageFormat.Png;
            Image img_return = Img;
            PropertyItem prp = null;
            foreach (PropertyItem prp2 in Img.PropertyItems){ prp = prp2; break; }; //POG gambiarra do caraio, construtor para System.Drawing.Imaging.PropertyItem que não existe....
            byte[] palavra = Encoding.UTF8.GetBytes(Comment);
            prp.Type = 2;
            prp.Id = 0x9286;
            prp.Value = palavra;
            prp.Len = palavra.Count();
            img_return.SetPropertyItem(prp);
            return img_return;
        }
        
    }
}
