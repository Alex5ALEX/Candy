namespace CandyServer.Models;

public class Component
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Quality { get; set; } = string.Empty;


    //links

    public List<Composition> Compositions { get; set; } = [];

    public List<SupplyCompaund> SupplyCompaunds { get; set; } = [];


}
