using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BudgetNest.Data;  // <-- THIS
using Microsoft.EntityFrameworkCore; // optional if you need EF methods
using BudgetNest.Models;


namespace BudgetNest.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<Todo> Todos { get; set; } = new List<Todo>();

    public void OnGet()
    {
        Todos = _context.Todos.ToList();
    }
}

