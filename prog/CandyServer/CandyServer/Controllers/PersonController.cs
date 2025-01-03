using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Controllers;

[Route("api/[controller]")]
[ApiController]

public class PersonController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PersonController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var persons = await _context.Persons.ToListAsync();
        return Ok(persons);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var person = await _context.Persons.FindAsync(id);

        if (person == null) { return NotFound(); }

        return Ok(person);
    }

    [HttpGet("login/{login}/{password}")]
    public async Task<IActionResult> Login(string login, string password)
    {
        var person = await _context.Persons.FirstOrDefaultAsync(p => p.Login == login && p.Password == password);

        if (person == null)
        {
            return BadRequest("Not found");
        }

        var customer = await _context.Customers.FirstOrDefaultAsync(p => p.PersonId == person.Id);
        var admin = await _context.Admins.FirstOrDefaultAsync(p => p.PersonId == person.Id);

        if (customer != null)
        {
            return Ok("Customer");
        }
        else if (admin != null)
        {
            return Ok("Admin");
        }

        return BadRequest("Not found");
    }

    [HttpGet("input_login/{login}/pass/{password}")]
    public async Task<IActionResult> InputLogin(string login, string password)
    {
        var person = await _context.Persons.FirstOrDefaultAsync(p => p.Login == login && p.Password == password);

        if (person == null)
        {
            return BadRequest("Not found");
        }

        return Ok(person);
    }

    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Person person)
    {
        person.Id = Guid.NewGuid();

        var error = await _context.Persons.FirstOrDefaultAsync(p => p.Login == person.Login);

        if (error != null)
        {
            return BadRequest();
        }

        await _context.Persons.AddAsync(person);
        await _context.SaveChangesAsync();

        return Ok(person);
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Person personGet)
    {

        var person = await _context.Persons.FirstOrDefaultAsync(c => c.Id == personGet.Id);

        if (person == null)
        {
            return NotFound();
        }

        var error = await _context.Persons.FirstOrDefaultAsync(p => p.Login == personGet.Login);

        if (error != null && error.Id != person.Id)
        {
            return BadRequest();
        }


        _context.Persons.Update(personGet);

        await _context.SaveChangesAsync();

        return Ok("Person updated");
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var person = await _context.Persons.FirstOrDefaultAsync(c => c.Id == Id);

        if (person == null) { return NotFound(); }

        _context.Persons.Remove(person);
        await _context.SaveChangesAsync();

        return Ok("Person deleted");
    }
}
