using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product(
        int Id,
        string Name,
        Category Category,
        double Price,
        int InStock
    )
    {
        public Product():this(1,"",0,0,1)
        {  }
    }

}
