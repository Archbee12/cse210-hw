using System;

public class Product
{
  private string _name;
  private string _productID;
  private double _price;
  private double _quantity;

  public Product(string name, string productID, double price, double quantity)
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

  public override string ToString()
  {
    return $"{_name} (ID: {_productID})";
  }

  public string GetName()
  {
    return _name;
  }

  public string GetProductId()
  {
    return _productID;
  }

  public double GetPrice()
  {
    return _price;
  }

  public double GetQuantity()
  {
    return _quantity;
  }
}