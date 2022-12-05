namespace LanguageFeatures.Models;

public class Product
{
    public string  Name { get; set; }
    public decimal? Price { get; set; }

    public static Product?[] GetProducts()
    {
        Product kayak = new()
        {
            Name = "Kayak",
            Price = 275M
        };

        Product LifeJacket = new()
        {
            Name = "Life Jacket",
            Price = 48.95M
        };

        return new Product?[] { kayak, LifeJacket, null };
    }
}