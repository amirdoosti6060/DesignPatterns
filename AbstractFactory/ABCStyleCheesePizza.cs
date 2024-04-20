namespace AbstractFactory
{
    public class ABCStyleCheesePizza : IPepperoniPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing ABC Style Cheese Pizza ...");
        }

        public void Bake()
        {
            Console.WriteLine("Baking ABC Style Cheese Pizza ...");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting ABC Style Cheese Pizza ...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing ABC Style Cheese Pizza ...");
        }
    }
}
