class Customer {
    private string _name;
    private Address _address;
    public Customer(string name, string streetAddress, string city, string stateProvince, string country) {
        _name = name;
        _address = new Address(streetAddress, city, stateProvince, country);
    }
    public string GetName() {
        return _name;
    }
    public string GetAddress() {
        return _address.CreateAddress();
    }
    public bool isInUSA() {
        return _address.isInUSA();
    }
}