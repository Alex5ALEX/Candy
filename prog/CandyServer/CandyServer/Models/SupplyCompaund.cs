namespace CandyServer.Models;

public class SupplyCompaund
{
    public double Weight { get; set; } = 0;

    public decimal Price { get; set; } = 0;


    //links

    public Guid SupplyId { get; set; }

    public Supply? Supply { get; set; }

    public Guid ComponentId { get; set; }

    public Component? Component { get; set; }

}
