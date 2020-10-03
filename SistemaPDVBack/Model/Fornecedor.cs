using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Fornecedor : AbsPessoa
    {
        public int IdFornecedor { get; set; }
        public int InscricaoEstadual { get; set; }
        public string NomeFantasia { get; set; }

        public Fornecedor(int idFornecedor, int inscricaoEstadual, string nomeFantasia,
                          int idEndereco, string logradouroPessoa, string ufPessoa, string numeroPessoa,
                          string complementoPessoa, string bairroPessoa, string cidadePessoa)
                          : base(idEndereco, logradouroPessoa, ufPessoa, numeroPessoa, complementoPessoa, bairroPessoa, cidadePessoa)
        {
            IdFornecedor = idFornecedor;
            InscricaoEstadual = inscricaoEstadual;
            NomeFantasia = nomeFantasia;
        }

    }
}
