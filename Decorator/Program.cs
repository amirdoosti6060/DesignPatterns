using Decorator;

Console.WriteLine("Decorator Design Pattern (Structural Design Pattern)");

// Create a standard order
IOrder order = new StandardOrder();
order.ProcessOrder();

Console.WriteLine("\nApplying PriorityOrderDecorator:");
// Decorate the order with priority handling
IOrder priorityOrder = new PriorityOrderDecorator(order);
priorityOrder.ProcessOrder();

Console.WriteLine("\nApplying InternationalOrderDecorator:");
// Decorate the order with international shipping
IOrder internationalOrder = new InternationalOrderDecorator(order);
internationalOrder.ProcessOrder();

Console.WriteLine("\nApplying both PriorityOrderDecorator and InternationalOrderDecorator:");
// Decorate the order with both priority handling and international shipping
IOrder fullOrder = new InternationalOrderDecorator(priorityOrder);
fullOrder.ProcessOrder();
