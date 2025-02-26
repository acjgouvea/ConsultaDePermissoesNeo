using System;

namespace ConsultaPermissoes.Transferencia
{
    public class DadosAlteracao
    {
        public int? Loja_IN { get; set; }
        public int? Produto_IN { get; set; }
        public double? PrecoFixo { get; set; }
        public double? MkUpPromocional { get; set; }
        public DateTime? DataValidade { get; set; }
        public string Motivo { get; set; }
    }
}
