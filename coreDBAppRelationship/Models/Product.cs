using System;
using System.Collections.Generic;

#nullable disable

namespace coreDBAppRelationship.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public string Image { get; set; }
        public DateTime? ProductAddedDate { get; set; }
        public int? BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
