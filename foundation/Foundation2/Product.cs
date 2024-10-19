using System;

public class Product
{
    private string _productName;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productID, decimal price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductInformation()
    {
        return $"{_productName} ({_productID}) - {_quantity} units";
    }

    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }
}