namespace AbstractFactory
{
    public class DEFPizzaFactory : IPizzaFactory
    {
        public IPizza CreateCheesePizza()
        {
            return new DEFStyleCheesePizza();
        }

        public IPizza CreatePepperoniPizza()
        {
            return new DEFStylePepperoniPizza();
        }
    }
}
