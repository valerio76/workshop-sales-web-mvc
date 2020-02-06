using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class Product
    {
        public int Id { get; set; }
        public string DepartmentId { get; set; }
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Price { get; set; }
        public Product(int id, string department, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
