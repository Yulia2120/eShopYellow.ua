using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopYellow.ua.DataModel
{
    public class Model1: DbContext
    {
        public Model1()
          : base("name=Model1") { }

        public virtual DbSet<ProductInfo> ProductInfoList { get; set; }
        public IEnumerable<object> Products { get; internal set; }
    }
}
