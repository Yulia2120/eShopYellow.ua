using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopYellow.ua
{
    public class ProductInfo
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [StringLength(255)]
        public string Price { get; set; }
        [StringLength(2255)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

    }
}
