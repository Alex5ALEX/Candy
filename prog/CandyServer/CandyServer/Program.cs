using CandyServer.Data;
using Newtonsoft.Json;

namespace CandyServer;

public static class Program
{
    public static void Main(string[] args)
    {


        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<ApplicationDbContext>();

        builder.Services.AddControllers().AddNewtonsoftJson(
            options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

        builder.Services.AddControllers();
        builder.Services.AddAutoMapper(typeof(Program).Assembly);


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}





