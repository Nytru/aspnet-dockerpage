using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Pages;

public class ShowRoom : PageModel
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Message { get; set; }

    public void OnGet(string name, string email, string message)
    {
        Name = name;
        Email = email;
        Message = message;
    }
}