using System;

class Products
{
  public string _name;
  public string _productID;
  public double _price;
  public double _quantity;

  public Products(string name, string productID, double price, double quantity)
  {
    _name = name;
    _productID = productID;
    _price = price;
    _quantity = quantity;
  }

  public double TotalCost()
  {
    return _price * _quantity;
  }

  
}