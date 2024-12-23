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
public class CompositionController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CompositionController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/<CompositionController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var compositions = await _context.Compositions.ToListAsync();
        return Ok(compositions);
    }

    // GET api/<CompositionController>/5
    [HttpGet("/candy/{Id_Candy}")]
    public async Task<IActionResult> GetByCandyId(Guid Id_Candy)
    {
        var compositions = await _context.Compositions.FindAsync(Id_Candy);

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // GET api/<CompositionController>/5
    [HttpGet("/component/{Id_Component}")]
    public async Task<IActionResult> GetByComponentId(Guid Id_Component)
    {
        var compositions = await _context.Compositions.FindAsync(Id_Component);

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // POST api/<CompositionController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] CreateCompositionDto component)
    {
        await _context.Compositions.AddAsync(_mapper.Map<Composition>(component));
        await _context.SaveChangesAsync();

        return Ok("Composition created");
    }

    // PUT api/<CompositionController>/5
    [HttpPut("/candy/{Id_Candy}/component/{Id_Component}")]
    public async Task<IActionResult> Put(
        Guid Id_Candy, Guid Id_Component, [FromBody] CreateCompositionDto compositionDto)
    {
        var composition = await _context.Compositions.AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id_Component == Id_Component && c.Id_Candy == Id_Candy);

        if (composition == null)
        {
            return NotFound();
        }

        composition = _mapper.Map<Composition>(compositionDto);
        composition.Id_Component = Id_Component;
        composition.Id_Candy = Id_Candy;

        _context.Compositions.Update(composition);

        await _context.SaveChangesAsync();

        return Ok("Composition updated");
    }

    // DELETE api/<CompositionController>/5
    [HttpDelete("/candy/{Id_Candy}/component/{Id_Component}")]
    public async Task<IActionResult> Delete(Guid Id_Candy, Guid Id_Component)
    {
        var composition = await _context.Compositions
            .FirstOrDefaultAsync(c => c.Id_Component == Id_Component && c.Id_Candy == Id_Candy);

        if (composition == null) { return NotFound(); }

        _context.Compositions.Remove(composition);
        await _context.SaveChangesAsync();

        return Ok("Composition deleted");
    }
}
