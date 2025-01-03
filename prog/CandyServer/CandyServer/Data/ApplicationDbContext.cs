using CandyServer.Configuration;
using CandyServer.Configurations;
using CandyServer.Models;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderCompaund> OrderCompaunds { get; set; }

    public DbSet<Candy> Candies { get; set; }

    public DbSet<Composition> Compositions { get; set; }

    public DbSet<Component> Components { get; set; }

    public DbSet<SupplyCompaund> SupplyCompaunds { get; set; }

    public DbSet<Supply> Supplies { get; set; }

    public DbSet<Provider> Providers { get; set; }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Admin> Admins { get; set; }


    //настройка строки подключения
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.EnableSensitiveDataLogging();
        var connectionString = "server=localhost;port=3306;database=Candy;user id=root;password=BuildSQLData;";

        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new OrderCompaundConfiguration());
        modelBuilder.ApplyConfiguration(new SupplyCompaundConfiguration());
        modelBuilder.ApplyConfiguration(new CompositionConfiguration());
        modelBuilder.ApplyConfiguration(new InitDBPerson());
        modelBuilder.ApplyConfiguration(new InitDBAdmin());

        base.OnModelCreating(modelBuilder);
    }
}
