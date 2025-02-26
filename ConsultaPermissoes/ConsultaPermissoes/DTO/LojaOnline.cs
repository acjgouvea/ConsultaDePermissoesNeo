

namespace ConsultaPermissoes.Transferencia
{
    public class LojaOnline
    {
        public int? loj_codigo_IN { get; set; }
        public string loj_descricao_VC { get; set; }

        public string DescricaoLojaCompleta
        {
            get
            {
                return $"{loj_codigo_IN} - {loj_descricao_VC}";
            }
        }
    }

    public class Familia
    {
        public int? pro_familia { get; set; }
        public string fam_descricao { get; set; }
    }

    public class Grupo
    {
        public int? pro_grupo { get; set; }
        public string gru_descricao { get; set; }
    }

    public class SubGrupo
    {
        public int? sub_codigo { get; set; }
        public string sub_descricao { get; set; }
    }

    public class Empresa
    {
        public int? emp_empresa_IN { get; set; }
        public string emp_fantasia_VC { get; set; }
        public string DescricaoEmpresaCompleta
        {
            get
            {
                return $"{emp_empresa_IN} - {emp_fantasia_VC}";
            }
        }
    }

    public class Margem
    {
        public int? loj_codigo_IN { get; set; }
        public string loj_margemdelucropadrao_MN { get; set; }
    }

    public class Temp
    {
        public int? tem_codigo_IN { get; set; }
        public string tem_descricao_VC { get; set; }
    }

    public class ProdutoDesativar
    {
        public int? ppp_codigo_IN { get; set; }
    }

}
