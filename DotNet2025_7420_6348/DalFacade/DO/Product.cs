using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product(
        int Id=0,
        string Name="",
        Category Category=Category.cat1,
        double Price=0.0,
        int InStock=1
    )
    {
        public Product(
            string Name,
            Category Category,
            double Price,
            int InStock):this(1,Name,Category,Price,InStock)
        {  }
    }

}
