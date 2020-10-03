using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class ProdutoPedido
    {
        public int IdProdutoPedido { get; set; }
        public Pedido CodPedido { get; set; }
        public Produto CodProduto { get; set; }

        public int QuantidadeItemPedido { get; set; }


    }
}
