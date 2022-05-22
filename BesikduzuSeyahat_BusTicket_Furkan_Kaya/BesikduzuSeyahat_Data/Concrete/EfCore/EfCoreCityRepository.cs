using BesikduzuSeyahat.Data.Abstract;
using BesikduzuSeyahat.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesikduzuSeyahat.Data.Concrete.EfCore
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City, TicketContext>, ICityRepository
    {
        public string CityName()
        {
            throw new NotImplementedException();
        }
    }
}
