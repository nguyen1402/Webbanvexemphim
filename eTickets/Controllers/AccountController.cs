using eTickets.Data;
using eTickets.Data.Static;
using eTickets.Data.ViewModels;
using eTickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using eTickets.MailsUtis;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;

namespace eTickets.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;
        private readonly IEmailSender _emailSender;
        public INotyfService _NotyfService { get; }


        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext context, IEmailSender emailSender, INotyfService notyfService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _emailSender = emailSender;
            _NotyfService = notyfService;
        }
        [Route("tai-khoan-cua-toi.html", Name = "Information")]
        public IActionResult Information()
        {

            var taikhoanid = HttpContext.Session.GetString("Id");
            if (taikhoanid != null)
            {
                var khachhang = _context.Users.AsNoTracking()
                    .SingleOrDefault(c => c.Id == taikhoanid);
                if (khachhang != null)
                {
                    return View(khachhang);
                }
                return RedirectToAction("Login");
            }
            return View();
        }
        [Authorize]
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        public IActionResult Login() => View(new LoginVM());

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, /*isPersistent: xem khi đăng xuất có lưu vào cooki k*/false, /*lockoutOnFailure: xem có bị khóa khi đănn nhập thất bại*/false);
                    if (result.Succeeded)
                    {
                        HttpContext.Session.SetString("Id", user.Id);
                        return RedirectToAction("Index", "Movies");
                    }
                }

                if (user.EmailConfirmed == false)
                {
                    TempData["Error"] = "Vui lòng xác minh email để đăng nhập !";
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
                    var callback = Url.Action(nameof(RegisterCompleted), "Account", new { userId = user.Id, token }, Request.Scheme);
                    await _emailSender.SendEmailAsync(user.Email, "Email xác thực",
                        $"Bấm vào đây <a href='{callback}'> để kích hoạt tài khoản");
                    return View(loginVM);
                }
                TempData["Error"] = "Đăng nhập thất bại !";
                return View(loginVM);
            }

            TempData["Error"] = "Đăng nhập thất bại !";
            return View(loginVM);
        }

        public IActionResult Register() => View(new RegisterVM());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            var user = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
            if (user != null)
            {
                TempData["Error"] = "Email đã có người sử dụng";
                return View(registerVM);
            }

            var newUser = new ApplicationUser()
            {
                FullName = registerVM.FullName,
                Email = registerVM.EmailAddress,
                UserName = registerVM.EmailAddress
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);
            await _userManager.AddToRoleAsync(newUser, UserRoles.User);
            if (newUserResponse.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
                var callback = Url.Action(nameof(RegisterCompleted), "Account", new { userId = newUser.Id, token}, Request.Scheme);
                await _emailSender.SendEmailAsync(newUser.Email, "Email xác thực",
                    $"Bấm vào đây <a href='{callback}'> để kích hoạt tài khoản");
            }
            else
            {
                foreach (var error in newUserResponse.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View();
            }
            return RedirectToAction(nameof(RegisterLoading));
        }

        [AllowAnonymous]
        public async Task<IActionResult> RegisterCompleted(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Không tìm thấy User có ID {user}");
            }
            token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));
            var resual = await _userManager.ConfirmEmailAsync(user, token);
            if (resual.Succeeded)
            {
                TempData["Error"] = "Xác thực thành công !";
                return View();
            }
            TempData["Error"] = "Xác thực thất bại!";
            return View();
        }
        public IActionResult RegisterLoading()
        {
            return View();
        }
        public IActionResult AccessDenied(string ReturnUrl)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Movies");
        }
        [HttpGet]
        [Route("doimatkhau")]
        public async Task<IActionResult> ChangedPassword()
        {
            return View();
        }
        [HttpPost]
        [Route("doimatkhau")]
        public async Task<IActionResult> ChangedPassword(ChangedPasswordVM _changed)
        {
            var taikhoanid = HttpContext.Session.GetString("Id");
            var user = await _userManager.FindByIdAsync(taikhoanid);
            if (user == null)
            {
                TempData["Error"] = "Đổi mật khẩu thất bại !";
                return View(_changed);
            }
            if (string.IsNullOrEmpty(_changed.PasswordNow))
            {
                TempData["Error"] = "Cần điền mật khẩu !";
                return View(_changed);
            }
            if (string.IsNullOrEmpty(_changed.PasswordNew) || _changed.PasswordNew.Length < 5 )
            {
                TempData["Error"] = "Mật khẩu phải mới phải có ít nhất 5 kí tự !";
                return View(_changed);
            }
            if (_changed.PasswordNew != _changed.NhaplaiPassword)
            {
                TempData["Error"] = "Nhập lại mật khẩu không khớp !";
                return View(_changed);
            }
            var resul = await _userManager.ChangePasswordAsync(user, _changed.PasswordNow, _changed.PasswordNew);
            if (resul.Succeeded)
            {
                _NotyfService.Success("Đổi mật khẩu thành công !");
                return RedirectToAction("Information", "Account");
            }
            TempData["Error"] = "Đổi mật khẩu thất bại !";
            return View(_changed);
        }
        //Quên mật khẩu
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM forgotPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(forgotPasswordModel);
            var user = await _userManager.FindByEmailAsync(forgotPasswordModel.Email);
            if (user == null)
                return RedirectToAction(nameof(ForgotPasswordConfirmationFails));

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "Account", new { token, email = user.Email }, Request.Scheme);

            await _emailSender.SendEmailAsync(user.Email, "Email xác thực",
                $"Bấm vào đây <a href='{callback}'> để đổi mật khẩu");
            return RedirectToAction(nameof(ForgotPasswordConfirmation));
        }

        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
        public IActionResult ForgotPasswordConfirmationFails()
        {
            return View();
        }


        //Làm mới mật khẩu
        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            var model = new ResetPasswordModel { Token = token, Email = email };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            if (!ModelState.IsValid) return View(resetPasswordModel);
            var user = await _userManager.FindByEmailAsync(resetPasswordModel.Email);
            if (user == null)
            {
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }
            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordModel.Token, resetPasswordModel.Password);
            if (!resetPassResult.Succeeded)
            {
                TempData["Error"] = "Đổi mật khẩu thất bại !";
                return View(resetPasswordModel);
            }
            return RedirectToAction(nameof(ResetPasswordConfirmation));
        }

        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }





    }
}
