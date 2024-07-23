using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace KariyerKırtasiye.MvcWebUi.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            try
            {
                var kategoriler = new List<Category>()
                {
            new Category(){Name="Kitap", Description="Kitap Ürünleri"},
            new Category(){Name="Kalem", Description="Kalem Ürünleri"},
            new Category(){Name="Defter", Description="Defter Ürünleri"},
            new Category(){Name="Oyuncak", Description="Oyuncak Ürünleri"},
            new Category(){Name="Ofis", Description="Ofis Ürünleri"},
            new Category(){Name="Elektronik", Description="Elektronik Cihazlar"}
                };

                foreach (var kategori in kategoriler)
                {
                    context.Categories.Add(kategori);
                }

                context.SaveChanges();

                var urunler = new List<Product>()
        {
            new Product(){Name="Faber Castel silgi", Description="Yumşak uçlu iz yapmaz kaliteli  silgi", Price=50, Stock=100, IsApproved=false, CategoryId=1,IsHome=true,Image="1.jpg"  },
            new Product(){Name="Rotring Kalem", Description="Rotring, teknik çizimler ve yazı işleri için önde gelen bir markadır ve ürün yelpazesinde çeşitli kalemler bulunmaktadır. Rotring kalemler, mühendislik, mimarlık ve sanat gibi alanlarda yaygın olarak kullanılan ergonomik tasarımlarıyla dikkat çeker. Genellikle metal uçlu olan bu kalemler, dayanıklılıklarıyla bilinir ve farklı mekanizma seçenekleri sunar.", Price=450, Stock=100, IsApproved=true, CategoryId=2,IsHome=true,Image="2.jpg"},
            new Product(){Name="Kalemtraş Faber Castel", Description="Güzel kalem  açmaktadır", Price=30, Stock=100, IsApproved=true, IsHome=true,CategoryId=3,Image="3.jpg"},
            new Product(){Name="Gıpta 120 Yaprak Çizgili", Description="Gıpta 120 Yaprak Çizgili, not almak ve günlük tutmak için ideal bir seçenektir. Bu defter, 120 yaprak çizgili kağıdıyla standart A5 boyutunda tasarlanmıştır (148 mm x 210 mm). Yumuşak kapaklı olan bu defter, beyaz kağıt üzerine çizgili desenlerle sunulmaktadır. Spiral bağlı yapısı sayesinde kolayca açılıp kapanabilir. Hem iş hem de okul amaçları için uygun olan bu defter, pratik ve kullanışlı bir seçenektir.", Price=100, Stock=100, IsApproved=true, CategoryId=4,IsHome=true,Image="4.jpg"},
            new Product(){Name="Tarih Atlası", Description="Anlaşılabilir ve göze hitap  eder", Price=75, Stock=100, IsApproved=true,IsHome=true, CategoryId=5, Image = "5.jpg"},
            new Product(){Name="0,7 Uç", Description="Yumşak  ve  her  kalem için  uygundur", Price=35, Stock=100, IsApproved=true,IsHome=true, CategoryId=2,Image="6.jpg"},
           
        };

                foreach (var urun in urunler)
                {
                    context.Products.Add(urun);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            base.Seed(context);
        }

    }
}