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
        public string CpfColaborador { get; set; }
        public int ? CodCliente { get; set; }
        public int Status { get; set; }
        public string DataDoPedido { get; set; }
        public string FormaDePagamento { get; set; }
        public string TipoCliente { get; set; }


    }
}
