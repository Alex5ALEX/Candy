using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CustomerController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/<CustomerController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var customers = await _context.Customers.Include(c => c.Person).ToListAsync();
        return Ok(customers);
    }

    // GET api/<CustomerController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var customers = await _context.Customers.Where(c => c.Id == id)
            .Include(c => c.Person).SingleOrDefaultAsync();

        if (customers == null) { return NotFound(); }

        return Ok(customers);
    }

    // GET api/<CustomerController>/5
    [HttpGet("person/{id}")]
    public async Task<IActionResult> GetByPersonId(Guid id)
    {
        var customers = await _context.Customers.Where(c => c.PersonId == id)
            .Include(c => c.Person).SingleOrDefaultAsync();

        if (customers == null) { return NotFound(); }

        return Ok(customers);
    }

    // POST api/<CustomerController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Customer component)
    {
        await _context.Customers.AddAsync(component);
        await _context.SaveChangesAsync();

        return Ok("customer created");
    }

    // PUT api/<CustomerController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Customer componentDto)
    {
        var component = await _context.Customers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null)
        {
            return NotFound();
        }

        component = componentDto;
        component.Id = Id;

        _context.Customers.Update(component);

        await _context.SaveChangesAsync();

        return Ok("customer updated");
    }

    // DELETE api/<CustomerController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var component = await _context.Customers.FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null) { return NotFound(); }

        _context.Customers.Remove(component);
        await _context.SaveChangesAsync();

        return Ok("customer deleted");
    }
}