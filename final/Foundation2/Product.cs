class Product {
    private string _name;
    private double _pricePerUnit;
    private int _productID;
    private int _quantity;
    public Product(string name, double pricePerUnit, int productID, int quantity) {
        _name = name;
        _pricePerUnit = pricePerUnit;
        _productID = productID;
        _quantity = quantity;
    }
    public string GetName() {
        return _name;
    }
    public double GetPrice() {
        return _pricePerUnit * _quantity;
    }
    public int GetProductID() {
        return _productID;
    }
}