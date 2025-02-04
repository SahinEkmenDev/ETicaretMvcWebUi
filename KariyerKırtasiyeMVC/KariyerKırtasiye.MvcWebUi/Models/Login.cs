﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KariyerKırtasiye.MvcWebUi.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
       
        [Required]
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}