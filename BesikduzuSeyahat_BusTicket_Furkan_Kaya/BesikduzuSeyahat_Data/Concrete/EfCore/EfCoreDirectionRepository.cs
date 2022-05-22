using BesikduzuSeyahat.Data.Abstract;
using BesikduzuSeyahat.Data.Concrete.EfCore;
using BesikduzuSeyahat.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesikduzuSeyahat.Data.Concrete.EfCore
{
    public class EfCoreDirectionRepository : EfCoreGenericRepository<Direction, TicketContext>, IDirectionRepository
    {
        public string GetArrival(string arrival)
        {
            using (var context = new TicketContext())
            {
                var arv = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(arrival))
                    .Select(i => i.CityName)
                    .ToList();
                return arv[0];
            }
        }

        public string GetDeparture(string departure)
        {
            using (var context = new TicketContext())
            {
                var dprt = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(departure))
                    .Select(i => i.CityName)
                    .ToList();
                return dprt[0];
            }
        }

        public int GetDirectionByStartFinish(string start, string drctn1, string drctn2, string drctn3, string finish)
        {
            throw new NotImplementedException();
        }

        public Direction GetDirectionDetails(int id)
        {
            using (var context = new TicketContext())
            {
                return context.Directions
                    .Where(i => i.DirectionId == id)
                    .AsNoTracking()
                    .FirstOrDefault();
            }
        }

        public List<Direction> GetTravel(string departure, string arrival)
        {
            using (var context = new TicketContext())
            {
                var dprt = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(departure))
                    .Select(i => i.CityName)
                    .ToList();
                var arv = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(arrival))
                    .Select(i => i.CityName)
                    .ToList();
                var directions = context.Directions
                    .FromSqlRaw($"select * from Directions where ((Start='{dprt[0]}' or direction1='{dprt[0]}' or direction2='{dprt[0]}' or direction3='{dprt[0]}' ) and (Finish='{arv[0]}' or direction3='{arv[0]}' or direction2='{arv[0]}' or direction1='{arv[0]}' )) ")
                    .ToList();

                return directions;

            }
        }
    }
}
