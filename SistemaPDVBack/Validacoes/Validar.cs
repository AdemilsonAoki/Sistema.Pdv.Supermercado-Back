using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Validacoes
{
    class Validar
    {
        public Validar(string teste)
        {
            this.conversao(teste);
        }

        public void conversao(string teste) {

            decimal teste1 = decimal.Parse(teste);
        }
    }
}
