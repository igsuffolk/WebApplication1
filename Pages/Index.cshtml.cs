
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWithBlazor.Pages
{
    public class IndexModel : PageModel
    {
        public string Result;
        private readonly ILogger<IndexModel> _logger;
       
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
           
        }

        public async Task OnGet()
        {
           

        }
    }
}
