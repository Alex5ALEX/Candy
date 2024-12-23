namespace CandyServer.Models;

public class Composition
{
    public double Weight { get; set; } = 0;


    //links

    public Guid Id_Candy { get; set; }

    public Candy? Candy { get; set; }

    public Guid Id_Component { get; set; }

    public Component? Component { get; set; }  

}
