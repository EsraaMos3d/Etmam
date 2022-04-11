using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core;
using Project.Core.Helper;
using Project.Core.Models;
using Project.EF;
using Project.Web.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers.API
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController( IUnitOfWork unitOfWork, ApplicationDbContext context  , UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult GetFormt(string PartialName )
        {
            return PartialView("~/Pages/Forms/"+ PartialName);
        }
        [HttpPost]
        public SelectList GetDeptByCollege(int College_ID)
        {
            SelectList Depts= new SelectList(_unitOfWork.Department.GetAll().Where(a => a.FK_College_Id == College_ID).ToList(), "Department_ID", SessionHelper.IsArabic ? "Name_Ar" : "Name_En");
            return Depts;
        }
        [HttpPost]
        public JsonResult ChangeTicketStatus(int Ticket_ID,int TicketStatus_Id)
        {

           Ticket ticket= _unitOfWork.Ticket.GetAll().Where(a => a.Ticket_Id == Ticket_ID).FirstOrDefault();
            if(ticket !=null)
            {
                List<TicketStatus> ticketstatus = _unitOfWork.TicketStatus.GetAll().ToList();
                ticket.FK_TicketStatus_Id = TicketStatus_Id;
                ticket.ModifiedOn = DateTime.Now;
                ticket.ModifiedBy = SessionHelper.UserId;
                ticket.ApprovedBy = SessionHelper.NameAr;
                if( _unitOfWork.Complete()==1)
                {
                    _unitOfWork.Notification.Add(new Notification() { CreatedBy = SessionHelper.UserId, NotificationText = SessionHelper.NameAr + "change ticket status from" + ticketstatus.Find(a=>a.TicketStatus_ID== ticket.FK_TicketStatus_Id).Name_En + "to" + ticketstatus.Find(a => a.TicketStatus_ID == TicketStatus_Id).Name_En, ModifiedBy = ticket.CreatedBy, IsDeleted = false });
                    _unitOfWork.Complete();
                    return Json(true);
                }
            }
            return Json( false);
        } 
        [HttpPost]
        public JsonResult AddReasonToTicket(int Ticket_ID,string Reason)
        {

           Ticket ticket= _unitOfWork.Ticket.GetAll().Where(a => a.Ticket_Id == Ticket_ID).FirstOrDefault();
            if(ticket !=null)
            {
                ticket.ModifiedOn = DateTime.Now;
                ticket.ModifiedBy = SessionHelper.UserId;
                ticket.ApprovedBy = SessionHelper.NameAr;
                ticket.Reason = Reason;
                if ( _unitOfWork.Complete()==1)
                {
                    //_unitOfWork.Notification.Add(new Notification() { CreatedBy = SessionHelper.UserId, NotificationText = SessionHelper.NameAr + "change ticket status from" + ticketstatus.Find(a=>a.TicketStatus_ID== ticket.FK_TicketStatus_Id).Name_En + "to" + ticketstatus.Find(a => a.TicketStatus_ID == TicketStatus_Id).Name_En, ModifiedBy = ticket.CreatedBy, IsDeleted = false });
                    //_unitOfWork.Complete();
                    return Json(true);
                }
            }
            return Json( false);
        }
        [HttpPost]
        public async Task<JsonResult> ChangeUserRole(string User_ID, string NewRole,string OldRoleName)
        {

           //var UserRole= _context.UserRoles.ToList().Where(a => a.UserId == User_ID).FirstOrDefault();
           var User= _context.Users.ToList().Where(a => a.Id == User_ID&&a.IsDeleted==false).FirstOrDefault();
           //var rolename= _context.Roles.ToList().Where(a => a.Id == Role_Id).FirstOrDefault().Name;
            if(User != null)
            {
                _context.SaveChanges();
                await _userManager.RemoveFromRoleAsync(User, OldRoleName);
                await _userManager.AddToRoleAsync(User,NewRole);
                _unitOfWork.Notification.Add(new Notification() {CreatedBy= SessionHelper.UserId, NotificationText=SessionHelper.NameEn+"change role from"+ OldRoleName+"to"+ NewRole,ModifiedBy= User_ID,IsDeleted=false });
                _unitOfWork.Complete();
                //if (_context.SaveChanges() == 1)
                //{
                //    return Json(true);
                //}
            }
            return Json( true);
        }
        [HttpPost]
        public IActionResult TicketDataHelder(DTParameters param,int? TicketStatus, DateTime? DateTo ,DateTime? DateFrom)
        {
            try
            {
                var columnSearch = param.Columns.Select(c => new Tuple<string, string>(c.Data, c.Search.Value)).ToList();
                var AllTicket = _unitOfWork.TicketRepository.GetAllTicket().Where(a => (a.FK_TicketStatus_Id == TicketStatus || TicketStatus == null) && (DateFrom == null || a.CreatedOn.Value.Date >= DateFrom.Value.Date) && (DateTo == null||a.CreatedOn.Value.Date <= DateTo.Value.Date));
                var xx = AllTicket;
                if (SessionHelper.RoleName== "CreateTicket")
                {
                    AllTicket= AllTicket.Where(a => a.CreatedBy == SessionHelper.UserId);
                }
                var Tickets = AllTicket;
                if (param.Search.Value != null && Tickets != null)
                    Tickets = AllTicket.Where(a => a.TicketNumber.Contains(param.Search == null ? "" : param.Search.Value)|| a.ApprovedBy.ToString().Contains(param.Search == null ? "" : param.Search.Value));
                var sortedPatient = Tickets.SortBy(param.SortOrder).Skip(param.Start).Take(param.Length).ToList();
                var recordsTotal = Tickets.Count();
                var data = sortedPatient;
                var jsonData = new { draw = param.Draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Json(jsonData);
            }
            catch 
            {
                return Json(false);
            }
        }
        [HttpPost]
        public IActionResult UserDataHelder(DTParameters param)
        {
            try
            {
                var columnSearch = param.Columns.Select(c => new Tuple<string, string>(c.Data, c.Search.Value)).ToList();
                var AllUser = _unitOfWork.UserRepository.GetAllUser();
                var Users = AllUser;
                if (param.Search.Value != null && Users != null)
                    Users = AllUser.Where(a => a.UserNumber.Contains(param.Search == null ? "" : param.Search.Value));//|| a.TicketStatus.Contains(param.Search == null ? "" : param.Search.Value) || a.TicketType.Contains(param.Search == null ? "" : param.Search.Value) || a.ApprovedBy.ToString().Contains(param.Search == null ? "" : param.Search.Value));
                var sortedPatient = Users.SortBy(param.SortOrder).Skip(param.Start).Take(param.Length).ToList();
                var recordsTotal = Users.Count();
                var data = sortedPatient;
                var jsonData = new { draw = param.Draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Json(jsonData);
            }
            catch 
            {
                return Json(false);
            }
        }

        [HttpPost]
        public ActionResult SaveTicket(string Data)
        {
            if(Data !="")
            {
                string base64 = Data.Split(',')[1];
                byte[] bytes = Convert.FromBase64String(base64);
                var split = System.Text.Encoding.UTF8.GetBytes(Data);
                var maxnum = _unitOfWork.Ticket.GetAll().Select(a => a.TicketNumber).Max();
                if (maxnum == "")
                    maxnum = "1";
                else
                    maxnum = (int.Parse(maxnum) + 1).ToString();

                ////image 
                //string fileNameWitPath = "~/Client/ScreenShot/custom_name.png";
                //using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
                //{
                //    using (BinaryWriter bw = new BinaryWriter(fs))
                //    {
                //        byte[] data = Convert.FromBase64String(Data);//convert from base64
                //        bw.Write(data);
                //        bw.Close();
                //    }

                //}
                    Ticket ticket = new Ticket() { TicketNumber= maxnum, Data = bytes, FK_TicketStatus_Id=1,FK_TicketType_Id=1, CreatedBy = SessionHelper.UserId, CreatedOn = DateTime.Now, IsDeleted = false };
                _unitOfWork.Ticket.Add(ticket);
                if (_unitOfWork.Complete() == 1)
                {
                   // return Json(true);
                }
            }
            // return Json(false);
            return RedirectToPage("/CreateTicket");
        }
    }
}
