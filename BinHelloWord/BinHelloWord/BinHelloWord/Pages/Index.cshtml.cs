using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BinHelloWord.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Employee employee { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            employee = Newtonsoft.Json.JsonConvert.DeserializeObject<Employee>("{\"id\":\"1\",\"name\":\"bineesh\", }");

        }
    }
}