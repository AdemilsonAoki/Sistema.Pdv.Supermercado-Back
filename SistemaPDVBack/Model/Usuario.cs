using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public string cpfColaborador { get; set; }

        public string Login { get; set; }
        public string Senha { get; set; }
        public int StatusAtivo { get; set; }

    }
}
