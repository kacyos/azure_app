using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app.Pages
{
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
            throw new Exception("This is a test exception for Application Insights.");
        }
    }

}
