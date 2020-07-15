using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public int PartnerId { get; set; }

        public int CategoryId { get; set; }

        public string Details { get; set; }

        public string Image { get; set; }

        public  decimal Price { get; set; }

        public decimal DiscountPrice { get; set; }
    }
}
