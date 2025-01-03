using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrderCompaundController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public OrderCompaundController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/<OrderCompaundController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var compositions = await _context.OrderCompaunds.ToListAsync();
        return Ok(compositions);
    }

    // GET api/<OrderCompaundController>/5
    [HttpGet("candy/{Id_Candy}")]
    public async Task<IActionResult> GetByCandyId(Guid Id_Candy)
    {
        var compositions = await _context.OrderCompaunds.Where(c => c.CandyId == Id_Candy)
            .Include(c => c.Order).ToListAsync();

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // GET api/<OrderCompaundController>/5
    [HttpGet("order/{Id_Order}")]
    public async Task<IActionResult> GetByComponentId(Guid Id_Order)
    {
        var compositions = await _context.OrderCompaunds.Where(c => c.OrderId == Id_Order)
            .Include(c => c.Candy).ToListAsync();

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // GET api/<OrderCompaundController>/candy/5
    [HttpGet("candy/{Id_Candy}/order/{Id_Order}")]
    public async Task<IActionResult> GetById(Guid Id_Candy, Guid Id_Order)
    {
        var compositions = await _context.OrderCompaunds
            .Where(c => c.OrderId == Id_Order && c.CandyId == Id_Candy).SingleOrDefaultAsync();

        if (compositions == null) { return NotFound(); }

        return Ok(compositions);
    }

    // POST api/<OrderCompaundController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] OrderCompaund component)
    {
        await _context.OrderCompaunds.AddAsync(component);
        await _context.SaveChangesAsync();

        return Ok("compaund created");
    }

    // PUT api/<OrderCompaundController>/5
    [HttpPut("candy/{Id_Candy}/order/{Id_Order}")]
    public async Task<IActionResult> Put(
        Guid Id_Candy, Guid Id_Order, [FromBody] OrderCompaund compositionDto)
    {
        var composition = await _context.OrderCompaunds.AsNoTracking()
            .FirstOrDefaultAsync(c => c.OrderId == Id_Order && c.CandyId == Id_Candy);

        if (composition == null)
        {
            return NotFound();
        }

        composition = compositionDto;
        composition.OrderId = Id_Order;
        composition.CandyId = Id_Candy;

        _context.OrderCompaunds.Update(composition);

        await _context.SaveChangesAsync();

        return Ok("compaund updated");
    }

    // DELETE api/<OrderCompaundController>/5
    [HttpDelete("candy/{Id_Candy}/order/{Id_Order}")]
    public async Task<IActionResult> Delete(Guid Id_Candy, Guid Id_Order)
    {
        var composition = await _context.OrderCompaunds
            .FirstOrDefaultAsync(c => c.OrderId == Id_Order && c.CandyId == Id_Candy);

        if (composition == null) { return NotFound(); }

        _context.OrderCompaunds.Remove(composition);
        await _context.SaveChangesAsync();

        return Ok("compaund deleted");
    }
}
