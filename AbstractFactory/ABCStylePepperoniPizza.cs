namespace AbstractFactory
{
    public class ABCStylePepperoniPizza : IPepperoniPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing ABC Style Pepperoni Pizza ...");
        }

        public void Bake()
        {
            Console.WriteLine("Baking ABC Style Pepperoni Pizza ...");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting ABC Style Pepperoni Pizza ...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing ABC Style Pepperoni Pizza ...");
        }
    }
}
