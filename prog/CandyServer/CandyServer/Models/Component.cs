namespace CandyServer.Models;

public class Component
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }


    //links

    public List<Composition> Compositions { get; set; } = [];

    public List<SupplyCompaund> SupplyCompaunds { get; set; } = [];
}
