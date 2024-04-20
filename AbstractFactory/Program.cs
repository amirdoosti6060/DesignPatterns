using AbstractFactory;

Console.WriteLine("Abstract Factory Design Pattern (Creational Design Pattern)");

Console.WriteLine(" ======================= ABC Style ======================= ");
var abcFactory = new ABCPizzaFactory();
Client(abcFactory);

Console.WriteLine(" ======================= DEF Style ======================= ");
var defFactory = new DEFPizzaFactory();
Client(defFactory);

void Client(IPizzaFactory pizzaFactory)
{
    Console.WriteLine(" ------ Pepperoni ------ ");
    IPizza pepperoniPizza = pizzaFactory.CreatePepperoniPizza();
    pepperoniPizza.Prepare();
    pepperoniPizza.Bake();
    pepperoniPizza.Cut();
    pepperoniPizza.Box();

    Console.WriteLine(" ------ Cheese ------ ");
    IPizza cheesePizza = pizzaFactory.CreateCheesePizza();
    cheesePizza.Prepare();
    cheesePizza.Bake();
    cheesePizza.Cut();
    cheesePizza.Box();
}
