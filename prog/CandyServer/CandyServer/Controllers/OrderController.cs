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
public class OrderController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public OrderController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/<OrderController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var customers = await _context.Orders.ToListAsync();
        return Ok(customers);
    }

    // GET api/<OrderController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var customers = await _context.Orders.FindAsync(id);

        if (customers == null) { return NotFound(); }

        return Ok(customers);
    }

    // POST api/<OrderController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] CreateOrderDto component)
    {
        await _context.Orders.AddAsync(_mapper.Map<Order>(component));
        await _context.SaveChangesAsync();

        return Ok("customer created");
    }

    // PUT api/<OrderController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] CreateOrderDto componentDto)
    {
        var component = await _context.Orders.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null)
        {
            return NotFound();
        }

        component = _mapper.Map<Order>(componentDto);
        component.Id = Id;

        _context.Orders.Update(component);

        await _context.SaveChangesAsync();

        return Ok("order updated");
    }

    // DELETE api/<OrderController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var component = await _context.Orders.FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null) { return NotFound(); }

        _context.Orders.Remove(component);
        await _context.SaveChangesAsync();

        return Ok("order deleted");
    }
}
