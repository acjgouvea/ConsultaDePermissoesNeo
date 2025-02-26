using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPermissoes.Erros
{
    public class tratarErros
    {
        public string tratarErro(Exception ex, string procedimentoChamador, string Modulo)
        {
            string erroTratado;


            erroTratado = "Modulo: " + Modulo + "\n"
                        + "Procedimento: " + procedimentoChamador + "\n"
                        + "Descrição do Erro: " + ex.Message + "\n"
                        + "Numero do Erro: " + ex.HResult.ToString() + "\n"
                        + "Linha do Erro: " + EncontrarLinhaDeErro(ex.StackTrace.ToString());

            return erroTratado;
        }


        private string EncontrarLinhaDeErro(string stackTrace)
        {
            // Procurando a substring que contém a linha
            int startIndex = stackTrace.LastIndexOf(":linha ");
            if (startIndex != -1)
            {
                string info = stackTrace.Substring(startIndex + 7); // +7 para ignorar ":linha "
                int endIndex = info.IndexOf("\r\n"); // Procurando o final da linha
                if (endIndex != -1)
                {
                    info = info.Substring(0, endIndex); // Capturando somente a parte com o número da linha
                }
                return info.Trim(); // Removendo espaços extras
            }

            return "";

        }
    }
}
