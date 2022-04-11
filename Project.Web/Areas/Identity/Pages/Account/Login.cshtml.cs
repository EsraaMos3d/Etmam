using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Project.Core.Models;
using Project.Core;
using Project.Core.Helper;

namespace Project.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public LoginModel(SignInManager<ApplicationUser> signInManager, 
            ILogger<LoginModel> logger,
            UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
           // returnUrl ??= Url.Content("~/account/Profile");
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var user = _unitOfWork.ApplicationUser.GetAll().Where(a => a.Email == Input.Email).FirstOrDefault();
                    if (user != null)
                    {
                        SessionHelper.UserId = user.Id;
                        SessionHelper.UserName = user.UserName;
                        SessionHelper.NameAr = user.Full_Name_Ar;
                        SessionHelper.NameEn = user.Full_Name_En;
                        var userRole = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
                        SessionHelper.IsAdmin = userRole != null && userRole == "ManageAuthority" ? true : false;
                        SessionHelper.RoleName = userRole;
                        List<Notification> Notifications = new List<Notification>();
                        Notifications = _unitOfWork.Notification.GetAll().Where(a => a.IsDeleted == false && a.ModifiedBy == user.Id && a.ModifiedBy != null).ToList();
                        SessionHelper.Notifications = Notifications;
                        SessionHelper.NotificationsCount = Notifications.Count().ToString();
                        if (userRole == "ManageTicket")
                        {
                            //created ticket to be approved
                            //Tickets = _unitOfWork.Ticket.GetAll().Where(a => a.IsDeleted == false && a.FK_TicketStatus_Id == 1).ToList();
                            //SessionHelper.Tickets = Tickets;
                            //SessionHelper.NotificationsCount = Tickets.Count().ToString();

                        }
                        if (userRole == "CreateTicket")
                        {
                            //notifi user that created ticket is approved
                           
                        }
                        _logger.LogInformation("User logged in.");
                        return LocalRedirect("/Index");
                    }
                    if (result.RequiresTwoFactor)
                    {
                        return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                    }
                    if (result.IsLockedOut)
                    {
                        _logger.LogWarning("User account locked out.");
                        return RedirectToPage("./Lockout");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return Page();
                    }
                }
            }

                // If we got this far, something failed, redisplay form
                return Page();
        }
    }
}
