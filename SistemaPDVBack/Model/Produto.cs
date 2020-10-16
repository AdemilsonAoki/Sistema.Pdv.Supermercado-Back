using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Produto
    {
        public int CodBarras { get; set; }
        public int CodFornecedor { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal MargemLucro { get; set; }
        public string  DataFabricacao { get; set; }
        public string DataVencimento { get; set; }
        public int QuantidadeEstoqueProduto { get; set; }
        public string Categoria { get; set; }
        public int StatusAtivo { get; set; }

    
    }
    
    
}
