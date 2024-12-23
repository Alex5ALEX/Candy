using AutoMapper;
using CandyServer.Data;
using CandyServer.DTOs;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ComponentController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public ComponentController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
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
        [FromBody] CreateComponentDto component)
    {
        await _context.Components.AddAsync(_mapper.Map<Component>(component));
        await _context.SaveChangesAsync();

        return Ok("component created");
    }

    // PUT api/<ComponentController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] CreateComponentDto componentDto)
    {
        var component = await _context.Components.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null)
        {
            return NotFound();
        }

        component = _mapper.Map<Component>(componentDto);
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
