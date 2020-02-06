using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
