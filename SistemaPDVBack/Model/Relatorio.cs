using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Relatorio
    {
        string dataInicial;
        string dataFinal;
        public string DataInicial { get { return dataInicial;} set {dataInicial = value; } }
        public string DataFinal { get { return dataFinal; } set { dataFinal = value; } }

    }
}
