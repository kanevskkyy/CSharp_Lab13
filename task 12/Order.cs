using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    internal class Order
    {
        public string CompanyName { get; set; }
        public int ProductsAmount { get; set; }
        public string Product {  get; set; }
        public Order(string CompanyName, int ProductsAmount, string product)
        {
            this.CompanyName = CompanyName;
            this.ProductsAmount = ProductsAmount;
            this.Product = product;
        }

    }
}
