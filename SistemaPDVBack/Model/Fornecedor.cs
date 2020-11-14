﻿using MySql.Data.MySqlClient;
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
        public string InscricaoEstadual { get; set; }
        public string NomeFantasia { get; set; }
        public string UfPessoa { get; set; }
        public string NumeroPessoa { get; set; }
        public string ComplementoPessoa { get; set; }

        public string BairroPessoa { get; set; }
        public string CidadePessoa { get; set; }
        public int CepFornecedor { get; set; }

        public int StatusAtivo { get; set; }
        public string  Cnpj { get; set; }
        public string Rua { get; set; }





    }
}
