// Interface for searchable objects
interface ISearchable
{
    bool SearchByPrice(double price);
    bool SearchByCategory(string category);
    bool SearchByRating(int rating);
}


