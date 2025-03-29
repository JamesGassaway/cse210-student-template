class Address {
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(string streetAddress, string city, string stateProvince, string country) {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public string CreateAddress() {
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }
    public bool isInUSA() {
        if (_country == "Unites States" || _country == "USA") {
            return true;
        }
        else {
            return false;
        }
    }
}