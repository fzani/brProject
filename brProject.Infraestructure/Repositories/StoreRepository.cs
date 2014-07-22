using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brProject.Infraestructure
{
    public class StoreRepository<T> : Repository<T> where T : class
    {
    }
}
