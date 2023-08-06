using IdentityWithRole.Models;
using IdentityWithRole.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWithRole.Controllers
{
    public class AccountController : Controller
    {
        public readonly SignInManager<IdentityUser> _signManager;
        public readonly UserManager<IdentityUser> _userManager;
        public readonly ApplicationDbContext _context;
        public AccountController(SignInManager<IdentityUser> signManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _signManager = signManager;
            _userManager = userManager;
            _context = context;
        }
        #region Register
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var result2 = await _userManager.AddToRoleAsync(user, "Admin");
                    await _signManager.SignInAsync(user, isPersistent: false).ConfigureAwait(false);
                    return RedirectToAction("index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(model);
        }
        #endregion

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginVM user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    var userData = await _userManager.FindByNameAsync(user.Email);
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();

            return RedirectToAction("Login");
        }

    }
}
