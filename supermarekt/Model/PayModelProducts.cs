using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker.Model
{
    internal class PayModelProducts
    {
     
       

        public int? Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public String Category_id { get; set; }

      


        public PayModelProducts(int? id, string name, int price, int stock, String category_id)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            Category_id = category_id;
        }


       
        

    }

}

