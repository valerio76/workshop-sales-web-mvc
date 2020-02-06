using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Price { get; set; }

        public Department Department { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Product()
        {
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        } 
        
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
