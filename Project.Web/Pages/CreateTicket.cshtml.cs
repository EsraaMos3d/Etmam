using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core;
using Project.Core.Helper;
using Project.Core.Models;

namespace Project.Web.Pages
{
    public class CreateTicketModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateTicketModel( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            ViewData["Colleges"] = new SelectList(_unitOfWork.College.GetAll().ToList(), "College_Id", SessionHelper.IsArabic ? "CollegeName_Ar" : "CollegeName_En");
        }
 
    }
}
