using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Fornecedor 
    {
        public int IdFornecedor { get; set; }
        public int InscricaoEstadual { get; set; }
        public string NomeFantasia { get; set; }
       public string LogradouroPessoa { get; set; }
        public string UfPessoa { get; set; }
        public string NumeroPessoa { get; set; }
        public string ComplementoPessoa { get; set; }

        public string BairroPessoa { get; set; }
        public string CidadePessoa { get; set; }


    }
}
