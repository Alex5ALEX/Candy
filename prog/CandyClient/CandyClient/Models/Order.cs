namespace CandyClient.Models;

public class Order
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;


    //links
    public Guid CustomerId { get; set; }

    public Customer? Customer { get; set; }

    public List<OrderCompaund> OrderCompaunds { get; set; } = [];
}
