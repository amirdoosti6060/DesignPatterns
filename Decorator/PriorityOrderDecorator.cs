namespace Decorator
{
    public class PriorityOrderDecorator : OrderDecorator
    {
        public PriorityOrderDecorator(IOrder order) : base(order)
        {
        }

        public override void ProcessOrder()
        {
            base.ProcessOrder();
            AddPriorityHandling();
        }

        private void AddPriorityHandling()
        {
            Console.WriteLine("Adding priority handling to the order.");
        }
    }
}
