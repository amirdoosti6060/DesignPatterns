namespace AbstractFactory
{
    public class DEFStylePepperoniPizza : IPepperoniPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing DEF Style Pepperoni Pizza ...");
        }

        public void Bake()
        {
            Console.WriteLine("Baking DEF Style Pepperoni Pizza ...");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting DEF Style Pepperoni Pizza ...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing DEF Style Pepperoni Pizza ...");
        }
    }
}
