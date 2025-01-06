using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;

namespace BlApi
{
    public interface ISale:ICrud<Sale>
    {
        int Create(Sale s);
        Sale? Read(int id);
        Sale? Read(Func<Sale, bool> filter);
        List<Sale?> ReadAll(Func<Sale, bool>? filter = null);
        void Update(Sale sale);
        void Delete(int id);
    }
}
