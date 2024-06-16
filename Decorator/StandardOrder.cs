namespace Decorator
{
    public class StandardOrder : IOrder
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing standard order.");
        }
    }
}
