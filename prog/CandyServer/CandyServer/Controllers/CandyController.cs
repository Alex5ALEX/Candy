using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CandyController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CandyController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/<CandyController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var candies = await _context.Candies.ToListAsync();
        return Ok(candies);
    }

    // GET api/<CandyController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var candy = await _context.Candies.Where(c => c.Id == id).Include(c => c.Compositions)
            .ThenInclude(c => c.Component).SingleOrDefaultAsync();

        if (candy == null) { return NotFound(); }

        return Ok(candy);
    }

    // POST api/<CandyController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Candy candy)
    {
        await _context.Candies.AddAsync(candy);
        await _context.SaveChangesAsync();

        return Ok("candy created");
    }

    // PUT api/<CandyController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Candy candyDto)
    {
        var candy = await _context.Candies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (candy == null)
        {
            return NotFound();
        }

        candy = candyDto;
        candy.Id = Id;

        _context.Candies.Update(candy);

        await _context.SaveChangesAsync();

        return Ok("Candy updated");
    }

    // DELETE api/<CandyController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var candy = await _context.Candies.FirstOrDefaultAsync(c => c.Id == Id);

        if (candy == null) { return NotFound(); }

        _context.Candies.Remove(candy);
        await _context.SaveChangesAsync();

        return Ok("Candy deleted");
    }
}
