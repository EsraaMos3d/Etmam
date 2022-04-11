using Project.Core.Interfaces;
using Project.Core.Models;
using Project.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.EF.Repositories
{
    public class UserRepository:BaseRepository<ApplicationUser>,IUserRepository
    {
        private readonly ApplicationDbContext _context;
    public UserRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
    
        public IQueryable<VM_User> GetAllUser()
        {
            var Users = (from U in _context.Users
                           join UR in _context.UserRoles
                          on U.Id equals UR.UserId into grouping1
                          from UR in grouping1.DefaultIfEmpty()
                          join R in _context.Roles
                          on UR.RoleId equals R.Id into grouping2
                         from R in grouping2.DefaultIfEmpty()
                         where U.IsDeleted == false
                          select (new VM_User()
                          {
                              UserId=U.Id,
                              Email=U.Email,
                              UserName=U.UserName,
                              UserNumber=U.UserNumber,
                              FK_Branch_Id =U.FK_Branch_Id,
                              FK_College_Id =U.FK_College_Id,
                              FK_Department_Id=U.FK_Department_Id,
                              Mobile=U.Mobile,
                              Phone = U.Phone,
                              NID = U.NID,
                              Address = U.Address,
                              Full_Name_Ar = U.Full_Name_Ar,
                              Full_Name_En = U.Full_Name_En,
                              RoleId = R.Id,
                              RoleName = R.Name,
                          }));
            return Users;
        }
    }
}
