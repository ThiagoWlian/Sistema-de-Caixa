using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FrenteCaixa
{
    class Log
    {
        private String textoArquivoLog;

        public void insereTextoArquivo(String texto)
        {
            textoArquivoLog = File.ReadAllText(System.Reflection.Assembly.GetExecutingAssembly().Location);
            StreamWriter log;
            String caminho = ("C:\\Users\\ThiagoW\\Desktop\\log.txt");
            log = File.CreateText(caminho);
            log.WriteLine("#----------------------------------------------------LOG-----------------------------------------------------#\r\n" + DateTime.Now + " " + texto + "\r\n" + textoArquivoLog);
            log.Close();
        }

    }
}
