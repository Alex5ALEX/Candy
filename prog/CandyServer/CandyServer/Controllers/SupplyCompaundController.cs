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
public class SupplyCompaundController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public SupplyCompaundController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/<SupplyCompaundController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var compositions = await _context.SupplyCompaunds.ToListAsync();
        return Ok(compositions);
    }

    // GET api/<SupplyCompaundController>/5
    [HttpGet("/supply/{Id_Supply}")]
    public async Task<IActionResult> GetByCandyId(Guid Id_Supply)
    {
        var compositions = await _context.SupplyCompaunds.FindAsync(Id_Supply);

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // GET api/<SupplyCompaundController>/5
    [HttpGet("/component/{Id_Component}")]
    public async Task<IActionResult> GetByComponentId(Guid Id_Component)
    {
        var compositions = await _context.SupplyCompaunds.FindAsync(Id_Component);

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // POST api/<SupplyCompaundController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] CreateSupplyCompaundDto component)
    {
        await _context.SupplyCompaunds.AddAsync(_mapper.Map<SupplyCompaund>(component));
        await _context.SaveChangesAsync();

        return Ok("compound created");
    }

    // PUT api/<SupplyCompaundController>/5
    [HttpPut("/supply/{Id_Supply}/component/{Id_Component}")]
    public async Task<IActionResult> Put(
        Guid Id_Supply, Guid Id_Component, [FromBody] CreateCompositionDto compositionDto)
    {
        var composition = await _context.SupplyCompaunds.AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id_Component == Id_Component && c.Id_Supply == Id_Supply);

        if (composition == null)
        {
            return NotFound();
        }

        composition = _mapper.Map<SupplyCompaund>(compositionDto);
        composition.Id_Component = Id_Component;
        composition.Id_Supply = Id_Supply;

        _context.SupplyCompaunds.Update(composition);

        await _context.SaveChangesAsync();

        return Ok("compound updated");
    }

    // DELETE api/<SupplyCompaundController>/5
    [HttpDelete("/supply/{Id_Supply}/component/{Id_Component}")]
    public async Task<IActionResult> Delete(Guid Id_Supply, Guid Id_Component)
    {
        var composition = await _context.SupplyCompaunds
            .FirstOrDefaultAsync(c => c.Id_Component == Id_Component && c.Id_Supply == Id_Supply);

        if (composition == null) { return NotFound(); }

        _context.SupplyCompaunds.Remove(composition);
        await _context.SaveChangesAsync();

        return Ok("compound deleted");
    }
}
