using CORE_HBKSOFTWARE.Interfaces;
using CORE_HBKSOFTWARE.Models;
using DataAccesLayer;
using Entity.KelimeOyunu;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebKelimeOyunu.Models;

namespace WebKelimeOyunu.Controllers
{
    public class AccountController : BaseController
    {
        readonly KelimeOyunuDBContext dBContext = new KelimeOyunuDBContext();
        private readonly IUnitOfWork<User> _unitOfWorkUser;
        private readonly IEmailSender _emailSender;
        private readonly ITokenGenerator _tokenGenerator;
        public readonly IRecaptchaValidator _recaptchaValidator;
        public readonly IPasswordHashing _passwordHashing;

        public AccountController(
            IUnitOfWork<User> unitOfWorkUser,
            IEmailSender emailSender,
            IRecaptchaValidator recaptchaValidator,
            ITokenGenerator tokenGenerator,
            IPasswordHashing passwordHashing)
        {
            _unitOfWorkUser = unitOfWorkUser;
            _emailSender = emailSender;
            _recaptchaValidator = recaptchaValidator;
            _tokenGenerator = tokenGenerator;
            _passwordHashing = passwordHashing;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(
            bool isRegistered = false,
            bool isVerifiedAccount = false,
            bool isAgainVerifiedAccount = false)
        {
            if (isRegistered)
            {
                ViewBag.Message = "Kaydınız başarılı bir şekilde alınmıştır. Hesabınızı doğrulayabilmeniz için e-mail adresinize mail gönderilmiştir.(Spam klasörünü kontrol etmeyi unutmayın.)";
                ViewBag.JS = "showControllerSuccess();";
            }
            if (isVerifiedAccount)
            {
                ViewBag.Message = "Hesabınız başarıyla doğrulanmıştır. Artık giriş yapabilirsiniz.";
                ViewBag.JS = "showControllerSuccess();";
            }
            if (isAgainVerifiedAccount)
            {
                ViewBag.Message = "Hesabınızı zaten doğrulamışsınız.";
                ViewBag.JS = "showControllerError();";
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var findUser = _unitOfWorkUser.RepositoryUser.GetUsersByEmail(loginViewModel.UserEMail);
                var userData = findUser.FirstOrDefault(x => x.UserEMail == loginViewModel.UserEMail);
                if (userData != null)
                {
                    if (userData.UserIsActive && userData.UserIsEmailConfirmed)
                    {
                        if (userData.UserRoleID == 1)
                        {
                            string ID = userData.UserID.ToString();
                            var claims = new List<Claim>
                                {
                                   new Claim(ClaimTypes.Email,userData.UserEMail),
                                   new Claim(ClaimTypes.Role,"Admin"),
                                   new Claim(ClaimTypes.NameIdentifier,ID),
                                   new Claim(ClaimTypes.Name,userData.UserName + userData.UserSurname)

                                };
                            var userIdentity = new ClaimsIdentity(claims, "UserIdentity");
                            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults
                                .AuthenticationScheme, new ClaimsPrincipal(principal),
                                new AuthenticationProperties
                                {
                                    AllowRefresh = true,
                                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30),
                                    IsPersistent = true,
                                    IssuedUtc = DateTimeOffset.UtcNow
                                });
                            return RedirectToAction("Index", "Admin");
                        }
                        else if (userData.UserRoleID == 2)
                        {
                            string ID = userData.UserID.ToString();
                            var claims = new List<Claim>
                                {
                                   new Claim(ClaimTypes.Email,userData.UserEMail),
                                   new Claim(ClaimTypes.Role,"Gamer"),
                                   new Claim(ClaimTypes.NameIdentifier,ID),
                                   new Claim(ClaimTypes.Name,userData.UserName + userData.UserSurname)
                                };
                            var userIdentity = new ClaimsIdentity(claims, "UserIdentity");
                            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults
                                .AuthenticationScheme, new ClaimsPrincipal(principal),
                                new AuthenticationProperties
                                {
                                    AllowRefresh = true,
                                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30),
                                    IsPersistent = true,
                                    IssuedUtc = DateTimeOffset.UtcNow
                                });
                            return RedirectToAction("Index", "Gamer");
                        }
                        else
                        {
                            return RedirectToAction("AccessDenied", "Account");
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Hesabınız aktif değil ya da doğrulanmamış! Lütfen hesabınızı doğrulayınız.";
                        ViewBag.JS = "showControllerError();";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "Girmiş olduğunuz bilgilere ait bir hesap bulamadık! Lütfen tekrar deneyiniz.";
                    ViewBag.JS = "showControllerError();";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Girmiş olduğunuz verilerde hata var! Lütfen tekrar deneyiniz.";
                ViewBag.JS = "showControllerError();";
                return View();
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var findUser = dBContext.Users.FirstOrDefault(
                    x => x.UserEMail == registerViewModel.User.UserEMail);
                if (findUser != null)
                {
                    ViewBag.Message = "Girmiş olduğunuz E-Mail Adresi veya Telefon Numarası ile daha önce kayıt olunmuştur! Lütfen tekrar deneyiniz.";
                    ViewBag.JS = "showControllerError();";
                    return View();
                }
                else
                {
                    if (registerViewModel.User.UserPassword != registerViewModel.UserAgainPassword)
                    {
                        ViewBag.Message = "Girmiş olduğunuz şifreler eşleşmemektedir! Lütfen tekrar deneyiniz.";
                        ViewBag.JS = "showControllerError();";
                        return View(registerViewModel);
                    }
                    else
                    {
                        var token = _tokenGenerator.GetToken(null);
                        registerViewModel.User.UserToken = token;
                        registerViewModel.User.UserIsActive = true;
                        _unitOfWorkUser.RepositoryUser.Create(registerViewModel.User);
                        _unitOfWorkUser.Complete();
                        string mailSubject = "HESABINIZI DOĞRULAYIN";
                        var verifyAccountLink =
                            Url.Action("VerifyAccount", "Account", new
                            {
                                email = registerViewModel.User.UserEMail,
                                token = token
                            }, Request.Scheme
                        );
                        var messageModel = new MessageModel(registerViewModel.User.UserName, registerViewModel.User.UserSurname, registerViewModel.User.UserEMail, mailSubject, verifyAccountLink, "verify-account", null);
                        _emailSender.EmailSendWithMimeAsync(messageModel);
                        return RedirectToAction("Login", new { isRegistered = true });
                    }
                }
            }
            else
            {
                ViewBag.Message = "Girmiş olduğunuz verilerde hata var! Lütfen tekrar deneyiniz.";
                ViewBag.JS = "showError();";
                return View(registerViewModel);
            }
        }

        [AllowAnonymous]
        public IActionResult VerifyAccount(string token, string email)
        {
            if (getCurrentUserClaimRole() != null)
            {
                if (getCurrentUserClaimRole() == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if (getCurrentUserClaimRole() == "Gamer")
                {
                    return RedirectToAction("Index", "Gamer");
                }
            }
            else
            {
                if (token != null && email != null)
                {
                    var user = dBContext.Users.FirstOrDefault(x => x.UserEMail == email);
                    if (user != null)
                    {
                        if (user.UserIsEmailConfirmed != true && user.UserToken == token)
                        {
                            user.UserIsEmailConfirmed = true;
                            user.UserToken = null;
                            _unitOfWorkUser.RepositoryUser.Update(user);
                            _unitOfWorkUser.Complete();
                            return RedirectToAction("Login", new { isVerifiedAccount = true });
                        }
                        else
                        {
                            return RedirectToAction("Login", new { isAgainVerifiedAccount = true });
                        }
                    }
                    else
                    {
                        return RedirectToAction("AccessDenied", "Account");
                    }
                }
                else
                {
                    return RedirectToAction("AccessDenied", "Account");
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}