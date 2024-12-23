using AutoMapper;
using CandyServer.Data;
using CandyServer.DTOs;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CandyController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CandyController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
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
        var candy = await _context.Candies.FindAsync(id);

        if (candy == null) { return NotFound(); }

        return Ok(candy);
    }

    // POST api/<CandyController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] CreateCandyDto candy)
    {
        await _context.Candies.AddAsync(_mapper.Map<Candy>(candy));
        await _context.SaveChangesAsync();

        return Ok("candy created");
    }

    // PUT api/<CandyController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] CreateCandyDto candyDto)
    {
        var candy = await _context.Candies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (candy == null)
        {
            return NotFound();
        }

        candy = _mapper.Map<Candy>(candyDto);
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
