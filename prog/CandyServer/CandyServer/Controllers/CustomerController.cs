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
public class CustomerController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CustomerController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/<CustomerController>
    [HttpGet]
    public async Task<IActionResult> GetAllCandy()
    {
        var customers = await _context.Customers.ToListAsync();
        return Ok(customers);
    }

    // GET api/<CustomerController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var customers = await _context.Customers.FindAsync(id);

        if (customers == null) { return NotFound(); }

        return Ok(customers);
    }

    // POST api/<CustomerController>
    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] CreateCustomerDto component)
    {
        await _context.Customers.AddAsync(_mapper.Map<Customer>(component));
        await _context.SaveChangesAsync();

        return Ok("customer created");
    }

    // PUT api/<CustomerController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] CreateCustomerDto componentDto)
    {
        var component = await _context.Customers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null)
        {
            return NotFound();
        }

        component = _mapper.Map<Customer>(componentDto);
        component.Id = Id;

        _context.Customers.Update(component);

        await _context.SaveChangesAsync();

        return Ok("customer updated");
    }

    // DELETE api/<CustomerController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var component = await _context.Customers.FirstOrDefaultAsync(c => c.Id == Id);

        if (component == null) { return NotFound(); }

        _context.Customers.Remove(component);
        await _context.SaveChangesAsync();

        return Ok("customer deleted");
    }
}