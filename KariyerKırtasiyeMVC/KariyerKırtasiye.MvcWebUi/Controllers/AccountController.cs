﻿using KariyerKırtasiye.MvcWebUi.Identity;
using KariyerKırtasiye.MvcWebUi.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KariyerKırtasiye.MvcWebUi.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());

            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());

            RoleManager = new RoleManager<ApplicationRole>(roleStore);
        }




        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {

            if (ModelState.IsValid)
            {
                var user = new ApplicationUser();
                user.Name = model.Name;
                user.Surname = model.SurName;
                user.Email = model.Email;
                user.UserName = model.UserName;
                IdentityResult result = UserManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRole(user.Id, "user ");
                    }
                    return RedirectToAction("Login", "Account");

                }
                else
                {
                    ModelState.AddModelError("RegisterUserError","Kullanıcı oluşturma hatası."); 
                }

            }
            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {

            if (ModelState.IsValid)
            {
                //Login İşlemleri
             var user=   UserManager.Find(model.UserName,model.Password);

                if (user != null) 
                {
                    //Var olan kullanıcıyı  sisteme dahil  et
                    // ApplicationCookie oluşturup  sisteme bırak 
                    var authManager=HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");

                    var authProperties = new AuthenticationProperties();
                  authProperties.IsPersistent=model.RememberMe;
                    authManager.SignIn(authProperties, identityclaims);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Kullanıcı Bulunamadı");
                }

            }
            return View(model);
        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();


            return RedirectToAction("Index","Home");
        }


    }
}