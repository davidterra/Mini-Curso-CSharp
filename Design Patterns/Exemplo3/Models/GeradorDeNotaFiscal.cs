using System.Collections.Generic;

namespace Exemplo3.Models
{
    public class GeradorDeNotaFiscal
    {
        private readonly IList<IAcaoAposGerarNota> _acoes;

        // Repare agora que a classe GeradorDeNotaFiscal não está mais fortemente acoplada a uma ação concreta, mas sim a uma lista qualquer de ações.
        public GeradorDeNotaFiscal(IList<Models.IAcaoAposGerarNota> acoes )
        {
            _acoes = acoes;
        }

        
        public NotaFiscal Gera(Pedido pedido)
        {
            var nf = new NotaFiscal(pedido.Cliente,
                                  pedido.ValorTotal * 0.94,
                                  System.DateTime.Now);

            foreach(var acao in _acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }
    }
}
