using Microsoft.AspNetCore.Identity;
using myScoreApp.Models.Comments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.Models
{
    public class Mekan
    {
        public int mekanId { get; set; }

        [Display(Name = "Kategori")]
        public string CatName { get; set; }
        
        [Display(Name = "Fiyat")]
        public string Fiyat { get; set; }

        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }

        [Display(Name = "Ürün Açıklaması")]
        public string urunAciklamasi { get; set; }

        [Display(Name = "Ürün Stok Sayısı")]
        public string urunStok { get; set; }

        [Display(Name = "Ürüne Ait Resim")]
        public string mekanResim { get; set; }

        [Display(Name = "Tarih")]
        public DateTime tarih { get; set; }
        public List<MainComment> MainComments { get; set; }
        public IdentityUser user { get; set; }
    }
}
