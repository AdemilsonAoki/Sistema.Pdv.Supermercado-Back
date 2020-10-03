using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Colaborador:AbsPessoa
    {

        public int IdColaborador { get; set; }
        public Departamento CodDepartamento { get; set; }

        public string CpfColaborador { get; set; }

        public int AtivoColaborador { get; set; }
        public string CargoColaborador { get; set; }
        public string TelefoneColaborador { get; set; }
        public string EmailPessoalColaborador { get; set; }
        public string EmailCorporativo { get; set; }

        public Colaborador(int idColaborador, Departamento codDepartamento, string cpfColaborador, int ativoColaborador, string cargoColaborador, 
                            string telefoneColaborador, string emailPessoalColaborador, string emailCorporativo,
                            int idEndereco, string logradouroPessoa, string ufPessoa, string numeroPessoa,
                            string complementoPessoa, string bairroPessoa, string cidadePessoa)
                             :base(idEndereco, logradouroPessoa, ufPessoa, numeroPessoa, complementoPessoa, bairroPessoa, cidadePessoa)

        {
            IdColaborador = idColaborador;
            CodDepartamento = codDepartamento;
            CpfColaborador = cpfColaborador;
            AtivoColaborador = ativoColaborador;
            CargoColaborador = cargoColaborador;
            TelefoneColaborador = telefoneColaborador;
            EmailPessoalColaborador = emailPessoalColaborador;
            EmailCorporativo = emailCorporativo;
        }
    }
}
