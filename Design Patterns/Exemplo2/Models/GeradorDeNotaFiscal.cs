namespace Exemplo2.Models
{
    public class GeradorDeNotaFiscal
    {
        private readonly SAP _sap;
        private readonly Dao.NFDao _dao;

        public GeradorDeNotaFiscal(Dao.NFDao dao, SAP sap)
        {
            _dao = dao;
            _sap = sap;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            var nf = new NotaFiscal(pedido.Cliente,
                                  pedido.ValorTotal * 0.94,
                                  System.DateTime.Now);

            _dao.Persiste(nf);
            
            _sap.Envia(nf);

            return nf;
        }
    }
}
