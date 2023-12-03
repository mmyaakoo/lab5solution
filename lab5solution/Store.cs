// Class representing a store
class Store
{
    private List<User> users;
    private List<Product> products;
    private List<Order> orders;

    public Store()
    {
        users = new List<User>();
        products = new List<Product>();
        orders = new List<Order>();
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Available Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
        }
    }

    public void PlaceOrder(User user, List<Product> selectedProducts, int quantity)
    {
        Order newOrder = new Order(selectedProducts, quantity);
        orders.Add(newOrder);
        user.PurchaseHistory.Add($"Order ID: {orders.IndexOf(newOrder)}, Total Cost: {newOrder.TotalCost}, Status: {newOrder.Status}");
        Console.WriteLine("Order placed successfully!");
    }

    public void DisplayOrders(User user)
    {
        Console.WriteLine($"Order History for {user.Username}:");
        foreach (var order in user.PurchaseHistory)
        {
            Console.WriteLine(order);
        }
    }

    public List<Product> SearchProducts(ISearchable searchable, double price)
    {
        return products.Where(p => searchable.SearchByPrice(price)).ToList();
    }

    public List<Product> SearchProducts(ISearchable searchable, string category)
    {
        return products.Where(p => searchable.SearchByCategory(category)).ToList();
    }

    public List<Product> SearchProducts(ISearchable searchable, int rating)
    {
        return products.Where(p => searchable.SearchByRating(rating)).ToList();
    }
}