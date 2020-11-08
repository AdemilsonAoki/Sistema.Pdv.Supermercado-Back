using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SistemaPDVBack.DTO;

namespace SistemaPDVBack
{
    class ControllerCupom
    {
        List<ProdutoPedidoDTO> produtos = new List<ProdutoPedidoDTO>();

        public List<string> Layout = new List<string>();

   

        public ControllerCupom()
        {

        }
 
        public void ImprimirCupom(string codItem, string codigoBarras, string Descricao, string quantidade, string valorUnitario, string total, string Status,string cpf, string codigoVenda, string data, string hora, string caixa)
        {


            produtos.Add(new ProdutoPedidoDTO(codItem,  codigoBarras, Descricao, quantidade, valorUnitario, total, Status));

            StreamWriter x;

            string caminho = "F:\\Users\\PC\\Desktop\\Projetos\\Teste.txt";

            x = File.CreateText(caminho);

            foreach (ProdutoPedidoDTO obj in produtos)
            {

                x.WriteLine(obj.CodigoItem + ";" + obj.CodBarras + ";" + obj.NomeProduto + ";" + obj.Quantidade + ";" + obj.PrecoUnit + ";" + obj.Total + ";" + obj.StatusAtivo + ";");
            }

            x.Close();

            StringBuilder sb = new StringBuilder();

            string caminhoArquivo = "F:\\Users\\PC\\Desktop\\Projetos\\Teste.txt";

            var consulta = from linha in File.ReadAllLines(caminhoArquivo)
                           let ProdutoDados = linha.Split(';')
                           select new ProdutoPedidoDTO()
                           {
                               CodigoItem = ProdutoDados[0],
                               CodBarras = ProdutoDados[1],
                               NomeProduto = ProdutoDados[2],
                               Quantidade = ProdutoDados[3],
                               PrecoUnit = ProdutoDados[4],
                               Total = ProdutoDados[5],
                               StatusAtivo = ProdutoDados[6],
                           };


            foreach (var item in consulta)
            {
                sb.AppendFormat("{0,-6}{1,-6}{2,-12}{3,-5}{4,-8}{5,-35}{6,-30}{7}",
                   item.CodigoItem,
                   item.CodBarras,
                   item.NomeProduto,
                   item.Quantidade,
                   item.PrecoUnit,
                   item.Total,
                   item.StatusAtivo,

                   Environment.NewLine);
            }
            File.WriteAllText(@"F:\\Users\\PC\\Desktop\\Projetos\\Teste1.txt", sb.ToString());

            Layout.Clear();

            using (StreamReader reader = new StreamReader("F:\\Users\\PC\\Desktop\\Projetos\\Teste1.txt"))
            {
                Layout.Add("");
                Layout.Add(" LUCAS GABRIEL SOUZA SILVA - LTDA ");
                Layout.Add(" Rua Orelio Sabadin n° 210");
                Layout.Add(" Sorocaba-Sp");
                Layout.Add(" -------------------------------------------");
                Layout.Add(" CNPJ: 71.564.173/0001-80        "+ data);
                Layout.Add(" IE: 714.145.789                 "+ hora);
                Layout.Add(" IM: 4567412                     ");
                Layout.Add(" -------------------------------------------");
                Layout.Add(" CODIGO:" + codigoVenda);

                Layout.Add(" CPF/CNPJ:" + cpf) ;

                Layout.Add(" -------------------------------------------");
                Layout.Add(" ---------------CUPOM FISCAL----------------");
                Layout.Add(" -------------------------------------------");
                Layout.Add(" Cod   CD    DESC.      QTDE   UN     TOTAL ");

                Layout.Add("");


                List<string> Todos = new List<string>();
                List<string> cancelado = new List<string>();
                List<string> totalVenda = new List<string>();

                string line;

                while ((line = reader.ReadLine()) != null)
                {


                    if (line.Contains("Cancelado"))
                    {
                        cancelado.Add(line);
                        Todos.Add(line);
                    }                   
                    else if (line.Contains("Total"))
                    {
                        totalVenda.Add(line);
                    }
                    else 
                    {
                       Todos.Add(line);
                    }
                }
             


                foreach (string obj in Todos)
                {
                    Layout.Add(" " + obj);
                }
                bool vericadora = false;


                foreach (string obj in cancelado)
                {
                    if(vericadora == false)
                    {
                        Layout.Add(" -----------------Cancelado-----------------");
                        vericadora = true;

                    }
                    Layout.Add(" " + obj);



                }
                Layout.Add(" -------------------------------------------");



                foreach (string obj in totalVenda)
                {
                    Layout.Add(" " + obj);
                }
                Layout.Add(" -------------------------------------------");
                Layout.Add(" -------------------------------------------");

                Layout.Add(" CAIXA:" + caixa);
                Layout.Add(" COLABORAR: ANTONIO");
                Layout.Add(" PDVR 2.0.3");
                Layout.Add(" BEMATECH MP -2100");
                Layout.Add(" -------------------------------------------");
            }

        }
    }
}