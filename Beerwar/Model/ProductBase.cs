namespace Beerwar.Model;

public abstract class ProductBase
{
    private string Name { get; set; } = string.Empty;
    private string Description { get; set; } =  string.Empty;
    private int Rating { get; set; } 
    private string ImageSource { get; set; } = string.Empty;
}