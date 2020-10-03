using SistemaPDVBack.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class AbsPessoa:IEndereco
    {

        public int IdEndereco { get; set; }
        public string LogradouroPessoa { get; set; }
        public string UfPessoa { get; set; }
        public string NumeroPessoa { get; set; }
        public string ComplementoPessoa { get; set; }
        public string BairroPessoa { get; set; }
        public string CidadePessoa { get; set; }

        public AbsPessoa(int idEndereco, string logradouroPessoa, string ufPessoa, string numeroPessoa, string complementoPessoa, string bairroPessoa, string cidadePessoa)
        {
            IdEndereco = idEndereco;
            LogradouroPessoa = logradouroPessoa;
            UfPessoa = ufPessoa;
            NumeroPessoa = numeroPessoa;
            ComplementoPessoa = complementoPessoa;
            BairroPessoa = bairroPessoa;
            CidadePessoa = cidadePessoa;
        }
    }
}
