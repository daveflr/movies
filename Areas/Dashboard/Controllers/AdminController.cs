using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal;
using Microsoft.EntityFrameworkCore;
using movies.Models;
using movies.Areas.Dashboard.ViewModels;

namespace movies.Areas.Dashboard.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly MoviesDbContext _db;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
            MoviesDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }

        [Area("Dashboard")]
        [Authorize(Roles = "Admin, Editor")]
        public IActionResult Enter()
        {
            return LocalRedirect("/Dashboard");
        }

        [Area("Dashboard")]
        [Authorize(Roles = "Admin, Editor")]
        public async Task<IActionResult> Index()
        {
            var adminViewModel = new AdminViewModel
            {
                UserCount = await _userManager.Users.CountAsync(),
                CommentsCount = await _db.Comments.CountAsync(),
                MoviesCount = await _db.Movies.CountAsync(),
                RolesCount = await _roleManager.Roles.CountAsync()
            };
            return View("Index", adminViewModel);
        }

        [Area("Dashboard")]
        [Authorize(Roles = "Admin, Editor")]
        public async Task<IActionResult> Users()
        {
            var userListTables = new List<UserListTable>();
            foreach (var user in await _userManager.Users.ToListAsync())
            {
                var userListTableModel = new UserListTable
                {
                    Users = user,
                    CommentCount = await _db.Comments
                        .CountAsync(u => u.UserId == user.Id),
                    UserRoles = await _userManager.GetRolesAsync(user),
                };
                userListTables.Add(userListTableModel);
            }

            return View("Users", userListTables);
        }

        [Area("Dashboard")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateRol(string rolName = null)
        {
            var rol = new IdentityRole(rolName);
            await _roleManager.CreateAsync(rol);
            return LocalRedirect("/Dashboard");
        }

        [Area("Dashboard")]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditUserRoles(List<string> rolesSelected, string email = null)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (rolesSelected.Count == 0)
            {
                foreach (var rol in await _roleManager.Roles.ToListAsync())
                {
                    var result = await _userManager.RemoveFromRoleAsync(user, rol.Name);
                }
            }

            foreach (var rol in rolesSelected)
            {
                var roleToAssign = await _roleManager.FindByNameAsync(rol);
                var assign = await _userManager.AddToRoleAsync(user, rol);
            }

            return RedirectToAction("Users");
        }
    }
}