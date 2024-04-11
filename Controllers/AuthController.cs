using Bloger_Project_Practise.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger_Project_Practise.Controllers
{
    public class AuthController : Controller
    {
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;

        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());  
        }

        //Sử dụng 2 phương thức PasswordSignIn lấy thông tin user và SighOut để logout user khỏi app;
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            var result = await _signInManager.PasswordSignInAsync(vm.UserName, vm.Password, false, false);
            if(!result.Succeeded)
            {
                return View(vm);
            }

            //SigninManager quản lý việc đăng nhập đăng xuất còn User Manager quản lý người dùng
            //Ta tìm tên của user thông qua UserManager sau đó so sánh với role của user từ đó tìm ra Admin
            //Sau khi đã tìm đươc Admin, ta chuyển hướng họ về Panel
            //Còn nếu là user thông thường ta điều hường về lại trang chủ
            var user = await _userManager.FindByNameAsync(vm.UserName);
            var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");

            if(isAdmin)
            {
                return RedirectToAction("Index", "Panel");
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        //Sử dụng 2 phương thức PasswordSignIn lấy thông tin user và SighOut để logout user khỏi app;
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }

            //Tương tự cho việc khai báo và sử dụng Identity User ở bước tạo Login, Logout tại Program.cs
            var user = new IdentityUser
            {
                UserName = vm.Email,
                Email = vm.Email
            };

            var result = await _userManager.CreateAsync(user, vm.Password);

            if(result.Succeeded)
            {
                //Tại tham số thứ 2 của SignInAsync(isPersistent), ta có thể phát triển thành ghi nhớ password cho lần đăng nhập tiếp theo
                await _signInManager.SignInAsync(user, false);

                return RedirectToAction("Index", "Home");
            }

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
