namespace AbstractFactory
{
    public class DEFStyleCheesePizza : IPepperoniPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing DEF Style Cheese Pizza ...");
        }

        public void Bake()
        {
            Console.WriteLine("Baking DEF Style Cheese Pizza ...");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting DEF Style Cheese Pizza ...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing DEF Style Cheese Pizza ...");
        }
    }
}
