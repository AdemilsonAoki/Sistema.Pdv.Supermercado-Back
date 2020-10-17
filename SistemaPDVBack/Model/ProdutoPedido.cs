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
        public int CodPedido { get; set; }
        public int CodProduto { get; set; }

        public int QuantidadeItemPedido { get; set; }


    }
}
