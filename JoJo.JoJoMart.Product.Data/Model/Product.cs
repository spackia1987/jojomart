using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoJo.JoJoMart.Product.Data.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(256, MinimumLength =3)]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public List<string>? Images { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        [ForeignKey("Seller")]
        public int SellerID { get; set; }
        public Seller? Seller { get; set; }
    }

    public class Seller
    {
        [Key]
        public int SellerID { get; set; }

        [Required]
        public string? SellerName { get; set; }

        public string SellerProfile { get; set; }
    }
    
}
