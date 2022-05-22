using BesikduzuSeyahat.Business.Abstract;
using BesikduzuSeyahat.Data.Abstract;
using BesikduzuSeyahat.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesikduzuSeyahat.Business.Concrete
{
    public class DirectionManager : IDirectionService
    {
        private IDirectionRepository _directionRepository;
        public DirectionManager(IDirectionRepository directionRepository)
        {
            _directionRepository = directionRepository;
        }
        public void Create(Direction entity)
        {
            _directionRepository.Create(entity);
        }

        public void Delete(Direction entity)
        {
            _directionRepository.Delete(entity);
        }

        public void Update(Direction entity)
        {
            _directionRepository.Update(entity);
        }

        public List<Direction> GetAll()
        {
            return _directionRepository.GetAll();
        }

        public Direction GetById(int id)
        {
            return _directionRepository.GetById(id);
        }

        public string GetDeparture(string departure)
        {
            return _directionRepository.GetDeparture(departure);
        }

        public string GetArrival(string arrival)
        {
            return _directionRepository.GetArrival(arrival);
        }
       
        public int GetDirectionByStartFinish(string start, string direction1, string direction2, string direction3, string finish)
        {
            return _directionRepository.GetDirectionByStartFinish(start, direction1, direction2, direction3, finish);
        }

        public Direction GetDirectionDetails(int id)
        {
            return _directionRepository.GetDirectionDetails(id);
        }

        public List<Direction> GetTravel(string departure, string arrival)
        {
            return _directionRepository.GetTravel(departure, arrival);
        }

        
    }
}
