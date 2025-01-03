using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SupplyController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SupplyController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/<SupplyController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var customers = await _context.Supplies.ToListAsync();
        return Ok(customers);
    }

    // GET api/<SupplyController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var customers = await _context.Supplies.Where(s => s.Id == id).Include(s => s.Provider).SingleOrDefaultAsync();

        if (customers == null) { return NotFound(); }

        return Ok(customers);
    }

    // POST api/<SupplyController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Supply component)
    {
        await _context.Supplies.AddAsync(component);
        await _context.SaveChangesAsync();

        return Ok("supply created");
    }

    // PUT api/<SupplyController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Supply componentDto)
    {
        var component = await _context.Supplies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null)
        {
            return NotFound();
        }

        component = componentDto;
        component.Id = Id;

        _context.Supplies.Update(component);

        await _context.SaveChangesAsync();

        return Ok("supply updated");
    }

    // DELETE api/<SupplyController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var component = await _context.Supplies.FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null) { return NotFound(); }

        _context.Supplies.Remove(component);
        await _context.SaveChangesAsync();

        return Ok("order deleted");
    }
}
