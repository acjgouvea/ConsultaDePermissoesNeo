using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPermissoes.Transferencia
{
    public class DadosGrid
    {
        public bool sel { get; set; }
        public int? loj_codigo_IN { get; set; }

        public int? pro_codigo { get; set; }

        public int? emp_empresa_IN { get; set; }

        public int? pro_produto { get; set; }

        public string pro_descricao { get; set; }

        public string fam_descricao { get; set; }

        public string gru_descricao { get; set; }

        public string sub_descricao { get; set; }

        public string Num_CA { get; set; }

        public string for_razao { get; set; }

        public string pro_referencia_VC { get; set; }

        public string Descricao_Grade { get; set; }

        public DateTime? DataVigencia { get; set; }

        public string pro_marca_VC { get; set; }

        public string tem_descricao_VC { get; set; }

        public double? loj_margemdelucropadrao_MN { get; set; }

        public string margemMkup
        {
            get
            {
                return !string.IsNullOrEmpty(loj_margemdelucropadrao_MN?.ToString())? $"{loj_margemdelucropadrao_MN}%": string.Empty; 
            }
        }

        public double? ppp_mKbppromocional_MN { get; set; }

        public string margemMkupEspecial
        {
            get
            {
                return !string.IsNullOrEmpty(ppp_mKbppromocional_MN?.ToString()) ? $"{ppp_mKbppromocional_MN}%" : string.Empty;
            }
        }

        public DateTime ppp_datacriacao_DT { get; set; }

        public double? ppp_precopromocional_MN { get; set; }

        public double? PrecoCompra { get; set; }

        public double PrecoCompraFormat
        {
            get
            {
                return PrecoCompra ?? 0;
            }
        }

        public double? PrecoCheioB2C { get; set; }

        public double PrecoCheioB2CFormat
        {
            get
            {
                return PrecoCheioB2C ?? 0;
            }
        }

        public double? PrecoComercial { get; set; }

        public double PrecoComercialFormat
        {
            get
            {
                return PrecoComercial ?? 0;
            }
        }

        public double? PrecoDiferenciadoB2C { get; set; }

        public double PrecoDiferenciadoB2CFormat
        {
            get
            {
                return PrecoDiferenciadoB2C ?? 0;
            }
        }

        public int? Codigo_Grade { get; set; }
        public int? Saldo {  get; set; }
    }
}
