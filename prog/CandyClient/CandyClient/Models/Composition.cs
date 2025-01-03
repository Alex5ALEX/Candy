namespace CandyClient.Models;

public class Composition
{
    public double Weight { get; set; } = 0;

    //links
    public Guid CandyId { get; set; }

    public Candy? Candy { get; set; }

    public Guid ComponentId { get; set; }

    public Component? Component { get; set; }

}
