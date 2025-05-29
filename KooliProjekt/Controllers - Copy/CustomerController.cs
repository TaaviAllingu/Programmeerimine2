using KooliProjekt.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class CustomerController : Controller
{
    private readonly ApplicationDbContext _context;

    public CustomerController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Index meetod lehekülje ja suurusega
    public async Task<IActionResult> Index(int page = 1)
    {
        int pageSize = 5;
        var customers = _context.Customers.AsQueryable();
        var result = await customers.GetPagedAsync(page, pageSize);
        return View(result);
    }
}
