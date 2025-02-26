

using System;

namespace ConsultaPermissoes.Transferencia
{
    public class MkupLoja
    {
        public int? loj_codigo_IN { get; set; }
        public double? loj_margemdelucropadrao_MN { get; set; } 
    }

    public class LogMkupLoja
    {
        public int? loj_loja_IN { get; set; }
        public double? MkupPadrao { get; set; }
        public string Usuario_Log { get; set; }  
        public DateTime Data_Log { get; set; }  
    }
}
