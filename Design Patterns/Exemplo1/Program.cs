namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerador = new GeradorDeNotaFiscal();

            var pedido = new Pedido("Xpto", 1000, 1);

            var nf = gerador.Gera(pedido);
        }
    }
}
