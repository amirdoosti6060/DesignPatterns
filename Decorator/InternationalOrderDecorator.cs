namespace Decorator
{
    public class InternationalOrderDecorator : OrderDecorator
    {
        public InternationalOrderDecorator(IOrder order) : base(order)
        {
        }

        public override void ProcessOrder()
        {
            base.ProcessOrder();
            AddInternationalShipping();
        }

        private void AddInternationalShipping()
        {
            Console.WriteLine("Adding international shipping to the order.");
        }
    }
}
