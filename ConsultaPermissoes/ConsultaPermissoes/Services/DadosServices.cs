using ConsultaPermissoes.Negocio;
using System;
using System.Data;
using ConsultaPermissoes.Transferencia;

namespace ConsultaPermissoes.Services
{
    public class DadosServices
    {
        public DataSet carregaObjetoFiltro(Filtros filtros)
        {
            try
            {
                DadosNeg dados = new DadosNeg();
                DataSet ds = new DataSet();

                ds = dados.SelecionarPemissoesDeUsuario(filtros);

                return ds;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
      
    }
}
