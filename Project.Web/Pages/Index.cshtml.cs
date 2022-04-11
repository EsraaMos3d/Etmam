using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Project.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Pages
{
   
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [Authorize]
        public IActionResult OnGet()
        {
            if(SessionHelper.UserId==null)
            {
                return LocalRedirect("/Identity/Account/Login");
            }
            else
            {
                return Page();
            }
        }
    }
}
