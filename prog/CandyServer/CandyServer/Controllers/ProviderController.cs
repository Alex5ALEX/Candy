using CandyServer.Data;
using CandyServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProviderController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProviderController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProviders()
    {
        var providers = await _context.Providers.ToListAsync();
        return Ok(providers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var provider = await _context.Providers.Where(p => p.Id == id)
            .Include(p => p.Supplies).SingleOrDefaultAsync();

        if (provider == null) { return NotFound(); }

        return Ok(provider);
    }

    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Provider provider)
    {
        await _context.Providers.AddAsync(provider);
        await _context.SaveChangesAsync();

        return Ok("provider created");
    }

    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Provider providerGet)
    {
        var provider = await _context.Providers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

        if (provider == null)
        {
            return NotFound();
        }

        provider = providerGet;
        provider.Id = Id;

        _context.Providers.Update(provider);

        await _context.SaveChangesAsync();

        return Ok("Provider updated");
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var provider = await _context.Providers.FirstOrDefaultAsync(c => c.Id == Id);

        if (provider == null) { return NotFound(); }

        _context.Providers.Remove(provider);
        await _context.SaveChangesAsync();

        return Ok("Provider deleted");
    }
}