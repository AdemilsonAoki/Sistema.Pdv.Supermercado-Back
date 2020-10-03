using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Interface
{
    interface IEndereco
    {
        int IdEndereco { get; set; }
        string LogradouroPessoa { get; set; }
        string UfPessoa { get; set; }
        string NumeroPessoa { get; set; }
        string ComplementoPessoa { get; set; }

        string BairroPessoa { get; set; }
        string CidadePessoa { get; set; }
    }
}
