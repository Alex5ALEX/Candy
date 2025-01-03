namespace CandyServer.Models;

public class OrderCompaund
{
    public int Quantity { get; set; } = 0;

    //links
    public Guid OrderId { get; set; }

    public Order? Order { get; set; }

    public Guid CandyId { get; set; }

    public Candy? Candy { get; set; }

}
