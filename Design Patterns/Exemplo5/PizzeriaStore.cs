namespace Exemplo5
{
    public class PizzeriaStore
    {
        private readonly SimplePizzaFactory _factory;

        public PizzeriaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        public Pizza Order(string type)
        {
            var pizza = _factory.CreatePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        
    }
}
