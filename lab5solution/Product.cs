// Class representing a product
class Product : ISearchable
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public int Rating { get; set; }

    public Product(string name, double price, string description, string category, int rating)
    {
        Name = name;
        Price = price;
        Description = description;
        Category = category;
        Rating = rating;
    }

    public bool SearchByPrice(double price)
    {
        return Price <= price;
    }

    public bool SearchByCategory(string category)
    {
        return Category.Equals(category, StringComparison.OrdinalIgnoreCase);
    }

    public bool SearchByRating(int rating)
    {
        return Rating >= rating;
    }
}


