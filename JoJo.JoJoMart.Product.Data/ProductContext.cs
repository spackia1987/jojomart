using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoJo.JoJoMart.Product.Data.Model;

namespace JoJo.JoJoMart.Product.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<JoJo.JoJoMart.Product.Data.Model.Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }

    }
}
