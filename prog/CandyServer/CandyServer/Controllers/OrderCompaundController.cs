using AutoMapper;
using CandyServer.Data;
using CandyServer.DTOs;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrderCompaundController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public OrderCompaundController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/<OrderCompaundController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var compositions = await _context.OrderCompaunds.ToListAsync();
        return Ok(compositions);
    }

    // GET api/<OrderCompaundController>/5
    [HttpGet("/candy/{Id_Candy}")]
    public async Task<IActionResult> GetByCandyId(Guid Id_Candy)
    {
        var compositions = await _context.OrderCompaunds.FindAsync(Id_Candy);

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // GET api/<OrderCompaundController>/5
    [HttpGet("/order/{Id_Order}")]
    public async Task<IActionResult> GetByComponentId(Guid Id_Order)
    {
        var compositions = await _context.OrderCompaunds.FindAsync(Id_Order);

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // POST api/<OrderCompaundController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] CreateCompositionDto component)
    {
        await _context.OrderCompaunds.AddAsync(_mapper.Map<OrderCompaund>(component));
        await _context.SaveChangesAsync();

        return Ok("compaund created");
    }

    // PUT api/<OrderCompaundController>/5
    [HttpPut("/candy/{Id_Candy}/order/{Id_Order}")]
    public async Task<IActionResult> Put(
        Guid Id_Candy, Guid Id_Order, [FromBody] CreateOrderCompaundDto compositionDto)
    {
        var composition = await _context.OrderCompaunds.AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id_Order == Id_Order && c.Id_Candy == Id_Candy);

        if (composition == null)
        {
            return NotFound();
        }

        composition = _mapper.Map<OrderCompaund>(compositionDto);
        composition.Id_Order = Id_Order;
        composition.Id_Candy = Id_Candy;

        _context.OrderCompaunds.Update(composition);

        await _context.SaveChangesAsync();

        return Ok("compaund updated");
    }

    // DELETE api/<OrderCompaundController>/5
    [HttpDelete("/candy/{Id_Candy}/order/{Id_Order}")]
    public async Task<IActionResult> Delete(Guid Id_Candy, Guid Id_Order)
    {
        var composition = await _context.OrderCompaunds
            .FirstOrDefaultAsync(c => c.Id_Order == Id_Order && c.Id_Candy == Id_Candy);

        if (composition == null) { return NotFound(); }

        _context.OrderCompaunds.Remove(composition);
        await _context.SaveChangesAsync();

        return Ok("compaund deleted");
    }
}
