using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core;
using Project.Core.Helper;

namespace Project.Web.Pages
{
    [AllowAnonymous]
    public class SearchTicketsModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public SearchTicketsModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            ViewData["TicketStatus"] = new SelectList(_unitOfWork.TicketStatus.GetAll().ToList(), "TicketStatus_ID", SessionHelper.IsArabic ? "Name_Ar" : "Name_En");
        }
    }
}
