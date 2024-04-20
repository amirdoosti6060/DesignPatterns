namespace AbstractFactory
{
    public class ABCPizzaFactory : IPizzaFactory
    {
        public IPizza CreateCheesePizza()
        {
            return new ABCStyleCheesePizza();
        }

        public IPizza CreatePepperoniPizza()
        {
            return new ABCStylePepperoniPizza();
        }
    }
}
