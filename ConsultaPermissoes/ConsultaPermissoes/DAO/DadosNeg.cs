using Falco.BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using ConsultaPermissoes.Transferencia;
using ConsultaPermissoes.Erros;

namespace ConsultaPermissoes.Negocio {
    public class DadosNeg {
        public DataSet SelecionarPemissoesDeUsuario(Filtros filtros) {
            try {

                //DataSet dataSet = new DataSet();

                clsBancoDados.LimparParametros();
                clsBancoDados.AdicionarParametro("@PAR_tipo_IN", filtros.Tipo_IN, ParameterDirection.Input);
                clsBancoDados.AdicionarParametro("@PAR_usuario_IN", filtros.usu_usuario_IN, ParameterDirection.Input);
                clsBancoDados.AdicionarParametro("@PAR_login_VC", filtros.usu_login_VC, ParameterDirection.Input);
                clsBancoDados.AdicionarParametro("@PAR_permissao_IN", filtros.per_permissao_IN, ParameterDirection.Input);
                clsBancoDados.AdicionarParametro("@PAR_permResumido_VC", filtros.per_resumido_VC, ParameterDirection.Input);


                return clsBancoDados.Executar("usp_SelecionarPemissoesDeUsuario", CommandType.StoredProcedure);
                //return dataSet;
            } catch (Exception ex) {
                // Trata erros e exibe mensagem para o usuário
                tratarErros tratarErros = new tratarErros();
                string erroTratado = tratarErros.tratarErro(ex, MethodBase.GetCurrentMethod()?.Name.ToString(), this.GetType().Name);

                MessageBox.Show(erroTratado, "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Retorna um DataSet vazio em caso de falha
                return new DataSet();
            }
        }


    }
}
