class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(string name, string streetAddress, string city, string stateProvince, string country) {
        _customer = new Customer(name, streetAddress, city, stateProvince, country);
    }
    public void AddProduct(string name, double pricePerUnit, int productID, int quantity) {
        Product _product = new Product(name, pricePerUnit, productID, quantity);
        _products.Add(_product);
    }
    public double calculateTotalCost() {
        double _totalCost = 0;
        foreach (Product product in _products) {
            _totalCost += product.GetPrice();
        }
        _totalCost += calculateShippingCost();
        return _totalCost;
    }
    public void createPackingLabel() {
        Console.WriteLine($"{_customer.GetName()}");
        foreach (Product _product in _products) {
            Console.WriteLine($"{_product.GetProductID()}");
        }
    }
    public void createShippingLabel() {
        Console.WriteLine( $"{_customer.GetName()},\n{_customer.GetAddress()}");
    }
    public float calculateShippingCost() {
        float _shippingCost;
        if (_customer.isInUSA() == true) {
            _shippingCost = 5;
        }
        else {
            _shippingCost = 35;
        }
        return _shippingCost;
    }
}