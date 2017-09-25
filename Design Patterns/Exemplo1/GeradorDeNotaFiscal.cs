namespace Exemplo1
{
    public class GeradorDeNotaFiscal
    {
        public NotaFiscal Gera(Pedido pedido)
        {
            var nf = new NotaFiscal(pedido.Cliente,
                                  pedido.ValorTotal * 0.94,
                                  System.DateTime.Now);

            new NFDao().Persiste(nf);

            var sap = new SAP();
            sap.Envia(nf);

            return nf;
        }
    }
}
