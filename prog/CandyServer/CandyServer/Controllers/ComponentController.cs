using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ComponentController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ComponentController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/<ComponentController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var components = await _context.Components.ToListAsync();
        return Ok(components);
    }

    // GET api/<ComponentController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var component = await _context.Components.FindAsync(id);

        if (component == null) { return NotFound(); }

        return Ok(component);
    }

    // POST api/<ComponentController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Component component)
    {
        await _context.Components.AddAsync(component);
        await _context.SaveChangesAsync();

        return Ok("component created");
    }

    // PUT api/<ComponentController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Component componentDto)
    {
        var component = await _context.Components.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null)
        {
            return NotFound();
        }

        component = componentDto;
        component.Id = Id;

        _context.Components.Update(component);

        await _context.SaveChangesAsync();

        return Ok("component updated");
    }

    // DELETE api/<ComponentController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var component = await _context.Components.FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null) { return NotFound(); }

        _context.Components.Remove(component);
        await _context.SaveChangesAsync();

        return Ok("Candy deleted");
    }
}
