using BesikduzuSeyahat.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesikduzuSeyahat.Data.Abstract
{
    public interface IDirectionRepository : IRepository<Direction>
    {
        string GetDeparture(string departure);
        string GetArrival(string arrival);
        List<Direction> GetTravel(string departure, string arrival);
        int GetDirectionByStartFinish(string start, string drctn1, string drctn2, string drctn3, string finish);
        Direction GetDirectionDetails(int id);


    }
}
