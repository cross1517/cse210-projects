using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private Address _address;

    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _products = new List<Product>();
        _address = address;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalPrice();
        }
        decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;

        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetProductInformation()}\n";
        }
        return packingLabel.Trim();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_address.GetFullAddress()}";
    }
}