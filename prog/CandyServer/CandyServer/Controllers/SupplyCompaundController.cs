using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SupplyCompaundController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SupplyCompaundController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/<SupplyCompaundController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var compositions = await _context.SupplyCompaunds.ToListAsync();
        return Ok(compositions);
    }

    // GET api/<SupplyCompaundController>/5
    [HttpGet("supply/{Id_Supply}")]
    public async Task<IActionResult> GetByCandyId(Guid Id_Supply)
    {
        var compositions = await _context.SupplyCompaunds.Where(c => c.SupplyId == Id_Supply)
            .Include(c => c.Component).ToListAsync();

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // GET api/<SupplyCompaundController>/5
    [HttpGet("component/{Id_Component}")]
    public async Task<IActionResult> GetByComponentId(Guid Id_Component)
    {
        var compositions = await _context.SupplyCompaunds.Where(c => c.ComponentId == Id_Component)
            .Include(c => c.Supply).ToListAsync();

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // GET api/<SupplyCompaundController>/candy/5
    [HttpGet("supply/{Id_Supply}/component/{Id_Component}")]
    public async Task<IActionResult> GetById(Guid Id_Supply, Guid Id_Component)
    {
        var compositions = await _context.SupplyCompaunds
            .Where(c => c.SupplyId == Id_Supply && c.ComponentId == Id_Component).SingleOrDefaultAsync();

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // POST api/<SupplyCompaundController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] SupplyCompaund component)
    {
        await _context.SupplyCompaunds.AddAsync(component);
        await _context.SaveChangesAsync();

        return Ok("compound created");
    }

    // PUT api/<SupplyCompaundController>/5
    [HttpPut("supply/{Id_Supply}/component/{Id_Component}")]
    public async Task<IActionResult> Put(
        Guid Id_Supply, Guid Id_Component, [FromBody] SupplyCompaund compositionDto)
    {
        var composition = await _context.SupplyCompaunds.AsNoTracking()
            .FirstOrDefaultAsync(c => c.ComponentId == Id_Component && c.SupplyId == Id_Supply);

        if (composition == null)
        {
            return NotFound();
        }

        composition = compositionDto;
        composition.ComponentId = Id_Component;
        composition.SupplyId = Id_Supply;

        _context.SupplyCompaunds.Update(composition);

        await _context.SaveChangesAsync();

        return Ok("compound updated");
    }

    // DELETE api/<SupplyCompaundController>/5
    [HttpDelete("supply/{Id_Supply}/component/{Id_Component}")]
    public async Task<IActionResult> Delete(Guid Id_Supply, Guid Id_Component)
    {
        var composition = await _context.SupplyCompaunds
            .FirstOrDefaultAsync(c => c.ComponentId == Id_Component && c.SupplyId == Id_Supply);

        if (composition == null) { return NotFound(); }

        _context.SupplyCompaunds.Remove(composition);
        await _context.SaveChangesAsync();

        return Ok("compound deleted");
    }
}
