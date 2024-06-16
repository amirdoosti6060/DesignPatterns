namespace Decorator
{
    public abstract class OrderDecorator : IOrder
    {
        protected IOrder _order;

        public OrderDecorator(IOrder order)
        {
            _order = order;
        }

        public virtual void ProcessOrder()
        {
            _order.ProcessOrder();
        }
    }
}
