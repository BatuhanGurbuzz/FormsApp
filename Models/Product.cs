using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models{
    public class Product{

        [Display(Name = "Ürün ID")]
        public int ProductID { get; set; }

        [Display(Name = "Ürün Adı")]
        public string? Name {get; set; }

        [Display(Name = "Ürün Fiyatı")]
        public decimal Price { get; set; }

        [Display(Name = "Ürün Resmi")]
        public string? Image {get; set; }

        [Display(Name = "Ürün Satış Durumu")]
        public bool isActive { get; set; }

        [Display(Name = "Ürün Kategori ID")]
        public int CategoryID { get; set; }
    }
}