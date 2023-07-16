


public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        this._customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculatePrice();
        }

        // Add shipping cost
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return Math.Round(total, 2);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"Product Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer Name: {_customer.Name}\n";
        shippingLabel += $"Address: {_customer.Address.GetFullAddress()}\n";
        return shippingLabel;
    }
}