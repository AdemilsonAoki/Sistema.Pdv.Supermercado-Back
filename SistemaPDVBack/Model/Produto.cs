using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Produto
    {
        public float CodBarras { get; set; }
        public int IdProduto { get; set; }

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
        public string StatusTeste { get; set; }



        public Produto()
        {
                
        }

        public Produto(int codBarras, string descricaoProduto, int quantidadeEstoqueProduto, decimal precoVenda,  string statusTeste)
        {

            CodBarras = codBarras;
            DescricaoProduto = descricaoProduto;
            PrecoVenda = precoVenda;
            QuantidadeEstoqueProduto = quantidadeEstoqueProduto;
            StatusTeste = statusTeste;
        }
    }


}
