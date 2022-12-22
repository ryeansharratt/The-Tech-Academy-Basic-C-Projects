using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DateTimeWebApp.Pages
{
    public class DateTimeModel : PageModel
    {
        private readonly ILogger<DateTimeModel> _logger;

        public DateTimeModel(ILogger<DateTimeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString();
            ViewData["TimeStamp"] = dateTime;
        }
    }
}
