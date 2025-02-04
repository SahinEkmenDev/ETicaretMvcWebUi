﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KariyerKırtasiye.MvcWebUi.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [StringLength(maximumLength:20,ErrorMessage ="En fazla 20 karakter girebilirsinz !")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }



    }
}