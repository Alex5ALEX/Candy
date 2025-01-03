using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CompositionController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CompositionController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/<CompositionController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var compositions = await _context.Compositions.ToListAsync();
        return Ok(compositions);
    }

    // GET api/<CompositionController>/candy/5
    [HttpGet("candy/{Id_Candy}")]
    public async Task<IActionResult> GetByCandyId(Guid Id_Candy)
    {
        var compositions = await _context.Compositions.Where(c => c.CandyId == Id_Candy)
            .Include(c => c.Component).ToListAsync();

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // GET api/<CompositionController>/component/5
    [HttpGet("component/{Id_Component}")]
    public async Task<IActionResult> GetByComponentId(Guid Id_Component)
    {
        var compositions = await _context.Compositions.Where(c => c.ComponentId == Id_Component)
            .Include(c => c.Candy).ToListAsync();

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // GET api/<CompositionController>/candy/5
    [HttpGet("candy/{Id_Candy}/component/{Id_Component}")]
    public async Task<IActionResult> GetById(Guid Id_Candy, Guid Id_Component)
    {
        var compositions = await _context.Compositions
            .Where(c => c.ComponentId == Id_Component && c.CandyId == Id_Candy).SingleOrDefaultAsync();

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // POST api/<CompositionController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Composition component)
    {
        await _context.Compositions.AddAsync(component);
        await _context.SaveChangesAsync();

        return Ok("Composition created");
    }

    // PUT api/<CompositionController>/candy/5/component/5
    [HttpPut("candy/{Id_Candy}/component/{Id_Component}")]
    public async Task<IActionResult> Put(
        Guid Id_Candy, Guid Id_Component, [FromBody] Composition compositionDto)
    {
        var composition = await _context.Compositions.AsNoTracking()
            .FirstOrDefaultAsync(c => c.ComponentId == Id_Component && c.CandyId == Id_Candy);

        if (composition == null)
        {
            return NotFound();
        }

        composition = compositionDto;
        composition.ComponentId = Id_Component;
        composition.CandyId = Id_Candy;

        _context.Compositions.Update(composition);

        await _context.SaveChangesAsync();

        return Ok("Composition updated");
    }

    // DELETE api/<CompositionController>/candy/5/component/5
    [HttpDelete("candy/{Id_Candy}/component/{Id_Component}")]
    public async Task<IActionResult> Delete(Guid Id_Candy, Guid Id_Component)
    {
        var composition = await _context.Compositions
            .FirstOrDefaultAsync(c => c.ComponentId == Id_Component && c.CandyId == Id_Candy);

        if (composition == null) { return NotFound(); }

        _context.Compositions.Remove(composition);
        await _context.SaveChangesAsync();

        return Ok("Composition deleted");
    }
}
