using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Colaborador
    {

        public int IdColaborador { get; set; }
        public string NomeColaborador { get; set; }

        public Departamento CodDepartamento { get; set; }

        public string CpfColaborador { get; set; }

        public int AtivoColaborador { get; set; }
        public string CargoColaborador { get; set; }
        public string TelefoneColaborador { get; set; }
        public string EmailPessoalColaborador { get; set; }
        public string EmailCorporativo { get; set; }


    }

    


}
