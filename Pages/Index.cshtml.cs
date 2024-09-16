using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HabitTracker.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public string TextExample { get; set; } = "TESTE VINDO DA CLASSE MODEL";

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
