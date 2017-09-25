namespace Exemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory
            // Defina uma interface para criar um objeto, mas deixe subclasses decidir qual classe instanciar.

            var factory = new SimplePizzaFactory();
            var pizzariaStore = new PizzeriaStore(factory);
            pizzariaStore.Order("cheese");

            System.Console.ReadKey();
        }
    }
}
