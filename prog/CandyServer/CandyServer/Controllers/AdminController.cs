using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CandyServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var admins = await _context.Admins.ToListAsync();
        return Ok(admins);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var admin = await _context.Admins.Where(a => a.Id == id).Include(a => a.Person).SingleOrDefaultAsync();

        if (admin == null) { return NotFound(); }

        return Ok(admin);
    }

    [HttpPost]
    public async Task<IActionResult> Set([FromBody] Admin admin)
    {
        admin.Id = Guid.NewGuid();

        await _context.Admins.AddAsync(admin);
        await _context.SaveChangesAsync();

        return Ok(admin);
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Admin adminGet)
    {

        var admin = await _context.Admins.FirstOrDefaultAsync(c => c.Id == adminGet.Id);

        if (admin == null)
        {
            return NotFound();
        }

        admin.JobTitle = adminGet.JobTitle;

        await _context.SaveChangesAsync();

        return Ok("Person updated");
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var admin = await _context.Admins.FirstOrDefaultAsync(c => c.Id == Id);

        if (admin == null) { return NotFound(); }

        _context.Admins.Remove(admin);
        await _context.SaveChangesAsync();

        return Ok("Person deleted");
    }
}
