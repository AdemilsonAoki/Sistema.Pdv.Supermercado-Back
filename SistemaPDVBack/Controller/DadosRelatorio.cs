using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Controller
{
    class DadosRelatorio
    {
        public string NomeComprador { get; set; }
        public string NomeVendedor { get; set; }
        public string RegiaoVenda { get; set; }
        public string CategoriaProduto { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorVenda { get; set; }


        private static Random _rand = new Random();

        public static DadosRelatorio GerarExemplo()
        {
            var compradores = new string[] { "Lojinha do Zé", "Mercearia da Esquina", "Tabacaria Top" };
            var vendedores = new string[] { "Fulaninho de Tal", "Beltrano Vende Tudo", "João do Caminhão" };
            var regioes = new string[] { "Norte", "Sul", "Leste", "Oeste", "Centro" };
            var categorias = new string[] { "Doce", "Salgado", "Perecível", "Bebida" };

            return new DadosRelatorio()
            {
                NomeComprador = compradores[_rand.Next(3)],
                NomeVendedor = vendedores[_rand.Next(3)],
                RegiaoVenda = regioes[_rand.Next(5)],
                CategoriaProduto = categorias[_rand.Next(4)],
                DataVenda = DateTime.Now.AddDays(_rand.Next(30)),
                ValorVenda = _rand.Next(1000)
            };
        }
    }



}
