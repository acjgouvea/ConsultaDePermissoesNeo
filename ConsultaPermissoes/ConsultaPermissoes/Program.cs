using Falco.BancoDados;
using ConsultaPermissoes;  
using System;
using System.Windows.Forms;
using ConsultaPermissoes.Apresentacao;

namespace ConsultaPermissoes
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (args.Length > 0)
            {
                clsBancoDados.Servidor = args[0];
                clsBancoDados.Banco = args[1];
                clsBancoDados.Usuario = args[2];
                clsBancoDados.Senha = args[3];
            }
            else
            {
                clsBancoDados.Servidor = "192.168.10.8";
                clsBancoDados.Banco = "MASERP";
                clsBancoDados.Usuario = "jose.machado";
                clsBancoDados.Senha = "Myx!@dp7*%iS";
                clsBancoDados.Conectar(true);
            }

            Application.Run(new frmSelecionarPermissoes());
        }
    }
}
