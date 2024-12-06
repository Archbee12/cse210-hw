using System;

public class Order
{
  private Customer _customer;
  private List<Product> _products = new List<Product>();

  public Order(Customer customer)
  {
    _customer = customer;
  }

  public void AddProduct(Product product)
  {
    _products.Add(product);
  }

  public double CalculateTotalCost()
  {
    double totalSum = 0;
    foreach (var product in _products)
    {
      totalSum += product.TotalCost();
    }

    double shippingCost = _customer.LivesInUSA() ? 5 : 35;
    totalSum += shippingCost;
    return totalSum;
  }

  public string PackingLabel()
  {
    string label = "";
    foreach (var product in _products)
    {
      label += $"{product}\n";
    }

    return label.TrimEnd();
  }

  public string _shippingLabel()
  {
    return _customer.ToString();
  }

  public Customer GetCustomer()
  {
    return _customer;
  }
}