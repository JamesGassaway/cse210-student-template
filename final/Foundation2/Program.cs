using System;

class Program
{
    private List<Order> _orders = new List<Order>();
    static void Main(string[] args)
    {
        Program program = new Program();
        program.CreateOrders();
        program.DisplayOrders();
    }
    public void CreateOrders() {
        Order _order1 = new Order("Tom Cruise", "1234 Place Prk", "Nowhere", "IL", "USA");
        _order1.AddProduct("Chips", 4.79, 780123958, 1);
        _order1.AddProduct("Ice Cream", 2.49, 978235897, 4);
        _orders.Add(_order1);

        Order _order2 = new Order("Rasputin", "987 Old Russia", "Moscow", "N/A", "Russia");
        _order2.AddProduct("Coat", 15.00, 1000022022, 1);
        _order2.AddProduct("Boots", 12.00, 293789723, 1);
        _order2.AddProduct("Scarf", 8.00, 203928494, 1);
        _orders.Add(_order2);
        
    }
    public void DisplayOrders() {
        int _orderNumber = 0;
        foreach (Order _order in _orders) {
            Console.WriteLine($"Order No. {_orderNumber}:");
            Console.WriteLine($"Total Cost: {_order.calculateTotalCost()}");
            Console.WriteLine("\nPacking Label:");
            _order.createPackingLabel();
            Console.WriteLine("\nShipping Label:");
            _order.createShippingLabel();
            Console.WriteLine("");
            _orderNumber++;
        }
    }
}