namespace CandyServer.Models;

public class Customer
{
    public Guid Id { get; set; }
    public Guid PersonId { get; set; }

    //links
    public Person? Person { get; set; }
    public List<Order> Orders { get; set; } = [];

}
