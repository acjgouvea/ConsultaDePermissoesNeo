using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPermissoes.Transferencia
{
    public class Filtros
    {
        public int Tipo_IN { get; set; }  
        public int? usu_usuario_IN {  get; set; }
        public string usu_login_VC { get; set; }
        public int? per_permissao_IN { get; set; }
        public string per_resumido_VC { get; set; }

    }
}
