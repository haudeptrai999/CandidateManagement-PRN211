using CandidateManagement_BusinessObjects;
using CandidateManagement_Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManagement_RazerPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private IHRAccountService hRAccountService;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            hRAccountService = new HRAccountService();
        }

        [BindProperty]
        public Hraccount hraccount { get; set; }
        public string NotifyText { get; set; }

        public IActionResult OnPost()
        {
            Hraccount hraccountLogin = hRAccountService.GetHraccountByEmail(hraccount.Email);
            if (hraccountLogin != null && hraccountLogin.Password.Equals(hraccount.Password))
            {
                return RedirectToPage("CandidateProfilePage", new { role = hraccountLogin.MemberRole });
            }
            else
            {
                NotifyText = "Invalid email or password";
                return Page();
            }

            //return Page();
        }

        public void OnGet()
        {

        }
    }
}
