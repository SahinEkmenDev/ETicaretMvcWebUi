using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KariyerKırtasiye.MvcWebUi.Entity
{
    public class Product
    {

        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Fiyat")]
        public double Price { get; set; }
        [DisplayName("Ürün Stok")]
        public int Stock { get; set; }


        [DisplayName("Ürün Resmi")]
        public string Image { get; set; }
        [DisplayName("Onaylı mı?")]
        public bool IsApproved { get; set; }
        [DisplayName("Anasayfada mı")]
        public bool IsHome { get; set; }
        [DisplayName("Ürün açıklama")]
        public string Description { get; set; }
        [DisplayName("Nereye Ekleyeceksiniz ?")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }



    }
}