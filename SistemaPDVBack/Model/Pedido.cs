using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Pedido
    {
        public int IdPedido { get; set; }
        public Colaborador CodColaborador { get; set; }
        public Cliente CodCliente { get; set; }
        public int Status { get; set; }
        public DateTime DataDoPedido { get; set; }
        public int FormaDePagamento { get; set; }

    }
}
