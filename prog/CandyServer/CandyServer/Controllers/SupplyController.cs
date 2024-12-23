using AutoMapper;
using CandyServer.Data;
using CandyServer.DTOs;
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
    private readonly IMapper _mapper;

    public SupplyController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
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
        var customers = await _context.Supplies.FindAsync(id);

        if (customers == null) { return NotFound(); }

        return Ok(customers);
    }

    // POST api/<SupplyController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] CreateSupplyDto component)
    {
        await _context.Supplies.AddAsync(_mapper.Map<Supply>(component));
        await _context.SaveChangesAsync();

        return Ok("supply created");
    }

    // PUT api/<SupplyController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] CreateSupplyDto componentDto)
    {
        var component = await _context.Supplies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null)
        {
            return NotFound();
        }

        component = _mapper.Map<Supply>(componentDto);
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
