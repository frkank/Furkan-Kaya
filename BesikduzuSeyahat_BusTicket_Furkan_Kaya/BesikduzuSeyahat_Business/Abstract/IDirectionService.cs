using BesikduzuSeyahat.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesikduzuSeyahat.Business.Abstract
{
    public interface IDirectionService
    {
        Direction GetById(int id);
        void Create(Direction entity);
        void Update(Direction entity);
        void Delete(Direction entity);

        List<Direction> GetAll();
        string GetDeparture(string departure);
        string GetArrival(string arrival);
        List<Direction> GetTravel(string departure, string arrival);
        int GetDirectionByStartFinish(string start, string direction1, string direction2, string direction3, string finish);
        Direction GetDirectionDetails(int id);
    }
}
