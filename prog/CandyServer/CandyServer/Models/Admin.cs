namespace CandyServer.Models;

public class Admin
{
    public Guid Id { get; set; }

    public string JobTitle { get; set; }


    //links


    public Guid PersonId { get; set; }

    public Person? Person { get; set; }
}
