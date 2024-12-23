namespace CandyServer.Models;

public class SupplyCompaund
{
    public double Weight { get; set; } = 0;

    public decimal Price { get; set; } = 0;


    //links

    public Guid Id_Supply { get; set; }

    public Supply? Supply { get; set; }

    public Guid Id_Component { get; set; }

    public Component? Component { get; set; }

}
