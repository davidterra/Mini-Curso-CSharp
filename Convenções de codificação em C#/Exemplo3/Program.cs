using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {

            var clientes = new List<Cliente>
            {
                new Cliente(1, "Xpto", "Bar"),
                new Cliente(2, "Acme", "Bar"),
                new Cliente(3, "Foo", "Xpto"),
            };

            var cidades = new List<Cidade>
            {
                new Cidade { Nome = "Bar" },
                new Cidade { Nome = "Xpto" }
            };

            var clientesComCidades = from cli in clientes
                                      join cid in cidades on cli.Cidade equals cid.Nome
                                     where cli.Cidade == "Xpto"
                                      select new
                                      {
                                          Cliente = cli,
                                          Cidade = cid
                                      };

            foreach (var item in clientesComCidades)
            {
                System.Console.WriteLine("Nome Cliente:{0} Cidade: {1}", item.Cliente.Nome, item.Cidade.Nome);
            }

            System.Console.ReadKey();


        }
    }
}
