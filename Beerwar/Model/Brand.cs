namespace Beerwar.Model;

public class Brand
{
    public int Id { get; init; }
    public string Name { get; init; }
    public List<Beer> Products { get; init; }
}