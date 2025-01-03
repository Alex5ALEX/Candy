namespace CandyServer.Models;

public class Supply
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public decimal Price { get; set; }

    //links

    public List<SupplyCompaund> SupplyCompaunds { get; set; } = [];

    public Guid ProviderId { get; set; }

    public Provider? Provider { get; set; }

}
