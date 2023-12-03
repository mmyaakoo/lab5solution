// Class representing an order
class Order
{
    public List<Product> Products { get; set; }
    public int Quantity { get; set; }
    public double TotalCost => Products.Sum(p => p.Price * Quantity);
    public string Status { get; set; }

    public Order(List<Product> products, int quantity)
    {
        Products = products;
        Quantity = quantity;
        Status = "Pending";
    }
}
