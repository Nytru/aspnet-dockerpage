using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string? Name { get; set; }

    [BindProperty]
    public string? Email { get; set; }

    [BindProperty]
    public string? Message { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        Name = Request.Form["name"];
        Email = Request.Form["email"];
        Message = Request.Form["message"];

        return RedirectToPage("/ShowRoom", new { name = Name, email = Email, message = Message });

    }
}