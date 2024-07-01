using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product 
    {
        [Display(Name = "Urun Id")]
        [BindNever]
        public int ProductId {  get; set; }

        [Required(ErrorMessage = "Gerekli bir alan")]
        [Display(Name = "Urun Adı")]
        public string? Name { get; set; }

        [Required]
        [Range(0,100000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get;  set; }

        [Display(Name = "Resim")]
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

    }
}