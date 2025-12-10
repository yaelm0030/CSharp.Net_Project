using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    internal record Product(
        int Id=0,
        string Name="",
        Category Category=Category.cat1,
        double Price=0.0,
        int InStock=1
    )
    { }

}
