using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductType { get; set; }//ring, chain

        public List<Item> Items { get; set; }
    }
}
