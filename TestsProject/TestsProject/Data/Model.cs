using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestsProject.Data
{
    class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
    class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }
        public bool Discontinued { get; set; }
    }
}
