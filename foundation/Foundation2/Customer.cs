using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool LivesInUSA()
    {
        if (_address.GetCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
}