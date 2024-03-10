using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models{
    public class Product{

        [Display(Name = "Ürün ID")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Ürün adı verilmesi zorunludur!")]
        [Display(Name = "Ürün Adı")]
        public string? Name {get; set; }

        [Required(ErrorMessage = "Ürün fiyat bilgisi zorunludur!")]
        [Range(0, 100000, ErrorMessage ="Fiyat Aralığı 0 - 100000 arasında olmalıdır!")]
        [Display(Name = "Ürün Fiyatı")]
        public decimal? Price { get; set; }

        
        [Display(Name = "Ürün Resmi")]
        public string? Image {get; set; }

        [Display(Name = "Ürün Satış Durumu")]
        public bool isActive { get; set; }

        [Required(ErrorMessage = "Ürünün kategorisi seçilmelidir!")]
        [Display(Name = "Ürün Kategori")]
        public int? CategoryID { get; set; }
    }
}