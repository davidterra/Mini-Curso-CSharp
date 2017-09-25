namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dependências explícitas
            // É uma boa prática quando se pensa em orientação a objetos deixar as dependências da classe explícitas, basta olhar seu construtor e ver quais classe são necessárias para que ela
            // faça seu trabalho por completo. 
            // Em segundo lugar, ao recebera dependência pelo construtor, a classe facilita sua extensão. Por meio de polimorfismo, o desenvolvedor pode, a qualquer momento, 
            // optar por passar alguma classe filho da classe que é recebida (ou, no caso de uma interface, outra classe a implementa), mudando/evoluindo seu comportamento.


            var dao = new Dao.NFDao();
            var sap = new Models.SAP();
            var gerador = new Models.GeradorDeNotaFiscal(dao, sap);

            var pedido = new Models.Pedido("Xpto", 1000, 1);
            var nf = gerador.Gera(pedido);
        }
    }
}
