namespace CandyServer.Models;

public class Candy
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; } = 0;

    public double Weight { get; set; } = 0;


    //links
    public List<OrderCompaund> OrderCompaunds { get; set; } = [];

    public List<Composition> Compositions { get; set; } = [];


}
