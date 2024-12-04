using System;

public class Order
{
  public Customer _customer;
  private List<Product> _products = new List<Product>();

  public Order(Customer customer)
  {
    _customer = customer;
  }

  public void AddProduct(Product products)
  {
    _products.Add(product);
  }

  public int CalculateTotalCost()
  {
    int totalSum = 0;
    foreach (var product in _products)
    {
      totalSum += _products.TotalCost();
    }

    int shippingCost = _customer.LivesInUSA() ? 5 : 35;
    return totalSum + shippingCost;
  }

  public string _packingLabel()
  {
    string label = "";
    foreach (var product in _products)
    {
      label += product + "\n";
    }

    return label.TrimEnd()
  }

  public string _shippingLabel()
  {
    return _customer.ToString();
  }
}