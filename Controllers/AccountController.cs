using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace yeni_layihe.Models;

public class AccountController : Controller{
private readonly UserManager<IdentityUser> _userManager;
private readonly SignInManager<IdentityUser> _signInManager;

public AccountController(UserManager<IdentityUser> userManager,
                              SignInManager<IdentityUser> signInManager)
    {
            _userManager = userManager;
            _signInManager = signInManager;
    }

    public IActionResult Register(){
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(Users model){

        if(ModelState.IsValid){
            var user = new IdentityUser{
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if(result.Succeeded){
                await _signInManager.SignInAsync(user, isPersistent:false);

                return RedirectToAction("index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            ModelState.AddModelError(string.Empty, "Invalid login");
        }
        return View(model);
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login(){
        return View();
    }

    public async Task<IActionResult> Login(Login model){
        if(ModelState.IsValid){
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if(result.Succeeded){
                return RedirectToAction("index", "Home");
        }

        ModelState.AddModelError(string.Empty, "Invalid Login");
        }

        return View(model);
    }
}