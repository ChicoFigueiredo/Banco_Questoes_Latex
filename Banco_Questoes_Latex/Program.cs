using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Banco_Questoes_Latex
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Testes());
        }

        private static System.Threading.Timer Vigia = new System.Threading.Timer(VigiaTimerCallback, 5, 0, 300000);

        private static void VigiaTimerCallback(Object o)
        {
            Limpeza_Ambiente();
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }


        private static async void Limpeza_Ambiente()
        {
            await Task.Run(() => {
                string Diretorio_Atual = Properties.Settings.Default.Temp_Folder;
                try { Diretorio_Atual = Directory.CreateDirectory(Diretorio_Atual).FullName; } catch (Exception ex) { };
                Array.ForEach(Directory.GetFiles(Diretorio_Atual), delegate (string path) { try { File.Delete(path); } catch (Exception ex) { };  });
            });
        }
    }
}
