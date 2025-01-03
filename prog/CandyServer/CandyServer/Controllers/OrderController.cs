using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CandyServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public OrderController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/<OrderController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var customers = await _context.Orders.ToListAsync();
        return Ok(customers);
    }

    // GET api/<OrderController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var customers = await _context.Orders.Where(o => o.Id == id)
            .Include(o => o.OrderCompaunds).ThenInclude(c => c.Candy)
            .Include(o => o.Customer).SingleOrDefaultAsync();

        if (customers == null) { return NotFound(); }

        return Ok(customers);
    }

    // GET api/<OrderController>/5
    [HttpGet("customer/{id}")]
    public async Task<IActionResult> GetAllOrdersByIdCustomer(Guid id)
    {
        var customers = await _context.Orders.Where(o => o.CustomerId == id)
            .Include(o => o.OrderCompaunds).ThenInclude(c => c.Candy)
            .Include(o => o.Customer).ToListAsync();

        if (customers == null) { return NotFound(); }

        return Ok(customers);
    }

    // POST api/<OrderController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Order component)
    {
        await _context.Orders.AddAsync(component);
        await _context.SaveChangesAsync();

        return Ok("customer created");
    }

    // PUT api/<OrderController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Order componentDto)
    {
        var component = await _context.Orders.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null)
        {
            return NotFound();
        }

        component = componentDto;
        component.Id = Id;

        _context.Orders.Update(component);

        await _context.SaveChangesAsync();

        return Ok("order updated");
    }

    // DELETE api/<OrderController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var component = await _context.Orders.FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null) { return NotFound(); }

        _context.Orders.Remove(component);
        await _context.SaveChangesAsync();

        return Ok("order deleted");
    }
}
