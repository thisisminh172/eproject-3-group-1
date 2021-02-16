using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public int Pairs { get; set; }//not clear

        public int BrandId { get; set; }//FK

        public int Quantity { get; set; }//Storage

        public int CategoryId { get; set; }//FK

        //public string ProductQuality { get; set; }//not clear

        public int CertifyId { get; set; }//FK

        public int ProductId { get; set; }//FK

        public int GoldTypeId { get; set; }//FK

        public int DiamondTypeId { get; set; }// does not required, nullable

        public float GoldWeight { get; set; }

        public int WastageInPercentage { get; set; }

        public float TotalMaking { get; set; }//total price

        public int Size { get; set; }

        public virtual Gold Gold { get; set; }
        public virtual Certification Certification { get; set; }
        public virtual Product Product { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<ItemImage> ItemImages { get; set; }
    }
}
