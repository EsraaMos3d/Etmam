using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core;
using Project.Core.Helper;
using Project.EF;

namespace Project.Web.Pages
{
    public class ManageAuthorityModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        public ManageAuthorityModel(IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }
        public void OnGet()
        {
            ViewData["Roles"] = new SelectList(_context.Roles.ToList(), "Id", "Name");
        }
    }
}
