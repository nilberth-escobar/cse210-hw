

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }

    public string Name
    {
        get { return _name; }
    }

    public int ProductId
    {
        get { return _productId; }
    }

    public double Price
    {
        get { return _price; }
    }

    public int Quantity
    {
        get { return _quantity; }
    }
}