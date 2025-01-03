namespace CandyClient.Models;

public class Person
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
