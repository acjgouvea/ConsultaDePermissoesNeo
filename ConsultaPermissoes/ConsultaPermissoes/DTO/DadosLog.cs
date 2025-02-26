using System;

namespace ConsultaPermissoes.Transferencia
{
    public class DadosLog
    {
          public string ppp_usuariocriacao_VC { get; set; }
          
          public DateTime? ppp_datacriacao_DT { get; set; }
          
          public string ppp_usuarioultimaalteracao_VC { get; set; }
          
          public DateTime? ppp_dataultimaalteracao_DT { get; set; }
          
          public string ppp_usuariodesativacao_VC { get; set; }
          
          public DateTime? ppp_datadesativacao_DT { get; set; }
          
          public int? ppp_loja_IN { get; set; }
          
          public double? ppp_precopromocional_MN {  get; set; }

            public string PrecoPromocionalFormat
            {
                get
                {
                    return ppp_precopromocional_MN.HasValue ? $"R${ppp_precopromocional_MN.Value:N2}" : "R$0,00";
                }
            }

        public double? ppp_mKbppromocional_MN { get; set; }
          
          public DateTime? ppp_datavalidade_DT { get; set; }
          
          public int? ppp_produto_IN { get; set; }

          public string ppp_motivo_VC { get; set; }

    }
}
