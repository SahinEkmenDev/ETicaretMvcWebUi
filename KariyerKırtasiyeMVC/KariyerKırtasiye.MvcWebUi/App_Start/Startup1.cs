﻿using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Cookies;
[assembly: OwinStartup(typeof(KariyerKırtasiye.MvcWebUi.App_Start.Startup1))]

namespace KariyerKırtasiye.MvcWebUi.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {


            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            app.UseCookieAuthentication(new CookieAuthenticationOptions() 
            { 

                AuthenticationType="AplicationCookie",
                LoginPath=new PathString("/Account/Login")

            });
            
        }
    }
}
