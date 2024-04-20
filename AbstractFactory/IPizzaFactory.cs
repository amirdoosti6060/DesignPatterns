namespace AbstractFactory
{
    public interface IPizzaFactory
    {
        IPizza CreatePepperoniPizza();
        IPizza CreateCheesePizza();
    }
}
