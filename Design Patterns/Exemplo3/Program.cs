
using System.Collections.Generic;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Resolvendo o Problema da Nota Fiscal
            // Para gerenciar melhor a dependência da classe GeradorDeNotaFiscal, é necessário
            // fazer com que ela dependa de módulos estáveis; uma interface é a melhor candidata.

            Models.IAcaoAposGerarNota acao1 = new Models.SAP();
            Models.IAcaoAposGerarNota acao2 = new Dao.NFDao();

            IList<Models.IAcaoAposGerarNota> acoes = new List<Models.IAcaoAposGerarNota>
            {
                acao1,
                acao2,
            };

            var gerador = new Models.GeradorDeNotaFiscal(acoes);

            var pedido = new Models.Pedido("Xpto", 1000, 1);

            var nf = gerador.Gera(pedido);
        }
    }
}
